using Lab10.Driver;
using Lab10.PageObjects;
using Lab10.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Lab10
{
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(5000);
            steps.CloseBrowser();
        }

        [Test] //1. �������� "�������"
        public void ViewBasketTest()
        {
            steps.OpenBasket();
        }

        [Test] //2. ����� ������ ������������ canon
        public void SearchCameraModelTest() 
        {
            steps.SearchCamera();
        }

        [Test] //3. ����� �������� �������� ��� ���� � Wi-Fi
        public void SearchColorHomePrinterWithWIFITest()
        {
            steps.OpenPrinterPage();
            steps.OpenHomePrintersPage();
            steps.SearchFilterColorPrinterWithWIFI();
        }

        [Test] //5. ����� ������������� ������������� ������
        public void SearchMirrorlessFullFrameCameraTest()
        {
            steps.OpenMirrirlessCamerasPage();
            steps.SearchFilterMirrorlessFullFrameCameras();
        }

        [Test] //6. �������� �� ��������
        public void NewsletterSubscriptionTest()
        {
            steps.NewsletterSubscription();
        }

        [Test] //7. �������� ������������ �� ��� ����������
        public void SearchCameraSoftTest()
        {
            steps.OpenSupportPage();
            steps.DownloadSoftForCamera();
        }

        [Test] //8. �������� ������� ������ (4 ������)
        public void SendFeedbackTest()
        {
            steps.OpenSpeedliteFlashesPage();
            steps.OpenSpeedliteFlash();
            steps.OpenWriteFirstFeedback();
            steps.WriteFirstFeedback();
        }

        [Test] //9. ����� ��������� � ���������� ������ ��� ������ �������� �� ��������������
        public void SearchLensForLandscapeWithStabilizerTest()
        {
            steps.OpenLensesForDigitalSLRcameras();
            steps.SearchLensForLandscapeWithStabilizer();
        }

        [Test] //10. ����� ���������
        public void SearchProectorsTest()
        {
            steps.OpenForProfessionalPhotoAndVideoPage();
            steps.SearchProectorsInForProfessionalPhotoAndVideo();            
        }

        [Test] //11. �������� �������� ��������
        public void SeeBinoclesPage()
        {
            steps.OpenForProfessionalPhotoAndVideoPage();
            steps.SearchOtherProductsForProfessionalPhotoAndVideo();
        }


    }    
}
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUniversityTest.IFrames
{
    class Video
    {
        protected IWebElement element;
        //Constructor ========================================================================================================
        public Video(IWebElement element)
        {
            this.element = element;
        }

        //Iframe Functionalities =============================================================================================
        public void PlayOrPauseVideo()
        {
            element.FindElement(By.ClassName("vp-video")).Click();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace İnstagramBot1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Takip ve Takipçilerin çekilmesi sayıya göre değişkenlik gösterebilir lütfen listeler doldurulana kadar bekleyiniz...");
            if (cb_loginAuto.Checked == true) MessageBox.Show("Hesaba giriş sağlandıktan sonra doğrulama kodunu giriniz ve uygulamada çıkan soruyu onaylayınız...");
            string tName = tb_username.Text;
            string tPass = tb_password.Text;
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com");
            Thread.Sleep(5000);
            IWebElement username = driver.FindElement(By.Name("username"));
            IWebElement password = driver.FindElement(By.Name("password"));
            IWebElement login = driver.FindElement(By.CssSelector(".sqdOP.L3NKy.y3zKF"));
            username.SendKeys(tName);
            password.SendKeys(tPass);
            login.Click();
            if (cb_loginAuto.Checked==true)
            {
                DialogResult secim = MessageBox.Show("Doğrulama İşlemi Tamamlandı Mı? ","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (secim == DialogResult.Yes)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    driver.Navigate().GoToUrl("https://www.instagram.com");
                }
            }
            else
            {
                Thread.Sleep(4000);
            }
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://www.instagram.com/"+ tName.ToString());
            // follow çek //////////////////////////////////////////////////////////////////////////////
            Thread.Sleep(6000);
            IWebElement followC = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a > span"));
            string XfollowC = followC.Text;
            XfollowC.Replace('.',' ');
            XfollowC.Trim();
            double followCo = Convert.ToDouble(XfollowC);
            IWebElement follow = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a > span"));
            follow.Click();
            Thread.Sleep(1500);
            // sayfayı kaydırma javascript //////////////////////////////////////////////////////////////////////////////
            string jscommand = "" +
                "sayfa = document.querySelector('.isgrP');" +
                "sayfa.scrollTo(0,sayfa.scrollHeight);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(jscommand);
            Thread.Sleep(500);
            ArrayList followCou = new ArrayList();
            while (true)
            {
                for (int i = 0; i < (followCo/12); i++)
                {
                    js.ExecuteScript(jscommand);
                    Thread.Sleep(250);
                }
                js.ExecuteScript(jscommand);
                Thread.Sleep(250);
                try
                {
                    IReadOnlyCollection<IWebElement> followNamesC = driver.FindElements(By.CssSelector(".FPmhX.notranslate._0imsa"));
                    foreach (IWebElement item in followNamesC)
                    {
                        followCou.Add(item.Text);
                    }
                }
                catch (Exception h)
                {
                    MessageBox.Show(h.Message);
                }
                if (double.Parse(followCou.Count.ToString()) == (followCo-1) || double.Parse(followCou.Count.ToString()) == (followCo) || double.Parse(followCou.Count.ToString()) == (followCo + 1))
                {
                    //MessageBox.Show("Takip Listesi Oluşturuldu...");
                    break;
                }
                followCou.Clear();
            }
            // sayfayı kaydırma javascript //////////////////////////////////////////////////////////////////////////////
            IReadOnlyCollection<IWebElement> followNames = driver.FindElements(By.CssSelector(".FPmhX.notranslate._0imsa"));
            foreach (IWebElement item in followNames)
            {
                lbl_takip.Items.Add(item.Text);
            }
            Thread.Sleep(250);
            lbl_followCount.Text = "Takip Sayısı =" + lbl_takip.Items.Count;
            
            // follower çek //////////////////////////////////////////////////////////////////////////////
            driver.Navigate().GoToUrl("https://www.instagram.com/" + tName.ToString());
            Thread.Sleep(6000);
            IWebElement followerC = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > a > span"));
            string XfollowerC = followerC.Text;
            XfollowerC.Replace(',',' ');
            XfollowC.Trim();
            Double followerCo = Convert.ToDouble(XfollowerC);
            IWebElement followers = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > a"));
            followers.Click();
            Thread.Sleep(1000);
            string jscommand2 = "" +
               "sayfa2 = document.querySelector('.isgrP');" +
               "sayfa2.scrollTo(0,sayfa2.scrollHeight);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(jscommand2);
            Thread.Sleep(500);
            ArrayList followerCou = new ArrayList();
            while (true)
            {
                for (int i = 0; i < (followerCo / 12); i++)
                {
                    js2.ExecuteScript(jscommand2);
                    Thread.Sleep(250);
                }
                js2.ExecuteScript(jscommand2);
                Thread.Sleep(250);
                IReadOnlyCollection<IWebElement> followersNamesC = driver.FindElements(By.CssSelector(".FPmhX.notranslate._0imsa"));
                try
                {
                    foreach (IWebElement item in followersNamesC)
                    {
                        followerCou.Add(item.Text);
                    }
                }
                catch (Exception h)
                {
                    MessageBox.Show(h.Message);
                }
                if (double.Parse(followerCou.Count.ToString()) == (followerCo - 1) || double.Parse(followerCou.Count.ToString()) == (followerCo) || double.Parse(followerCou.Count.ToString()) == (followerCo + 1))
                {
                    break;
                }
                followerCou.Clear();
            }
            IReadOnlyCollection<IWebElement> followersNames = driver.FindElements(By.CssSelector(".FPmhX.notranslate._0imsa"));
            foreach (IWebElement item in followersNames)
            {
                lbl_takipci.Items.Add(item.Text);
            }
            Thread.Sleep(250);
            lbl_followerCount.Text = "Takipçi Sayısı =" + lbl_takipci.Items.Count;

            driver.Dispose();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            ArrayList takipliste = new ArrayList();
            ArrayList takipciliste = new ArrayList();
            ArrayList unfolllowliste = new ArrayList();

            foreach (string item in lbl_takip.Items)
            {
                takipliste.Add(item);
            }
            foreach (string item in lbl_takipci.Items)
            {
                takipciliste.Add(item);
            }
            foreach (string item in takipliste)
            {
                if (takipciliste.Contains(item))
                {

                }
                else
                {
                    if (unfolllowliste.Contains(item))
                    {

                    }
                    else
                    {
                        unfolllowliste.Add(item);
                    }
                }
            }
            foreach (string item in unfolllowliste)
            {
                lbl_unfollow.Items.Add(item);
            }
            lbl_unfollowCount.Text = "Takip Etmeyen = "+lbl_unfollow.Items.Count;
        }
    }
}

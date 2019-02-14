using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace tvspam
{
    public partial class Form1 : Form
    {
        int crashreport = 0;
        int finprogress = 0;
        int finprogress2 = 0;
        SqlCommand cmd;
        int messagecount = 0;
        int totalmessagecount = 0;
        SqlConnection conn;
        ChromeDriver driver;
        string mtext = "hi";
        string mtext2 = "hi";
        string importfile = "";
        string importfile2 = "";
        public Form1()
        {
            
            InitializeComponent();
            try
            {
                
                //updatetotalmessages
                totalmessagecount = int.Parse(getmessagescount());
                fill();
            }
            catch
            {
             
            }

        }

        public void fill()
        {
            try
            {
                txtmessagecount.Text = messagecount.ToString();
                txttotalmessagecount.Text = totalmessagecount.ToString();
            }
            catch { }
        }

        public void GetDriverReady()
        {
            try
            {
                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--disable - http2");
                options.AddArgument("--disable-notifications");
                //options.AddArgument("--headless");
                //options.AddArgument("--dns-prefetch-disable");
                //options.AddArgument("--always-authorize-plugins");
                //Environment.CurrentDirectory
                //driver.NetworkConditions.Latency = new TimeSpan (0,0,0,0,100);
                //("offline = False, latency = 5, download_throughput = 500 * 1024, upload_throughput = 500 * 1024");
                driver = new ChromeDriver(chromeDriverService, options, new TimeSpan(0, 0, 1000, 0));
                ChromeNetworkConditions c = new ChromeNetworkConditions();
                c.Latency = new TimeSpan(0, 0, 0, 0, 400);
                c.DownloadThroughput = 500 * 1024;
                c.UploadThroughput = 500 * 1024;
                driver.NetworkConditions = c;
                Size x = new Size(1920, 1080);
                driver.Manage().Window.Size = x;

                bypass();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void bypass()
        {
            try
            {
                driver.Url = "https://www.tradingview.com";
                var a = driver.FindElement(By.CssSelector(".tv-expected-language__stay-text"));
                a.Click();
            }
            catch
            {
            }
            //tv-expected-language__stay-text
            ///html/body/div[2]/div[2]/div[1]/div[1]/form/article/div[4]/div
        }
        public bool DoLogin(Account ac)
        {

            try
            {

                Thread.Sleep(3000);
                driver.Url = "https://www.tradingview.com/#signin";
                Thread.Sleep(3000);
                if (driver.Url == "https://www.tradingview.com/#signin")
                {
                    driver.ExecuteScript("location.reload()");

                }


                Thread.Sleep(5000);
                driver.FindElementByXPath("//*[@id=\"signin-form\"]/div[1]/div[1]/input").SendKeys(ac.username);
                driver.FindElementByXPath("//*[@id=\"signin-form\"]/div[2]/div[1]/div[1]/input").SendKeys(ac.password);
                driver.FindElementByXPath("//*[@id=\"signin-form\"]/div[3]/div[2]/button/span[2]").Click();
                UpdateSendingmessageby(ac.username);
                UpdateSendingmessageby2(ac.username);
                Thread.Sleep(5000);
                return true;
            }
            catch
            {
                DoLogin(ac);
                return false;
            }
        }
        public bool ControlInvokeRequired(Control c, Action a)
        {
           
                if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
                else return false;

                return true;
            
        }
        public void UpdateSendingmessageby(String text)
        {
            try
            {

                //Check if invoke requied if so return - as i will be recalled in correct thread
                if (ControlInvokeRequired(txtSendingAccount, () => UpdateSendingmessageby(text))) return;
                txtSendingAccount.Text = text;
            }
            catch { }
           
        }
        public void UpdateSendingmessageby2(String text)
        {
            try
            {

                //Check if invoke requied if so return - as i will be recalled in correct thread
                if (ControlInvokeRequired(txtsendinguser2, () => UpdateSendingmessageby2(text))) return;
                txtsendinguser2.Text = text;
            }
            catch { }

        }
        public void Updatecount(String count)
        {
            try
            {
                //Check if invoke requied if so return - as i will be recalled in correct thread
                if (ControlInvokeRequired(txtmessagecount, () => Updatecount(count))) return;
                txtmessagecount.Text = count;
            }
            catch { }

           
        }
        public void Updatecount2(String count)
        {
            try
            {
                //Check if invoke requied if so return - as i will be recalled in correct thread
                if (ControlInvokeRequired(txtsentcount2, () => Updatecount2(count))) return;
                txtsentcount2.Text = count;
            }
            catch { }


        }
        public void Updatetotalcount2(string totalcount)
        {
            try
            {
                if (ControlInvokeRequired(txttotalsent2, () => Updatetotalcount2(totalcount))) return;
                txttotalsent2.Text = totalcount;
            }
            catch
            {
            }
        }
        public void Updatetotalcount( string totalcount)
        {
            try
            {
                if (ControlInvokeRequired(txttotalmessagecount, () => Updatetotalcount(totalcount))) return;
                txttotalmessagecount.Text = totalcount;
            }
            catch
            {
            }
        }
        public bool checkloginsuccess()
        {
            try
            {
                driver.Url = "https://www.tradingview.com/";
                var x = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[1]/div[4]/span[2]/a");
                if (x.Text == "SIGN IN") { return false; }
                else { return true; }

                //tv-header__device-signin js-header__signin
            }
            catch { return true; }
        }
        public void sendmessages(string username)
        {
            try
            {

                var accounts = getaccounts();
                foreach (DataRow account in accounts.Rows)
                {
                    if (finprogress == 0)
                    {
                        break;
                    }
                    
                        int flag = 0;
                    if (DoLogin(new Account(account["username"].ToString(), account["password"].ToString())))
                    {
                        if (checkloginsuccess())
                        {
                            //check login success
                            navigatetourl(username);

                            System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> a = null;
                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                            try
                            {
                                while (flag == 0)
                                {
                                    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                                    a = driver.FindElements(By.CssSelector(".tv-button.tv-button--primary.tv-button--primary_ghost.tv-user-block__action.js-profile-message"));
                                    foreach (IWebElement user in a)
                                    {
                                        if (!ismessagesentforuser(user.GetAttribute("data-id").ToString()))
                                        {
                                            if (sendmessage(user))
                                            {
                                                flag = 1;

                                                insertnewmessage(account["username"].ToString(), account["id"].ToString(), mtext, user.GetAttribute("data-id").ToString());
                                                messagecount++;
                                                totalmessagecount++;
                                                Updatecount(messagecount.ToString());
                                                Updatetotalcount(totalmessagecount.ToString());
                                                break;
                                            }
                                            else if (crashreport == 1)  
                                            
                                            {
                                                insertnewmessage(account["username"].ToString(), account["id"].ToString(), "not sent", user.GetAttribute("data-id").ToString());
                                                crashreport = 0;
                                            }
                                            else
                                            {
                                                flag = 1;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            catch
                            {

                            }
                            signout();

                            //signout
                        }
                    }
                }
            }
            catch
            {
            }
        }

        public void sendmessages2(List<string> userlist)
        {
            try
            {
                int sentcount = 0;
                var accounts = getaccounts();
                while (sentcount < userlist.Count)
                {
                    foreach (DataRow account in accounts.Rows)
                    {

                        if (finprogress2 == 0 || sentcount == userlist.Count)
                        {
                            break;
                        }
                        
                            DoLogin(new Account(account["username"].ToString(), account["password"].ToString()));
                        if (checkloginsuccess())
                        {
                            if (navigatetourl2(userlist[sentcount]))
                            {


                                try
                                {
                                    //tv-profile__action tv-button tv-button--size_small tv-button--primary_ghost js-profile-message
                                    var x = driver.FindElement(By.CssSelector(".tv-profile__action.tv-button.tv-button--size_small.tv-button--primary_ghost.js-profile-message"));
                                    if (sendmessage(x))
                                    {
                                        sentcount++;
                                        insertnewmessage(account["username"].ToString(), account["id"].ToString(), mtext2, x.GetAttribute("data-username").ToString());
                                        messagecount++;
                                        totalmessagecount++;
                                        Updatecount2(messagecount.ToString());
                                        Updatetotalcount2(totalmessagecount.ToString());
                                        Updatecount(messagecount.ToString());
                                        Updatetotalcount(totalmessagecount.ToString());

                                    }
                                    else
                                    {

                                    }
                                }
                                catch { sentcount++; }
                            }
                            else { sentcount++; }
                            signout();
                        }
                        if (finprogress2 == 0 || sentcount == userlist.Count)
                        {
                            break;
                        }
                    }
                }
                finprogress2 = 0;
                //

                    //signout

                }
            catch
            {
            }
        }
        public void signout()
        {
            try
            {
                driver.Url = "https://www.tradingview.com";
                driver.FindElementByXPath("//html/body/div[3]/div[2]/div[1]/div[4]/span[1]/span[1]").Click();
                driver.FindElementByXPath("/html/body/div[3]/div[2]/div[1]/div[4]/span[1]/span[2]/span[14]/a").Click();
                
                //driver.Quit();
                //
                Thread.Sleep(5000);
                bypass();
                Thread.Sleep(3000);
            }
            catch
            {
                signout();
            }
        }
        public bool sendmessage(IWebElement x)
        {
            try
            {
                Thread.Sleep(5000);
                x.Click();
                Thread.Sleep(5000);
                ///html/body/div[14]/div[2]/div[1]/div/div/textarea
                ///html/body/div[14]/div[2]/div[1]/div/div/textarea
                //tv - dialog__widetextarea

                //js-dialog__action-click js-dialog__no-drag tv-button tv-button--success
                driver.FindElementByClassName("tv-dialog__widetextarea").SendKeys(mtext);
                var c = driver.FindElement(By.CssSelector(".js-dialog__action-click.js-dialog__no-drag.tv-button.tv-button--success")).Text;
                Thread.Sleep(5000);
                ///html/body/div[15]/div[1]/div
                driver.FindElement(By.CssSelector(".js-dialog__action-click.js-dialog__no-drag.tv-button.tv-button--success")).Click();
                Thread.Sleep(5000);
                if(driver.FindElements(By.CssSelector(".js-title-text.tv-dialog__title")).Count == 0) { return true; }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                //sendmessage(x);
                crashreport = 1;
                return false;
            }
          
        }
        
        public bool ismessagesentforuser(string username)
        {
            var messages = getmessages();
            if(messages.Select("touser = '" + username + "'").Length == 1)
                {
                return true;
                }
            else
            {
                return false;
            }
        }
        
         
        public void navigatetourl(string username)
        {
            try
            {
                driver.Url = "https://www.tradingview.com/u/" + username + "/#followers";
            }
            catch
            {
            }
        }
        public bool navigatetourl2(string username)
        {
            try
            {
                driver.Url = "https://www.tradingview.com/u/" + username;
                return true;
            }
            catch
            {
                return false;
            }
        }



        public void connect()
        {
            try
            {

                conn = new SqlConnection();
               
                conn.ConnectionString = "Data Source = localhost; Initial Catalog = mtradingview; Integrated Security=True; ";
               
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch
            {
                Console.WriteLine("connection error");
                connect();
            }
        }
        public DataTable getaccounts()
        {
            connect();
            try
            {
                SqlCommand cm = new SqlCommand("select * from account where isactive = 1", conn);
                cm.CommandTimeout = 30000;
                var dataReader = cm.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dataReader);
                return dt;
            }
            catch
            {
                Console.WriteLine("get error");
                //Index2();
                return null;
            }
        }
        public DataTable getmessages()
        {
            connect();
            try
            {
                SqlCommand cm = new SqlCommand("select * from message", conn);
                cm.CommandTimeout = 30000;
                var dataReader = cm.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dataReader);
                return dt;
            }
            catch
            {
                Console.WriteLine("get error");
                //Index2();
                return null;
            }
        }
        public string getmessagescount()
        {
            connect();
            try
            {
                SqlCommand cm = new SqlCommand("select * from message", conn);
                cm.CommandTimeout = 30000;
                var dataReader = cm.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dataReader);
                return dt.Rows.Count.ToString();
            }
            catch
            {
                Console.WriteLine("get error");
                //Index2();
                return "0";
            }
        }
        public void insertnewmessage(string account, string accountid,string text, string touser)
        {

            connect();

            try
            {
                var query = "insert into message (account , accountid,text,touser) select '" + account + "','" + accountid + "','" + text + "','" + touser +"'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("set a user error");
                connect();
            }

        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    GetDriverReady();
                    int round = 0;
                    finprogress = 1;
                    mtext = txttext.Text;
                    txtPage.Enabled = false;
                    btnstart.Enabled = false;
                    Task.Factory.StartNew(() =>
                    {

                        while (finprogress == 1)
                        {
                            sendmessages(txtPage.Text);

                            if (round <= 6)
                            {
                                Thread.Sleep(6000000);
                                round = 0;
                            }
                            round++;

                        }



                    });
                }
                if (radioButton2.Checked == true)
                {
                    if (!(importfile == ""))
                    {
                        List<string> userslist = new List<string>();
                        string line;
                        System.IO.StreamReader file = new System.IO.StreamReader(importfile);
                        while ((line = file.ReadLine()) != null)
                        {
                            userslist.Add(line);

                        }

                        GetDriverReady();
                        int round = 0;
                        finprogress = 1;
                        mtext = txttext.Text;
                        txtPage.Enabled = false;
                        btnstart.Enabled = false;
                        Task.Factory.StartNew(() =>
                        {
                            foreach (string x in userslist)
                            {
                                while (finprogress == 1)
                                {
                                    sendmessages(x);

                                    if (round <= 6)
                                    {
                                        Thread.Sleep(6000000);
                                        round = 0;
                                    }
                                    round++;

                                }
                            }



                        });
                    }
                    else
                    {
                        MessageBox.Show("No file selected !");
                    }
                }




                }
            catch
            {

            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {

            
            finprogress = 0;
            txtPage.Enabled = true;
            btnstart.Enabled = true;
        }

        private void btnimportfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                importfile2 = openfd.FileName;
                
            }
        }

        private void btnstart2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(importfile2 == ""))
                {
                    List<string> userslist = new List<string>();
                    GetDriverReady();
                    string line;
                    finprogress2 = 1;
                    System.IO.StreamReader file = new System.IO.StreamReader(importfile2);
                    while ((line = file.ReadLine()) != null)
                    {
                        userslist.Add(line);

                    }

                    //MessageBox.Show(userslist.Count().ToString());

                    btnstart2.Enabled = false;
                    Task.Factory.StartNew(() =>
                    {

                        while (finprogress2 == 1)
                        {
                            sendmessages2(userslist);

                        }

                    });

                }
                else
                {
                    MessageBox.Show("No file selected !");
                }
            }
            catch
            {

            }
        }

        private void btnstop2_Click(object sender, EventArgs e)
        {
            finprogress = 0;
            
            btnstart.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfd = new OpenFileDialog();
                if (openfd.ShowDialog() == DialogResult.OK)
                {
                    importfile = openfd.FileName;

                }
            }
            catch
            {

            }
        }
    }



}

public class Account
{
    public string username;
    public string password;

    public Account(string u,string p)
    {
        this.username = u;
        this.password = p;
    }
}

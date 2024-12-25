using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class rockScissorsGame : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Label字串設定
                Session["time"] = 30;
                Session["win"] = 0;
                Session["lose"] = 0;
                Session["draw"] = 0;
                titleLabel.Text = "Hi! Rockrt. Press Start";
                timeLabel.Text = "30 Seconds Countdown";
                resultLabel.Text = "";
                drawLabel.Text = "";
                winLabel.Text = "";
                loseLabel.Text = "";

                //Btn Enable
                startBtn.Enabled = true;
                

                //Btn Disable
                pauseBtn.Enabled = false;
                stopBtn.Enabled = false;
                paperPic.Enabled = false;
                scissorsPic.Enabled = false;
                stonePic.Enabled = false;

                Timer.Enabled = false;
                Timer.Interval = 1000;

                //紀錄
                Session["win"] = 0;
                Session["lose"] = 0;
                Session["draw"] = 0;
            }
            
        }

        protected void buttonClick(object sender, ImageClickEventArgs e)
        {
            //使用者數字與電腦數字
            int userNum = 0;
            int comNum = 0;

            //判斷是誰觸發buttonClick(),然後做判斷,放上使用者的圖片,呼叫電腦隨機亂數方法
            if (((ImageButton)sender).ID == paperPic.ID)
            {
                userNum = 0;
                rockrtPic.ImageUrl = "Resources/paper.png";
                comNum = comTrun();
            }

            else if (((ImageButton)sender).ID == scissorsPic.ID)
            {
                userNum = 1;
                rockrtPic.ImageUrl = "Resources/scissors.png";
                comNum = comTrun();
            }

            else if (((ImageButton)sender).ID == stonePic.ID)
            {
                userNum = 2;
                rockrtPic.ImageUrl = "Resources/stone.png";
                comNum = comTrun();
            }

            //判斷勝負, 平手Draw 勝Rockrt Win 負Rockrt Lose
            if (userNum - comNum == 0)
            {
                resultLabel.Text = "Draw";
                Session["draw"] = Convert.ToInt32(Session["draw"]) + 1;
            }
            else if (userNum - comNum == 1 || userNum - comNum == -2)
            {
                resultLabel.Text = "Rockrt Win";
                Session["win"] = Convert.ToInt32(Session["win"]) + 1;
            }
            else
            {
                resultLabel.Text = "Rockrt Lose";
                Session["lose"] = Convert.ToInt32(Session["lose"]) + 1;
            }
        }

        //電腦隨機亂數出拳並設定圖片, paper:0 sci:1 stone:2
        protected int comTrun()
        {
            int temp;
            Random random = new Random();
            temp = random.Next(0, 3);
            if (temp == 0)
            {
                computerPic.ImageUrl = "Resources/paper.png";
            }
            else if (temp == 1)
            {
                computerPic.ImageUrl = "Resources/scissors.png";
            }
            else if (temp == 2)
            {
                computerPic.ImageUrl = "Resources/stone.png";
            }
            return temp;
        }

        protected void startBtn_Click(object sender, EventArgs e)
        {
            //前一次紀錄清空, 將title補上
            Session["win"] = 0;
            Session["lose"] = 0;
            Session["draw"] = 0;
            drawLabel.Text = "";
            winLabel.Text = "";
            loseLabel.Text = "";
            titleLabel.Text = "Are You Rockrt? Good for You.";

            //startBtn Disable
            startBtn.Enabled = false;

            //Btn Enable
            pauseBtn.Enabled = true;
            stopBtn.Enabled = true;
            paperPic.Enabled = true;
            scissorsPic.Enabled = true;
            stonePic.Enabled = true;

            //timer start
            Session["time"] = 30;
            timeLabel.Text = $"Time {Session["time"]}sec";
            Timer.Enabled = true;
        }

        //計時器的計時方法
        protected void Timer_Tick(object sender, EventArgs e)
        {
            int currentTime = (int)Session["time"];
            currentTime--;
            Session["time"] = currentTime;
            timeLabel.Text = $"Time {Session["time"]} sec";
            if (currentTime == 0)
            {
                Timer.Enabled = false;

                //倒數秒數為零時將出拳圖片拿掉並初始化
                computerPic.ImageUrl = "Resources/question.png";
                rockrtPic.ImageUrl = "Resources/question.png";

                //Btn Disable
                pauseBtn.Enabled = false;
                stopBtn.Enabled = false;
                paperPic.Enabled = false;
                scissorsPic.Enabled = false;
                stonePic.Enabled = false;

                //Btn Enable
                startBtn.Enabled = true;

                //show titleLabel, 放上titleLabel字串
                int winCount = Convert.ToInt32(Session["win"]);
                int loseCount = Convert.ToInt32(Session["lose"]);
                int drawCount = Convert.ToInt32(Session["draw"]);

                if (winCount > loseCount)
                {
                    titleLabel.Text = "Rock Rockrt";
                }
                else if (winCount < loseCount)
                {
                    titleLabel.Text = "Poor Rockrt";
                }
                else
                {
                    titleLabel.Text = "Draw Rockrt";
                }

                //設定resultLabel, drawLabel, winLabel, loseLabel
                resultLabel.Text = "";
                drawLabel.Text = $"Draw {Session["draw"]} Times!";
                winLabel.Text = $"Rockrt Win {Session["win"]} Times!";
                loseLabel.Text = $"Rockrt Lose {Session["lose"]} Times!";

                // 只更新需要的面板
                timerPanel.Update();
                gamePanel.Update();
            }
            else
            {
                // 只更新時間面板
                timerPanel.Update();
            }
        }

        protected void pauseBtn_Click(object sender, EventArgs e)
        {
            if (pauseBtn.Text == "Pause")
            {
                pauseBtn.Text = "Cont.";
                Timer.Enabled = false;
                titleLabel.Text = "Pausing. Press Cont.";

                //Btn Disable
                paperPic.Enabled = false;
                scissorsPic.Enabled = false;
                stonePic.Enabled = false;
            }
            else
            {
                pauseBtn.Text = "Pause";
                titleLabel.Text = "Keep Going Rockrt!";
                Timer.Enabled = true;
                //Btn Enable
                paperPic.Enabled = true;
                scissorsPic.Enabled = true;
                stonePic.Enabled = true;
            }
        }

        protected void stopBtn_Click(object sender, EventArgs e)
        {
            //Stop後將數值與圖片初始化, 等待下一次Start
            Timer.Enabled = false;
            Session["win"] = 0;
            Session["lose"] = 0;
            Session["draw"] = 0;
            Session["time"] = 30;
            computerPic.ImageUrl = "Resources/question.png";
            rockrtPic.ImageUrl = "Resources/question.png";
            timeLabel.Text = "30 Seconds Countdown";
            pauseBtn.Text = "Pause";
            resultLabel.Text = "";
            titleLabel.Text = "Hi! Rockrt. Press Start";

            //Btn Enable
            startBtn.Enabled = true;

            //Btn Disable
            pauseBtn.Enabled = false;
            paperPic.Enabled = false;
            scissorsPic.Enabled = false;
            stonePic.Enabled = false;
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace dicegame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        int playerMoney = 1000;
        int betAmount = 0;

        int playerScore = 0;
        int computerScore = 0;

        bool playerLeopard = false;
        bool computerLeopard = false;

        PictureBox[] playerPics;
        PictureBox[] computerPics;

        Image[] diceImages;

        SoundPlayer rollSound,checkSound,enoughSound,playerSound,pcSound,tieSound;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateMoney();
            playerPics = new PictureBox[]
            {
                  picP1,picP2,picP3,picP4
            };

            computerPics = new PictureBox[]
            {
                  picC1,picC2,picC3,picC4
            };

            // 載入骰子圖片
            diceImages = new Image[]
            {
                 Image.FromFile("Images/dice1.png"),
                 Image.FromFile("Images/dice2.png"),
                 Image.FromFile("Images/dice3.png"),
                 Image.FromFile("Images/dice4.png"),
                 Image.FromFile("Images/dice5.png"),
                 Image.FromFile("Images/dice6.png")
            };

            rollSound = new SoundPlayer("Sounds/roll.wav");
            checkSound = new SoundPlayer("Sounds/check.wav");
            enoughSound = new SoundPlayer("Sounds/enough.wav");
            playerSound = new SoundPlayer("Sounds/playerwin.wav");
            pcSound = new SoundPlayer("Sounds/pcwin.wav");
            tieSound = new SoundPlayer("Sounds/tie.wav");

        }
        private async Task AnimateDice(PictureBox[] pics)
        {
            rollSound.Play();

            // 記錄原始位置與大小
            Point[] originalLocations = new Point[pics.Length];
            Size[] originalSizes = new Size[pics.Length];

            for (int i = 0; i < pics.Length; i++)
            {
                originalLocations[i] = pics[i].Location;
                originalSizes[i] = pics[i].Size;
            }

            // 動畫循環
            for (int t = 0; t < 20; t++)
            {
                for (int i = 0; i < pics.Length; i++)
                {
                    int value = rand.Next(1, 7);

                    pics[i].Image = diceImages[value - 1];

                    // ===== 抖動效果 =====

                    int offsetX = rand.Next(-8, 9);
                    int offsetY = rand.Next(-8, 9);

                    pics[i].Location = new Point(
                        originalLocations[i].X + offsetX,
                        originalLocations[i].Y + offsetY
                    );

                    // ===== 縮放效果 =====

                    int scale = rand.Next(-10, 11);

                    pics[i].Size = new Size(
                        originalSizes[i].Width + scale,
                        originalSizes[i].Height + scale
                    );

                    pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                }

                await Task.Delay(50);
            }

            // 還原位置與大小
            for (int i = 0; i < pics.Length; i++)
            {
                pics[i].Location = originalLocations[i];
                pics[i].Size = originalSizes[i];
            }
        }
        private async Task<int[]> RollDiceWithAnimation(PictureBox[] pics)
        {
            await AnimateDice(pics);

            int[] dice;

            while (true)
            {
                dice = new int[4];

                for (int i = 0; i < 4; i++)
                {
                    dice[i] = rand.Next(1, 7);
                }

                if (HasPair(dice))
                    break;
            }

            // 顯示最終骰面
            for (int i = 0; i < 4; i++)
            {
                pics[i].Image = diceImages[dice[i] - 1];
            }
            // 停止時放大一下
            for (int i = 0; i < pics.Length; i++)
            {
                pics[i].Size = new Size(110, 110);
            }

            await Task.Delay(100);

            for (int i = 0; i < pics.Length; i++)
            {
                pics[i].Size = new Size(100, 100);
            }
            return dice;
        }

        private async void btnRoll_Click(object sender, EventArgs e)
        {
            btnRoll.Enabled = false;

            betAmount = (int)numBet.Value;

            if (betAmount <= 0)
            {

                checkSound.Play(); 
                MessageBox.Show("請下注");
                btnRoll.Enabled = true;
                return;
            }

            if (betAmount > playerMoney)
            {
                enoughSound.Play();
                MessageBox.Show("資金不足");
                btnRoll.Enabled = true;
                return;
            }

            playerMoney -= betAmount;

            // 玩家擲骰動畫
            int[] playerDice =
                await RollDiceWithAnimation(playerPics);

            playerScore =
                CalculateScore(playerDice, out playerLeopard);

            // 電腦擲骰動畫
            await Task.Delay(500);

            int[] computerDice =
                await RollDiceWithAnimation(computerPics);

            computerScore =
                CalculateScore(computerDice, out computerLeopard);

            JudgeWinner();

            UpdateMoney();

            btnRoll.Enabled = true;
        }

        // =========================
        // 是否存在對子
        // =========================
        private bool HasPair(int[] dice)
        {
            var groups = dice.GroupBy(x => x);

            return groups.Any(g => g.Count() >= 2);
        }
        // =========================
        // 計算分數
        // =========================
        private int CalculateScore(int[] dice, out bool leopard)
        {
            leopard = false;

            var groups = dice.GroupBy(x => x)
                             .OrderByDescending(g => g.Count())
                             .ThenByDescending(g => g.Key)
                             .ToList();

            // 豹子：四顆相同
            if (groups[0].Count() == 4)
            {
                leopard = true;
                return 100; // 豹子最高分
            }

            // 三顆相同 + 單張
            if (groups[0].Count() == 3)
            {
                return groups[1].Key;
            }

            // 兩組對子
            if (groups.Count == 2 &&
                groups[0].Count() == 2 &&
                groups[1].Count() == 2)
            {
                return Math.Max(groups[0].Key, groups[1].Key);
            }

            // 一組對子
            if (groups[0].Count() == 2)
            {
                int sum = groups.Where(g => g.Count() == 1)
                                .Sum(g => g.Key);

                return sum;
            }

            return 0;
        }

        // =========================
        // 判定勝負
        // =========================
        private void JudgeWinner()
        {
            // 豹子優先
            if (playerLeopard && !computerLeopard)
            {
                int reward = betAmount * 3; // 本金 + 2倍獎金

                playerMoney += reward;

                lblResult.Text =
                    $"玩家豹子！獲得 {reward} 元";
            }
            else if (!playerLeopard && computerLeopard)
            {
                lblResult.Text = "電腦豹子，玩家失敗";
            }
            else
            {
                if (playerScore > computerScore)
                {
                    int reward = betAmount; // 本金 + 1倍獎金

                    playerMoney += reward*2;

                    lblResult.Text =
                        $"玩家勝利！獲得 {reward} 元";
                    playerSound.Play();
                }
                else if (playerScore < computerScore)
                {
                    lblResult.Text = "電腦勝利";
                    pcSound.Play();
                }
                else
                {
                    // 平手退回本金
                    playerMoney += betAmount;

                    lblResult.Text = "平手，退回本金";
                    tieSound.Play();
                }
            }
        }

        // =========================
        // 更新資金
        // =========================
        private void UpdateMoney()
        {
            lblMoney.Text = $"目前資金：{playerMoney}";
        }

        private void lblMoney_Click(object sender, EventArgs e)
        {

        }
    }
}

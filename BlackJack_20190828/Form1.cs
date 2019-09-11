using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Filename; BlackJack_DanieOtto
// Author; Danie Otto
// Created; 2019/09/09
// Operating System; Windows 10
// Version; Visual Studio 2019
// Date; 2019/09/08
// Purpose; BlackJack Program
/* Description; This is a BlackJack game which is played by the user. The object of the
    * game is to reach a score of 21 without going over this amount.
    */  

namespace BlackJack_20190828
{
    public partial class BlackJack : Form
    {
        public BlackJack()//Main BlackJack class.
        {
            InitializeComponent();
            btnHit.Enabled = false;//"btnHit" is disabled. 
            btnStay.Enabled = false;//"btnStay" is disabled. 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBox1.Visible = false;//"picBox1" visibility is removed.
            picBox2.Visible = false;//"picBox2" visibility is removed.
            picBox3.Visible = false;//"picBox3" visibility is removed.
            picBox4.Visible = false;//"picBox4" visibility is removed.

            lblWinsCounter.Visible = false;//"lblWinsCounter" visibility is removed.
            lblLossesCounter.Visible = false;//"lblLossesCounter" visibility is removed.
            lblTiesCounter.Visible = false;//"lblTiesCounter" visibility is removed.
        }

        /// <summary>
        /// This code segment handles the initialization of various 
        /// Classes, Lists and Variables
        /// </summary>
        #region Initialization of various Lists, Classes and Variables
        /* The Card class consists of three fields, the "cardValue" which will
         * represent the numercal value of the card. The "cardName" which describes
         * the face and suit of the card. And lastly the "cardImage", which is responsible
         * for the card image.
         */
        class Card
        {
            public int cardValue { get; set; }//"cardValue" field is created.
            public string cardName { get; set; }//"cardname" field is created.
            public string cardImage { get; set; }//cardImage" field is created. 
        }

        /* A instance of the Random class is created to assist with
         * the generation of random numbers.
         */
        static Random rand = new Random();

        int winScore = 0; //Keeps track of all the players Wins.
        int lossScore = 0; //Keeps track of all the players Losses.
        int tiedScore = 0; //Keeps track of all the players Ties.
        int playerCardSum = 0; //Tracks the numerical sum of the players hand.
        int dealerCardSum = 0; //Tracks the numerical sum of the dealers hand.
        int dealerInitialDisplayTotal = 0; /*This value is only used once when the 
        * "Deal" button is pressed. This is done so that only the dealers first card
        * total is displayed to the player.
        */
        string playerCardText = string.Empty; /*Displays the "cardName" on the 
        * "lblPlayerText" label.
        */
        string dealerCardText = string.Empty; /*Displays the "cardName" on the 
        * "lblDealerText" label.
        */
        string dealerSecondCardText = string.Empty; /*Displays the dealers second card
        * "cardName". 
        */

        /* The "playerCards" and "dealerCards" Lists stores all cards the player 
         * and dealer currently have in play. These are used in the "TotalPlayerSum()"
         * and "TotalDealerSum()" methods to calculate the players and dealers current
         * hand totals. 
         */
        List<Card> playerCards = new List<Card>()
        {
            new Card() { cardValue  = 0, cardName= "null", cardImage= "null" }
        };

        List<Card> dealerCards = new List<Card>()
        {
            new Card() { cardValue = 0, cardName = "null", cardImage = "null" }
        };

        /* The "usedCards" List is used to store all cards that are currently in play
         * for both the player and dealer. 
         */
        List<int> usedCards = new List<int>();

        /* The "playerHitPicutreBox" and "dealerHitPictureBox" PictureBoxes are used
         * to create picture boxes for the "cardImage" values during player Hit phase 
         * and the dealer Hit phase.
         */
        PictureBox playerHitPictureBox = new PictureBox();
        PictureBox dealerHitPictureBox = new PictureBox();
        PictureBox cardBack = new PictureBox(); /*PictureBox used to dislpay the 
        * "CardBack.png" image. 
        */

        //"deckOfCards" List is created using the "Card" class.
        static List<Card> deckOfCards = new List<Card>()
        {
            //Adding a new Card class object for all 52 instances of the "deckOfCards" List.
            #region card initialization
            //Clubs initialization
            new Card() { cardValue = 11, cardName = "Ace of Clubs", cardImage = @"../../bin/Debug/Cards/0.png"},
            new Card() { cardValue = 2, cardName = "Two of Clubs", cardImage = @"../../bin/Debug/Cards/1.png" },
            new Card() { cardValue = 3, cardName = "Three of Clubs", cardImage = @"../../bin/Debug/Cards/2.png" },
            new Card() { cardValue = 4, cardName = "Four of Clubs", cardImage = @"../../bin/Debug/Cards/3.png" },
            new Card() { cardValue = 5, cardName = "Five of Clubs", cardImage = @"../../bin/Debug/Cards/4.png" },
            new Card() { cardValue = 6, cardName = "Six of Clubs", cardImage = @"../../bin/Debug/Cards/5.png" },
            new Card() { cardValue = 7, cardName = "Seven of Clubs", cardImage = @"../../bin/Debug/Cards/6.png" },
            new Card() { cardValue = 8, cardName = "Eight of Clubs", cardImage = @"../../bin/Debug/Cards/7.png" },
            new Card() { cardValue = 9, cardName = "Nine of Clubs", cardImage = @"../../bin/Debug/Cards/8.png" },
            new Card() { cardValue = 10, cardName = "Ten of Clubs", cardImage = @"../../bin/Debug/Cards/9.png" },
            new Card() { cardValue = 10, cardName = "Jack of Clubs", cardImage = @"../../bin/Debug/Cards/10.png" },
            new Card() { cardValue = 10, cardName = "Queen of Clubs", cardImage = @"../../bin/Debug/Cards/11.png" },
            new Card() { cardValue = 10, cardName = "King of Clubs", cardImage = @"../../bin/Debug/Cards/12.png" },

            //Hearts initialization
            new Card() { cardValue = 11, cardName = "Ace of Hearts", cardImage = @"../../bin/Debug/Cards/13.png" },
            new Card() { cardValue  = 2, cardName = "Two of Hearts", cardImage = @"../../bin/Debug/Cards/14.png" },
            new Card() { cardValue = 3, cardName = "Three of Hearts", cardImage = @"../../bin/Debug/Cards/15.png" },
            new Card() { cardValue = 4, cardName =  "Four of Hearts", cardImage = @"../../bin/Debug/Cards/16.png"},
            new Card() { cardValue = 5, cardName = "Five of Hearts", cardImage = @"../../bin/Debug/Cards/17.png" },
            new Card() { cardValue = 6, cardName = "Six of Hearts", cardImage = @"../../bin/Debug/Cards/18.png" },
            new Card() { cardValue = 7, cardName = "Seven of Hearts", cardImage = @"../../bin/Debug/Cards/19.png" },
            new Card() { cardValue = 8, cardName = "Eight of Hearts", cardImage = @"../../bin/Debug/Cards/20.png" },
            new Card() { cardValue = 9, cardName = "Nine of Hearts", cardImage = @"../../bin/Debug/Cards/21.png" },
            new Card() { cardValue = 10, cardName = "Ten of Hearts", cardImage = @"../../bin/Debug/Cards/22.png" },
            new Card() { cardValue = 10, cardName = "Jack of Hearts", cardImage = @"../../bin/Debug/Cards/23.png" },
            new Card() { cardValue = 10, cardName = "Queen of Hearts", cardImage = @"../../bin/Debug/Cards/24.png" },
            new Card() { cardValue = 10, cardName = "King of Hearts", cardImage = @"../../bin/Debug/Cards/25.png" },

            //Spades initialization
            new Card() { cardValue = 11, cardName = "Ace of Spades", cardImage = @"../../bin/Debug/Cards/26.png" },
            new Card() { cardValue  = 2, cardName = "Two of Spades", cardImage = @"../../bin/Debug/Cards/27.png" },
            new Card() { cardValue = 3, cardName = "Three of Spades", cardImage = @"../../bin/Debug/Cards/28.png"},
            new Card() { cardValue = 4, cardName =  "Four of Spades", cardImage = @"../../bin/Debug/Cards/29.png"},
            new Card() { cardValue = 5, cardName = "Five of Spades", cardImage = @"../../bin/Debug/Cards/30.png" },
            new Card() { cardValue = 6, cardName = "Six of Spades", cardImage = @"../../bin/Debug/Cards/31.png" },
            new Card() { cardValue = 7, cardName = "Seven of Spades", cardImage = @"../../bin/Debug/Cards/32.png" },
            new Card() { cardValue = 8, cardName = "Eight of Spades", cardImage = @"../../bin/Debug/Cards/33.png" },
            new Card() { cardValue = 9, cardName = "Nine of Spades", cardImage = @"../../bin/Debug/Cards/34.png" },
            new Card() { cardValue = 10, cardName = "Ten of Spades", cardImage = @"../../bin/Debug/Cards/35.png" },
            new Card() { cardValue = 10, cardName = "Jack of Spades", cardImage = @"../../bin/Debug/Cards/36.png" },
            new Card() { cardValue = 10, cardName = "Queen of Spades", cardImage = @"../../bin/Debug/Cards/37.png" },
            new Card() { cardValue = 10, cardName = "King of Spades", cardImage = @"../../bin/Debug/Cards/38.png" },

            //Diamonds initialization
            new Card() { cardValue = 11, cardName = "Ace of Diamonds", cardImage = @"../../bin/Debug/Cards/39.png" },
            new Card() { cardValue  = 2, cardName = "Two of Diamonds", cardImage = @"../../bin/Debug/Cards/40.png" },
            new Card() { cardValue = 3, cardName = "Three of Diamonds", cardImage = @"../../bin/Debug/Cards/41.png" },
            new Card() { cardValue = 4, cardName =  "Four of Diamonds", cardImage = @"../../bin/Debug/Cards/42.png"},
            new Card() { cardValue = 5, cardName = "Five of Diamonds", cardImage = @"../../bin/Debug/Cards/43.png" },
            new Card() { cardValue = 6, cardName = "Six of Diamonds", cardImage = @"../../bin/Debug/Cards/44.png" },
            new Card() { cardValue = 7, cardName = "Seven of Diamonds", cardImage = @"../../bin/Debug/Cards/45.png" },
            new Card() { cardValue = 8, cardName = "Eight of Diamonds", cardImage = @"../../bin/Debug/Cards/46.png" },
            new Card() { cardValue = 9, cardName = "Nine of Diamonds", cardImage = @"../../bin/Debug/Cards/47.png" },
            new Card() { cardValue = 10, cardName = "Ten of Diamonds", cardImage = @"../../bin/Debug/Cards/48.png" },
            new Card() { cardValue = 10, cardName = "Jack of Diamonds", cardImage = @"../../bin/Debug/Cards/49.png" },
            new Card() { cardValue = 10, cardName = "Queen of Diamonds", cardImage = @"../../bin/Debug/Cards/50.png" },
            new Card() { cardValue = 10, cardName = "King of Diamonds", cardImage = @"../../bin/Debug/Cards/51.png" }
            #endregion
        };
        #endregion

        /// <summary>
        /// The Deal Button Event. 
        /// </summary>
        #region Deal Button 
        /* The Visibility of various Form elements are enabled. 
         * 
         * A random number is generated using the "SelectRandomCard()" method. This randomized number 
         * is then used to select a random card from the "deckOfCards" List. This is then used to 
         * create a new object of the Card class. The randomized number is then added to the 
         * "usedCards" List. 
         * 
         * This process is then done once more for the second card in the player starting hand. 
         * Before the random number is used to create a new object of the Card class it is first
         * passed through a while loop which is used to compare the integer value to those stored
         * in the "usedCards" List. Only once the uniqueness of the value has been determined it
         * is then used to create a new object of the Card Class.
         *  
         * The first and second Card class objects are then added to the "playerCards" List.
         * 
         * Next, "picBox1" and "picBox2" are both initialized to represent the two new Card objects 
         * visually. This is done using the "cardImage" value from the Card class.
         * 
         * This process is then repeated for the Dealer Hand with the exception of "picBox4" being
         * hidden and having a Card Back dislpayed instead. 
         */
        private void BtnDeal_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = true;//The "btnHit" button is enabled.
            btnStay.Enabled = true;//The "btnStay" button is enabled.
            picBox1.Visible = true;//The "picBox1" PictureBox is made visible. 
            picBox2.Visible = true;//The "picBox2" PictureBox is made visible. 
            picBox3.Visible = true;//The "picBox3" PictureBox is made visible. 
            picBox4.Visible = true;//The "picBox4" PictureBox is made visible. 
            btnDeal.Visible = false;//The "btn"deal" button is made visible.

            #region Player Hand
            //Player hand gets created. SelectRandomCard() method is used to initialize two random cards.
            int randomCardOne = SelectRandomCard();//A random number is generated using the "SelectRandomCard()" method.
            Card playerCardOne = deckOfCards[randomCardOne];/*A new instance of the Card class is created using 
                    * the "randomCard" number to select a card from the "deckOfCards" List.
                    */
            usedCards.Add(randomCardOne);//The used "randomCard" number is then added to the "usedCards" List. 

            int randomCardTwo = SelectRandomCard();//A random number is generated using the "SelectRandomCard()" method.
            while (usedCards.Contains(randomCardTwo))
            {
                randomCardTwo = SelectRandomCard();
            }/* A while loop checks to make sure this number has not been used
                  * previously. This is done by comparing the number with those stored in the "usedCards" List. 
                  */
            Card playerCardTwo = deckOfCards[randomCardTwo];/*A new instance of the Card class is created using 
                    * the "randomCard" number to select a card from the "deckOfCards" List.
                    */
            usedCards.Add(randomCardTwo);//The used "randomCard" number is then added to the "usedCards" List. 

            playerCards.Add(playerCardOne);//The new Card class object is added to the "playerCards" List.
            playerCards.Add(playerCardTwo);//The new Card class object is added to the "playerCards" List.

            picBox1.ImageLocation = playerCardOne.cardImage;/* The "picBox1.ImageLocation
                    * is assigned to new Card class objects "cardImage".
                    */
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;/*The "picBox1" SizeMode is changed
                    * to AutoSize.
                    */

            picBox2.ImageLocation = playerCardTwo.cardImage;/* The "picBox2.ImageLocation"
                    * is assigned to new Card class objects "cardImage".
                    */
            picBox2.SizeMode = PictureBoxSizeMode.AutoSize;/*The "picBox2" SizeMode is changed
                    * to AutoSize.
                    */

            playerCardSum = (playerCardOne.cardValue + playerCardTwo.cardValue);/*The "playerCardOne" and
                    * "playerCardTwo" values are assigned to "playerCardSum"
                    */
            lblPlayerScore.Text = playerCardSum.ToString();//"playerCardSum" is assigned to "lblPlayerScore".

            playerCardText = playerCardOne.cardName + "\n" + playerCardTwo.cardName;/* "playerCardText" will
                    * be used to display the card names of "playerCardOne" and "playerCardTwo" Card objects.
                    */

            lblPlayerText.Text = playerCardText;//"lblPlayerText" is assigned the "playerCardText" value. 
            #endregion

            
            #region Dealer Hand
            //Dealer hand gets created.
            int randomCardThree = SelectRandomCard();//A random number is generated using the "SelectRandomCard()" method.
            while (usedCards.Contains(randomCardThree))
            {
                randomCardThree = SelectRandomCard();
            }/* A while loop checks to make sure this number has not been used
                  * previously. This is done by comparing the number with those stored in the "usedCards" List. 
                  */
            Card dealerCardOne = deckOfCards[randomCardThree];/*A new instance of the Card class is created using 
                    * the "randomCard" number to select a card from the "deckOfCards" List.
                    */
            usedCards.Add(randomCardThree);//The used "randomCard" number is then added to the "usedCards" List. 

            int randomCardFour = SelectRandomCard();//A random number is generated using the "SelectRandomCard()" method.
            while (usedCards.Contains(randomCardFour))
            {
                randomCardFour = SelectRandomCard();
            }/* A while loop checks to make sure this number has not been used
                  * previously. This is done by comparing the number with those stored in the "usedCards" List. 
                  */
            usedCards.Add(randomCardFour);//The used "randomCard" number is then added to the "usedCards" List. 
            Card dealerCardTwo = deckOfCards[randomCardFour];/*A new instance of the Card class is created using 
                    * the "randomCard" number to select a card from the "deckOfCards" List.
                    */

            dealerCards.Add(dealerCardOne);//The new Card class object is added to the "dealerCards" List.
            dealerCards.Add(dealerCardTwo);//The new Card class object is added to the "dealerCards" List.

            picBox3.ImageLocation = dealerCardOne.cardImage;/* The "picBox3.ImageLocation"
                    * is assigned to new Card class objects "cardImage".
                    */
            picBox3.SizeMode = PictureBoxSizeMode.AutoSize;/*The "picBox3" SizeMode is changed
                    * to AutoSize.
                    */

            picBox4.ImageLocation = dealerCardTwo.cardImage;/* The "picBox4.ImageLocation"
                    * is assigned to new Card class objects "cardImage".
                    */
            picBox4.SizeMode = PictureBoxSizeMode.AutoSize;/*The "picBox4" SizeMode is changed
                    * to AutoSize.
                    */
            cardBack.ImageLocation = @"../../bin/Debug/Cards/CardBack.png";//The "cardBack" image location is specified.
            cardBack.SizeMode = PictureBoxSizeMode.AutoSize;/*The "cardBack" SizeMode is changed
                    * to AutoSize.
                    */
            cardBack.Location = new Point(727, 126);//The "cardBack" is assigned a new fixed Point.
            this.Controls.Add(cardBack);//The Controls collection is used to Add the "cardBack"
            cardBack.BringToFront();/*The "cardBack" is brought to the front so that it is not 
                    * obstructed by cards infront of it.
                    */

            dealerCardSum = dealerCardOne.cardValue + dealerCardTwo.cardValue;/* The new Card class object's "cardValue" 
                    * is added to the "dealerCardSum" value.
                    */

            dealerInitialDisplayTotal = dealerCardOne.cardValue;//The "dealerInitialDisplayTotal" is assigned.

            lblDealerScore.Text = dealerInitialDisplayTotal.ToString();

            dealerCardText = dealerCardOne.cardName;
            dealerSecondCardText = dealerCardTwo.cardName;

            lblDealerText.Text = dealerCardText;

            /*If the "playerCardSum" value is determined to be exactly 21 a MessageBox is displayed
             *notifying the player of this. */
            if (playerCardSum == 21)
            {
                MessageBox.Show("Blackjack! Press \"Stay\" to see if the dealer can make it a tie!");
            }
            #endregion
        }
        #endregion

        /// <summary>
        /// The Hit Button Event.
        /// </summary>
        #region Hit Button 
        /* A random number is generated using the "SelectRandomCard()" method. A while loop checks to make
         * sure this number has not already been used. This is done using the "usedCards" List. 
         * This randomized number is then used to select a random card from the "deckOfCards" List. This is 
         * then used to create a new object of the Card class. 
         * 
         * The Card class object is then added to the "playerCards" List.
         * 
         * Next, a new picture box image is created to represent the new Card object visually. 
         * This is done using the "cardImage" value from the Card class.
         */
        private void BtnHit_Click(object sender, EventArgs e)
        {
            int randomCard = SelectRandomCard();//A random number is generated using the "SelectRandomCard()" method.
            while (usedCards.Contains(randomCard))
            {
                randomCard = SelectRandomCard();
            }/* A while loop checks to make sure this number has not been used
                  * previously. This is done by comparing the number with those stored in the "usedCards" List. 
                  */
            Card additionalPlayerCard = deckOfCards[randomCard];/*A new instance of the Card class is created using 
                    * the "randomCard" number to select a card from the "deckOfCards" List.
                    */
            usedCards.Add(randomCard);//The used "randomCard" number is then added to the "usedCards" List. 

            playerCards.Add(additionalPlayerCard);//The new Card class object is added to the "playerCards" List.

            playerHitPictureBox.ImageLocation = additionalPlayerCard.cardImage;/* The "playerHitPictureBox.ImageLocation
                    * is assigned to new Card class objects "cardImage".
                    */
            playerHitPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;/*The "dealerHitPictureBox" SizeMode is changed
                    * to AutoSize.
                    */
            playerHitPictureBox.Location = new Point(115, 150);//The "dealerHitPictureBox" is assigned a new fixed Point.
            this.Controls.Add(playerHitPictureBox);//The Controls collection is used to Add the "playerHitPictureBox"
            playerHitPictureBox.BringToFront();/*The "playerHitPictureBox" is brought to the front so that it is not 
                    * obstructed by cards infront of it.
                    */

            TotalPlayerSum();//The "TotalPlayerSum()" method is called to calculate the new dealer card total.

            playerCardText = playerCardText + "\n" + additionalPlayerCard.cardName;/*The new Card class objects 
                    * "cardName" is assigned to the "dealerCardText" variable.
                    */

            lblPlayerText.Text = playerCardText;

            lblPlayerScore.Text = playerCardSum.ToString();

            /* An If statement checks to see if the player's card totals are above 21.
             * If this is the case, the player busts and automatically loses and the game is 
             * reset using the "ResetGame()" method.
             * If the player total is exactly 21, a MessageBox informs the player of this. 
             */
            if (playerCardSum > 21)//An If statement checks to see if the "playerCardSum" is above 21.
            {
                MessageBox.Show("You lost");
                lossScore += 1;//The "lossScore" variable is increased by one.
                lblLossesCounter.Visible = true;
                lblLossesCounter.Text = lossScore.ToString();
                this.Controls.Remove(cardBack);//The "cardBack" image is removed.
                ResetGame();//The game is reset.
            }
            else if(playerCardSum == 21)//An else If statement checks to see if the "playerCardSum" is equal to 21.
            {
                MessageBox.Show("Blackjack! Press \"Stay\" to see if the dealer can make it a tie!");
            }
        }
        #endregion

        /// <summary>
        /// The Stay Button Event
        /// </summary>
        #region Stay Button
        // The BtnStay_Click Event calls the "DealerHitandStay()" method. 
        private void BtnStay_Click(object sender, EventArgs e)
        {
            DealerHitandStay();//The "DealerHitandStay()" method is called.
        }
        #endregion

        /// <summary>
        /// The method responsible for the logic behind the 
        /// dealer "hitting" and "staying".
        /// Author; Danie Otto
        /// Version; 1
        /// Date; 2019/09/09
        /// </summary>
        #region Dealer hit and stay
        /*The "DealerHitandStay()" method enters a while loop if the Dealers hand is less than 17.
         * The Dealer is then forced to hit until their hand total is equal to or over the amount of 17. 
         * 
         * A random number is generated using the "SelectRandomCard()" method. A while loop checks to make
         * sure this number has not already been used. This is done using the "usedCards" List. 
         * This randomized number is then used to select a random card from the "deckOfCards" List. This is 
         * then used to create a new object of the Card class. 
         * 
         * The Card class object is then added to the "dealerCards" List. 
         * 
         * Next, a new picture box image is created to represent the new Card object visually. 
         * This is done using the "cardImage" value from the Card class.
         */
        public void DealerHitandStay()
        {
            while(dealerCardSum < 17)/*The "DealerHitandStay()" method enters a while loop if the 
                *Dealers hand is less than 17.
                */
            {
                int randomCard = SelectRandomCard();//A random number is generated using the "SelectRandomCard()" method.
                while (usedCards.Contains(randomCard))
                {
                    randomCard = SelectRandomCard();
                }/* A while loop checks to make sure this number has not been used
                  * previously. This is done by comparing the number with those stored in the "usedCards" List. 
                  */
                Card additionalDealerCard = deckOfCards[randomCard];/*A new instance of the Card class is created using 
                    * the "randomCard" number to select a card from the "deckOfCards" List.
                    */
                usedCards.Add(randomCard);//The used "randomCard" number is then added to the "usedCards" List. 

                dealerCards.Add(additionalDealerCard);//The new Card class object is added to the "dealerCards" List.

                dealerCardSum += additionalDealerCard.cardValue;/* The new Card class object's "cardValue" is added to 
                    * the "dealerCardSum" value.
                    */

                TotalDealerSum();//The "TotalDealerSum()" method is called to calculate the new dealer card total.

                dealerHitPictureBox.ImageLocation = additionalDealerCard.cardImage;/* The "dealerHitPictureBox.ImageLocation
                    * is assigned to new Card class objects "cardImage".
                    */
                dealerHitPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;/*The "dealerHitPictureBox" SizeMode is changed
                    * to AutoSize.
                    */
                dealerHitPictureBox.Location = new Point(670, 150);//The "dealerHitPictureBox" is assigned a new fixed Point.
                this.Controls.Add(dealerHitPictureBox);//The Controls collection is used to Add the "dealerHitPictureBox"
                dealerHitPictureBox.BringToFront();/*The "dealerHitPictureBox" is brought to the front so that it is not 
                    * obstructed by cards infront of it.
                    */

                this.Controls.Remove(cardBack); /*Removes the dealer card back so the player 
                                                 may view it.*/

                lblDealerScore.Text = dealerCardSum.ToString();/*The "lblDealerScore" label is assigned the 
                    * "dealerCardSum" value.
                    */
                dealerCardText += "\n" + additionalDealerCard.cardName;/*The new Card class objects "cardName" is assigned
                    * to the "dealerCardText" variable.
                    */ 
                lblDealerText.Text = dealerCardText;//The "dealerCardText" variable is assigned to the "lblDealerText" label.

                if(dealerCardSum >= 17)//The while loop is exited once the "dealerCardSum" is more than or equal to 17.
                {
                    break;
                }
            }

            /*Multiple If statements are then used to evaluate the player and 
             * dealer scores against the predetermined win or lose conditions.
             * 
             * For each possible scenario a MessageBox is shown displaying the 
             * result to the player. The outcome is also updated to the scoreboard.
             */
            this.Controls.Remove(cardBack);/*Removes the dealer card back so the player 
                                            may view it.*/
            lblDealerScore.Text = dealerCardSum.ToString();
            dealerCardText = dealerCardText + "\n" + dealerSecondCardText;/*The "dealerCardText" is concatenated
            * with the "dealerSecondCardText"
            */
            lblDealerText.Text = dealerCardText;
            TotalDealerSum();//The "TotalDealerSum()" method is called to calculate the new dealer card total.

            if (dealerCardSum > 21)//An If statement is used to check whether the "dealerCardSum" is over 21.
            {
                MessageBox.Show("You won!");
                winScore += 1;//The "winScore" variable is increased by one.
                lblWinsCounter.Visible = true;
                lblWinsCounter.Text = winScore.ToString();
                ResetGame();//The game is reset.
            }
            else if(playerCardSum > dealerCardSum)/*An If statement is used to check whether the "playerCardSum"
                * is more than the "dealerCardSum".
                */
            {
                MessageBox.Show("You won!");
                winScore += 1;//The "winScore" variable is increased by one.
                lblWinsCounter.Visible = true;
                lblWinsCounter.Text = winScore.ToString();
                ResetGame();//The game is reset.
            }
            else if(dealerCardSum > playerCardSum)/*An If statement is used to check whether the "dealerCardSum"
                * is more than the "playerCardSum".
                */
            {
                MessageBox.Show("You lost");
                lossScore += 1;//The "lossScore" variable is increased by one.
                lblLossesCounter.Visible = true;
                lblLossesCounter.Text = lossScore.ToString();
                ResetGame();//The game is reset.
            }
            else if(dealerCardSum == playerCardSum)/*An If statement is used to check whether the "playerCardSum"
                * is equal to that of the "dealerCardSum".
                */
            {
                MessageBox.Show("its a tie!");
                tiedScore += 1;//The "tiedScore" variable is increased by one.
                lblTiesCounter.Visible = true;
                lblTiesCounter.Text = tiedScore.ToString();
                ResetGame();//The game is reset.
            }
        }
        #endregion

        /// <summary>
        /// Methods for calculating the card sums
        /// for both the player and the dealer. 
        /// Author; Danie Otto
        /// Version; 1
        /// Date; 2019/09/09
        /// </summary>
        #region Player and Dealer card totals
        /*The "TotalPlayerSum()" method first initializes the "playerCardSum" variable to 0.
         * A for loop then reassigns the "playerCardSum" values back by use of the "playerCards" List.
         * This is done so that we may check the "playerCards" List for instances of cards with the 
         * value of "11". Only Aces will contain the value of 11 in the program. All the Aces the Player 
         * contains have now been identified. 
         * 
         * An If statement then checks if the Player is about to bust. If this is the case then a value of 
         * "10" is removed from the Player total for each Ace the player hand contains. 
         */
        public void TotalPlayerSum()
        {
            playerCardSum = 0;//The "playerCardSum" variable is reset to 0.
            for(int i = 0; i < playerCards.Count; i++)
            {
                playerCardSum += playerCards[i].cardValue;/* A for loop reassigns the "playerCardSum" values back 
                * by use of the "playerCards" List.
                */
            }

            if(playerCardSum > 21)//An If statement then checks if the player is about to bust.
            {
                foreach(Card card in playerCards)
                {
                    if(card.cardValue == 11)
                    {
                        playerCardSum -= 10;/*a value of "10" is removed from the player total for 
                            * each Ace the player hand contains reducing the Ace value to 1.
                            */
                        if (playerCardSum <= 21)/*If the "playerCardSum" value is less than or equal to
                            * 21, a break statement occurs
                            */
                        {
                            break;
                        }
                    }
                }
            }
        }

        /*The "TotalDealerSum()" method first initializes the "dealerCardSum" variable to 0.
         * A for loop then reassigns the "dealerCardSum" values back by use of the "dealerCards" List.
         * This is done so that we may check the "dealerCards" List for instances of cards with the 
         * value of "11". Only Aces will contain the value of 11 in the program. All the Aces the Dealer
         * contains have now been identified. 
         * 
         * An If statement then checks if the Dealer is about to bust. If this is the case then a value of 
         * "10" is removed from the Player total for each Ace the dealer hand contains.
         */
        public void TotalDealerSum()
        {
            dealerCardSum = 0;//The "playerCardSum" variable is reset to 0.
            for (int i = 0; i < dealerCards.Count; i++)
            {
                dealerCardSum += dealerCards[i].cardValue;/* A for loop reassigns the "dealerCardSum" values back 
                * by use of the "dealerCards" List.
                */
            }
            if(dealerCardSum > 21)//An If statement then checks if the dealer is about to bust.
                foreach (Card card in dealerCards)
                {
                    if(card.cardValue == 11)
                    {
                        dealerCardSum -= 10;/*a value of "10" is removed from the dealer total for 
                            * each Ace the dealer hand contains reducing the Ace value to 1.
                            */
                        if (dealerCardSum <= 21)/*If the "playerCardSum" value is less than or equal to
                            * 21, a break statement occurs
                            */
                        {
                            break;
                        }
                    }
                }
        }
        #endregion

        /// <summary>
        /// Select Random Card method.
        /// Author; Danie Otto
        /// Version; 1
        /// Date; 2019/09/09
        /// </summary>
        #region Select Random Card method
        /*The "SelectRandomCard()" method is responsible for generating a random number
        between 0 and the total counted numer of cards in the "deckOfCards" list*/
        public static int SelectRandomCard()
        {
            int randomCard;//A new integer variable is declared.
            randomCard = rand.Next(0, deckOfCards.Count);/*The "randomCard" is assigned a random number between
            * 0 and the total count of the "deckOfCards" List.
            */
            return randomCard;//The "randomCard" value is returned. 
        }
        #endregion

        /// <summary>
        /// The Reset Game method.
        /// Author; Danie Otto
        /// Version; 1
        /// Date; 2019/09/09
        /// </summary>
        #region Reset Game method
        /*This method is called multiple times during the execution of the program.
        The Reset Game method is responsible for clearing all Variable contents, 
        PictureBox images as well as various control visibility settings.*/
        public void ResetGame()
        {
            //The below four lines are responsible for changing the current cards in play back to standard card backs. 
            picBox1.ImageLocation = @"../../bin/Debug/Cards/CardBack.png";//"picBox1" is restored to the Card Back Image.
            picBox2.ImageLocation = @"../../bin/Debug/Cards/CardBack.png";//"picBox2" is restored to the Card Back Image.
            picBox3.ImageLocation = @"../../bin/Debug/Cards/CardBack.png";//"picBox3" is restored to the Card Back Image.
            picBox4.ImageLocation = @"../../bin/Debug/Cards/CardBack.png";//"picBox4" is restored to the Card Back Image.
            this.Controls.Remove(playerHitPictureBox);//The "playerHitPictureBox" PictureBox is removed.
            this.Controls.Remove(dealerHitPictureBox);//The "dealerHitPictureBox" PictureBox is removed.

            playerCardSum = 0;//"playerCardSum" variable is reset to null. 
            dealerCardSum = 0;//"dealerCardSum" variable is reset to null. 

            playerCards.Clear();//"playerCards" List is cleared of contents.
            dealerCards.Clear();//"dealerCards" List is cleared of contents.

            btnHit.Enabled = false;//The "btnHit" button is disabled.
            btnStay.Enabled = false;//The "btnSat" button is disabled.

            btnDeal.Visible = true;//The "btnDeal" button is made visible.

            lblPlayerScore.Text = String.Empty;//The "lblPlayerScore" label is reset. 
            lblDealerScore.Text = String.Empty;//The "lblDealerScore" label is reset. 
            lblPlayerText.Text = String.Empty;//The "lblPlayerText" label is reset. 
            lblDealerText.Text = String.Empty;//The "lblDealerText" label is reset. 
        }
        #endregion

        /// <summary>
        /// The "Start" and "Quit" Button Events.
        /// </summary>
        #region Start and Quit Buttons
        /*This code segment is respondible for the "Start" button.
        When this button is pressed, the "pnlMain" panel becomes hidden,
        The player can then proceed to play the game by pressing the "Deal" button.*/ 
        private void LblStartGame_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;//Enables the "pnlMain" panel. 
            cardBack.Visible = true;//Enables the "CardBack" image.
        }

        /*This code segment is responsible for the "Quit" button. 
        When the button is pressed, the game reverts to the "Start" screen. 
        In addition the game is reset and all variables are cleared of contents.*/ 
        private void LblQuit_Click(object sender, EventArgs e)
        {
            ResetGame();//"ResetGame()" method is used to restart the game.
            lblWinsCounter.Text = String.Empty;//"lblWinsCounter" is reset.
            lblLossesCounter.Text = String.Empty;//"lblLossesCounter" is reset.
            lblTiesCounter.Text = String.Empty;//"lblTiesCounter" is reset.
            pnlMain.Visible = true;//"pnlMain" Panel is made visible.
            cardBack.Visible = false;//Card Back image is made visible.
        }
        #endregion
    }
}
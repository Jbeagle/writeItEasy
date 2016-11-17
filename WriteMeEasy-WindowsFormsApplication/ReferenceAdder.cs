﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteMeEasy_WindowsFormsApplication
{
    public partial class ReferenceAdder : Form
    {
        public ReferenceAdder()
        {
            InitializeComponent();

            this.Width = 1909;
            this.Height = 1447;
            sourceInfoGroupBox.Height = 155;
            sourceInfoPanel.Height = 135;

            bookAuth.Checked = false;
            bookAuth.Checked = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getSourceInfoHeight(int numSourceInfo)
        {
            return (numSourceInfo * 25) + 5;
        }

        private void removeInsideInfo()
        {
            sourceInfoPanel.VerticalScroll.Value = 0;
            sourceInfoPanel.Controls.Clear();
        }

        private void translatorAdderButton_Click(object sender, EventArgs e)
        {
            Control firstTranslator = Controls.Find("translatorFirstEnter1", true)[0];
            Control middleTranslator = Controls.Find("translatorMiddleEnter1", true)[0];
            Control lastTranslator = Controls.Find("translatorLastEnter1", true)[0];
            sourceInfoPanel.VerticalScroll.Value = 0;
            string numAuth = sourceInfoGroupBox.Tag.ToString().Split(',')[0];
            string numPieces = sourceInfoGroupBox.Tag.ToString().Split(',')[1];
            string numTranslator = sourceInfoGroupBox.Tag.ToString().Split(',')[2];
            string newIndex = (Convert.ToInt32(numTranslator) + 1).ToString();
            string newPieces = (Convert.ToInt32(numPieces) + 1).ToString();
            addAuthor(Convert.ToInt32(newPieces), 25, "translatorFirstEnter" + numTranslator);
            Button addTranslatorButton = (Button)Controls.Find("translatorAdderButton", true)[0];
            addTranslatorButton.Location = new Point(addTranslatorButton.Location.X, addTranslatorButton.Location.Y - 25);

            Label translatorLabel = new Label();
            translatorLabel.Text = "Translator Name:";
            sourceInfoPanel.Controls.Add(translatorLabel);
            translatorLabel.Location = new Point(0, Convert.ToInt32(numAuth) * 25 + 50);

            TextBox translatorFirstEnter = new TextBox();
            translatorFirstEnter.Name = "translatorFirstEnter" + newIndex;
            sourceInfoPanel.Controls.Add(translatorFirstEnter);
            translatorFirstEnter.Location = new Point(firstTranslator.Location.X, Convert.ToInt32(numAuth) * 25 + 50);
            translatorFirstEnter.Width = 100;

            TextBox translatorMiddleEnter = new TextBox();
            translatorMiddleEnter.Name = "translatorMiddleEnter" + newIndex;
            sourceInfoPanel.Controls.Add(translatorMiddleEnter);
            translatorMiddleEnter.Location = new Point(middleTranslator.Location.X, Convert.ToInt32(numAuth) * 25 + 50);
            translatorMiddleEnter.Width = 100;

            TextBox translatorLastEnter = new TextBox();
            translatorLastEnter.Name = "translatorLastEnter" + newIndex;
            sourceInfoPanel.Controls.Add(translatorLastEnter);
            translatorLastEnter.Location = new Point(lastTranslator.Location.X, Convert.ToInt32(numAuth) * 25 + 50);
            translatorLastEnter.Width = 100;

            sourceInfoGroupBox.Tag = numAuth + "," + newPieces + "," + newIndex;
        }

        private void intervieweeAdderButton_Click(object sender, EventArgs e)
        {
            Control firstInterviewee = Controls.Find("intervieweeFirstEnter1", true)[0];
            Control middleInterviewee = Controls.Find("intervieweeMiddleEnter1", true)[0];
            Control lastInterviewee = Controls.Find("intervieweeLastEnter1", true)[0];
            sourceInfoPanel.VerticalScroll.Value = 0;
            string numInterviewer = sourceInfoGroupBox.Tag.ToString().Split(',')[0];
            string numPieces = sourceInfoGroupBox.Tag.ToString().Split(',')[1];
            string numInterviewee = sourceInfoGroupBox.Tag.ToString().Split(',')[2];
            string newIndex = (Convert.ToInt32(numInterviewee) + 1).ToString();
            string newPieces = (Convert.ToInt32(numPieces) + 1).ToString();
            addAuthor(Convert.ToInt32(newPieces), 25, "intervieweeFirstEnter" + numInterviewee);
            Button addIntervieweeButton = (Button)Controls.Find("intervieweeAdderButton", true)[0];
            addIntervieweeButton.Location = new Point(addIntervieweeButton.Location.X, addIntervieweeButton.Location.Y - 25);

            Label intervieweeLabel = new Label();
            intervieweeLabel.Text = "Interviewee:";
            sourceInfoPanel.Controls.Add(intervieweeLabel);
            intervieweeLabel.Location = new Point(0, Convert.ToInt32(numInterviewer) * 25);

            TextBox intervieweeFirstEnter = new TextBox();
            intervieweeFirstEnter.Name = "intervieweeFirstEnter" + newIndex;
            sourceInfoPanel.Controls.Add(intervieweeFirstEnter);
            intervieweeFirstEnter.Location = new Point(firstInterviewee.Location.X, Convert.ToInt32(numInterviewer) * 25);
            intervieweeFirstEnter.Width = 100;

            TextBox intervieweeMiddleEnter = new TextBox();
            intervieweeMiddleEnter.Name = "intervieweeMiddleEnter" + newIndex;
            sourceInfoPanel.Controls.Add(intervieweeMiddleEnter);
            intervieweeMiddleEnter.Location = new Point(middleInterviewee.Location.X, Convert.ToInt32(numInterviewer) * 25);
            intervieweeMiddleEnter.Width = 100;

            TextBox intervieweeLastEnter = new TextBox();
            intervieweeLastEnter.Name = "intervieweeLastEnter" + newIndex;
            sourceInfoPanel.Controls.Add(intervieweeLastEnter);
            intervieweeLastEnter.Location = new Point(lastInterviewee.Location.X, Convert.ToInt32(numInterviewer) * 25);
            intervieweeLastEnter.Width = 100;

            sourceInfoGroupBox.Tag = numInterviewer + "," + newPieces + "," + newIndex;
        }

        private void interviewerAdderButton_Click(object sender, EventArgs e)
        {
            Control firstInterviewer = Controls.Find("interviewerFirstEnter1", true)[0];
            Control middleInterviewer = Controls.Find("interviewerMiddleEnter1", true)[0];
            Control lastInterviewer = Controls.Find("interviewerLastEnter1", true)[0];
            sourceInfoPanel.VerticalScroll.Value = 0;
            string numInterviewer = sourceInfoGroupBox.Tag.ToString().Split(',')[0];
            string numPieces = sourceInfoGroupBox.Tag.ToString().Split(',')[1];
            string numInterviewee = sourceInfoGroupBox.Tag.ToString().Split(',')[2];
            string newIndex = (Convert.ToInt32(numInterviewer) + 1).ToString();
            string newPieces = (Convert.ToInt32(numPieces) + 1).ToString();
            addAuthor(Convert.ToInt32(newPieces), 25, "interviewerFirstEnter" + numInterviewer);
            Button addInterviewerButton = (Button)Controls.Find("interviewerAdderButton", true)[0];
            addInterviewerButton.Location = new Point(addInterviewerButton.Location.X, addInterviewerButton.Location.Y - 25);

            Label interviewerLabel = new Label();
            interviewerLabel.Text = "Interviewer:";
            sourceInfoPanel.Controls.Add(interviewerLabel);
            interviewerLabel.Location = new Point(0, 0);

            TextBox interviewerFirstEnter = new TextBox();
            interviewerFirstEnter.Name = "interviewerFirstEnter" + newIndex;
            sourceInfoPanel.Controls.Add(interviewerFirstEnter);
            interviewerFirstEnter.Location = new Point(firstInterviewer.Location.X, 0);
            interviewerFirstEnter.Width = 100;

            TextBox interviewerMiddleEnter = new TextBox();
            interviewerMiddleEnter.Name = "interviewerMiddleEnter" + newIndex;
            sourceInfoPanel.Controls.Add(interviewerMiddleEnter);
            interviewerMiddleEnter.Location = new Point(middleInterviewer.Location.X, 0);
            interviewerMiddleEnter.Width = 100;

            TextBox interviewerLastEnter = new TextBox();
            interviewerLastEnter.Name = "interviewerLastEnter" + newIndex;
            sourceInfoPanel.Controls.Add(interviewerLastEnter);
            interviewerLastEnter.Location = new Point(lastInterviewer.Location.X, 0);
            interviewerLastEnter.Width = 100;

            sourceInfoGroupBox.Tag = newIndex + "," + newPieces + "," + numInterviewee;
        }

        private void authorAdderButton_Click(object sender, EventArgs e)
        {
            Control firstAuthor = Controls.Find("authorFirstEnter1", true)[0];
            Control middleAuthor = Controls.Find("authorMiddleEnter1", true)[0];
            Control lastAuthor = Controls.Find("authorLastEnter1", true)[0];
            sourceInfoPanel.VerticalScroll.Value = 0;
            string numAuth = sourceInfoGroupBox.Tag.ToString().Split(',')[0];
            string numPieces = sourceInfoGroupBox.Tag.ToString().Split(',')[1];
            string newIndex = (Convert.ToInt32(numAuth) + 1).ToString();
            string newPieces = (Convert.ToInt32(numPieces) + 1).ToString();
            addAuthor(Convert.ToInt32(newPieces), 25, "authorFirstEnter" + numAuth);
            Button addAuthorButton = (Button)Controls.Find("authorAdderButton", true)[0];
            addAuthorButton.Location = new Point(addAuthorButton.Location.X, addAuthorButton.Location.Y - 25);

            Label authorLabel = new Label();
            authorLabel.Text = "Author:";
            sourceInfoPanel.Controls.Add(authorLabel);
            authorLabel.Location = new Point(0, 0);

            TextBox authorFirstEnter = new TextBox();
            authorFirstEnter.Name = "authorFirstEnter" + newIndex;
            sourceInfoPanel.Controls.Add(authorFirstEnter);
            authorFirstEnter.Location = new Point(firstAuthor.Location.X, 0);
            authorFirstEnter.Width = 100;

            TextBox authorMiddleEnter = new TextBox();
            authorMiddleEnter.Name = "authorMiddleEnter" + newIndex;
            sourceInfoPanel.Controls.Add(authorMiddleEnter);
            authorMiddleEnter.Location = new Point(middleAuthor.Location.X, 0);
            authorMiddleEnter.Width = 100;

            TextBox authorLastEnter = new TextBox();
            authorLastEnter.Name = "authorLastEnter" + newIndex;
            sourceInfoPanel.Controls.Add(authorLastEnter);
            authorLastEnter.Location = new Point(lastAuthor.Location.X, 0);
            authorLastEnter.Width = 100;

            sourceInfoGroupBox.Tag = newIndex + "," + newPieces;
        }
        private void authorTransAdderButton_Click(object sender, EventArgs e)
        {
            Control firstAuthor = Controls.Find("authorFirstEnter1", true)[0];
            Control middleAuthor = Controls.Find("authorMiddleEnter1", true)[0];
            Control lastAuthor = Controls.Find("authorLastEnter1", true)[0];
            sourceInfoPanel.VerticalScroll.Value = 0;
            string numAuth = sourceInfoGroupBox.Tag.ToString().Split(',')[0];
            string numPieces = sourceInfoGroupBox.Tag.ToString().Split(',')[1];
            string numTrans = sourceInfoGroupBox.Tag.ToString().Split(',')[2];
            string newIndex = (Convert.ToInt32(numAuth) + 1).ToString();
            string newPieces = (Convert.ToInt32(numPieces) + 1).ToString();
            addAuthor(Convert.ToInt32(newPieces), 25, "authorFirstEnter" + numAuth);
            Button addAuthorButton = (Button)Controls.Find("authorTransAdderButton", true)[0];
            addAuthorButton.Location = new Point(addAuthorButton.Location.X, addAuthorButton.Location.Y - 25);

            Label authorLabel = new Label();
            authorLabel.Text = "Author:";
            sourceInfoPanel.Controls.Add(authorLabel);
            authorLabel.Location = new Point(0, 0);

            TextBox authorFirstEnter = new TextBox();
            authorFirstEnter.Name = "authorFirstEnter" + newIndex;
            sourceInfoPanel.Controls.Add(authorFirstEnter);
            authorFirstEnter.Location = new Point(firstAuthor.Location.X, 0);
            authorFirstEnter.Width = 100;

            TextBox authorMiddleEnter = new TextBox();
            authorMiddleEnter.Name = "authorMiddleEnter" + newIndex;
            sourceInfoPanel.Controls.Add(authorMiddleEnter);
            authorMiddleEnter.Location = new Point(middleAuthor.Location.X, 0);
            authorMiddleEnter.Width = 100;

            TextBox authorLastEnter = new TextBox();
            authorLastEnter.Name = "authorLastEnter" + newIndex;
            sourceInfoPanel.Controls.Add(authorLastEnter);
            authorLastEnter.Location = new Point(lastAuthor.Location.X, 0);
            authorLastEnter.Width = 100;

            sourceInfoGroupBox.Tag = newIndex + "," + newPieces + "," + numTrans;
        }

        //highestControlName is the highest thing to lower
        private void addAuthor(int newNum, int pixels, string highestControlName)
        {
            Control highest = Controls.Find(highestControlName, true)[0];
            int highestY = highest.Location.Y;
            Control parent = highest.Parent;

            foreach (Control child in parent.Controls)
            {
                if (child.Location.Y >= highestY)
                {
                    child.Location = new Point(child.Location.X, child.Location.Y + pixels);
                }
            }

            if (getSourceInfoHeight(newNum) > 135)
            {
                sourceInfoPanel.Height = 135;
                sourceInfoGroupBox.Height = 160;
                sourceInfoPanel.AutoScroll = true;

                moveTo("quoteContentGroupBox", 434);
            }
            else
            {
                sourceInfoPanel.Height = getSourceInfoHeight(newNum);
                sourceInfoGroupBox.Height = getSourceInfoHeight(newNum) + 25;
                sourceInfoPanel.VerticalScroll.Value = 0;
                sourceInfoPanel.AutoScroll = false;

                moveTo("quoteContentGroupBox", getSourceInfoHeight(newNum) + 299);
            }
        }

        private void moveTo(string controlName, int yPos)
        {
            Control controlToMove = Controls.Find(controlName, true)[0];
            int yDiff = yPos - controlToMove.Location.Y;
            int topY = controlToMove.Location.Y;
            Control parent = controlToMove.Parent;

            foreach (Control child in parent.Controls)
            {
                if (child.Location.Y >= topY)
                {
                    child.Location = new Point(child.Location.X, child.Location.Y + yDiff);
                }
            }
            parent.Height += yDiff;
        }        

        private void referenceTypeChange(object sender, EventArgs e)
        {
            if (bookAuth.Checked)
            {
                removeInsideInfo(); 

                if (getSourceInfoHeight(6) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(6);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(6) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(6) + 299);
                }
                sourceInfoGroupBox.Tag = "1,6";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Year of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label publisherLabel = new Label();
                publisherLabel.Text = "Publisher Name:";
                sourceInfoPanel.Controls.Add(publisherLabel);
                publisherLabel.Location = new Point(0, 75);

                TextBox publisherEnter = new TextBox();
                publisherEnter.Name = "publisherEnter";
                sourceInfoPanel.Controls.Add(publisherEnter);
                publisherEnter.Location = new Point(109, 75);
                publisherEnter.Width = 150;

                Label publishLocationLabel = new Label();
                publishLocationLabel.Text = "Publication Location:";
                sourceInfoPanel.Controls.Add(publishLocationLabel);
                publishLocationLabel.Location = new Point(0, 100);
                publishLocationLabel.Width = 109;

                TextBox publishLocationEnter = new TextBox();
                publishLocationEnter.Name = "publishLocationEnter";
                sourceInfoPanel.Controls.Add(publishLocationEnter);
                publishLocationEnter.Location = new Point(109, 100);
                publishLocationEnter.Width = 150;

                Label editionLabel = new Label();
                editionLabel.Text = "Edition:";
                sourceInfoPanel.Controls.Add(editionLabel);
                editionLabel.Location = new Point(0, 125);

                TextBox editionEnter = new TextBox();
                editionEnter.Name = "editionEnter";
                sourceInfoPanel.Controls.Add(editionEnter);
                editionEnter.Location = new Point(109, 125);
                editionEnter.Width = 150;
            }
            else if (bookNoAuth.Checked)
            {
                removeInsideInfo();
                if (getSourceInfoHeight(5) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(5);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(5) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(5) + 299);
                }

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Year of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 0);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 0);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 25);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 25);
                titleEnter.Width = 150;

                Label publisherLabel = new Label();
                publisherLabel.Text = "Publisher Name:";
                sourceInfoPanel.Controls.Add(publisherLabel);
                publisherLabel.Location = new Point(0, 50);

                TextBox publisherEnter = new TextBox();
                publisherEnter.Name = "publisherEnter";
                sourceInfoPanel.Controls.Add(publisherEnter);
                publisherEnter.Location = new Point(109, 50);
                publisherEnter.Width = 150;

                Label publishLocationLabel = new Label();
                publishLocationLabel.Text = "Publication Location:";
                sourceInfoPanel.Controls.Add(publishLocationLabel);
                publishLocationLabel.Location = new Point(0, 75);
                publishLocationLabel.Width = 109;

                TextBox publishLocationEnter = new TextBox();
                publishLocationEnter.Name = "publishLocationEnter";
                sourceInfoPanel.Controls.Add(publishLocationEnter);
                publishLocationEnter.Location = new Point(109, 75);
                publishLocationEnter.Width = 150;

                Label editionLabel = new Label();
                editionLabel.Text = "Edition:";
                sourceInfoPanel.Controls.Add(editionLabel);
                editionLabel.Location = new Point(0, 100);

                TextBox editionEnter = new TextBox();
                editionEnter.Name = "editionEnter";
                sourceInfoPanel.Controls.Add(editionEnter);
                editionEnter.Location = new Point(109, 100);
                editionEnter.Width = 150;
            }
            else if (bookByOrg.Checked)
            {
                removeInsideInfo();
                if (getSourceInfoHeight(6) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(6);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(6) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(6) + 299);
                }

                Label authorLabel = new Label();
                authorLabel.Text = "Organization:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorEnter = new TextBox();
                authorEnter.Name = "authorEnter";
                sourceInfoPanel.Controls.Add(authorEnter);
                authorEnter.Location = new Point(109, 0);
                authorEnter.Width = 150;

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Year of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label publisherLabel = new Label();
                publisherLabel.Text = "Publisher Name:";
                sourceInfoPanel.Controls.Add(publisherLabel);
                publisherLabel.Location = new Point(0, 75);

                TextBox publisherEnter = new TextBox();
                publisherEnter.Name = "publisherEnter";
                sourceInfoPanel.Controls.Add(publisherEnter);
                publisherEnter.Location = new Point(109, 75);
                publisherEnter.Width = 150;

                Label publishLocationLabel = new Label();
                publishLocationLabel.Text = "Publication Location:";
                sourceInfoPanel.Controls.Add(publishLocationLabel);
                publishLocationLabel.Location = new Point(0, 100);
                publishLocationLabel.Width = 109;

                TextBox publishLocationEnter = new TextBox();
                publishLocationEnter.Name = "publishLocationEnter";
                sourceInfoPanel.Controls.Add(publishLocationEnter);
                publishLocationEnter.Location = new Point(109, 100);
                publishLocationEnter.Width = 150;

                Label editionLabel = new Label();
                editionLabel.Text = "Edition:";
                sourceInfoPanel.Controls.Add(editionLabel);
                editionLabel.Location = new Point(0, 125);

                TextBox editionEnter = new TextBox();
                editionEnter.Name = "editionEnter";
                sourceInfoPanel.Controls.Add(editionEnter);
                editionEnter.Location = new Point(109, 125);
                editionEnter.Width = 150;
            }
            else if (encyclopedia.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(9) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(9);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(9) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(9) + 299);
                }
                sourceInfoGroupBox.Tag = "1,9";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(180, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(295, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(410, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(530, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publicationYearLabel = new Label();
                publicationYearLabel.Text = "Year of Publication:";
                sourceInfoPanel.Controls.Add(publicationYearLabel);
                publicationYearLabel.Location = new Point(0, 25);

                TextBox publicationYearEnter = new TextBox();
                publicationYearEnter.Name = "publicationYearEnter";
                sourceInfoPanel.Controls.Add(publicationYearEnter);
                publicationYearEnter.Location = new Point(180, 25);
                publicationYearEnter.Width = 150;

                Label sectionNameLabel = new Label();
                sectionNameLabel.Text = "Section or Word Referenced:";
                sourceInfoPanel.Controls.Add(sectionNameLabel);
                sectionNameLabel.Location = new Point(0, 50);
                sectionNameLabel.Width = 180;

                TextBox sectionNameEnter = new TextBox();
                sectionNameEnter.Name = "sectionNameEnter";
                sourceInfoPanel.Controls.Add(sectionNameEnter);
                sectionNameEnter.Location = new Point(180, 50);
                sectionNameEnter.Width = 150;

                Label bookNameLabel = new Label();
                bookNameLabel.Text = "Title of Encyclopedia/Dictionary:";
                sourceInfoPanel.Controls.Add(bookNameLabel);
                bookNameLabel.Location = new Point(0, 75);
                bookNameLabel.Width = 180;

                TextBox bookNameEnter = new TextBox();
                bookNameEnter.Name = "bookNameEnter";
                sourceInfoPanel.Controls.Add(bookNameEnter);
                bookNameEnter.Location = new Point(180, 75);
                bookNameEnter.Width = 150;

                Label volumeLabel = new Label();
                volumeLabel.Text = "Volume:";
                sourceInfoPanel.Controls.Add(volumeLabel);
                volumeLabel.Location = new Point(0, 100);

                TextBox volumeEnter = new TextBox();
                volumeEnter.Name = "volumeEnter";
                sourceInfoPanel.Controls.Add(volumeEnter);
                volumeEnter.Location = new Point(180, 100);
                volumeEnter.Width = 150;

                Label pageStartLabel = new Label();
                pageStartLabel.Text = "Start Page:";
                sourceInfoPanel.Controls.Add(pageStartLabel);
                pageStartLabel.Location = new Point(0, 125);

                TextBox pageStartEnter = new TextBox();
                pageStartEnter.Name = "pageStartEnter";
                sourceInfoPanel.Controls.Add(pageStartEnter);
                pageStartEnter.Location = new Point(180, 125);
                pageStartEnter.Width = 150;

                Label pageEndLabel = new Label();
                pageEndLabel.Text = "End Page:";
                sourceInfoPanel.Controls.Add(pageEndLabel);
                pageEndLabel.Location = new Point(0, 150);

                TextBox pageEndEnter = new TextBox();
                pageEndEnter.Name = "pageEndEnter";
                sourceInfoPanel.Controls.Add(pageEndEnter);
                pageEndEnter.Location = new Point(180, 150);
                pageEndEnter.Width = 150;

                Label publishLocationLabel = new Label();
                publishLocationLabel.Text = "Publication Location:";
                sourceInfoPanel.Controls.Add(publishLocationLabel);
                publishLocationLabel.Location = new Point(0, 175);
                publishLocationLabel.Width = 180;

                TextBox publicationLocationEnter = new TextBox();
                publicationLocationEnter.Name = "publicationLocationEnter";
                sourceInfoPanel.Controls.Add(publicationLocationEnter);
                publicationLocationEnter.Location = new Point(180, 175);
                publicationLocationEnter.Width = 150;

                Label publisherLabel = new Label();
                publisherLabel.Text = "Publisher Name:";
                sourceInfoPanel.Controls.Add(publisherLabel);
                publisherLabel.Location = new Point(0, 200);

                TextBox publisherEnter = new TextBox();
                publisherEnter.Name = "publisherEnter";
                sourceInfoPanel.Controls.Add(publisherEnter);
                publisherEnter.Location = new Point(180, 200);
                publisherEnter.Width = 150;
            }
            else if (translated.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(7) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(7);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(7) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(7) + 299);
                }
                sourceInfoGroupBox.Tag = "1,7,1";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorTransAdder = new Button();
                authorTransAdder.Name = "authorTransAdderButton";
                authorTransAdder.Text = "Add an Author";
                authorTransAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorTransAdder);
                authorTransAdder.Location = new Point(459, 0);
                authorTransAdder.Click += new EventHandler(authorTransAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Publication Year:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label translatorLabel = new Label();
                translatorLabel.Text = "Translator Name:";
                sourceInfoPanel.Controls.Add(translatorLabel);
                translatorLabel.Location = new Point(0, 75);

                TextBox translatorFirstEnter = new TextBox();
                translatorFirstEnter.Name = "translatorFirstEnter1";
                sourceInfoPanel.Controls.Add(translatorFirstEnter);
                translatorFirstEnter.Location = new Point(109, 75);
                translatorFirstEnter.Width = 100;

                TextBox translatorMiddleEnter = new TextBox();
                translatorMiddleEnter.Name = "translatorMiddleEnter1";
                sourceInfoPanel.Controls.Add(translatorMiddleEnter);
                translatorMiddleEnter.Location = new Point(224, 75);
                translatorMiddleEnter.Width = 100;

                TextBox translatorLastEnter = new TextBox();
                translatorLastEnter.Name = "translatorLastEnter1";
                sourceInfoPanel.Controls.Add(translatorLastEnter);
                translatorLastEnter.Location = new Point(339, 75);
                translatorLastEnter.Width = 100;

                Button translatorAdder = new Button();
                translatorAdder.Name = "translatorAdderButton";
                translatorAdder.Text = "Add an Translator";
                translatorAdder.Width = 120;
                sourceInfoPanel.Controls.Add(translatorAdder);
                translatorAdder.Location = new Point(459, 75);
                translatorAdder.Click += new EventHandler(translatorAdderButton_Click);

                Label publishLocationLabel = new Label();
                publishLocationLabel.Text = "Publication Location:";
                sourceInfoPanel.Controls.Add(publishLocationLabel);
                publishLocationLabel.Location = new Point(0, 100);
                publishLocationLabel.Width = 109;

                TextBox publishLocationEnter = new TextBox();
                publishLocationEnter.Name = "publishLocationEnter";
                sourceInfoPanel.Controls.Add(publishLocationEnter);
                publishLocationEnter.Location = new Point(109, 100);
                publishLocationEnter.Width = 150;

                Label publisherLabel = new Label();
                publisherLabel.Text = "Publisher Name:";
                sourceInfoPanel.Controls.Add(publisherLabel);
                publisherLabel.Location = new Point(0, 125);

                TextBox publisherEnter = new TextBox();
                publisherEnter.Name = "publisherEnter";
                sourceInfoPanel.Controls.Add(publisherEnter);
                publisherEnter.Location = new Point(109, 125);
                publisherEnter.Width = 150;

                Label editionLabel = new Label();
                editionLabel.Text = "Edition:";
                sourceInfoPanel.Controls.Add(editionLabel);
                editionLabel.Location = new Point(0, 150);

                TextBox editionEnter = new TextBox();
                editionEnter.Name = "editionEnter";
                sourceInfoPanel.Controls.Add(editionEnter);
                editionEnter.Location = new Point(109, 150);
                editionEnter.Width = 150;

            }
            else if (magazine.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(8) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(8);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(8) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(8) + 299);
                }
                sourceInfoGroupBox.Tag = "1,8";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Date of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Article Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label magazineNameLabel = new Label();
                magazineNameLabel.Text = "Magazine Name:";
                sourceInfoPanel.Controls.Add(magazineNameLabel);
                magazineNameLabel.Location = new Point(0, 75);

                TextBox magazineNameEnter = new TextBox();
                magazineNameEnter.Name = "magazineNameEnter";
                sourceInfoPanel.Controls.Add(magazineNameEnter);
                magazineNameEnter.Location = new Point(109, 75);
                magazineNameEnter.Width = 150;

                Label volumeNumberLabel = new Label();
                volumeNumberLabel.Text = "Volume Number:";
                sourceInfoPanel.Controls.Add(volumeNumberLabel);
                volumeNumberLabel.Location = new Point(0, 100);

                TextBox volumeNumberEnter = new TextBox();
                volumeNumberEnter.Name = "volumeNumberEnter";
                sourceInfoPanel.Controls.Add(volumeNumberEnter);
                volumeNumberEnter.Location = new Point(109, 100);
                volumeNumberEnter.Width = 150;

                Label issueNumberLabel = new Label();
                issueNumberLabel.Text = "Issue Number:";
                sourceInfoPanel.Controls.Add(issueNumberLabel);
                issueNumberLabel.Location = new Point(0, 125);

                TextBox issueNumberEnter = new TextBox();
                issueNumberEnter.Name = "issueNumberEnter";
                sourceInfoPanel.Controls.Add(issueNumberEnter);
                issueNumberEnter.Location = new Point(109, 125);
                issueNumberEnter.Width = 150;

                Label pageStartLabel = new Label();
                pageStartLabel.Text = "Start Page:";
                sourceInfoPanel.Controls.Add(pageStartLabel);
                pageStartLabel.Location = new Point(0, 150);

                TextBox pageStartEnter = new TextBox();
                pageStartEnter.Name = "pageStartEnter";
                sourceInfoPanel.Controls.Add(pageStartEnter);
                pageStartEnter.Location = new Point(109, 150);
                pageStartEnter.Width = 150;

                Label pageEndLabel = new Label();
                pageEndLabel.Text = "End Page:";
                sourceInfoPanel.Controls.Add(pageEndLabel);
                pageEndLabel.Location = new Point(0, 175);

                TextBox pageEndEnter = new TextBox();
                pageEndEnter.Name = "pageEndEnter";
                sourceInfoPanel.Controls.Add(pageEndEnter);
                pageEndEnter.Location = new Point(109, 175);
                pageEndEnter.Width = 150;
            }
            else if (newspaper.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(6) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(6);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(6) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(6) + 299);
                }
                sourceInfoGroupBox.Tag = "1,8";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Date of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Article Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label newspaperNameLabel = new Label();
                newspaperNameLabel.Text = "Newspaper Name:";
                sourceInfoPanel.Controls.Add(newspaperNameLabel);
                newspaperNameLabel.Location = new Point(0, 75);

                TextBox newspaperNameEnter = new TextBox();
                newspaperNameEnter.Name = "newspaperNameEnter";
                sourceInfoPanel.Controls.Add(newspaperNameEnter);
                newspaperNameEnter.Location = new Point(109, 75);
                newspaperNameEnter.Width = 150;
                
                Label pageStartLabel = new Label();
                pageStartLabel.Text = "Start Page:";
                sourceInfoPanel.Controls.Add(pageStartLabel);
                pageStartLabel.Location = new Point(0, 100);

                TextBox pageStartEnter = new TextBox();
                pageStartEnter.Name = "pageStartEnter";
                sourceInfoPanel.Controls.Add(pageStartEnter);
                pageStartEnter.Location = new Point(109, 100);
                pageStartEnter.Width = 150;

                Label pageEndLabel = new Label();
                pageEndLabel.Text = "End Page:";
                sourceInfoPanel.Controls.Add(pageEndLabel);
                pageEndLabel.Location = new Point(0, 125);

                TextBox pageEndEnter = new TextBox();
                pageEndEnter.Name = "pageEndEnter";
                sourceInfoPanel.Controls.Add(pageEndEnter);
                pageEndEnter.Location = new Point(109, 125);
                pageEndEnter.Width = 150;

            }
            else if (journal.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(8) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(8);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(8) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(8) + 299);
                }
                sourceInfoGroupBox.Tag = "1,8";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Year of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Article Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label journalNameLabel = new Label();
                journalNameLabel.Text = "Journal Name:";
                sourceInfoPanel.Controls.Add(journalNameLabel);
                journalNameLabel.Location = new Point(0, 75);

                TextBox journalNameEnter = new TextBox();
                journalNameEnter.Name = "journalNameEnter";
                sourceInfoPanel.Controls.Add(journalNameEnter);
                journalNameEnter.Location = new Point(109, 75);
                journalNameEnter.Width = 150;

                Label volumeNumberLabel = new Label();
                volumeNumberLabel.Text = "Volume Number:";
                sourceInfoPanel.Controls.Add(volumeNumberLabel);
                volumeNumberLabel.Location = new Point(0, 100);

                TextBox volumeNumberEnter = new TextBox();
                volumeNumberEnter.Name = "volumeNumberEnter";
                sourceInfoPanel.Controls.Add(volumeNumberEnter);
                volumeNumberEnter.Location = new Point(109, 100);
                volumeNumberEnter.Width = 150;

                Label issueNumberLabel = new Label();
                issueNumberLabel.Text = "Issue Number:";
                sourceInfoPanel.Controls.Add(issueNumberLabel);
                issueNumberLabel.Location = new Point(0, 125);

                TextBox issueNumberEnter = new TextBox();
                issueNumberEnter.Name = "issueNumberEnter";
                sourceInfoPanel.Controls.Add(issueNumberEnter);
                issueNumberEnter.Location = new Point(109, 125);
                issueNumberEnter.Width = 150;

                Label pageStartLabel = new Label();
                pageStartLabel.Text = "Start Page:";
                sourceInfoPanel.Controls.Add(pageStartLabel);
                pageStartLabel.Location = new Point(0, 150);

                TextBox pageStartEnter = new TextBox();
                pageStartEnter.Name = "pageStartEnter";
                sourceInfoPanel.Controls.Add(pageStartEnter);
                pageStartEnter.Location = new Point(109, 150);
                pageStartEnter.Width = 150;

                Label pageEndLabel = new Label();
                pageEndLabel.Text = "End Page:";
                sourceInfoPanel.Controls.Add(pageEndLabel);
                pageEndLabel.Location = new Point(0, 175);

                TextBox pageEndEnter = new TextBox();
                pageEndEnter.Name = "pageEndEnter";
                sourceInfoPanel.Controls.Add(pageEndEnter);
                pageEndEnter.Location = new Point(109, 175);
                pageEndEnter.Width = 150;

            }
            else if (onlineJournal.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(8) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(8);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(8) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(8) + 299);
                }
                sourceInfoGroupBox.Tag = "1,8";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Year of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Article Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label journalNameLabel = new Label();
                journalNameLabel.Text = "Journal Name:";
                sourceInfoPanel.Controls.Add(journalNameLabel);
                journalNameLabel.Location = new Point(0, 75);

                TextBox journalNameEnter = new TextBox();
                journalNameEnter.Name = "journalNameEnter";
                sourceInfoPanel.Controls.Add(journalNameEnter);
                journalNameEnter.Location = new Point(109, 75);
                journalNameEnter.Width = 150;

                Label volumeNumberLabel = new Label();
                volumeNumberLabel.Text = "Volume Number:";
                sourceInfoPanel.Controls.Add(volumeNumberLabel);
                volumeNumberLabel.Location = new Point(0, 100);

                TextBox volumeNumberEnter = new TextBox();
                volumeNumberEnter.Name = "volumeNumberEnter";
                sourceInfoPanel.Controls.Add(volumeNumberEnter);
                volumeNumberEnter.Location = new Point(109, 100);
                volumeNumberEnter.Width = 150;

                Label issueNumberLabel = new Label();
                issueNumberLabel.Text = "Issue Number:";
                sourceInfoPanel.Controls.Add(issueNumberLabel);
                issueNumberLabel.Location = new Point(0, 125);

                TextBox issueNumberEnter = new TextBox();
                issueNumberEnter.Name = "issueNumberEnter";
                sourceInfoPanel.Controls.Add(issueNumberEnter);
                issueNumberEnter.Location = new Point(109, 125);
                issueNumberEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 150);

                TextBox retrievedFromEnter = new TextBox();
                retrievedFromEnter.Name = "retrievedFromEnter";
                sourceInfoPanel.Controls.Add(retrievedFromEnter);
                retrievedFromEnter.Location = new Point(109, 150);
                retrievedFromEnter.Width = 150;

                Label doiLabel = new Label();
                doiLabel.Text = "DOI:";
                sourceInfoPanel.Controls.Add(doiLabel);
                doiLabel.Location = new Point(0, 175);

                TextBox doiEnter = new TextBox();
                doiEnter.Name = "doiEnter";
                sourceInfoPanel.Controls.Add(doiEnter);
                doiEnter.Location = new Point(109, 175);
                doiEnter.Width = 150;
            }
            else if (onlinePeriodical.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(8) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(8);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(8) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(8) + 299);
                }
                sourceInfoGroupBox.Tag = "1,8";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Year of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Article Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label periodicalNameLabel = new Label();
                periodicalNameLabel.Text = "Periodical Name:";
                sourceInfoPanel.Controls.Add(periodicalNameLabel);
                periodicalNameLabel.Location = new Point(0, 75);

                TextBox periodicalNameEnter = new TextBox();
                periodicalNameEnter.Name = "periodicalNameEnter";
                sourceInfoPanel.Controls.Add(periodicalNameEnter);
                periodicalNameEnter.Location = new Point(109, 75);
                periodicalNameEnter.Width = 150;

                Label volumeNumberLabel = new Label();
                volumeNumberLabel.Text = "Volume Number:";
                sourceInfoPanel.Controls.Add(volumeNumberLabel);
                volumeNumberLabel.Location = new Point(0, 100);

                TextBox volumeNumberEnter = new TextBox();
                volumeNumberEnter.Name = "volumeNumberEnter";
                sourceInfoPanel.Controls.Add(volumeNumberEnter);
                volumeNumberEnter.Location = new Point(109, 100);
                volumeNumberEnter.Width = 150;

                Label issueNumberLabel = new Label();
                issueNumberLabel.Text = "Issue Number:";
                sourceInfoPanel.Controls.Add(issueNumberLabel);
                issueNumberLabel.Location = new Point(0, 125);

                TextBox issueNumberEnter = new TextBox();
                issueNumberEnter.Name = "issueNumberEnter";
                sourceInfoPanel.Controls.Add(issueNumberEnter);
                issueNumberEnter.Location = new Point(109, 125);
                issueNumberEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 150);

                TextBox retrievedFromEnter = new TextBox();
                retrievedFromEnter.Name = "retrievedFromEnter";
                sourceInfoPanel.Controls.Add(retrievedFromEnter);
                retrievedFromEnter.Location = new Point(109, 150);
                retrievedFromEnter.Width = 150;

                Label doiLabel = new Label();
                doiLabel.Text = "DOI:";
                sourceInfoPanel.Controls.Add(doiLabel);
                doiLabel.Location = new Point(0, 175);

                TextBox doiEnter = new TextBox();
                doiEnter.Name = "doiEnter";
                sourceInfoPanel.Controls.Add(doiEnter);
                doiEnter.Location = new Point(109, 175);
                doiEnter.Width = 150;
            }
            else if (onlineNewspaper.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(5) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(5);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(5) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(5) + 299);
                }
                sourceInfoGroupBox.Tag = "1,4";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Date of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Article Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label newspaperNameLabel = new Label();
                newspaperNameLabel.Text = "Newspaper Name:";
                sourceInfoPanel.Controls.Add(newspaperNameLabel);
                newspaperNameLabel.Location = new Point(0, 75);

                TextBox newspaperNameEnter = new TextBox();
                newspaperNameEnter.Name = "newspaperNameEnter";
                sourceInfoPanel.Controls.Add(newspaperNameEnter);
                newspaperNameEnter.Location = new Point(109, 75);
                newspaperNameEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 100);

                TextBox retrieveFromEnter = new TextBox();
                retrieveFromEnter.Name = "retrieveFromEnter";
                sourceInfoPanel.Controls.Add(retrieveFromEnter);
                retrieveFromEnter.Location = new Point(109, 100);
                retrieveFromEnter.Width = 150;
            }
            else if (electronicBook.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(4) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(4);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(4) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(4) + 299);
                }
                sourceInfoGroupBox.Tag = "1,4";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Date of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Book Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;
                
                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 75);

                TextBox retrieveFromEnter = new TextBox();
                retrieveFromEnter.Name = "retrieveFromEnter";
                sourceInfoPanel.Controls.Add(retrieveFromEnter);
                retrieveFromEnter.Location = new Point(109, 75);
                retrieveFromEnter.Width = 150;
            }
            else if (kindle.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(3) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(3);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(3) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(3) + 299);
                }
                sourceInfoGroupBox.Tag = "1,3";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Date of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Book Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;
            }
            else if (onlineBibliography.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(4) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(4);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(4) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(4) + 299);
                }
                sourceInfoGroupBox.Tag = "1,4";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Date of Publication:";
                sourceInfoPanel.Controls.Add(publishDateLabel);
                publishDateLabel.Location = new Point(0, 25);

                TextBox publishDateEnter = new TextBox();
                publishDateEnter.Name = "publishDateEnter";
                sourceInfoPanel.Controls.Add(publishDateEnter);
                publishDateEnter.Location = new Point(109, 25);
                publishDateEnter.Width = 150;

                Label bookTitleLabel = new Label();
                bookTitleLabel.Text = "Book Title:";
                sourceInfoPanel.Controls.Add(bookTitleLabel);
                bookTitleLabel.Location = new Point(0, 50);

                TextBox titleEnter = new TextBox();
                titleEnter.Name = "titleEnter";
                sourceInfoPanel.Controls.Add(titleEnter);
                titleEnter.Location = new Point(109, 50);
                titleEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 75);

                TextBox retrieveFromEnter = new TextBox();
                retrieveFromEnter.Name = "retrieveFromEnter";
                sourceInfoPanel.Controls.Add(retrieveFromEnter);
                retrieveFromEnter.Location = new Point(109, 75);
                retrieveFromEnter.Width = 150;
            }
            else if (onlineInterview.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(5) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(5);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(5) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(5) + 299);
                }
                sourceInfoGroupBox.Tag = "1,5,1";

                Label interviewerLabel = new Label();
                interviewerLabel.Text = "Interviewer:";
                sourceInfoPanel.Controls.Add(interviewerLabel);
                interviewerLabel.Location = new Point(0, 0);

                TextBox interviewerFirstEnter = new TextBox();
                interviewerFirstEnter.Name = "interviewerFirstEnter1";
                sourceInfoPanel.Controls.Add(interviewerFirstEnter);
                interviewerFirstEnter.Location = new Point(109, 0);
                interviewerFirstEnter.Width = 100;

                TextBox interviewerMiddleEnter = new TextBox();
                interviewerMiddleEnter.Name = "interviewerMiddleEnter1";
                sourceInfoPanel.Controls.Add(interviewerMiddleEnter);
                interviewerMiddleEnter.Location = new Point(224, 0);
                interviewerMiddleEnter.Width = 100;

                TextBox interviewerLastEnter = new TextBox();
                interviewerLastEnter.Name = "interviewerLastEnter1";
                sourceInfoPanel.Controls.Add(interviewerLastEnter);
                interviewerLastEnter.Location = new Point(339, 0);
                interviewerLastEnter.Width = 100;

                Button interviewerAdder = new Button();
                interviewerAdder.Name = "interviewerAdderButton";
                interviewerAdder.Text = "Add an Interviewer";
                interviewerAdder.Width = 150;
                sourceInfoPanel.Controls.Add(interviewerAdder);
                interviewerAdder.Location = new Point(459, 0);
                interviewerAdder.Click += new EventHandler(interviewerAdderButton_Click);

                Label intervieweeLabel = new Label();
                intervieweeLabel.Text = "Interviewee:";
                sourceInfoPanel.Controls.Add(intervieweeLabel);
                intervieweeLabel.Location = new Point(0, 25);

                TextBox intervieweeFirstEnter = new TextBox();
                intervieweeFirstEnter.Name = "intervieweeFirstEnter1";
                sourceInfoPanel.Controls.Add(intervieweeFirstEnter);
                intervieweeFirstEnter.Location = new Point(109, 25);
                intervieweeFirstEnter.Width = 100;

                TextBox intervieweeMiddleEnter = new TextBox();
                intervieweeMiddleEnter.Name = "intervieweeMiddleEnter1";
                sourceInfoPanel.Controls.Add(intervieweeMiddleEnter);
                intervieweeMiddleEnter.Location = new Point(224, 25);
                intervieweeMiddleEnter.Width = 100;

                TextBox intervieweeLastEnter = new TextBox();
                intervieweeLastEnter.Name = "intervieweeLastEnter1";
                sourceInfoPanel.Controls.Add(intervieweeLastEnter);
                intervieweeLastEnter.Location = new Point(339, 25);
                intervieweeLastEnter.Width = 100;

                Button intervieweeAdder = new Button();
                intervieweeAdder.Name = "intervieweeAdderButton";
                intervieweeAdder.Text = "Add an Interviewee";
                intervieweeAdder.Width = 150;
                sourceInfoPanel.Controls.Add(intervieweeAdder);
                intervieweeAdder.Location = new Point(459, 25);
                intervieweeAdder.Click += new EventHandler(intervieweeAdderButton_Click);

                Label interviewDateLabel = new Label();
                interviewDateLabel.Text = "Date of Interview:";
                sourceInfoPanel.Controls.Add(interviewDateLabel);
                interviewDateLabel.Location = new Point(0, 50);

                TextBox interviewDateEnter = new TextBox();
                interviewDateEnter.Name = "interviewDateEnter";
                sourceInfoPanel.Controls.Add(interviewDateEnter);
                interviewDateEnter.Location = new Point(109, 50);
                interviewDateEnter.Width = 150;

                Label interviewTitleLabel = new Label();
                interviewTitleLabel.Text = "Interview Title:";
                sourceInfoPanel.Controls.Add(interviewTitleLabel);
                interviewTitleLabel.Location = new Point(0, 75);

                TextBox interviewTitleEnter = new TextBox();
                interviewTitleEnter.Name = "interviewTitleEnter";
                sourceInfoPanel.Controls.Add(interviewTitleEnter);
                interviewTitleEnter.Location = new Point(109, 75);
                interviewTitleEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 100);

                TextBox retrieveFromEnter = new TextBox();
                retrieveFromEnter.Name = "retrieveFromEnter";
                sourceInfoPanel.Controls.Add(retrieveFromEnter);
                retrieveFromEnter.Location = new Point(109, 100);
                retrieveFromEnter.Width = 150;
            }
            else if (onlineEncyclopedia.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(4) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(4);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(4) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(4) + 299);
                }
                sourceInfoGroupBox.Tag = "1,4";

                Label sectionNameLabel = new Label();
                sectionNameLabel.Text = "Section or Word Referenced:";
                sourceInfoPanel.Controls.Add(sectionNameLabel);
                sectionNameLabel.Location = new Point(0, 0);
                sectionNameLabel.Width = 180;

                TextBox sectionNameEnter = new TextBox();
                sectionNameEnter.Name = "sectionNameEnter";
                sourceInfoPanel.Controls.Add(sectionNameEnter);
                sectionNameEnter.Location = new Point(180, 0);
                sectionNameEnter.Width = 150;

                Label publicationDateLabel = new Label();
                publicationDateLabel.Text = "Publication Date:";
                sourceInfoPanel.Controls.Add(publicationDateLabel);
                publicationDateLabel.Location = new Point(0, 25);
                publicationDateLabel.Width = 180;

                TextBox publicationDateEnter = new TextBox();
                publicationDateEnter.Name = "publicationDateEnter";
                sourceInfoPanel.Controls.Add(publicationDateEnter);
                publicationDateEnter.Location = new Point(180, 25);
                publicationDateEnter.Width = 150;

                Label nameLabel = new Label();
                nameLabel.Text = "Name of Encyclopedia/Dictionary:";
                sourceInfoPanel.Controls.Add(nameLabel);
                nameLabel.Location = new Point(0, 50);

                TextBox nameEnter = new TextBox();
                nameEnter.Name = "nameEnter";
                sourceInfoPanel.Controls.Add(nameEnter);
                nameEnter.Location = new Point(180, 50);
                nameEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 75);

                TextBox retrievedFromEnter = new TextBox();
                retrievedFromEnter.Name = "retrievedFromEnter";
                sourceInfoPanel.Controls.Add(retrievedFromEnter);
                retrievedFromEnter.Location = new Point(180, 75);
                retrievedFromEnter.Width = 150;
            }
            else if (forumDiscussion.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(5) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(5);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(5) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(5) + 299);
                }
                sourceInfoGroupBox.Tag = "1,5,1";

                Label posterLabel = new Label();
                posterLabel.Text = "Person Posting:";
                sourceInfoPanel.Controls.Add(posterLabel);
                posterLabel.Location = new Point(0, 0);

                TextBox posterFirstEnter = new TextBox();
                posterFirstEnter.Name = "posterFirstEnter";
                sourceInfoPanel.Controls.Add(posterFirstEnter);
                posterFirstEnter.Location = new Point(109, 0);
                posterFirstEnter.Width = 100;

                TextBox posterMiddleEnter = new TextBox();
                posterMiddleEnter.Name = "posterMiddleEnter";
                sourceInfoPanel.Controls.Add(posterMiddleEnter);
                posterMiddleEnter.Location = new Point(224, 0);
                posterMiddleEnter.Width = 100;

                TextBox posterLastEnter = new TextBox();
                posterLastEnter.Name = "posterLastEnter";
                sourceInfoPanel.Controls.Add(posterLastEnter);
                posterLastEnter.Location = new Point(339, 0);
                posterLastEnter.Width = 100;

                Label postDateLabel = new Label();
                postDateLabel.Text = "Date Posted:";
                sourceInfoPanel.Controls.Add(postDateLabel);
                postDateLabel.Location = new Point(0, 25);

                TextBox postDateEnter = new TextBox();
                postDateEnter.Name = "postDateEnter";
                sourceInfoPanel.Controls.Add(postDateEnter);
                postDateEnter.Location = new Point(109, 25);
                postDateEnter.Width = 150;

                Label messageTitleLabel = new Label();
                messageTitleLabel.Text = "Message Title:";
                sourceInfoPanel.Controls.Add(messageTitleLabel);
                messageTitleLabel.Location = new Point(0, 50);

                TextBox messageTitleEnter = new TextBox();
                messageTitleEnter.Name = "messageTitleEnter";
                sourceInfoPanel.Controls.Add(messageTitleEnter);
                messageTitleEnter.Location = new Point(109, 50);
                messageTitleEnter.Width = 150;

                Label messageNumberLabel = new Label();
                messageNumberLabel.Text = "Message Number:";
                sourceInfoPanel.Controls.Add(messageNumberLabel);
                messageNumberLabel.Location = new Point(0, 75);

                TextBox messageNumberEnter = new TextBox();
                messageNumberEnter.Name = "messageNumberEnter";
                sourceInfoPanel.Controls.Add(messageNumberEnter);
                messageNumberEnter.Location = new Point(109, 75);
                messageNumberEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 100);

                TextBox retrieveFromEnter = new TextBox();
                retrieveFromEnter.Name = "retrieveFromEnter";
                sourceInfoPanel.Controls.Add(retrieveFromEnter);
                retrieveFromEnter.Location = new Point(109, 100);
                retrieveFromEnter.Width = 150;
            }
            else if (bookReview.Checked)
            {
                removeInsideInfo();

                if (getSourceInfoHeight(10) > 135)
                {
                    sourceInfoPanel.Height = 135;
                    sourceInfoGroupBox.Height = 160;
                    sourceInfoPanel.AutoScroll = true;

                    moveTo("quoteContentGroupBox", 434);
                }
                else
                {
                    sourceInfoPanel.Height = getSourceInfoHeight(10);
                    sourceInfoGroupBox.Height = getSourceInfoHeight(10) + 25;
                    sourceInfoPanel.VerticalScroll.Value = 0;
                    sourceInfoPanel.AutoScroll = false;

                    moveTo("quoteContentGroupBox", getSourceInfoHeight(10) + 299);
                }
                sourceInfoGroupBox.Tag = "1,9";

                Label authorLabel = new Label();
                authorLabel.Text = "Author:";
                sourceInfoPanel.Controls.Add(authorLabel);
                authorLabel.Location = new Point(0, 0);

                TextBox authorFirstEnter = new TextBox();
                authorFirstEnter.Name = "authorFirstEnter1";
                sourceInfoPanel.Controls.Add(authorFirstEnter);
                authorFirstEnter.Location = new Point(109, 0);
                authorFirstEnter.Width = 100;

                TextBox authorMiddleEnter = new TextBox();
                authorMiddleEnter.Name = "authorMiddleEnter1";
                sourceInfoPanel.Controls.Add(authorMiddleEnter);
                authorMiddleEnter.Location = new Point(224, 0);
                authorMiddleEnter.Width = 100;

                TextBox authorLastEnter = new TextBox();
                authorLastEnter.Name = "authorLastEnter1";
                sourceInfoPanel.Controls.Add(authorLastEnter);
                authorLastEnter.Location = new Point(339, 0);
                authorLastEnter.Width = 100;

                Button authorAdder = new Button();
                authorAdder.Name = "authorAdderButton";
                authorAdder.Text = "Add an Author";
                authorAdder.Width = 100;
                sourceInfoPanel.Controls.Add(authorAdder);
                authorAdder.Location = new Point(459, 0);
                authorAdder.Click += new EventHandler(authorAdderButton_Click);

                Label publicationDateLabel = new Label();
                publicationDateLabel.Text = "Date of Publication:";
                sourceInfoPanel.Controls.Add(publicationDateLabel);
                publicationDateLabel.Location = new Point(0, 25);

                TextBox publicationDateEnter = new TextBox();
                publicationDateEnter.Name = "publicationDateEnter";
                sourceInfoPanel.Controls.Add(publicationDateEnter);
                publicationDateEnter.Location = new Point(109, 25);
                publicationDateEnter.Width = 150;

                Label reviewTitleLabel = new Label();
                reviewTitleLabel.Text = "Review Title:";
                sourceInfoPanel.Controls.Add(reviewTitleLabel);
                reviewTitleLabel.Location = new Point(0, 50);
                reviewTitleLabel.Width = 109;

                TextBox reviewTitleEnter = new TextBox();
                reviewTitleEnter.Name = "reviewTitleEnter";
                sourceInfoPanel.Controls.Add(reviewTitleEnter);
                reviewTitleEnter.Location = new Point(109, 50);
                reviewTitleEnter.Width = 150;

                Label reviewedLabel = new Label();
                reviewedLabel.Text = "Title Being Reviewed:";
                sourceInfoPanel.Controls.Add(reviewedLabel);
                reviewedLabel.Location = new Point(0, 75);
                reviewedLabel.Width = 109;

                TextBox reviewedEnter = new TextBox();
                reviewedEnter.Name = "reviewedEnter";
                sourceInfoPanel.Controls.Add(reviewedEnter);
                reviewedEnter.Location = new Point(109, 75);
                reviewedEnter.Width = 150;

                Label sourceReviewingLabel = new Label();
                sourceReviewingLabel.Text = "Source of Review:";
                sourceInfoPanel.Controls.Add(sourceReviewingLabel);
                sourceReviewingLabel.Location = new Point(0, 100);
                sourceReviewingLabel.Width = 109;

                TextBox sourceReviewingEnter = new TextBox();
                sourceReviewingEnter.Name = "sourceReviewingEnter";
                sourceInfoPanel.Controls.Add(sourceReviewingEnter);
                sourceReviewingEnter.Location = new Point(109, 100);
                sourceReviewingEnter.Width = 150;

                Label volumeLabel = new Label();
                volumeLabel.Text = "Volume:";
                sourceInfoPanel.Controls.Add(volumeLabel);
                volumeLabel.Location = new Point(0, 125);

                TextBox volumeEnter = new TextBox();
                volumeEnter.Name = "volumeEnter";
                sourceInfoPanel.Controls.Add(volumeEnter);
                volumeEnter.Location = new Point(109, 125);
                volumeEnter.Width = 150;

                Label issueLabel = new Label();
                issueLabel.Text = "Issue:";
                sourceInfoPanel.Controls.Add(issueLabel);
                issueLabel.Location = new Point(0, 150);

                TextBox issueEnter = new TextBox();
                issueEnter.Name = "issueEnter";
                sourceInfoPanel.Controls.Add(issueEnter);
                issueEnter.Location = new Point(109, 150);
                issueEnter.Width = 150;

                Label pageStartLabel = new Label();
                pageStartLabel.Text = "Start Page:";
                sourceInfoPanel.Controls.Add(pageStartLabel);
                pageStartLabel.Location = new Point(0, 175);

                TextBox pageStartEnter = new TextBox();
                pageStartEnter.Name = "pageStartEnter";
                sourceInfoPanel.Controls.Add(pageStartEnter);
                pageStartEnter.Location = new Point(109, 175);
                pageStartEnter.Width = 150;

                Label pageEndLabel = new Label();
                pageEndLabel.Text = "End Page:";
                sourceInfoPanel.Controls.Add(pageEndLabel);
                pageEndLabel.Location = new Point(0, 200);

                TextBox pageEndEnter = new TextBox();
                pageEndEnter.Name = "pageEndEnter";
                sourceInfoPanel.Controls.Add(pageEndEnter);
                pageEndEnter.Location = new Point(109, 200);
                pageEndEnter.Width = 150;

                Label retrievedFromLabel = new Label();
                retrievedFromLabel.Text = "Retrieved From:";
                sourceInfoPanel.Controls.Add(retrievedFromLabel);
                retrievedFromLabel.Location = new Point(0, 225);
                retrievedFromLabel.Width = 109;

                TextBox retrievedFromEnter = new TextBox();
                retrievedFromEnter.Name = "retrievedFromEnter";
                sourceInfoPanel.Controls.Add(retrievedFromEnter);
                retrievedFromEnter.Location = new Point(109, 225);
                retrievedFromEnter.Width = 150;
            }
            else if (blog.Checked)
            {
                removeInsideInfo();

            }
            else if (wiki.Checked)
            {
                removeInsideInfo();

            }
            else if (webDoc.Checked)
            {
                removeInsideInfo();

            }
            else if (onlineDissertation.Checked)
            {
                removeInsideInfo();

            }
            else if (publishedDissertation.Checked)
            {
                removeInsideInfo();

            }
            else if (unpublishedDissertation.Checked)
            {
                removeInsideInfo();

            } 
            else if (privateOrgReport.Checked)
            {
                removeInsideInfo();

            }
            else if (governmentDocument.Checked)
            {
                removeInsideInfo();

            }
            else if (review.Checked)
            {
                removeInsideInfo();

            }
            else if (lectureNotesSlides.Checked)
            {
                removeInsideInfo();

            }
            else if (audioPodcast.Checked)
            {
                removeInsideInfo();

            }
            else if (videoPodcast.Checked)
            {
                removeInsideInfo();

            }
            else if (motionPicture.Checked)
            {
                removeInsideInfo();

            }
            else if (tvBroadcast.Checked)
            {
                removeInsideInfo();

            }
            else if (tvEpisode.Checked)
            {
                removeInsideInfo();

            }
            else if (music.Checked)
            {
                removeInsideInfo();

            }
            else if (interview.Checked)
            {
                removeInsideInfo();

            }
            else if (email.Checked)
            {
                removeInsideInfo();

            }
            else if (personal.Checked)
            {
                removeInsideInfo();

            }
            else if (letterToEditor.Checked)
            {
                removeInsideInfo();

            }
            else
            {

            }
        }
    }
}
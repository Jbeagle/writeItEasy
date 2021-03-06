﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WriteMeEasy_WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private void includeSectionLabelsCheck_CheckedChanged(object sender, EventArgs e)
        {
            int numSections = myPaper.sections.Count;
            int sectionMult = numSections * 27;
            int totalSpace = 243 + sectionMult;
            if (includeSectionLabelsCheck.Checked)
            {
                for (int i = 1; i <= numSections; i++)
                {
                    Label sectionLabelLabel = (Label)Controls.Find("section" + i + "LabelLabel", true)[0];
                    sectionLabelLabel.Enabled = true;
                    TextBox sectionLabelEnter = (TextBox)Controls.Find("section" + i + "LabelEnter", true)[0];
                    sectionLabelEnter.Enabled = true;
                }

                addSpace("sectionsDefaultButton", 243, "sectionsPanel", "SECTIONS");
                sectionLabelGroupBox.Height = 288;
                sectionLabelLocationGroupBox.Visible = true;
                sectionLabelStyleGroupBox.Visible = true;
                sectionLabelAlignChoose.Visible = true;
                sectionLabelAlignLabel.Visible = true;
            }
            else
            {
                for (int i = 1; i <= numSections; i++)
                {
                    Label sectionLabelLabel = (Label)Controls.Find("section" + i + "LabelLabel", true)[0];
                    sectionLabelLabel.Enabled = false;
                    TextBox sectionLabelEnter = (TextBox)Controls.Find("section" + i + "LabelEnter", true)[0];
                    sectionLabelEnter.Enabled = false;
                }

                addSpace("sectionsDefaultButton", -243, "sectionsPanel", "SECTIONS");
                sectionLabelGroupBox.Height = 45;
                sectionLabelLocationGroupBox.Visible = false;
                sectionLabelStyleGroupBox.Visible = false;
                sectionLabelAlignChoose.Visible = false;
                sectionLabelAlignLabel.Visible = false;
            }
            subsectionLabelGroupBox.Location = new Point(9, sectionLabelGroupBox.Location.Y + sectionLabelGroupBox.Height + 13);
            subsubsectionLabelGroupBox.Location = new Point(9, subsectionLabelGroupBox.Location.Y + subsectionLabelGroupBox.Height + 13);
        }

        private void includeSubsectionLabelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (includeSubsectionLabelCheck.Checked)
            {
                addSpace("sectionsDefaultButton", 243, "sectionsPanel", "SECTIONS");
                subsectionLabelGroupBox.Height = 288;
                subsectionLabelLocationGroupBox.Visible = true;
                subsectionLabelStyleGroupBox.Visible = true;
                subsectionLabelAlignChoose.Visible = true;
                subsectionLabelAlignLabel.Visible = true;
                for (int i = 1; i <= myPaper.sections.Count; i++)
                {
                    for (int j = 1; j <= myPaper.sections[i - 1].subSections.Count; j++)
                    {
                        Label subsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "LabelLabel", true)[0];
                        subsectionLabelLabel.Enabled = true;
                        TextBox subsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "LabelEnter", true)[0];
                        subsectionLabelTextBox.Enabled = true;
                    }
                }
            }
            else
            {
                addSpace("sectionsDefaultButton", -243, "sectionsPanel", "SECTIONS");
                subsectionLabelGroupBox.Height = 45;
                subsectionLabelLocationGroupBox.Visible = false;
                subsectionLabelStyleGroupBox.Visible = false;
                subsectionLabelAlignChoose.Visible = false;
                subsectionLabelAlignLabel.Visible = false;
                for (int i = 1; i <= myPaper.sections.Count; i++)
                {
                    for (int j = 1; j <= myPaper.sections[i - 1].subSections.Count; j++)
                    {
                        Label subsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "LabelLabel", true)[0];
                        subsectionLabelLabel.Enabled = false;
                        TextBox subsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "LabelEnter", true)[0];
                        subsectionLabelTextBox.Enabled = false;
                    }
                }
            }
            subsubsectionLabelGroupBox.Location = new Point(9, subsectionLabelGroupBox.Location.Y + subsectionLabelGroupBox.Height + 13);
        }

        private void includeSubsubsectionLabelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (includeSubsubsectionLabelCheck.Checked)
            {
                addSpace("sectionsDefaultButton", 243, "sectionsPanel", "SECTIONS");
                subsubsectionLabelGroupBox.Height = 288;
                subsubsectionLabelLocationGroupBox.Visible = true;
                subsubsectionLabelStyleGroupBox.Visible = true;
                subsubsectionLabelAlignChoose.Visible = true;
                subsubsectionLabelAlignLabel.Visible = true;
                for (int i = 1; i <= myPaper.sections.Count; i++)
                {
                    for (int j = 1; j <= myPaper.sections[i - 1].subSections.Count; j++)
                    {
                        for (int k = 1; k <= myPaper.sections[i - 1].subSections[j - 1].subsubSections.Count; k++)
                        {
                            Label subsubsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelLabel", true)[0];
                            subsubsectionLabelLabel.Enabled = true;
                            TextBox subsubsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelEnter", true)[0];
                            subsubsectionLabelTextBox.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                addSpace("sectionsDefaultButton", -243, "sectionsPanel", "SECTIONS");
                subsubsectionLabelGroupBox.Height = 45;
                subsubsectionLabelLocationGroupBox.Visible = false;
                subsubsectionLabelStyleGroupBox.Visible = false;
                subsubsectionLabelAlignChoose.Visible = false;
                subsubsectionLabelAlignLabel.Visible = false;
                for (int i = 1; i <= myPaper.sections.Count; i++)
                {
                    for (int j = 1; j <= myPaper.sections[i - 1].subSections.Count; j++)
                    {
                        for (int k = 1; k <= myPaper.sections[i - 1].subSections[j - 1].subsubSections.Count; k++)
                        {
                            Label subsubsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelLabel", true)[0];
                            subsubsectionLabelLabel.Enabled = false;
                            TextBox subsubsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelEnter", true)[0];
                            subsubsectionLabelTextBox.Enabled = false;
                        }
                    }
                }
            }
        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            Section newSection = new Section();
            newSection.index = myPaper.sections.Count + 1;
            myPaper.sections.Add(newSection);

            GroupBox newSectionGroupBox = new GroupBox();
            newSectionGroupBox.Name = "section" + newSection.index + "groupBox";
            newSectionGroupBox.Text = "Section " + newSection.index;
            newSectionGroupBox.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Bold);
            contentPanel.Controls.Add(newSectionGroupBox);

            Label newSectionLabelLabel = new Label();
            newSectionLabelLabel.Name = "section" + newSection.index + "LabelLabel";
            newSectionLabelLabel.Text = "Section Label:";

            TextBox newSectionLabelEnter = new TextBox();
            newSectionLabelEnter.Name = "section" + newSection.index + "LabelEnter";
            newSectionLabelEnter.Size = new Size(185, 20);
            newSectionGroupBox.Controls.Add(newSectionLabelEnter);
            newSectionLabelEnter.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            newSectionLabelEnter.Location = new Point(81, 19);

            if (!includeSectionLabelsCheck.Checked)
            {
                newSectionLabelLabel.Enabled = false;
                newSectionLabelEnter.Enabled = false;
            }

            newSectionGroupBox.Controls.Add(newSectionLabelLabel);
            newSectionLabelLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            newSectionLabelLabel.Location = new Point(6, 22);
            newSectionLabelEnter.Tag = newSection.index;
            newSectionLabelEnter.TextChanged += new EventHandler(sectionTitleChanged);

            Label newSectionContentLabel = new Label();
            newSectionContentLabel.Name = "section" + newSection.index + "contentLabel";
            newSectionContentLabel.Text = "Content:";
            newSectionGroupBox.Controls.Add(newSectionContentLabel);
            newSectionContentLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);

            RichTextBox newSectionContent = new RichTextBox();
            newSectionContent.Name = "section" + newSection.index + "Content";
            newSectionGroupBox.Controls.Add(newSectionContent);
            newSectionContent.Location = new Point(9, 70);
            newSectionContent.Tag = newSection.index;
            newSectionContent.Enter += new EventHandler(sectionLast);
            newSectionContent.SelectionIndent = 40;
            newSectionContent.SelectionHangingIndent = -40;
            newSectionContent.Font = new Font("Times New Roman", (float)12, FontStyle.Regular);

            Button newSectionAddSubsectionButton = new Button();
            newSectionAddSubsectionButton.Name = "section" + newSection.index + "AddSubsectionButton";
            newSectionAddSubsectionButton.Text = "Add Subsection";
            newSectionAddSubsectionButton.Size = new Size(130, 23);
            newSectionAddSubsectionButton.UseVisualStyleBackColor = true;
            newSectionGroupBox.Controls.Add(newSectionAddSubsectionButton);
            newSectionGroupBox.Controls.Add(newSectionContentLabel);
            newSectionAddSubsectionButton.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            newSectionAddSubsectionButton.Tag = newSection.index;
            newSectionAddSubsectionButton.Click += new EventHandler(sectionAddSubsectionButton_Click);

            addSpace("addSectionButton", 308, "contentPanel", "CONTENT");            
            newSectionGroupBox.Size = new Size(tableLayoutPanel1.Width - 567, 298);
            newSectionGroupBox.Location = new Point(9, addSectionButton.Location.Y - 311);
            newSectionLabelLabel.Visible = true;
            newSectionLabelEnter.Visible = true;
            newSectionContentLabel.Location = new Point(6, 49);
            newSectionContent.Size = new Size(tableLayoutPanel1.Width - 585, 182);
            newSectionAddSubsectionButton.Location = new Point(9, 260);
        }

        private void sectionAddSubsectionButton_Click(object sender, EventArgs e)
        {
            if (!subsectionLabelGroupBox.Visible)
            {
                if (includeSubsectionLabelCheck.Checked)
                {
                    addSpace("sectionsDefaultButton", 296, "sectionsPanel", "SECTIONS");
                }
                else
                {
                    addSpace("sectionsDefaultButton", 56, "sectionsPanel", "SECTIONS");
                }                
                subsectionLabelGroupBox.Location = new Point(9, sectionLabelGroupBox.Location.Y + sectionLabelGroupBox.Height + 8);
                subsectionLabelGroupBox.Visible = true;
            }
            SubSection subSectionToAdd = new SubSection();

            int sectionIndex = Convert.ToInt32(((Button)sender).Tag);
            int subsectionIndex = 0;
            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    subsectionIndex = section.subSections.Count + 1;
                    subSectionToAdd.index = subsectionIndex;
                    section.subSections.Add(subSectionToAdd);
                }
            }

            GroupBox sectionToAddTo = (GroupBox)Controls.Find("section" + sectionIndex + "groupBox", true)[0];
            Control starter = Controls.Find("section" + sectionIndex + "AddSubsectionButton", true)[0];
            GroupBox subsectionToAdd = new GroupBox();
            subsectionToAdd.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "GroupBox";
            subsectionToAdd.Text = "Subsection " + subsectionIndex;
            sectionToAddTo.Controls.Add(subsectionToAdd);
            subsectionToAdd.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Bold);

            Label subsectionLabelLabel = new Label();
            subsectionLabelLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "LabelLabel";
            subsectionLabelLabel.Text = "Subsection Label:";
            subsectionToAdd.Controls.Add(subsectionLabelLabel);
            subsectionLabelLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsectionLabelLabel.Location = new Point(6, 22);

            TextBox subsectionLabelEnter = new TextBox();
            subsectionLabelEnter.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "LabelEnter";
            subsectionToAdd.Controls.Add(subsectionLabelEnter);
            subsectionLabelEnter.Font = new Font("Times New Roman", (float)12, FontStyle.Regular);
            subsectionLabelEnter.Location = new Point(110, 19);
            subsectionLabelEnter.Width = 185;

            if (!includeSubsectionLabelCheck.Checked)
            {
                subsectionLabelLabel.Enabled = false;
                subsectionLabelEnter.Enabled = false;
            }

            subsectionLabelEnter.Tag = sectionIndex + "," + subsectionIndex;
            subsectionLabelEnter.TextChanged += new EventHandler(subsectionTitleChanged);
            
            RichTextBox subsectionContent = new RichTextBox();
            subsectionContent.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Content";
            subsectionToAdd.Controls.Add(subsectionContent);
            subsectionContent.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsectionContent.Location = new Point(9, 70);
            subsectionContent.Tag = sectionIndex + "," + subsectionIndex;
            subsectionContent.Enter += new EventHandler(subsectionLast);
            subsectionContent.SelectionIndent = 40;
            subsectionContent.SelectionHangingIndent = -40;
            subsectionContent.Font = new Font("Times New Roman", (float)12, FontStyle.Regular);

            Label subsectionContentLabel = new Label();
            subsectionContentLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "ContentLabel";
            subsectionContentLabel.Text = "Content:";
            subsectionToAdd.Controls.Add(subsectionContentLabel);
            subsectionContentLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsectionContentLabel.BackColor = Color.Transparent;

            Button addSubsubsectionButton = new Button();
            addSubsubsectionButton.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "AddSubsubsectionButton";
            addSubsubsectionButton.Text = "Add Subsubsection";
            addSubsubsectionButton.Size = new Size(130, 23);
            addSubsubsectionButton.UseVisualStyleBackColor = true;
            addSubsubsectionButton.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            addSubsubsectionButton.Tag = sectionIndex + "," + subsectionIndex;
            addSubsubsectionButton.Click += new EventHandler(subsectionAddSubsubsectionButton_Click);

            addSpace("section" + sectionIndex + "AddSubsectionButton", 330, "contentPanel", "CONTENT");
            subsectionToAdd.Location = new Point(9, starter.Location.Y - 310);
            subsectionToAdd.Size = new Size(sectionToAddTo.Width - 18, 298);
            subsectionContentLabel.Location = new Point(6, 49);
            subsectionContent.Size = new Size(subsectionToAdd.Width - 18, 182);
            subsectionToAdd.Controls.Add(addSubsubsectionButton);
            addSubsubsectionButton.Location = new Point(9, 272);
        }

        private void subsectionAddSubsubsectionButton_Click(object sender, EventArgs e)
        {
            if (!subsubsectionLabelGroupBox.Visible)
            {
                if (includeSubsubsectionLabelCheck.Checked)
                {
                    addSpace("sectionsDefaultButton", 296, "sectionsPanel", "SECTIONS");
                }
                else
                {
                    addSpace("sectionsDefaultButton", 56, "sectionsPanel", "SECTIONS");
                }
                subsubsectionLabelGroupBox.Location = new Point(9, subsectionLabelGroupBox.Location.Y + subsectionLabelGroupBox.Height + 8);
                subsubsectionLabelGroupBox.Visible = true;
            }
            SubSubSection subsubSectionToAdd = new SubSubSection();

            string tag = (string)((Button)sender).Tag;
            string[] indexes = tag.Split(',');

            int sectionIndex = Convert.ToInt32(indexes[0]);
            int subsectionIndex = Convert.ToInt32(indexes[1]);
            int subsubsectionIndex = 0;
            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    foreach (SubSection subsection in section.subSections)
                    {
                        if (subsection.index == subsectionIndex)
                        {
                            subsubsectionIndex = subsection.subsubSections.Count + 1;
                            subsubSectionToAdd.index = subsubsectionIndex;
                            subsection.subsubSections.Add(subsubSectionToAdd);
                        }
                    }
                }
            }

            GroupBox subsectionToAddTo = (GroupBox)Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "GroupBox", true)[0];
            Control starter = Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "AddSubsubsectionButton", true)[0];
            GroupBox subsubsectionToAdd = new GroupBox();
            subsubsectionToAdd.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "GroupBox";
            subsubsectionToAdd.Text = "Subsubsection " + subsubsectionIndex;
            subsectionToAddTo.Controls.Add(subsubsectionToAdd);
            subsubsectionToAdd.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Bold);

            Label subsubsectionLabelLabel = new Label();
            subsubsectionLabelLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "LabelLabel";
            subsubsectionLabelLabel.Text = "Subsubsection Label:";
            subsubsectionToAdd.Controls.Add(subsubsectionLabelLabel);
            subsubsectionLabelLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsubsectionLabelLabel.Location = new Point(6, 22);
            subsubsectionLabelLabel.Size = new Size(110, 13);

            TextBox subsubsectionLabelEnter = new TextBox();
            subsubsectionLabelEnter.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "LabelEnter";
            subsubsectionToAdd.Controls.Add(subsubsectionLabelEnter);
            subsubsectionLabelEnter.Font = new Font("Times New Roman", (float)12, FontStyle.Regular);
            subsubsectionLabelEnter.Location = new Point(122, 19);
            subsubsectionLabelEnter.Width = 185;

            if (!includeSubsubsectionLabelCheck.Checked)
            {
                subsubsectionLabelLabel.Enabled = false;
                subsubsectionLabelEnter.Enabled = false;
            }

            subsubsectionLabelEnter.Tag = sectionIndex + "," + subsectionIndex + "," + subsubsectionIndex;
            subsubsectionLabelEnter.TextChanged += new EventHandler(subsubsectionTitleChanged);
            
            RichTextBox subsubsectionContent = new RichTextBox();
            subsubsectionContent.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "Content";
            subsubsectionToAdd.Controls.Add(subsubsectionContent);
            subsubsectionContent.Font = new Font("Times New Roman", (float)12, FontStyle.Regular);
            subsubsectionContent.Location = new Point(9, 70);
            subsubsectionContent.Tag = sectionIndex + "," + subsectionIndex + "," + subsubsectionIndex;
            subsubsectionContent.Enter += new EventHandler(subsubsectionLast);
            subsubsectionContent.SelectionIndent = 40;
            subsubsectionContent.SelectionHangingIndent = -40;

            Label subsubsectionContentLabel = new Label();
            subsubsectionContentLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "ContentLabel";
            subsubsectionContentLabel.Text = "Content:";
            subsubsectionToAdd.Controls.Add(subsubsectionContentLabel);
            subsubsectionContentLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsubsectionContentLabel.BackColor = Color.Transparent;

            addSpace("section" + sectionIndex + "Subsection" + subsectionIndex + "AddSubsubsectionButton", 318, "contentPanel", "CONTENT");
            subsubsectionToAdd.Location = new Point(9, starter.Location.Y - 298);
            subsubsectionToAdd.Size = new Size(subsectionToAddTo.Width - 18, 298);
            subsubsectionContentLabel.Location = new Point(6, 49);
            subsubsectionContent.Size = new Size(subsubsectionToAdd.Width - 18, 182);
        }

        private void sectionTextChanged(object sender, EventArgs e)
        {
            int sectionIndex = Convert.ToInt32(((RichTextBox)sender).Tag);
            RichTextBox sectionContent = (RichTextBox)Controls.Find("section" + sectionIndex + "Content", true)[0];

            startSelection = sectionContent.SelectionStart;
            endSelection = sectionContent.SelectionLength + sectionContent.SelectionStart;

            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    bool boldStarted = false;
                    bool italicStarted = false;
                    bool underlineStarted = false;
                    bool indentStarted = false;
                    string formattedSection = "";
                    string currentFont = "";
                    string currentSize = "";
                    for (int i = 0; i < sectionContent.Text.Length; i++)
                    {
                        sectionContent.Select(i, 1);
                        if (sectionContent.SelectionIndent == 40 && sectionContent.SelectionHangingIndent == 0 && !indentStarted)
                        {
                            formattedSection += '\v';
                            indentStarted = true;
                        }
                        else if ((sectionContent.SelectionIndent != 40 || sectionContent.SelectionHangingIndent != 0) && indentStarted)
                        {
                            formattedSection += '\v';
                            indentStarted = false;
                        }
                        if (sectionContent.SelectionFont.Bold && !boldStarted)
                        {
                            formattedSection += '\b';
                            boldStarted = true;
                        }
                        else if (!sectionContent.SelectionFont.Bold && boldStarted)
                        {
                            formattedSection += '\b';
                            boldStarted = false;
                        }
                        if (sectionContent.SelectionFont.Italic && !italicStarted)
                        {
                            formattedSection += '\a';
                            italicStarted = true;
                        }
                        else if (!sectionContent.SelectionFont.Italic && italicStarted)
                        {
                            formattedSection += '\a';
                            italicStarted = false;
                        }
                        if (sectionContent.SelectionFont.Underline && !underlineStarted)
                        {
                            formattedSection += '\f';
                            underlineStarted = true;
                        }
                        else if (!sectionContent.SelectionFont.Underline && underlineStarted)
                        {
                            formattedSection += '\f';
                            underlineStarted = false;
                        }
                        if (!sectionContent.SelectionFont.Name.Equals(currentFont))
                        {
                            currentFont = sectionContent.SelectionFont.Name;
                            formattedSection += "\\ffffffffff\\" + currentFont + "\\ffffffffffff\\";
                        }
                        if (!sectionContent.SelectionFont.Size.ToString().Equals(currentSize))
                        {
                            currentSize = sectionContent.SelectionFont.Size.ToString();
                            formattedSection += "\\ssssssssss\\" + currentSize + "\\ssssssssssss\\";
                        }
                        if (sectionContent.SelectedText.Equals('\n'.ToString()))
                        {
                            if (boldStarted)
                            {
                                formattedSection += '\b';
                            }
                            if (italicStarted)
                            {
                                formattedSection += '\a';
                            }
                            if (underlineStarted)
                            {
                                formattedSection += '\f';
                            }
                            if (indentStarted)
                            {
                                formattedSection += '\v';
                            }
                            indentStarted = false;
                            boldStarted = false;
                            italicStarted = false;
                            underlineStarted = false;
                        }
                        formattedSection += sectionContent.Text[i];
                        if (sectionContent.SelectedText.Equals('\n'.ToString()))
                        {
                            formattedSection += "\\ffffffffff\\" + sectionContent.SelectionFont.Name + "\\ffffffffffff\\";
                            formattedSection += "\\ssssssssss\\" + sectionContent.SelectionFont.Size.ToString() + "\\ssssssssssss\\";
                        }
                    }
                    section.content = formattedSection;
                }
            }
        }

        private void sectionTitleChanged(object sender, EventArgs e)
        {
            int sectionIndex = Convert.ToInt32(((TextBox)sender).Tag);

            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    TextBox titleText = (TextBox)Controls.Find("section" + sectionIndex + "LabelEnter", true)[0];
                    section.title = titleText.Text;
                }
            }
        }

        private void subsectionTitleChanged(object sender, EventArgs e)
        {
            string tagText = ((TextBox)sender).Tag.ToString();
            string[] tags = tagText.Split(',');
            int sectionIndex = Convert.ToInt32(tags[0]);
            int subsectionIndex = Convert.ToInt32(tags[1]);

            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    foreach (SubSection subsection in section.subSections)
                    {
                        if (subsection.index == subsectionIndex)
                        {
                            TextBox titleText = (TextBox)Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "LabelEnter", true)[0];
                            subsection.title = titleText.Text;
                        }
                    }                    
                }
            }
        }

        private void subsubsectionTitleChanged(object sender, EventArgs e)
        {
            string tagText = ((TextBox)sender).Tag.ToString();
            string[] tags = tagText.Split(',');
            int sectionIndex = Convert.ToInt32(tags[0]);
            int subsectionIndex = Convert.ToInt32(tags[1]);
            int subsubsectionIndex = Convert.ToInt32(tags[2]);

            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    foreach (SubSection subsection in section.subSections)
                    {
                        if (subsection.index == subsectionIndex)
                        {
                            foreach (SubSubSection subsubsection in subsection.subsubSections)
                            {
                                if (subsubsection.index == subsubsectionIndex)
                                {
                                    TextBox titleText = (TextBox)Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "LabelEnter", true)[0];
                                    subsubsection.title = titleText.Text;
                                }
                            }                                
                        }
                    }
                }
            }
        }

        private void subsectionTextChanged(object sender, EventArgs e)
        {
            string tag = (string)((RichTextBox)sender).Tag;
            string[] indexes = tag.Split(',');
            int sectionIndex = Convert.ToInt32(indexes[0]);
            int subsectionIndex = Convert.ToInt32(indexes[1]);
            RichTextBox subsectionContent = (RichTextBox)Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "Content", true)[0];

            //startSelection = subsectionContent.SelectionStart;
            //endSelection = subsectionContent.SelectionLength + subsectionContent.SelectionStart;

            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    foreach (SubSection subsection in section.subSections)
                    {
                        if (subsection.index == subsectionIndex)
                        {
                            bool boldStarted = false;
                            bool italicStarted = false;
                            bool underlineStarted = false;
                            bool indentStarted = false;
                            string formattedSubsection = "";
                            string currentFont = "";
                            string currentSize = "";
                            for (int i = 0; i < subsectionContent.Text.Length; i++)
                            {
                                subsectionContent.Select(i, 1);
                                if (subsectionContent.SelectionIndent == 40 && subsectionContent.SelectionHangingIndent == 0 && !indentStarted)
                                {
                                    formattedSubsection += '\v';
                                    indentStarted = true;
                                }
                                else if ((subsectionContent.SelectionIndent != 40 || subsectionContent.SelectionHangingIndent != 0) && indentStarted)
                                {
                                    formattedSubsection += '\v';
                                    indentStarted = false;
                                }
                                if (subsectionContent.SelectionFont.Bold && !boldStarted)
                                {
                                    formattedSubsection += '\b';
                                    boldStarted = true;
                                }
                                else if (!subsectionContent.SelectionFont.Bold && boldStarted)
                                {
                                    formattedSubsection += '\b';
                                    boldStarted = false;
                                }
                                if (subsectionContent.SelectionFont.Italic && !italicStarted)
                                {
                                    formattedSubsection += '\a';
                                    italicStarted = true;
                                }
                                else if (!subsectionContent.SelectionFont.Italic && italicStarted)
                                {
                                    formattedSubsection += '\a';
                                    italicStarted = false;
                                }
                                if (subsectionContent.SelectionFont.Underline && !underlineStarted)
                                {
                                    formattedSubsection += '\f';
                                    underlineStarted = true;
                                }
                                else if (!subsectionContent.SelectionFont.Underline && underlineStarted)
                                {
                                    formattedSubsection += '\f';
                                    underlineStarted = false;
                                }
                                if (!subsectionContent.SelectionFont.Name.Equals(currentFont))
                                {
                                    currentFont = subsectionContent.SelectionFont.Name;
                                    formattedSubsection += "\\ffffffffff\\" + currentFont + "\\ffffffffffff\\";
                                }
                                if (!subsectionContent.SelectionFont.Size.ToString().Equals(currentSize))
                                {
                                    currentSize = subsectionContent.SelectionFont.Size.ToString();
                                    formattedSubsection += "\\ssssssssss\\" + currentSize + "\\ssssssssssss\\";
                                }
                                if (subsectionContent.SelectedText.Equals('\n'.ToString()))
                                {
                                    if (boldStarted)
                                    {
                                        formattedSubsection += '\b';
                                    }
                                    if (italicStarted)
                                    {
                                        formattedSubsection += '\a';
                                    }
                                    if (underlineStarted)
                                    {
                                        formattedSubsection += '\f';
                                    }
                                    if (indentStarted)
                                    {
                                        formattedSubsection += '\v';
                                    }
                                    indentStarted = false;
                                    boldStarted = false;
                                    italicStarted = false;
                                    underlineStarted = false;
                                }
                                formattedSubsection += subsectionContent.Text[i];
                                if (subsectionContent.SelectedText.Equals('\n'.ToString()))
                                {
                                    formattedSubsection += "\\ffffffffff\\" + subsectionContent.SelectionFont.Name + "\\ffffffffffff\\";
                                    formattedSubsection += "\\ssssssssss\\" + subsectionContent.SelectionFont.Size.ToString() + "\\ssssssssssss\\";
                                }
                            }
                            subsection.content = formattedSubsection;
                        }
                    }
                }
            }
        }

        private void subsubsectionTextChanged(object sender, EventArgs e)
        {
            string tag = (string)((RichTextBox)sender).Tag;
            string[] indexes = tag.Split(',');
            int sectionIndex = Convert.ToInt32(indexes[0]);
            int subsectionIndex = Convert.ToInt32(indexes[1]);
            int subsubsectionIndex = Convert.ToInt32(indexes[2]);
            RichTextBox subsubsectionContent = (RichTextBox)Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "Content", true)[0];

            //startSelection = subsubsectionContent.SelectionStart;
            //endSelection = subsubsectionContent.SelectionLength + subsubsectionContent.SelectionStart;

            foreach (Section section in myPaper.sections)
            {
                if (section.index == sectionIndex)
                {
                    foreach (SubSection subsection in section.subSections)
                    {
                        if (subsection.index == subsectionIndex)
                        {
                            foreach (SubSubSection subsubsection in subsection.subsubSections)
                            {
                                if (subsubsection.index == subsubsectionIndex)
                                {
                                    bool boldStarted = false;
                                    bool italicStarted = false;
                                    bool underlineStarted = false;
                                    bool indentStarted = false;
                                    string formattedSubsubsection = "";
                                    string currentFont = "";
                                    string currentSize = "";
                                    for (int i = 0; i < subsubsectionContent.Text.Length; i++)
                                    {
                                        subsubsectionContent.Select(i, 1);
                                        if (subsubsectionContent.SelectionIndent == 40 && subsubsectionContent.SelectionHangingIndent == 0 && !indentStarted)
                                        {
                                            formattedSubsubsection += '\v';
                                            indentStarted = true;
                                        }
                                        else if ((subsubsectionContent.SelectionIndent != 40 || subsubsectionContent.SelectionHangingIndent == 0) && indentStarted)
                                        {
                                            formattedSubsubsection += '\v';
                                            indentStarted = false;
                                        }
                                        if (subsubsectionContent.SelectionFont.Bold && !boldStarted)
                                        {
                                            formattedSubsubsection += '\b';
                                            boldStarted = true;
                                        }
                                        else if (!subsubsectionContent.SelectionFont.Bold && boldStarted)
                                        {
                                            formattedSubsubsection += '\b';
                                            boldStarted = false;
                                        }
                                        if (subsubsectionContent.SelectionFont.Italic && !italicStarted)
                                        {
                                            formattedSubsubsection += '\a';
                                            italicStarted = true;
                                        }
                                        else if (!subsubsectionContent.SelectionFont.Italic && italicStarted)
                                        {
                                            formattedSubsubsection += '\a';
                                            italicStarted = false;
                                        }
                                        if (subsubsectionContent.SelectionFont.Underline && !underlineStarted)
                                        {
                                            formattedSubsubsection += '\f';
                                            underlineStarted = true;
                                        }
                                        else if (!subsubsectionContent.SelectionFont.Underline && underlineStarted)
                                        {
                                            formattedSubsubsection += '\f';
                                            underlineStarted = false;
                                        }
                                        if (!subsubsectionContent.SelectionFont.Name.Equals(currentFont))
                                        {
                                            currentFont = subsubsectionContent.SelectionFont.Name;
                                            formattedSubsubsection += "\\ffffffffff\\" + currentFont + "\\ffffffffffff\\";
                                        }
                                        if (!subsubsectionContent.SelectionFont.Size.ToString().Equals(currentSize))
                                        {
                                            currentSize = subsubsectionContent.SelectionFont.Size.ToString();
                                            formattedSubsubsection += "\\ssssssssss\\" + currentSize + "\\ssssssssssss\\";
                                        }
                                        if (subsubsectionContent.SelectedText.Equals('\n'.ToString()))
                                        {
                                            if (boldStarted)
                                            {
                                                formattedSubsubsection += '\b';
                                            }
                                            if (italicStarted)
                                            {
                                                formattedSubsubsection += '\a';
                                            }
                                            if (underlineStarted)
                                            {
                                                formattedSubsubsection += '\f';
                                            }
                                            if (indentStarted)
                                            {
                                                formattedSubsubsection += '\v';
                                            }
                                            indentStarted = false;
                                            boldStarted = false;
                                            italicStarted = false;
                                            underlineStarted = false;
                                        }
                                        formattedSubsubsection += subsubsectionContent.Text[i];
                                        if (subsubsectionContent.SelectedText.Equals('\n'.ToString()))
                                        {
                                            formattedSubsubsection += "\\ffffffffff\\" + subsubsectionContent.SelectionFont.Name + "\\ffffffffffff\\";
                                            formattedSubsubsection += "\\ssssssssss\\" + subsubsectionContent.SelectionFont.Size.ToString() + "\\ssssssssssss\\";
                                        }
                                    }
                                    subsubsection.content = formattedSubsubsection;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

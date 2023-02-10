/*
 * Project Name:            Random Quote Generator
 * Solution Name:           Random Quote Generator
 * Original creation date:  18/06/2006
 * Edit date:               18/01/2013
 * Programmer name:         Jamie Taylor (aka "GaProgMan")
 * File name:               Form1.cs
 * 
 * Purpose of the project:
 *
 *	This is a peice of hobby code written after I had the
 *	idea of creating a random quote generator.
 *		The basic idea came to me after watching way
 *	too many TV shows and films and wanting to impress my
 *	friends with random quotes taken from those shows.
 *		Originally designed to load a text file called
 *	"Quotes.txt" into memory, then randomly picking out a
 *	line (all individual quotes are stored on a single line
 *	of the file) into "lines" and displaying it in the text
 *	box "QuoteLabel".
 *		When the user presses the button labelled
 *	"Generate", the	program then chooses another random
 *	quote and displays it in the text box.
 *
 *	GNU Copyright information
 *	Copyright 2011 Jamie Taylor <jamie@taylorj.org.uk>
 *
 *	This program is free software; you can redistribute
 *	it and/or modify it under the terms of the GNU General
 *	Public License as published by the Free Software
 *	Foundation; either version 2 of the License, or (at
 *	your option) any later version.
 *
 *	This program is distributed in the hope that it will
 *	be useful, but WITHOUT ANY WARRANTY; without even the
 *	implied warranty of MERCHANTABILITY or FITNESS FOR A
 *	PARTICULAR PURPOSE.  See the GNU General Public
 *	License for more details.
 *
 *	You should have received a copy of the GNU General
 *	Public License along with this program; if not, write
 *	to the Free Software Foundation, Inc., 51 Franklin
 *	Street, Fifth Floor, Boston, MA 02110-1301, USA.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RandomQuotes
{
  public partial class Form1 : Form
  {
    public int randIndex;
    public int lineCount;
    public string[] quotes;
    public Random rand;
    
    public Form1()
    {
      InitializeComponent();
      System.Reflection.Assembly myAssembly =
          System.Reflection.Assembly.GetExecutingAssembly();
      //Load the picture of Abe Hiroshi as Ueda Jiro into memory
      Stream mainMenuPic = myAssembly.GetManifestResourceStream
          ("RandomQuotes.Dontokoi!.jpg");
      Bitmap mainMenuBitmap = new Bitmap(mainMenuPic);
      //Draw the picture of Ueda Jiro inside the mainMenuPictureBox
      mainMenuPictureBox.Image = mainMenuBitmap;

      //Load the txt file "Quotes.txt" into the array "quotes"
      StreamReader sr = File.OpenText("quotes.txt");
      lineCount = File.ReadAllLines("quotes.txt").Length;
      quotes = new string[lineCount];

      for (int i = 0; i &lt; lineCount; i++)
      {
      	quotes[i] = sr.ReadLine();
      }
      
      sr.Close();

      //Generate a random number between 0 and the length of the
      //text file and use that to pick a quote to display.
      rand = new System.Random();
      randIndex = rand.Next(0, lineCount);

      //Place the "Randomly" selected quote inside the text box
      //"quoteLabel"
      quoteLabel.Text = quotes[randIndex];
    }
      
    private void QuoteGenerateButton_Click(object sender, EventArgs e)
    {
      //When the user presses the "Generate" button, pick
      //another quote and place it in the text box quoteLabel
      randIndex = rand.Next(0, lineCount);
      quoteLabel.Text = quotes[randIndex];
    }	
  }
}
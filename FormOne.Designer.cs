namespace UsageBackgroundWorker
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         startButton = new System.Windows.Forms.Button();
         stopButton = new System.Windows.Forms.Button();
         progressBar = new System.Windows.Forms.ProgressBar();
         resultLabel = new System.Windows.Forms.Label();
         backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         SuspendLayout();
         // 
         // startButton
         // 
         startButton.Location = new System.Drawing.Point(12, 12);
         startButton.Name = "startButton";
         startButton.Size = new System.Drawing.Size(150, 23);
         startButton.TabIndex = 0;
         startButton.Text = "Запустить расчёты";
         startButton.UseVisualStyleBackColor = true;
         // 
         // stopButton
         // 
         stopButton.Location = new System.Drawing.Point(12, 41);
         stopButton.Name = "stopButton";
         stopButton.Size = new System.Drawing.Size(150, 23);
         stopButton.TabIndex = 1;
         stopButton.Text = "Остановить расчёты";
         stopButton.UseVisualStyleBackColor = true;
         // 
         // progressBar
         // 
         progressBar.Location = new System.Drawing.Point(168, 12);
         progressBar.Name = "progressBar";
         progressBar.Size = new System.Drawing.Size(250, 23);
         progressBar.TabIndex = 2;
         // 
         // resultLabel
         // 
         resultLabel.AutoSize = true;
         resultLabel.Location = new System.Drawing.Point(12, 67);
         resultLabel.Name = "resultLabel";
         resultLabel.Size = new System.Drawing.Size(78, 15);
         resultLabel.TabIndex = 3;
         resultLabel.Text = "Результат: —";
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(431, 110);
         Controls.Add(resultLabel);
         Controls.Add(progressBar);
         Controls.Add(stopButton);
         Controls.Add(startButton);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Использование BackgroundWorker в Windows Forms";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button startButton;
      private System.Windows.Forms.Button stopButton;
      private System.Windows.Forms.ProgressBar progressBar;
      private System.Windows.Forms.Label resultLabel;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
   }
}
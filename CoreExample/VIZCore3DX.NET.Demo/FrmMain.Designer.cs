﻿namespace VIZCore3DX.NET.Demo
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ckEdge = new System.Windows.Forms.CheckBox();
            this.ckSSAO = new System.Windows.Forms.CheckBox();
            this.ckShadow = new System.Windows.Forms.CheckBox();
            this.ckEnvLight = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(1, 47);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(920, 499);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(22, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ckEdge
            // 
            this.ckEdge.AutoSize = true;
            this.ckEdge.Location = new System.Drawing.Point(220, 16);
            this.ckEdge.Name = "ckEdge";
            this.ckEdge.Size = new System.Drawing.Size(60, 16);
            this.ckEdge.TabIndex = 2;
            this.ckEdge.Text = "모서리";
            this.ckEdge.UseVisualStyleBackColor = true;
            this.ckEdge.CheckedChanged += new System.EventHandler(this.ckEdge_CheckedChanged);
            // 
            // ckSSAO
            // 
            this.ckSSAO.AutoSize = true;
            this.ckSSAO.Location = new System.Drawing.Point(325, 16);
            this.ckSSAO.Name = "ckSSAO";
            this.ckSSAO.Size = new System.Drawing.Size(57, 16);
            this.ckSSAO.TabIndex = 3;
            this.ckSSAO.Text = "SSAO";
            this.ckSSAO.UseVisualStyleBackColor = true;
            this.ckSSAO.CheckedChanged += new System.EventHandler(this.ckSSAO_CheckedChanged);
            // 
            // ckShadow
            // 
            this.ckShadow.AutoSize = true;
            this.ckShadow.Location = new System.Drawing.Point(436, 16);
            this.ckShadow.Name = "ckShadow";
            this.ckShadow.Size = new System.Drawing.Size(60, 16);
            this.ckShadow.TabIndex = 4;
            this.ckShadow.Text = "그림자";
            this.ckShadow.UseVisualStyleBackColor = true;
            this.ckShadow.CheckedChanged += new System.EventHandler(this.ckShadow_CheckedChanged);
            // 
            // ckEnvLight
            // 
            this.ckEnvLight.AutoSize = true;
            this.ckEnvLight.Location = new System.Drawing.Point(542, 16);
            this.ckEnvLight.Name = "ckEnvLight";
            this.ckEnvLight.Size = new System.Drawing.Size(72, 16);
            this.ckEnvLight.TabIndex = 5;
            this.ckEnvLight.Text = "환경조명";
            this.ckEnvLight.UseVisualStyleBackColor = true;
            this.ckEnvLight.CheckedChanged += new System.EventHandler(this.ckEnvLight_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 545);
            this.Controls.Add(this.ckEnvLight);
            this.Controls.Add(this.ckShadow);
            this.Controls.Add(this.ckSSAO);
            this.Controls.Add(this.ckEdge);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3DX.NET - Demo";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox ckEdge;
        private System.Windows.Forms.CheckBox ckSSAO;
        private System.Windows.Forms.CheckBox ckShadow;
        private System.Windows.Forms.CheckBox ckEnvLight;
    }
}


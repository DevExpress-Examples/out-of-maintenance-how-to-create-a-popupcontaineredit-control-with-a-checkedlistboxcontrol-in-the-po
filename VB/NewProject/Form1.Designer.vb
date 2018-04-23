Imports Microsoft.VisualBasic
Imports System
Namespace NewProject
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.popupContainerEdit2 = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.listBox2 = New System.Windows.Forms.ListBox()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' popupContainerEdit1
			' 
			Me.popupContainerEdit1.Location = New System.Drawing.Point(12, 12)
			Me.popupContainerEdit1.Name = "popupContainerEdit1"
			Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEdit1.Size = New System.Drawing.Size(638, 20)
			Me.popupContainerEdit1.TabIndex = 0
			' 
			' popupContainerEdit2
			' 
			Me.popupContainerEdit2.Location = New System.Drawing.Point(12, 38)
			Me.popupContainerEdit2.Name = "popupContainerEdit2"
			Me.popupContainerEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEdit2.Size = New System.Drawing.Size(638, 20)
			Me.popupContainerEdit2.TabIndex = 2
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Location = New System.Drawing.Point(12, 262)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(638, 95)
			Me.listBox1.TabIndex = 3
			' 
			' listBox2
			' 
			Me.listBox2.FormattingEnabled = True
			Me.listBox2.Location = New System.Drawing.Point(12, 383)
			Me.listBox2.Name = "listBox2"
			Me.listBox2.Size = New System.Drawing.Size(638, 95)
			Me.listBox2.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(662, 490)
			Me.Controls.Add(Me.listBox2)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.popupContainerEdit2)
			Me.Controls.Add(Me.popupContainerEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
		Private popupContainerEdit2 As DevExpress.XtraEditors.PopupContainerEdit
		Private listBox1 As System.Windows.Forms.ListBox
		Private listBox2 As System.Windows.Forms.ListBox


	End Class
End Namespace


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TablePanelPrincipal = New TableLayoutPanel()
        TablePainelSuperior = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        TablePanelInferior = New TableLayoutPanel()
        Label1 = New Label()
        TextNome = New TextBox()
        Label4 = New Label()
        TextEndereco = New TextBox()
        Label5 = New Label()
        TextBairro = New TextBox()
        Label6 = New Label()
        TextCEP = New TextBox()
        Label7 = New Label()
        TextMunicipio = New TextBox()
        Label8 = New Label()
        TextEstado = New TextBox()
        CmbSexo = New ComboBox()
        Label9 = New Label()
        TablePanelPrincipal.SuspendLayout()
        TablePainelSuperior.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TablePanelInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' TablePanelPrincipal
        ' 
        TablePanelPrincipal.ColumnCount = 1
        TablePanelPrincipal.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TablePanelPrincipal.Controls.Add(TablePainelSuperior, 0, 1)
        TablePanelPrincipal.Controls.Add(TablePanelInferior, 0, 2)
        TablePanelPrincipal.Dock = DockStyle.Fill
        TablePanelPrincipal.Location = New Point(0, 0)
        TablePanelPrincipal.Name = "TablePanelPrincipal"
        TablePanelPrincipal.RowCount = 4
        TablePanelPrincipal.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TablePanelPrincipal.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TablePanelPrincipal.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TablePanelPrincipal.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TablePanelPrincipal.Size = New Size(800, 450)
        TablePanelPrincipal.TabIndex = 2
        ' 
        ' TablePainelSuperior
        ' 
        TablePainelSuperior.BackColor = SystemColors.ActiveCaption
        TablePainelSuperior.ColumnCount = 7
        TablePainelSuperior.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TablePainelSuperior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14F))
        TablePainelSuperior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31F))
        TablePainelSuperior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TablePainelSuperior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31F))
        TablePainelSuperior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14F))
        TablePainelSuperior.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TablePainelSuperior.Controls.Add(PictureBox1, 1, 0)
        TablePainelSuperior.Controls.Add(Label2, 2, 0)
        TablePainelSuperior.Controls.Add(PictureBox2, 5, 0)
        TablePainelSuperior.Controls.Add(Label3, 4, 0)
        TablePainelSuperior.Dock = DockStyle.Fill
        TablePainelSuperior.Location = New Point(3, 23)
        TablePainelSuperior.Name = "TablePainelSuperior"
        TablePainelSuperior.RowCount = 1
        TablePainelSuperior.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TablePainelSuperior.Size = New Size(794, 55)
        TablePainelSuperior.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(123, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(200, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 55)
        Label2.TabIndex = 2
        Label2.Text = "Cadastro de" & vbCrLf & "Clientes" & vbCrLf
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(597, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(71, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(426, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 55)
        Label3.TabIndex = 3
        Label3.Text = "Atualização"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TablePanelInferior
        ' 
        TablePanelInferior.BackColor = SystemColors.InactiveBorder
        TablePanelInferior.ColumnCount = 5
        TablePanelInferior.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TablePanelInferior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TablePanelInferior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TablePanelInferior.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TablePanelInferior.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120F))
        TablePanelInferior.Controls.Add(Label1, 1, 1)
        TablePanelInferior.Controls.Add(TextNome, 1, 2)
        TablePanelInferior.Controls.Add(Label4, 1, 3)
        TablePanelInferior.Controls.Add(TextEndereco, 1, 4)
        TablePanelInferior.Controls.Add(Label5, 1, 5)
        TablePanelInferior.Controls.Add(TextBairro, 1, 6)
        TablePanelInferior.Controls.Add(Label6, 1, 7)
        TablePanelInferior.Controls.Add(TextCEP, 1, 8)
        TablePanelInferior.Controls.Add(Label7, 1, 9)
        TablePanelInferior.Controls.Add(TextMunicipio, 1, 10)
        TablePanelInferior.Controls.Add(Label8, 3, 1)
        TablePanelInferior.Controls.Add(TextEstado, 3, 2)
        TablePanelInferior.Controls.Add(CmbSexo, 3, 4)
        TablePanelInferior.Controls.Add(Label9, 3, 3)
        TablePanelInferior.Dock = DockStyle.Fill
        TablePanelInferior.Location = New Point(3, 84)
        TablePanelInferior.Name = "TablePanelInferior"
        TablePanelInferior.RowCount = 12
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TablePanelInferior.Size = New Size(794, 342)
        TablePanelInferior.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Bottom
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(123, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nome"
        ' 
        ' TextNome
        ' 
        TextNome.Dock = DockStyle.Fill
        TextNome.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextNome.Location = New Point(123, 59)
        TextNome.MaxLength = 70
        TextNome.Name = "TextNome"
        TextNome.Size = New Size(243, 32)
        TextNome.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Bottom
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(123, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(243, 25)
        Label4.TabIndex = 2
        Label4.Text = "Endereço"
        ' 
        ' TextEndereco
        ' 
        TextEndereco.Dock = DockStyle.Fill
        TextEndereco.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextEndereco.Location = New Point(123, 115)
        TextEndereco.MaxLength = 70
        TextEndereco.Name = "TextEndereco"
        TextEndereco.Size = New Size(243, 32)
        TextEndereco.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Bottom
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(123, 143)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 25)
        Label5.TabIndex = 4
        Label5.Text = "Bairro"
        ' 
        ' TextBairro
        ' 
        TextBairro.Dock = DockStyle.Fill
        TextBairro.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBairro.Location = New Point(123, 171)
        TextBairro.MaxLength = 70
        TextBairro.Name = "TextBairro"
        TextBairro.Size = New Size(243, 32)
        TextBairro.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Bottom
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(123, 199)
        Label6.Name = "Label6"
        Label6.Size = New Size(243, 25)
        Label6.TabIndex = 5
        Label6.Text = "CEP"
        ' 
        ' TextCEP
        ' 
        TextCEP.Dock = DockStyle.Fill
        TextCEP.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextCEP.Location = New Point(123, 227)
        TextCEP.MaxLength = 70
        TextCEP.Name = "TextCEP"
        TextCEP.Size = New Size(243, 32)
        TextCEP.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Bottom
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(123, 255)
        Label7.Name = "Label7"
        Label7.Size = New Size(243, 25)
        Label7.TabIndex = 6
        Label7.Text = "Município"
        ' 
        ' TextMunicipio
        ' 
        TextMunicipio.Dock = DockStyle.Fill
        TextMunicipio.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextMunicipio.Location = New Point(123, 283)
        TextMunicipio.MaxLength = 70
        TextMunicipio.Name = "TextMunicipio"
        TextMunicipio.Size = New Size(243, 32)
        TextMunicipio.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Bottom
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(427, 31)
        Label8.Name = "Label8"
        Label8.Size = New Size(243, 25)
        Label8.TabIndex = 10
        Label8.Text = "Estado"
        ' 
        ' TextEstado
        ' 
        TextEstado.Dock = DockStyle.Fill
        TextEstado.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextEstado.Location = New Point(427, 59)
        TextEstado.MaxLength = 70
        TextEstado.Name = "TextEstado"
        TextEstado.Size = New Size(243, 32)
        TextEstado.TabIndex = 11
        ' 
        ' CmbSexo
        ' 
        CmbSexo.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        CmbSexo.FormattingEnabled = True
        CmbSexo.Location = New Point(427, 115)
        CmbSexo.Name = "CmbSexo"
        CmbSexo.Size = New Size(243, 33)
        CmbSexo.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Bottom
        Label9.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(427, 87)
        Label9.Name = "Label9"
        Label9.Size = New Size(243, 25)
        Label9.TabIndex = 13
        Label9.Text = "Sexo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TablePanelPrincipal)
        MinimumSize = New Size(818, 497)
        Name = "Form1"
        Text = "Form1"
        TablePanelPrincipal.ResumeLayout(False)
        TablePainelSuperior.ResumeLayout(False)
        TablePainelSuperior.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TablePanelInferior.ResumeLayout(False)
        TablePanelInferior.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TablePanelPrincipal As TableLayoutPanel
    Friend WithEvents TablePainelSuperior As TableLayoutPanel
    Friend WithEvents TablePanelInferior As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextNome As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextEndereco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBairro As TextBox
    Friend WithEvents TextCEP As TextBox
    Friend WithEvents TextMunicipio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextEstado As TextBox
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents Label9 As Label
End Class

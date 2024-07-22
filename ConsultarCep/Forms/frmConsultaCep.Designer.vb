<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaCep))
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpSair = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCEPFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpVoltar = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtUF = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCidade = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEndereco2 = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.grpConsultaCep = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.txtCEP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCep = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSair.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVoltar.SuspendLayout()
        CType(Me.grpDadosEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosEndereco.SuspendLayout()
        CType(Me.grpConsultaCep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsultaCep.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Size = New System.Drawing.Size(508, 385)
        Me.tabMain.TabIndex = 14
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpSair)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Location = New System.Drawing.Point(1, 21)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(504, 361)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "CEP"
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(3, 68)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(498, 225)
        Me.grdListagem.TabIndex = 16
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpSair
        '
        Me.grpSair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSair.BorderColor = System.Drawing.Color.Gray
        Me.grpSair.Controls.Add(Me.btnExcluir)
        Me.grpSair.Controls.Add(Me.btnNovo)
        Me.grpSair.Controls.Add(Me.btnSair)
        Me.grpSair.Location = New System.Drawing.Point(3, 299)
        Me.grpSair.Name = "grpSair"
        Me.grpSair.Size = New System.Drawing.Size(498, 59)
        Me.grpSair.TabIndex = 15
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.WindowsApplication1.My.Resources.Resources._1486564399_close_81512
        Me.btnExcluir.Location = New System.Drawing.Point(191, 28)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(94, 21)
        Me.btnExcluir.TabIndex = 13
        Me.btnExcluir.Text = "Excluir"
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.WindowsApplication1.My.Resources.Resources.add_new_page_icon_icons_com_71788
        Me.btnNovo.Location = New System.Drawing.Point(291, 28)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(94, 21)
        Me.btnNovo.TabIndex = 12
        Me.btnNovo.Text = "Novo"
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.WindowsApplication1.My.Resources.Resources.log_out_icon_icons_com_50106
        Me.btnSair.Location = New System.Drawing.Point(391, 28)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(94, 21)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BorderColor = System.Drawing.Color.Gray
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Controls.Add(Me.txtCEPFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(3, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(498, 59)
        Me.grpFiltro.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CEP:"
        '
        'txtCEPFiltro
        '
        Me.txtCEPFiltro.Location = New System.Drawing.Point(6, 29)
        Me.txtCEPFiltro.Mask = "00000-000"
        Me.txtCEPFiltro.Name = "txtCEPFiltro"
        Me.txtCEPFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtCEPFiltro.TabIndex = 10
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.WindowsApplication1.My.Resources.Resources.xmag_search_find_export_locate_5984
        Me.btnFiltrar.Location = New System.Drawing.Point(398, 28)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(94, 21)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpVoltar)
        Me.pagDados.Controls.Add(Me.grpDadosEndereco)
        Me.pagDados.Controls.Add(Me.grpConsultaCep)
        Me.pagDados.Location = New System.Drawing.Point(1, 21)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(504, 361)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados - CEP"
        '
        'grpVoltar
        '
        Me.grpVoltar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVoltar.BorderColor = System.Drawing.Color.Gray
        Me.grpVoltar.Controls.Add(Me.btnSalvar)
        Me.grpVoltar.Controls.Add(Me.btnVoltar)
        Me.grpVoltar.Location = New System.Drawing.Point(3, 299)
        Me.grpVoltar.Name = "grpVoltar"
        Me.grpVoltar.Size = New System.Drawing.Size(498, 59)
        Me.grpVoltar.TabIndex = 16
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.WindowsApplication1.My.Resources.Resources.save_file_disk_open_searsh_loading_clipboard_1513
        Me.btnSalvar.Location = New System.Drawing.Point(298, 28)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(94, 21)
        Me.btnSalvar.TabIndex = 12
        Me.btnSalvar.Text = "Salvar"
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.WindowsApplication1.My.Resources.Resources.window_back_button_icon_icons_com_53838
        Me.btnVoltar.Location = New System.Drawing.Point(398, 28)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(94, 21)
        Me.btnVoltar.TabIndex = 11
        Me.btnVoltar.Text = "Voltar"
        '
        'grpDadosEndereco
        '
        Me.grpDadosEndereco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosEndereco.BorderColor = System.Drawing.Color.Gray
        Me.grpDadosEndereco.Controls.Add(Me.txtUF)
        Me.grpDadosEndereco.Controls.Add(Me.txtCidade)
        Me.grpDadosEndereco.Controls.Add(Me.txtBairro)
        Me.grpDadosEndereco.Controls.Add(Me.txtEndereco)
        Me.grpDadosEndereco.Controls.Add(Me.lblEndereco2)
        Me.grpDadosEndereco.Controls.Add(Me.lblEndereco)
        Me.grpDadosEndereco.Controls.Add(Me.lblUF)
        Me.grpDadosEndereco.Controls.Add(Me.lblCidade)
        Me.grpDadosEndereco.Controls.Add(Me.lblBairro)
        Me.grpDadosEndereco.Location = New System.Drawing.Point(3, 68)
        Me.grpDadosEndereco.Name = "grpDadosEndereco"
        Me.grpDadosEndereco.Size = New System.Drawing.Size(498, 225)
        Me.grpDadosEndereco.TabIndex = 13
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(6, 173)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(53, 20)
        Me.txtUF.TabIndex = 13
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(6, 129)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(479, 20)
        Me.txtCidade.TabIndex = 12
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(6, 82)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(479, 20)
        Me.txtBairro.TabIndex = 11
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(6, 34)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(479, 20)
        Me.txtEndereco.TabIndex = 10
        '
        'lblEndereco2
        '
        Me.lblEndereco2.AutoSize = True
        Me.lblEndereco2.Location = New System.Drawing.Point(65, 9)
        Me.lblEndereco2.Name = "lblEndereco2"
        Me.lblEndereco2.Size = New System.Drawing.Size(0, 13)
        Me.lblEndereco2.TabIndex = 9
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(3, 18)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 2
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(3, 155)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 13)
        Me.lblUF.TabIndex = 4
        Me.lblUF.Text = "UF:"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(3, 111)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 5
        Me.lblCidade.Text = "Cidade:"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(3, 66)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 3
        Me.lblBairro.Text = "Bairro:"
        '
        'grpConsultaCep
        '
        Me.grpConsultaCep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpConsultaCep.BorderColor = System.Drawing.Color.Gray
        Me.grpConsultaCep.Controls.Add(Me.lblCep)
        Me.grpConsultaCep.Controls.Add(Me.txtCEP)
        Me.grpConsultaCep.Controls.Add(Me.btnCep)
        Me.grpConsultaCep.Location = New System.Drawing.Point(3, 3)
        Me.grpConsultaCep.Name = "grpConsultaCep"
        Me.grpConsultaCep.Size = New System.Drawing.Size(498, 59)
        Me.grpConsultaCep.TabIndex = 12
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(6, 13)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(31, 13)
        Me.lblCep.TabIndex = 14
        Me.lblCep.Text = "CEP:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(6, 29)
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(100, 20)
        Me.txtCEP.TabIndex = 10
        '
        'btnCep
        '
        Me.btnCep.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCep.Image = Global.WindowsApplication1.My.Resources.Resources.query
        Me.btnCep.Location = New System.Drawing.Point(398, 28)
        Me.btnCep.Name = "btnCep"
        Me.btnCep.Size = New System.Drawing.Size(94, 21)
        Me.btnCep.TabIndex = 11
        Me.btnCep.Text = "Consultar"
        '
        'FrmConsultaCep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(532, 409)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConsultaCep"
        Me.Text = "Consultar CEP"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSair.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVoltar.ResumeLayout(False)
        CType(Me.grpDadosEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosEndereco.ResumeLayout(False)
        Me.grpDadosEndereco.PerformLayout()
        CType(Me.grpConsultaCep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsultaCep.ResumeLayout(False)
        Me.grpConsultaCep.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCEPFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtUF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCidade As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEndereco2 As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblUF As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblBairro As Label
    Friend WithEvents grpConsultaCep As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCep As Label
    Friend WithEvents txtCEP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCep As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpSair As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpVoltar As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
End Class

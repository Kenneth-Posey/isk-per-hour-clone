﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuStripMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectionAddChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectionManageAPI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectionExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemUpdatePrices = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetPOSDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManageBlueprintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateCRESTTeams = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateIndustryFacilities = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateCRESTMarketPrices = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuResetData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetBlueprintData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetPriceData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetAgents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetIndustryJobs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetAssets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetCRESTDates = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuResetAllData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectionShoppingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewAssets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCharacterSkills = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCharacterStandings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCurrentResearchAgents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCurrentIndustryJobs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveCurrentTabSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDefaultTabSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDefaultBP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDefaultUpdatePrices = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDefaultManufacturing = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDefaultDatacores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDefaultReactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDefaultMining = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectDefaultChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventionSuccessMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIndustryUpgradeBelts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRefinery = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPatchNotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckforUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectionAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain = New System.Windows.Forms.StatusStrip()
        Me.pnlCharacter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlSkills = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlShoppingList = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.txtListEdit = New System.Windows.Forms.TextBox()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.gbSystems = New System.Windows.Forms.GroupBox()
        Me.tabMining = New System.Windows.Forms.TabPage()
        Me.gbMineOreProcessingType = New System.Windows.Forms.GroupBox()
        Me.chkMineUnrefinedOre = New System.Windows.Forms.CheckBox()
        Me.chkMineRefinedOre = New System.Windows.Forms.CheckBox()
        Me.chkMineCompressedOre = New System.Windows.Forms.CheckBox()
        Me.btnMineSaveAllSettings = New System.Windows.Forms.Button()
        Me.gbMineTaxBroker = New System.Windows.Forms.GroupBox()
        Me.chkMineIncludeTaxes = New System.Windows.Forms.CheckBox()
        Me.chkMineIncludeBrokerFees = New System.Windows.Forms.CheckBox()
        Me.gbMineStripStats = New System.Windows.Forms.GroupBox()
        Me.lblMineRange = New System.Windows.Forms.Label()
        Me.lblMineCycleTime1 = New System.Windows.Forms.Label()
        Me.lblMineRange1 = New System.Windows.Forms.Label()
        Me.lblMineCycleTime = New System.Windows.Forms.Label()
        Me.gbMineMiningDroneM3 = New System.Windows.Forms.GroupBox()
        Me.lblMineMiningDroneM3 = New System.Windows.Forms.Label()
        Me.txtMineMiningDroneM3 = New System.Windows.Forms.TextBox()
        Me.chkMineUseFleetBooster = New System.Windows.Forms.CheckBox()
        Me.gbMineJumpCosts = New System.Windows.Forms.GroupBox()
        Me.rbtnMineJumpMinerals = New System.Windows.Forms.RadioButton()
        Me.rbtnMineJumpCompress = New System.Windows.Forms.RadioButton()
        Me.chkMineIncludeJumpCosts = New System.Windows.Forms.CheckBox()
        Me.lblMineTotalJumpFuel = New System.Windows.Forms.Label()
        Me.txtMineTotalJumpFuel = New System.Windows.Forms.TextBox()
        Me.lblMineTotalJumpM3 = New System.Windows.Forms.Label()
        Me.txtMineTotalJumpM3 = New System.Windows.Forms.TextBox()
        Me.btnMineReset = New System.Windows.Forms.Button()
        Me.gbMineHauling = New System.Windows.Forms.GroupBox()
        Me.lblMineHaulerM3 = New System.Windows.Forms.Label()
        Me.txtMineHaulerM3 = New System.Windows.Forms.TextBox()
        Me.lblMineRTSec = New System.Windows.Forms.Label()
        Me.chkMineUseHauler = New System.Windows.Forms.CheckBox()
        Me.lblMineRTMin = New System.Windows.Forms.Label()
        Me.txtMineRTMin = New System.Windows.Forms.TextBox()
        Me.txtMineRTSec = New System.Windows.Forms.TextBox()
        Me.lblMineRoundTripTime = New System.Windows.Forms.Label()
        Me.btnMineRefresh = New System.Windows.Forms.Button()
        Me.gbMineBooster = New System.Windows.Forms.GroupBox()
        Me.pictMineLaserOptmize = New System.Windows.Forms.PictureBox()
        Me.pictMineRangeLink = New System.Windows.Forms.PictureBox()
        Me.pictMineFleetBoostShip = New System.Windows.Forms.PictureBox()
        Me.chkMineForemanLaserRangeBoost = New System.Windows.Forms.CheckBox()
        Me.cmbMineIndustReconfig = New System.Windows.Forms.ComboBox()
        Me.lblMineIndustrialReconfig = New System.Windows.Forms.Label()
        Me.chkMineRorqDeployedMode = New System.Windows.Forms.CheckBox()
        Me.cmbMineWarfareLinkSpec = New System.Windows.Forms.ComboBox()
        Me.lblMineWarfareLinkSpec = New System.Windows.Forms.Label()
        Me.cmbMineBoosterShipSkill = New System.Windows.Forms.ComboBox()
        Me.chkMineForemanMindlink = New System.Windows.Forms.CheckBox()
        Me.cmbMineBoosterShip = New System.Windows.Forms.ComboBox()
        Me.cmbMineMiningDirector = New System.Windows.Forms.ComboBox()
        Me.chkMineForemanLaserOpBoost = New System.Windows.Forms.CheckBox()
        Me.lblMineMiningDirector = New System.Windows.Forms.Label()
        Me.cmbMineMiningForeman = New System.Windows.Forms.ComboBox()
        Me.lblMineFleetBoosterShip = New System.Windows.Forms.Label()
        Me.lblMineMiningForeman = New System.Windows.Forms.Label()
        Me.lblMineBoosterShipSkill = New System.Windows.Forms.Label()
        Me.gbMineRefining = New System.Windows.Forms.GroupBox()
        Me.cmbOreProcessing17 = New System.Windows.Forms.ComboBox()
        Me.chkOreProcessing17 = New System.Windows.Forms.CheckBox()
        Me.lblOreProcessing17 = New System.Windows.Forms.Label()
        Me.gbMineStationYield = New System.Windows.Forms.GroupBox()
        Me.cmbMineRefineStationTax = New System.Windows.Forms.ComboBox()
        Me.lblMineRefineStationTax = New System.Windows.Forms.Label()
        Me.cmbMineStationEff = New System.Windows.Forms.ComboBox()
        Me.lblMineStationEff = New System.Windows.Forms.Label()
        Me.lblMineStationStanding = New System.Windows.Forms.Label()
        Me.txtMineRefineStanding = New System.Windows.Forms.TextBox()
        Me.gbMineBaseRefineSkills = New System.Windows.Forms.GroupBox()
        Me.lblMineRefineryEfficiency = New System.Windows.Forms.Label()
        Me.cmbMineRefining = New System.Windows.Forms.ComboBox()
        Me.lblMineRefining = New System.Windows.Forms.Label()
        Me.cmbMineRefineryEff = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing16 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing15 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing14 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing13 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing12 = New System.Windows.Forms.ComboBox()
        Me.chkOreProcessing16 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing15 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing14 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing13 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing12 = New System.Windows.Forms.CheckBox()
        Me.lblOreProcessing12 = New System.Windows.Forms.Label()
        Me.lblOreProcessing13 = New System.Windows.Forms.Label()
        Me.lblOreProcessing14 = New System.Windows.Forms.Label()
        Me.lblOreProcessing16 = New System.Windows.Forms.Label()
        Me.lblOreProcessing15 = New System.Windows.Forms.Label()
        Me.cmbOreProcessing6 = New System.Windows.Forms.ComboBox()
        Me.chkOreProcessing6 = New System.Windows.Forms.CheckBox()
        Me.lblOreProcessing6 = New System.Windows.Forms.Label()
        Me.cmbOreProcessing8 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing7 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing11 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing10 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing9 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing5 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing4 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing3 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing2 = New System.Windows.Forms.ComboBox()
        Me.cmbOreProcessing1 = New System.Windows.Forms.ComboBox()
        Me.chkOreProcessing8 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing7 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing11 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing10 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing9 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing5 = New System.Windows.Forms.CheckBox()
        Me.lblOreProcessing8 = New System.Windows.Forms.Label()
        Me.chkOreProcessing4 = New System.Windows.Forms.CheckBox()
        Me.lblOreProcessing7 = New System.Windows.Forms.Label()
        Me.chkOreProcessing3 = New System.Windows.Forms.CheckBox()
        Me.lblOreProcessing11 = New System.Windows.Forms.Label()
        Me.chkOreProcessing2 = New System.Windows.Forms.CheckBox()
        Me.chkOreProcessing1 = New System.Windows.Forms.CheckBox()
        Me.lblOreProcessing1 = New System.Windows.Forms.Label()
        Me.lblOreProcessing2 = New System.Windows.Forms.Label()
        Me.lblOreProcessing3 = New System.Windows.Forms.Label()
        Me.lblOreProcessing10 = New System.Windows.Forms.Label()
        Me.lblOreProcessing9 = New System.Windows.Forms.Label()
        Me.lblOreProcessing5 = New System.Windows.Forms.Label()
        Me.lblOreProcessing4 = New System.Windows.Forms.Label()
        Me.gbMineShipSetup = New System.Windows.Forms.GroupBox()
        Me.gbMineSelectShip = New System.Windows.Forms.GroupBox()
        Me.pictMineSelectedShip = New System.Windows.Forms.PictureBox()
        Me.lblMineSelectShip = New System.Windows.Forms.Label()
        Me.cmbMineBaseShipSkill = New System.Windows.Forms.ComboBox()
        Me.cmbMineExhumers = New System.Windows.Forms.ComboBox()
        Me.cmbMineShipType = New System.Windows.Forms.ComboBox()
        Me.lblMineBaseShipSkill = New System.Windows.Forms.Label()
        Me.lblMineExhumers = New System.Windows.Forms.Label()
        Me.gbMineShipEquipment = New System.Windows.Forms.GroupBox()
        Me.gbMiningRigs = New System.Windows.Forms.GroupBox()
        Me.rbtnMineNoRigs = New System.Windows.Forms.RadioButton()
        Me.rbtnMineIceRig = New System.Windows.Forms.RadioButton()
        Me.rbtnMineMercoxitRig = New System.Windows.Forms.RadioButton()
        Me.cmbMineMiningLaser = New System.Windows.Forms.ComboBox()
        Me.lblMineMiningUpgrade = New System.Windows.Forms.Label()
        Me.gbMineCrystals = New System.Windows.Forms.GroupBox()
        Me.rbtnMineT1Crystals = New System.Windows.Forms.RadioButton()
        Me.rbtnMineT2Crystals = New System.Windows.Forms.RadioButton()
        Me.cmbMineNumMiningUpgrades = New System.Windows.Forms.ComboBox()
        Me.cmbMineNumLasers = New System.Windows.Forms.ComboBox()
        Me.cmbMineMiningUpgrade = New System.Windows.Forms.ComboBox()
        Me.cmbMineImplant = New System.Windows.Forms.ComboBox()
        Me.chkMineMichiImplant = New System.Windows.Forms.CheckBox()
        Me.lblMineImplants = New System.Windows.Forms.Label()
        Me.lblMineLaserNumber = New System.Windows.Forms.Label()
        Me.lblMineNumMiningUpgrades = New System.Windows.Forms.Label()
        Me.lblMineMinerTurret = New System.Windows.Forms.Label()
        Me.gbMineSkills = New System.Windows.Forms.GroupBox()
        Me.cmbMineGasIceHarvesting = New System.Windows.Forms.ComboBox()
        Me.lblMineGasIceHarvesting = New System.Windows.Forms.Label()
        Me.cmbMineDeepCore = New System.Windows.Forms.ComboBox()
        Me.lblMineAstrogeology = New System.Windows.Forms.Label()
        Me.cmbMineSkill = New System.Windows.Forms.ComboBox()
        Me.lblMineSkill = New System.Windows.Forms.Label()
        Me.cmbMineAstrogeology = New System.Windows.Forms.ComboBox()
        Me.lblMineDeepCore = New System.Windows.Forms.Label()
        Me.gbMineMain = New System.Windows.Forms.GroupBox()
        Me.gbMineIncludeOres = New System.Windows.Forms.GroupBox()
        Me.chkMineIncludeHighSec = New System.Windows.Forms.CheckBox()
        Me.chkMineIncludeNullSec = New System.Windows.Forms.CheckBox()
        Me.chkMineIncludeLowSec = New System.Windows.Forms.CheckBox()
        Me.chkMineIncludeHighYieldOre = New System.Windows.Forms.CheckBox()
        Me.lblMineType = New System.Windows.Forms.Label()
        Me.cmbMineOreType = New System.Windows.Forms.ComboBox()
        Me.gbMineOreLocSov = New System.Windows.Forms.GroupBox()
        Me.chkMineWH = New System.Windows.Forms.CheckBox()
        Me.gbMineWHSpace = New System.Windows.Forms.GroupBox()
        Me.chkMineC6 = New System.Windows.Forms.CheckBox()
        Me.chkMineC2 = New System.Windows.Forms.CheckBox()
        Me.chkMineC4 = New System.Windows.Forms.CheckBox()
        Me.chkMineC1 = New System.Windows.Forms.CheckBox()
        Me.chkMineC5 = New System.Windows.Forms.CheckBox()
        Me.chkMineC3 = New System.Windows.Forms.CheckBox()
        Me.chkMineCaldari = New System.Windows.Forms.CheckBox()
        Me.chkMineMinmatar = New System.Windows.Forms.CheckBox()
        Me.chkMineGallente = New System.Windows.Forms.CheckBox()
        Me.chkMineAmarr = New System.Windows.Forms.CheckBox()
        Me.lstMineGrid = New System.Windows.Forms.ListView()
        Me.tabReactions = New System.Windows.Forms.TabPage()
        Me.gbReactionsTaxesFees = New System.Windows.Forms.GroupBox()
        Me.chkReactionsFees = New System.Windows.Forms.CheckBox()
        Me.chkReactionsTaxes = New System.Windows.Forms.CheckBox()
        Me.lblReactionsFees = New System.Windows.Forms.Label()
        Me.lblReactionsTaxes = New System.Windows.Forms.Label()
        Me.gbReactionsSelectedMats = New System.Windows.Forms.GroupBox()
        Me.lstReactionMats = New System.Windows.Forms.ListView()
        Me.gbReactions = New System.Windows.Forms.GroupBox()
        Me.lblReactionsNumPOS = New System.Windows.Forms.Label()
        Me.txtReactionsNumPOS = New System.Windows.Forms.TextBox()
        Me.btnReactionsSaveSettings = New System.Windows.Forms.Button()
        Me.gbReactionsHybrid = New System.Windows.Forms.GroupBox()
        Me.chkReactionsHybrid = New System.Windows.Forms.CheckBox()
        Me.gbReactionsBiochem = New System.Windows.Forms.GroupBox()
        Me.chkReactionsSimpleBio = New System.Windows.Forms.CheckBox()
        Me.chkReactionsComplexBio = New System.Windows.Forms.CheckBox()
        Me.gbReactionsOptions = New System.Windows.Forms.GroupBox()
        Me.chkReactionsRefine = New System.Windows.Forms.CheckBox()
        Me.chkReactionsIgnoreBaseMatPrice = New System.Windows.Forms.CheckBox()
        Me.chkReactionsBuildBasic = New System.Windows.Forms.CheckBox()
        Me.gbReactionsMoonMats = New System.Windows.Forms.GroupBox()
        Me.chkReactionsAdvMoonMats = New System.Windows.Forms.CheckBox()
        Me.chkReactionsProcMoonMats = New System.Windows.Forms.CheckBox()
        Me.lblReactionPOSFuelCost = New System.Windows.Forms.Label()
        Me.btnReactionRefresh = New System.Windows.Forms.Button()
        Me.txtReactionPOSFuelCost = New System.Windows.Forms.TextBox()
        Me.lstReactions = New System.Windows.Forms.ListView()
        Me.tabDatacores = New System.Windows.Forms.TabPage()
        Me.lstDC = New System.Windows.Forms.ListView()
        Me.gbDCOptions = New System.Windows.Forms.GroupBox()
        Me.btnDCSaveSettings = New System.Windows.Forms.Button()
        Me.gbDCAgentLocSov = New System.Windows.Forms.GroupBox()
        Me.chkDCThukkerSov = New System.Windows.Forms.CheckBox()
        Me.chkDCKhanidSov = New System.Windows.Forms.CheckBox()
        Me.chkDCMinmatarSov = New System.Windows.Forms.CheckBox()
        Me.chkDCSyndicateSov = New System.Windows.Forms.CheckBox()
        Me.chkDCGallenteSov = New System.Windows.Forms.CheckBox()
        Me.chkDCAmarrSov = New System.Windows.Forms.CheckBox()
        Me.chkDCAmmatarSov = New System.Windows.Forms.CheckBox()
        Me.chkDCCaldariSov = New System.Windows.Forms.CheckBox()
        Me.gbDCTotalIPH = New System.Windows.Forms.GroupBox()
        Me.lblDCTotalOptIPH = New System.Windows.Forms.Label()
        Me.lblDCTotalSelectedIPH = New System.Windows.Forms.Label()
        Me.txtDCTotalSelectedIPH = New System.Windows.Forms.TextBox()
        Me.txtDCTotalOptIPH = New System.Windows.Forms.TextBox()
        Me.gbDCPrices = New System.Windows.Forms.GroupBox()
        Me.rbtnDCSystemPrices = New System.Windows.Forms.RadioButton()
        Me.rbtnDCRegionPrices = New System.Windows.Forms.RadioButton()
        Me.rbtnDCUpdatedPrices = New System.Windows.Forms.RadioButton()
        Me.gbDCAgentTypes = New System.Windows.Forms.GroupBox()
        Me.cmbDCRegions = New System.Windows.Forms.ComboBox()
        Me.lblDCRegion = New System.Windows.Forms.Label()
        Me.chkDCLowSecAgents = New System.Windows.Forms.CheckBox()
        Me.chkDCHighSecAgents = New System.Windows.Forms.CheckBox()
        Me.chkDCIncludeAllAgents = New System.Windows.Forms.CheckBox()
        Me.gbDCBaseSkills = New System.Windows.Forms.GroupBox()
        Me.cmbDCResearchMgmt = New System.Windows.Forms.ComboBox()
        Me.lblDCResearchManagement = New System.Windows.Forms.Label()
        Me.lblDCNegotiation = New System.Windows.Forms.Label()
        Me.cmbDCConnections = New System.Windows.Forms.ComboBox()
        Me.lblDCConnections = New System.Windows.Forms.Label()
        Me.cmbDCNegotiation = New System.Windows.Forms.ComboBox()
        Me.gbDCDatacores = New System.Windows.Forms.GroupBox()
        Me.cmbDCSkillLevel17 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel16 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel15 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel14 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel13 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel12 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel11 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel10 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel9 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel8 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel7 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel6 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel5 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel4 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel3 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel2 = New System.Windows.Forms.ComboBox()
        Me.cmbDCSkillLevel1 = New System.Windows.Forms.ComboBox()
        Me.chkDC17 = New System.Windows.Forms.CheckBox()
        Me.chkDC4 = New System.Windows.Forms.CheckBox()
        Me.chkDC16 = New System.Windows.Forms.CheckBox()
        Me.chkDC3 = New System.Windows.Forms.CheckBox()
        Me.lblDatacore17 = New System.Windows.Forms.Label()
        Me.chkDC15 = New System.Windows.Forms.CheckBox()
        Me.chkDC2 = New System.Windows.Forms.CheckBox()
        Me.chkDC14 = New System.Windows.Forms.CheckBox()
        Me.chkDC1 = New System.Windows.Forms.CheckBox()
        Me.chkDC13 = New System.Windows.Forms.CheckBox()
        Me.chkDC12 = New System.Windows.Forms.CheckBox()
        Me.chkDC11 = New System.Windows.Forms.CheckBox()
        Me.chkDC10 = New System.Windows.Forms.CheckBox()
        Me.lblDatacore16 = New System.Windows.Forms.Label()
        Me.lblDatacore4 = New System.Windows.Forms.Label()
        Me.lblDatacore15 = New System.Windows.Forms.Label()
        Me.chkDC9 = New System.Windows.Forms.CheckBox()
        Me.lblDatacore14 = New System.Windows.Forms.Label()
        Me.lblDatacore3 = New System.Windows.Forms.Label()
        Me.chkDC8 = New System.Windows.Forms.CheckBox()
        Me.lblDatacore13 = New System.Windows.Forms.Label()
        Me.lblDatacore2 = New System.Windows.Forms.Label()
        Me.chkDC7 = New System.Windows.Forms.CheckBox()
        Me.chkDC6 = New System.Windows.Forms.CheckBox()
        Me.lblDatacore1 = New System.Windows.Forms.Label()
        Me.chkDC5 = New System.Windows.Forms.CheckBox()
        Me.lblDatacore5 = New System.Windows.Forms.Label()
        Me.lblDatacore6 = New System.Windows.Forms.Label()
        Me.lblDatacore7 = New System.Windows.Forms.Label()
        Me.lblDatacore8 = New System.Windows.Forms.Label()
        Me.lblDatacore12 = New System.Windows.Forms.Label()
        Me.lblDatacore11 = New System.Windows.Forms.Label()
        Me.lblDatacore10 = New System.Windows.Forms.Label()
        Me.lblDatacore9 = New System.Windows.Forms.Label()
        Me.gbDCCodes = New System.Windows.Forms.GroupBox()
        Me.lblDCColors = New System.Windows.Forms.Label()
        Me.lblDCRedText = New System.Windows.Forms.Label()
        Me.lblDCOrangeText = New System.Windows.Forms.Label()
        Me.lblDCGrayText = New System.Windows.Forms.Label()
        Me.lblDCBlueText = New System.Windows.Forms.Label()
        Me.lblDCGreenBackColor = New System.Windows.Forms.Label()
        Me.gbDCCorpMinmatar = New System.Windows.Forms.GroupBox()
        Me.lblDCCorp13 = New System.Windows.Forms.Label()
        Me.chkDCCorp13 = New System.Windows.Forms.CheckBox()
        Me.txtDCStanding13 = New System.Windows.Forms.TextBox()
        Me.lblDCCorpLabel4 = New System.Windows.Forms.Label()
        Me.lblDCCorp10 = New System.Windows.Forms.Label()
        Me.lblDCCorp11 = New System.Windows.Forms.Label()
        Me.lblDCCorp12 = New System.Windows.Forms.Label()
        Me.chkDCCorp10 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp11 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp12 = New System.Windows.Forms.CheckBox()
        Me.txtDCStanding10 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding11 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding12 = New System.Windows.Forms.TextBox()
        Me.lblDCStanding4 = New System.Windows.Forms.Label()
        Me.btnDCExporttoClip = New System.Windows.Forms.Button()
        Me.gbDCCorpAmarr = New System.Windows.Forms.GroupBox()
        Me.lblDCCorpLabel1 = New System.Windows.Forms.Label()
        Me.lblDCCorp1 = New System.Windows.Forms.Label()
        Me.lblDCCorp2 = New System.Windows.Forms.Label()
        Me.lblDCCorp3 = New System.Windows.Forms.Label()
        Me.chkDCCorp1 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp2 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp3 = New System.Windows.Forms.CheckBox()
        Me.txtDCStanding1 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding2 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding3 = New System.Windows.Forms.TextBox()
        Me.lblDCStanding1 = New System.Windows.Forms.Label()
        Me.btnDCReset = New System.Windows.Forms.Button()
        Me.gbDCCorpsCaldari = New System.Windows.Forms.GroupBox()
        Me.lblDCCorpLabel2 = New System.Windows.Forms.Label()
        Me.lblDCCorp4 = New System.Windows.Forms.Label()
        Me.lblDCCorp5 = New System.Windows.Forms.Label()
        Me.lblDCCorp6 = New System.Windows.Forms.Label()
        Me.chkDCCorp4 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp5 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp6 = New System.Windows.Forms.CheckBox()
        Me.txtDCStanding4 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding5 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding6 = New System.Windows.Forms.TextBox()
        Me.lblDCStanding2 = New System.Windows.Forms.Label()
        Me.gbDCCorpsGallente = New System.Windows.Forms.GroupBox()
        Me.lblDCCorpLabel3 = New System.Windows.Forms.Label()
        Me.lblDCCorp7 = New System.Windows.Forms.Label()
        Me.lblDCCorp8 = New System.Windows.Forms.Label()
        Me.lblDCCorp9 = New System.Windows.Forms.Label()
        Me.chkDCCorp7 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp8 = New System.Windows.Forms.CheckBox()
        Me.chkDCCorp9 = New System.Windows.Forms.CheckBox()
        Me.txtDCStanding7 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding8 = New System.Windows.Forms.TextBox()
        Me.txtDCStanding9 = New System.Windows.Forms.TextBox()
        Me.lblDCStanding3 = New System.Windows.Forms.Label()
        Me.btnDCRefresh = New System.Windows.Forms.Button()
        Me.tabManufacturing = New System.Windows.Forms.TabPage()
        Me.gbCalcBPSelectOptions = New System.Windows.Forms.GroupBox()
        Me.gbCalcIncludeNoTeam = New System.Windows.Forms.GroupBox()
        Me.chkCalcIncludeNoTeamComponents = New System.Windows.Forms.CheckBox()
        Me.chkCalcIncludeNoTeamCopy = New System.Windows.Forms.CheckBox()
        Me.chkCalcIncludeNoTeamInvention = New System.Windows.Forms.CheckBox()
        Me.chkCalcIncludeNoTeamManufacturing = New System.Windows.Forms.CheckBox()
        Me.gbIncludeItems = New System.Windows.Forms.GroupBox()
        Me.chkCalcCanRE = New System.Windows.Forms.CheckBox()
        Me.chkCalcCanInvent = New System.Windows.Forms.CheckBox()
        Me.chkCalcCanBuild = New System.Windows.Forms.CheckBox()
        Me.btnCalcSelectColumns = New System.Windows.Forms.Button()
        Me.gbSize = New System.Windows.Forms.GroupBox()
        Me.chkCalcXL = New System.Windows.Forms.CheckBox()
        Me.chkCalcLarge = New System.Windows.Forms.CheckBox()
        Me.chkCalcMedium = New System.Windows.Forms.CheckBox()
        Me.chkCalcSmall = New System.Windows.Forms.CheckBox()
        Me.gbCalcProdLines = New System.Windows.Forms.GroupBox()
        Me.chkCalcAutoCalcT2NumBPs = New System.Windows.Forms.CheckBox()
        Me.lblCalcBPs = New System.Windows.Forms.Label()
        Me.txtCalcNumBPs = New System.Windows.Forms.TextBox()
        Me.txtCalcRuns = New System.Windows.Forms.TextBox()
        Me.txtCalcLabLines = New System.Windows.Forms.TextBox()
        Me.lblCalcRuns = New System.Windows.Forms.Label()
        Me.lblCalcLabLines1 = New System.Windows.Forms.Label()
        Me.lblCalcProdLines1 = New System.Windows.Forms.Label()
        Me.txtCalcProdLines = New System.Windows.Forms.TextBox()
        Me.gbCalcCompareType = New System.Windows.Forms.GroupBox()
        Me.rbtnCalcCompareBuildBuy = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcCompareRawMats = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcCompareComponents = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcCompareAll = New System.Windows.Forms.RadioButton()
        Me.gbCalcTextColors = New System.Windows.Forms.GroupBox()
        Me.lblCalcText = New System.Windows.Forms.Label()
        Me.lblCalcColorCode3 = New System.Windows.Forms.Label()
        Me.lblCalcColorCode4 = New System.Windows.Forms.Label()
        Me.lblCalcColorCode5 = New System.Windows.Forms.Label()
        Me.lblCalcColorCode2 = New System.Windows.Forms.Label()
        Me.lblCalcColorCode1 = New System.Windows.Forms.Label()
        Me.gbCalcInvention = New System.Windows.Forms.GroupBox()
        Me.chkCalcDecryptorforT3 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptorforT2 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor0 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor9 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor8 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor7 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor6 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor5 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor4 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor3 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor2 = New System.Windows.Forms.CheckBox()
        Me.chkCalcDecryptor1 = New System.Windows.Forms.CheckBox()
        Me.lblCalcDecryptorUse = New System.Windows.Forms.Label()
        Me.gbBPRace = New System.Windows.Forms.GroupBox()
        Me.chkCalcRaceOther = New System.Windows.Forms.CheckBox()
        Me.chkCalcRacePirate = New System.Windows.Forms.CheckBox()
        Me.chkCalcRaceMinmatar = New System.Windows.Forms.CheckBox()
        Me.chkCalcRaceGallente = New System.Windows.Forms.CheckBox()
        Me.chkCalcRaceCaldari = New System.Windows.Forms.CheckBox()
        Me.chkCalcRaceAmarr = New System.Windows.Forms.CheckBox()
        Me.tabCalcFacilities = New System.Windows.Forms.TabControl()
        Me.tabCalcFacilityBase = New System.Windows.Forms.TabPage()
        Me.txtCalcBaseFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcBaseFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcBaseFacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcBaseFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcBaseFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcBaseFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcBaseFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcBaseFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcBaseFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcBaseFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcBaseFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcBaseFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcBaseFacilityType = New System.Windows.Forms.Label()
        Me.chkCalcBaseFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.cmbCalcBaseFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcBaseFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcBaseFacilityBonus = New System.Windows.Forms.Label()
        Me.cmbCalcPOSLargeShips = New System.Windows.Forms.ComboBox()
        Me.lblCalcPOSLargeShips = New System.Windows.Forms.Label()
        Me.cmbCalcPOSFuelBlocks = New System.Windows.Forms.ComboBox()
        Me.lblCalcPOSFuelBlocks = New System.Windows.Forms.Label()
        Me.cmbCalcPOSModules = New System.Windows.Forms.ComboBox()
        Me.lblCalcPOSModules = New System.Windows.Forms.Label()
        Me.tabCalcFacilityComponents = New System.Windows.Forms.TabPage()
        Me.txtCalcComponentFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcComponentFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcComponentFacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcComponentFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcComponentFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcComponentFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcComponentFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcComponentFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcComponentFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcComponentFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcComponentFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcComponentFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcComponentFacilityType = New System.Windows.Forms.Label()
        Me.chkCalcComponentFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.cmbCalcComponentFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcComponentFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcComponentFacilityBonus = New System.Windows.Forms.Label()
        Me.chkCalcCapComponentsFacility = New System.Windows.Forms.CheckBox()
        Me.tabCalcFacilityCopy = New System.Windows.Forms.TabPage()
        Me.txtCalcCopyFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcCopyFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcCopyInclude = New System.Windows.Forms.Label()
        Me.chkCalcCopyFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.chkCalcCopyFacilityIncludeTime = New System.Windows.Forms.CheckBox()
        Me.lblCalcCopyFacilityDefault = New System.Windows.Forms.Label()
        Me.chkCalcCopyFacilityIncludeCost = New System.Windows.Forms.CheckBox()
        Me.btnCalcCopyFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcCopyFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcCopyFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcCopyFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcCopyFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcCopyFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcCopyFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcCopyFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcCopyFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcCopyFacilityType = New System.Windows.Forms.Label()
        Me.cmbCalcCopyFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcCopyFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcCopyFacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilityT2Invention = New System.Windows.Forms.TabPage()
        Me.txtCalcInventionFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcInventionFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcInventionInclude = New System.Windows.Forms.Label()
        Me.chkCalcInventionFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.lblCalcInventionFacilityDefault = New System.Windows.Forms.Label()
        Me.chkCalcInventionFacilityIncludeTime = New System.Windows.Forms.CheckBox()
        Me.btnCalcInventionFacilitySave = New System.Windows.Forms.Button()
        Me.chkCalcInventionFacilityIncludeCost = New System.Windows.Forms.CheckBox()
        Me.lblCalcInventionFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcInventionFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcInventionFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcInventionFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcInventionFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcInventionFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcInventionFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcInventionFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcInventionFacilityType = New System.Windows.Forms.Label()
        Me.cmbCalcInventionFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcInventionFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcInventionFacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilityT3Invention = New System.Windows.Forms.TabPage()
        Me.txtCalcT3InventionFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcT3InventionFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcT3InventionInclude = New System.Windows.Forms.Label()
        Me.chkCalcT3InventionFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.lblCalcT3InventionFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcT3InventionFacilityDefault = New System.Windows.Forms.Label()
        Me.chkCalcT3InventionFacilityIncludeTime = New System.Windows.Forms.CheckBox()
        Me.btnCalcT3InventionFacilitySave = New System.Windows.Forms.Button()
        Me.chkCalcT3InventionFacilityIncludeCost = New System.Windows.Forms.CheckBox()
        Me.lblCalcT3InventionFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcT3InventionFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcT3InventionFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcT3InventionFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcT3InventionFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcT3InventionFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCalcT3InventionFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcT3InventionFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcT3InventionFacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilityCapitals = New System.Windows.Forms.TabPage()
        Me.txtCalcCapitalFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcCapitalFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcCapitalFacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcCapitalFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcCapitalFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcCapitalFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcCapitalFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcCapitalFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcCapitalFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcCapitalFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcCapitalFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcCapitalFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcCapitalFacilityType = New System.Windows.Forms.Label()
        Me.chkCalcCapitalFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.cmbCalcCapitalFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcCapitalFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcCapitalFacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilitySupers = New System.Windows.Forms.TabPage()
        Me.txtCalcSuperFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcSuperFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcSuperFacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcSuperFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcSuperFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcSuperFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcSuperFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcSuperFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcSuperFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcSuperFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcSuperFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcSuperFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcSuperFacilityType = New System.Windows.Forms.Label()
        Me.chkCalcSuperFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.cmbCalcSuperFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcSuperFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcSuperFacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilityT3Ships = New System.Windows.Forms.TabPage()
        Me.txtCalcT3FacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcT3FacilityManualTax = New System.Windows.Forms.Label()
        Me.chkCalcT3DestroyersFacility = New System.Windows.Forms.CheckBox()
        Me.lblCalcT3FacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcT3FacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcT3FacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcT3FacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcT3FacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcT3FacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcT3FacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcT3FacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcT3FacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcT3FacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcT3FacilityType = New System.Windows.Forms.Label()
        Me.chkCalcT3FacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.cmbCalcT3FacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcT3FacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcT3FacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilitySubsystems = New System.Windows.Forms.TabPage()
        Me.txtCalcSubsystemFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcSubsystemFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcSubsystemFacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcSubsystemFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcSubsystemFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcSubsystemFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcSubsystemFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcSubsystemFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcSubsystemFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcSubsystemFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcSubsystemFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcSubsystemFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcSubsystemFacilityType = New System.Windows.Forms.Label()
        Me.chkCalcSubsystemFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.cmbCalcSubsystemFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcSubsystemFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcSubsystemFacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilityBoosters = New System.Windows.Forms.TabPage()
        Me.txtCalcBoosterFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcBoosterFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcBoosterFacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcBoosterFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcBoosterFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtCalcBoosterFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcBoosterFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcBoosterFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcBoosterFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcBoosterFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcBoosterFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcBoosterFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcBoosterFacilityType = New System.Windows.Forms.Label()
        Me.chkCalcBoosterFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.cmbCalcBoosterFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcBoosterFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcBoosterFacilityBonus = New System.Windows.Forms.Label()
        Me.tabCalcFacilityNoPOS = New System.Windows.Forms.TabPage()
        Me.txtCalcNoPOSFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblCalcNoPOSFacilityManualTax = New System.Windows.Forms.Label()
        Me.lblCalcNoPOSFacilityDefault = New System.Windows.Forms.Label()
        Me.btnCalcNoPOSFacilitySave = New System.Windows.Forms.Button()
        Me.lblCalcNoPOSFacilityTaxRate = New System.Windows.Forms.Label()
        Me.chkCalcNoPOSFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.txtCalcNoPOSFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtCalcNoPOSFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbCalcNoPOSFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbCalcNoPOSFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbCalcNoPOSFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblCalcNoPOSFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblCalcNoPOSFacilityLocation = New System.Windows.Forms.Label()
        Me.lblCalcNoPOSFacilityType = New System.Windows.Forms.Label()
        Me.cmbCalcNoPOSFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblCalcNoPOSFacilityManualME = New System.Windows.Forms.Label()
        Me.lblCalcNoPOSFacilityBonus = New System.Windows.Forms.Label()
        Me.gbCalcFilter = New System.Windows.Forms.GroupBox()
        Me.cmbCalcBPTypeFilter = New System.Windows.Forms.ComboBox()
        Me.gbCalcBPTech = New System.Windows.Forms.GroupBox()
        Me.chkCalcPirateFaction = New System.Windows.Forms.CheckBox()
        Me.chkCalcStoryline = New System.Windows.Forms.CheckBox()
        Me.chkCalcNavyFaction = New System.Windows.Forms.CheckBox()
        Me.chkCalcT3 = New System.Windows.Forms.CheckBox()
        Me.chkCalcT2 = New System.Windows.Forms.CheckBox()
        Me.chkCalcT1 = New System.Windows.Forms.CheckBox()
        Me.gbCalcType = New System.Windows.Forms.GroupBox()
        Me.rbtnCalcSortSVRIPH = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcSortSVR = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcShowProfitPercent = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcProfit = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcIPH = New System.Windows.Forms.RadioButton()
        Me.gbCalcIncludeOwned = New System.Windows.Forms.GroupBox()
        Me.chkCalcIncludeT3Owned = New System.Windows.Forms.CheckBox()
        Me.chkCalcIncludeT2Owned = New System.Windows.Forms.CheckBox()
        Me.gbCalcAvgPrice = New System.Windows.Forms.GroupBox()
        Me.chkCalcSVRIncludeNull = New System.Windows.Forms.CheckBox()
        Me.lblCalcSVRRegion = New System.Windows.Forms.Label()
        Me.lblCalcAvgPrice = New System.Windows.Forms.Label()
        Me.cmbCalcSVRRegion = New System.Windows.Forms.ComboBox()
        Me.txtCalcSVRThreshold = New System.Windows.Forms.TextBox()
        Me.lblCalcSVRThreshold = New System.Windows.Forms.Label()
        Me.cmbCalcAvgPriceDuration = New System.Windows.Forms.ComboBox()
        Me.btnCalcSaveSettings = New System.Windows.Forms.Button()
        Me.gbIncludeTaxesFees = New System.Windows.Forms.GroupBox()
        Me.chkCalcFees = New System.Windows.Forms.CheckBox()
        Me.chkCalcTaxes = New System.Windows.Forms.CheckBox()
        Me.btnCalcExportList = New System.Windows.Forms.Button()
        Me.btnCalcPreview = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCalcReset = New System.Windows.Forms.Button()
        Me.gbCalcTextFilter = New System.Windows.Forms.GroupBox()
        Me.btnCalcResetTextSearch = New System.Windows.Forms.Button()
        Me.txtCalcItemFilter = New System.Windows.Forms.TextBox()
        Me.gbCalcBPType = New System.Windows.Forms.GroupBox()
        Me.chkCalcCelestials = New System.Windows.Forms.CheckBox()
        Me.chkCalcMisc = New System.Windows.Forms.CheckBox()
        Me.chkCalcSubsystems = New System.Windows.Forms.CheckBox()
        Me.chkCalcDeployables = New System.Windows.Forms.CheckBox()
        Me.chkCalcStructures = New System.Windows.Forms.CheckBox()
        Me.chkCalcStationParts = New System.Windows.Forms.CheckBox()
        Me.chkCalcBoosters = New System.Windows.Forms.CheckBox()
        Me.chkCalcRigs = New System.Windows.Forms.CheckBox()
        Me.chkCalcComponents = New System.Windows.Forms.CheckBox()
        Me.chkCalcAmmo = New System.Windows.Forms.CheckBox()
        Me.chkCalcDrones = New System.Windows.Forms.CheckBox()
        Me.chkCalcModules = New System.Windows.Forms.CheckBox()
        Me.chkCalcShips = New System.Windows.Forms.CheckBox()
        Me.gbCalcBPSelect = New System.Windows.Forms.GroupBox()
        Me.rbtnCalcBPFavorites = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcAllBPs = New System.Windows.Forms.RadioButton()
        Me.rbtnCalcBPOwned = New System.Windows.Forms.RadioButton()
        Me.gbCalcRelics = New System.Windows.Forms.GroupBox()
        Me.chkCalcRERelic2 = New System.Windows.Forms.CheckBox()
        Me.chkCalcRERelic3 = New System.Windows.Forms.CheckBox()
        Me.chkCalcRERelic1 = New System.Windows.Forms.CheckBox()
        Me.tabCalcTeams = New System.Windows.Forms.TabControl()
        Me.tabCalcTeamManufacturing = New System.Windows.Forms.TabPage()
        Me.txtCalcManufacturingTeamBonus = New System.Windows.Forms.TextBox()
        Me.btnCalcSaveManufacturingTeam = New System.Windows.Forms.Button()
        Me.cmbCalcManufacturingTeam = New System.Windows.Forms.ComboBox()
        Me.lblCalcManufacturingTeamDefault = New System.Windows.Forms.Label()
        Me.tabCalcTeamComponents = New System.Windows.Forms.TabPage()
        Me.txtCalcComponentManufacturingTeamBonus = New System.Windows.Forms.TextBox()
        Me.btnCalcSaveComponentManufacturingTeam = New System.Windows.Forms.Button()
        Me.cmbCalcComponentManufacturingTeam = New System.Windows.Forms.ComboBox()
        Me.lblCalcComponentManufacturingTeamDefault = New System.Windows.Forms.Label()
        Me.tabCalcTeamInvention = New System.Windows.Forms.TabPage()
        Me.txtCalcInventionTeamBonus = New System.Windows.Forms.TextBox()
        Me.btnCalcSaveInventionTeam = New System.Windows.Forms.Button()
        Me.cmbCalcInventionTeam = New System.Windows.Forms.ComboBox()
        Me.lblCalcInventionTeamDefault = New System.Windows.Forms.Label()
        Me.tabCalcTeamCopy = New System.Windows.Forms.TabPage()
        Me.btnCalcSaveCopyTeam = New System.Windows.Forms.Button()
        Me.cmbCalcCopyTeam = New System.Windows.Forms.ComboBox()
        Me.lblCalcCopyTeamDefault = New System.Windows.Forms.Label()
        Me.txtCalcCopyTeamBonus = New System.Windows.Forms.TextBox()
        Me.gbTempMEPE = New System.Windows.Forms.GroupBox()
        Me.txtCalcTempTE = New System.Windows.Forms.TextBox()
        Me.lblTempPE = New System.Windows.Forms.Label()
        Me.txtCalcTempME = New System.Windows.Forms.TextBox()
        Me.lblTempME = New System.Windows.Forms.Label()
        Me.lstManufacturing = New System.Windows.Forms.ListView()
        Me.tabUpdatePrices = New System.Windows.Forms.TabPage()
        Me.chkUpdatePricesCRESTHistory = New System.Windows.Forms.CheckBox()
        Me.chkUpdatePricesNoPrice = New System.Windows.Forms.CheckBox()
        Me.gbTradeHubSystems = New System.Windows.Forms.GroupBox()
        Me.cmbPriceSystems = New System.Windows.Forms.ComboBox()
        Me.chkSystems2 = New System.Windows.Forms.CheckBox()
        Me.chkSystems4 = New System.Windows.Forms.CheckBox()
        Me.chkSystems5 = New System.Windows.Forms.CheckBox()
        Me.chkSystems3 = New System.Windows.Forms.CheckBox()
        Me.chkSystems1 = New System.Windows.Forms.CheckBox()
        Me.txtPriceItemFilter = New System.Windows.Forms.TextBox()
        Me.chkSplitPrices = New System.Windows.Forms.CheckBox()
        Me.gbSplitPrices = New System.Windows.Forms.GroupBox()
        Me.cmbItemsSplitPrices = New System.Windows.Forms.ComboBox()
        Me.cmbRawMatsSplitPrices = New System.Windows.Forms.ComboBox()
        Me.lblItemsSplitPrices = New System.Windows.Forms.Label()
        Me.lblRawMatsSplitPrices = New System.Windows.Forms.Label()
        Me.btnSaveUpdatePrices = New System.Windows.Forms.Button()
        Me.btnEnterPrices = New System.Windows.Forms.Button()
        Me.btnClearItemFilter = New System.Windows.Forms.Button()
        Me.btnToggleAllPriceItems = New System.Windows.Forms.Button()
        Me.btnImportPrices = New System.Windows.Forms.Button()
        Me.lblItemFilter = New System.Windows.Forms.Label()
        Me.gbManufacturedItems = New System.Windows.Forms.GroupBox()
        Me.chkPriceManufacturedPrices = New System.Windows.Forms.CheckBox()
        Me.gbPriceTools = New System.Windows.Forms.GroupBox()
        Me.chkImplants = New System.Windows.Forms.CheckBox()
        Me.chkFuelBlocks = New System.Windows.Forms.CheckBox()
        Me.chkDataInterfaces = New System.Windows.Forms.CheckBox()
        Me.chkTools = New System.Windows.Forms.CheckBox()
        Me.gbComponents = New System.Windows.Forms.GroupBox()
        Me.chkHybrid = New System.Windows.Forms.CheckBox()
        Me.chkComponents = New System.Windows.Forms.CheckBox()
        Me.chkCapitalComponents = New System.Windows.Forms.CheckBox()
        Me.chkCapT2Components = New System.Windows.Forms.CheckBox()
        Me.gbItems = New System.Windows.Forms.GroupBox()
        Me.chkCelestials = New System.Windows.Forms.CheckBox()
        Me.chkDeployables = New System.Windows.Forms.CheckBox()
        Me.cmbPriceChargeTypes = New System.Windows.Forms.ComboBox()
        Me.chkStructures = New System.Windows.Forms.CheckBox()
        Me.chkStationComponents = New System.Windows.Forms.CheckBox()
        Me.chkCharges = New System.Windows.Forms.CheckBox()
        Me.chkBoosters = New System.Windows.Forms.CheckBox()
        Me.cmbPriceShipTypes = New System.Windows.Forms.ComboBox()
        Me.gbPricesTech = New System.Windows.Forms.GroupBox()
        Me.chkPricesT4 = New System.Windows.Forms.CheckBox()
        Me.chkPricesT6 = New System.Windows.Forms.CheckBox()
        Me.chkPricesT5 = New System.Windows.Forms.CheckBox()
        Me.chkPricesT3 = New System.Windows.Forms.CheckBox()
        Me.chkPricesT2 = New System.Windows.Forms.CheckBox()
        Me.chkPricesT1 = New System.Windows.Forms.CheckBox()
        Me.chkSubsystems = New System.Windows.Forms.CheckBox()
        Me.chkShips = New System.Windows.Forms.CheckBox()
        Me.chkModules = New System.Windows.Forms.CheckBox()
        Me.chkRigs = New System.Windows.Forms.CheckBox()
        Me.chkDrones = New System.Windows.Forms.CheckBox()
        Me.gbPrice = New System.Windows.Forms.GroupBox()
        Me.rbtnPercentileBuySell = New System.Windows.Forms.RadioButton()
        Me.rbtnPercentileBuy = New System.Windows.Forms.RadioButton()
        Me.rbtnPercentileSell = New System.Windows.Forms.RadioButton()
        Me.rbtnMedBuySell = New System.Windows.Forms.RadioButton()
        Me.rbtnAvgBuySell = New System.Windows.Forms.RadioButton()
        Me.rbtnMaxBuySell = New System.Windows.Forms.RadioButton()
        Me.rbtnMinBuySell = New System.Windows.Forms.RadioButton()
        Me.rbtnMedBuy = New System.Windows.Forms.RadioButton()
        Me.rbtnAvgBuy = New System.Windows.Forms.RadioButton()
        Me.rbtnMaxBuy = New System.Windows.Forms.RadioButton()
        Me.rbtnMinBuy = New System.Windows.Forms.RadioButton()
        Me.rbtnMedSell = New System.Windows.Forms.RadioButton()
        Me.rbtnAvgSell = New System.Windows.Forms.RadioButton()
        Me.rbtnMaxSell = New System.Windows.Forms.RadioButton()
        Me.rbtnMinSell = New System.Windows.Forms.RadioButton()
        Me.gbRawMaterials = New System.Windows.Forms.GroupBox()
        Me.chkMisc = New System.Windows.Forms.CheckBox()
        Me.chkAsteroids = New System.Windows.Forms.CheckBox()
        Me.chkPriceRawMaterialPrices = New System.Windows.Forms.CheckBox()
        Me.chkPlanetary = New System.Windows.Forms.CheckBox()
        Me.chkBoosterMats = New System.Windows.Forms.CheckBox()
        Me.chkDroneComponents = New System.Windows.Forms.CheckBox()
        Me.chkMatsandCompounds = New System.Windows.Forms.CheckBox()
        Me.chkAdvancedMats = New System.Windows.Forms.CheckBox()
        Me.chkProcessedMats = New System.Windows.Forms.CheckBox()
        Me.chkRawMats = New System.Windows.Forms.CheckBox()
        Me.chkGas = New System.Windows.Forms.CheckBox()
        Me.chkPolymers = New System.Windows.Forms.CheckBox()
        Me.chkAncientRelics = New System.Windows.Forms.CheckBox()
        Me.chkAncientSalvage = New System.Windows.Forms.CheckBox()
        Me.chkSalvage = New System.Windows.Forms.CheckBox()
        Me.chkDecryptors = New System.Windows.Forms.CheckBox()
        Me.chkDatacores = New System.Windows.Forms.CheckBox()
        Me.chkIceProducts = New System.Windows.Forms.CheckBox()
        Me.chkMinerals = New System.Windows.Forms.CheckBox()
        Me.gbRegions = New System.Windows.Forms.GroupBox()
        Me.chkRegion67 = New System.Windows.Forms.CheckBox()
        Me.chkRegion45 = New System.Windows.Forms.CheckBox()
        Me.chkRegion46 = New System.Windows.Forms.CheckBox()
        Me.chkRegion47 = New System.Windows.Forms.CheckBox()
        Me.chkRegion48 = New System.Windows.Forms.CheckBox()
        Me.chkRegion49 = New System.Windows.Forms.CheckBox()
        Me.chkRegion50 = New System.Windows.Forms.CheckBox()
        Me.chkRegion51 = New System.Windows.Forms.CheckBox()
        Me.chkRegion52 = New System.Windows.Forms.CheckBox()
        Me.chkRegion53 = New System.Windows.Forms.CheckBox()
        Me.chkRegion54 = New System.Windows.Forms.CheckBox()
        Me.chkRegion55 = New System.Windows.Forms.CheckBox()
        Me.chkRegion56 = New System.Windows.Forms.CheckBox()
        Me.chkRegion57 = New System.Windows.Forms.CheckBox()
        Me.chkRegion58 = New System.Windows.Forms.CheckBox()
        Me.chkRegion59 = New System.Windows.Forms.CheckBox()
        Me.chkRegion60 = New System.Windows.Forms.CheckBox()
        Me.chkRegion61 = New System.Windows.Forms.CheckBox()
        Me.chkRegion62 = New System.Windows.Forms.CheckBox()
        Me.chkRegion63 = New System.Windows.Forms.CheckBox()
        Me.chkRegion64 = New System.Windows.Forms.CheckBox()
        Me.chkRegion65 = New System.Windows.Forms.CheckBox()
        Me.chkRegion66 = New System.Windows.Forms.CheckBox()
        Me.chkRegion23 = New System.Windows.Forms.CheckBox()
        Me.chkRegion24 = New System.Windows.Forms.CheckBox()
        Me.chkRegion25 = New System.Windows.Forms.CheckBox()
        Me.chkRegion26 = New System.Windows.Forms.CheckBox()
        Me.chkRegion27 = New System.Windows.Forms.CheckBox()
        Me.chkRegion28 = New System.Windows.Forms.CheckBox()
        Me.chkRegion29 = New System.Windows.Forms.CheckBox()
        Me.chkRegion30 = New System.Windows.Forms.CheckBox()
        Me.chkRegion31 = New System.Windows.Forms.CheckBox()
        Me.chkRegion32 = New System.Windows.Forms.CheckBox()
        Me.chkRegion33 = New System.Windows.Forms.CheckBox()
        Me.chkRegion34 = New System.Windows.Forms.CheckBox()
        Me.chkRegion35 = New System.Windows.Forms.CheckBox()
        Me.chkRegion36 = New System.Windows.Forms.CheckBox()
        Me.chkRegion37 = New System.Windows.Forms.CheckBox()
        Me.chkRegion38 = New System.Windows.Forms.CheckBox()
        Me.chkRegion39 = New System.Windows.Forms.CheckBox()
        Me.chkRegion40 = New System.Windows.Forms.CheckBox()
        Me.chkRegion41 = New System.Windows.Forms.CheckBox()
        Me.chkRegion42 = New System.Windows.Forms.CheckBox()
        Me.chkRegion43 = New System.Windows.Forms.CheckBox()
        Me.chkRegion44 = New System.Windows.Forms.CheckBox()
        Me.chkRegion12 = New System.Windows.Forms.CheckBox()
        Me.chkRegion13 = New System.Windows.Forms.CheckBox()
        Me.chkRegion14 = New System.Windows.Forms.CheckBox()
        Me.chkRegion15 = New System.Windows.Forms.CheckBox()
        Me.chkRegion16 = New System.Windows.Forms.CheckBox()
        Me.chkRegion17 = New System.Windows.Forms.CheckBox()
        Me.chkRegion18 = New System.Windows.Forms.CheckBox()
        Me.chkRegion19 = New System.Windows.Forms.CheckBox()
        Me.chkRegion20 = New System.Windows.Forms.CheckBox()
        Me.chkRegion21 = New System.Windows.Forms.CheckBox()
        Me.chkRegion22 = New System.Windows.Forms.CheckBox()
        Me.chkRegion11 = New System.Windows.Forms.CheckBox()
        Me.chkRegion10 = New System.Windows.Forms.CheckBox()
        Me.chkRegion9 = New System.Windows.Forms.CheckBox()
        Me.chkRegion8 = New System.Windows.Forms.CheckBox()
        Me.chkRegion7 = New System.Windows.Forms.CheckBox()
        Me.chkRegion6 = New System.Windows.Forms.CheckBox()
        Me.chkRegion5 = New System.Windows.Forms.CheckBox()
        Me.chkRegion4 = New System.Windows.Forms.CheckBox()
        Me.chkRegion3 = New System.Windows.Forms.CheckBox()
        Me.chkRegion2 = New System.Windows.Forms.CheckBox()
        Me.chkRegion1 = New System.Windows.Forms.CheckBox()
        Me.btnCheckNullLowRegions = New System.Windows.Forms.Button()
        Me.btnCheckEmpireRegions = New System.Windows.Forms.Button()
        Me.btnCheckNoRegions = New System.Windows.Forms.Button()
        Me.btnCheckAllRegions = New System.Windows.Forms.Button()
        Me.tabBlueprints = New System.Windows.Forms.TabPage()
        Me.btnBPForward = New System.Windows.Forms.Button()
        Me.btnBPBack = New System.Windows.Forms.Button()
        Me.gbFilters = New System.Windows.Forms.GroupBox()
        Me.chkBPXL = New System.Windows.Forms.CheckBox()
        Me.chkBPLarge = New System.Windows.Forms.CheckBox()
        Me.chkBPMedium = New System.Windows.Forms.CheckBox()
        Me.chkBPSmall = New System.Windows.Forms.CheckBox()
        Me.gbBPBlueprintType = New System.Windows.Forms.GroupBox()
        Me.rbtnBPCelestialsBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPMiscBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPStructureBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPFavoriteBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPStationPartsBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPOwnedBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPRigBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPBoosterBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPSubsystemBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPModuleBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPAmmoChargeBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPDroneBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPComponentBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPAllBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPShipBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPDeployableBlueprints = New System.Windows.Forms.RadioButton()
        Me.lblBPSelectBlueprint = New System.Windows.Forms.Label()
        Me.gbBPInventionStats = New System.Windows.Forms.GroupBox()
        Me.lblBPTotalUnits = New System.Windows.Forms.Label()
        Me.lblBPTaxes = New System.Windows.Forms.Label()
        Me.lblBPTotalUnits1 = New System.Windows.Forms.Label()
        Me.lblBPBrokerFees = New System.Windows.Forms.Label()
        Me.lblBPPT = New System.Windows.Forms.Label()
        Me.chkBPTaxes = New System.Windows.Forms.CheckBox()
        Me.lblBPMarketCost = New System.Windows.Forms.Label()
        Me.lblBPMarketCost1 = New System.Windows.Forms.Label()
        Me.lblBPRawTotalCost = New System.Windows.Forms.Label()
        Me.lblBPCompProfit = New System.Windows.Forms.Label()
        Me.lblBPRawTotalCost1 = New System.Windows.Forms.Label()
        Me.chkBPBrokerFees = New System.Windows.Forms.CheckBox()
        Me.lblBPCompIPH = New System.Windows.Forms.Label()
        Me.lblBPRawIPH = New System.Windows.Forms.Label()
        Me.lblBPTotalCompCost1 = New System.Windows.Forms.Label()
        Me.lblBPCompIPH1 = New System.Windows.Forms.Label()
        Me.lblBPTotalItemPT = New System.Windows.Forms.Label()
        Me.lblBPTotalCompCost = New System.Windows.Forms.Label()
        Me.lblBPCPTPT = New System.Windows.Forms.Label()
        Me.lblBPRawSVR = New System.Windows.Forms.Label()
        Me.lblBPRawIPH1 = New System.Windows.Forms.Label()
        Me.lblBPRawProfit = New System.Windows.Forms.Label()
        Me.lblBPBPSVR = New System.Windows.Forms.Label()
        Me.lblBPCompProfit1 = New System.Windows.Forms.Label()
        Me.lblBPRawProfit1 = New System.Windows.Forms.Label()
        Me.lblBPProductionTime = New System.Windows.Forms.Label()
        Me.lblBPBPSVR1 = New System.Windows.Forms.Label()
        Me.lblBPRawSVR1 = New System.Windows.Forms.Label()
        Me.chkBPPricePerUnit = New System.Windows.Forms.CheckBox()
        Me.lblBPBuyColor = New System.Windows.Forms.Label()
        Me.lblBPBuildColor = New System.Windows.Forms.Label()
        Me.gbBPMEPEImage = New System.Windows.Forms.GroupBox()
        Me.btnBPSaveBP = New System.Windows.Forms.Button()
        Me.tabBPInventionEquip = New System.Windows.Forms.TabControl()
        Me.tabFacility = New System.Windows.Forms.TabPage()
        Me.txtBPFacilityManualTax = New System.Windows.Forms.TextBox()
        Me.lblBPFacilityManualTax = New System.Windows.Forms.Label()
        Me.cmbBPFacilityType = New System.Windows.Forms.ComboBox()
        Me.lblBPFacilityDefault = New System.Windows.Forms.Label()
        Me.lblBPFacilityActivity = New System.Windows.Forms.Label()
        Me.cmbBPFacilityActivities = New System.Windows.Forms.ComboBox()
        Me.btnBPFacilitySave = New System.Windows.Forms.Button()
        Me.lblBPFacilityTaxRate = New System.Windows.Forms.Label()
        Me.txtBPFacilityManualTE = New System.Windows.Forms.TextBox()
        Me.txtBPFacilityManualME = New System.Windows.Forms.TextBox()
        Me.cmbBPFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.lblBPFacilityUsage = New System.Windows.Forms.Label()
        Me.cmbBPFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbBPFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.lblBPFacilityManualTE = New System.Windows.Forms.Label()
        Me.lblBPFacilityLocation = New System.Windows.Forms.Label()
        Me.lblBPFacility = New System.Windows.Forms.Label()
        Me.chkBPFacilityIncludeUsage = New System.Windows.Forms.CheckBox()
        Me.lblBPFacilityManualME = New System.Windows.Forms.Label()
        Me.lblBPFacilityBonus = New System.Windows.Forms.Label()
        Me.tabInventionCalcs = New System.Windows.Forms.TabPage()
        Me.lblBPCopyTime = New System.Windows.Forms.Label()
        Me.lblBPT2InventStatus = New System.Windows.Forms.Label()
        Me.lblBPCopyCosts = New System.Windows.Forms.Label()
        Me.txtBPInventionLines = New System.Windows.Forms.TextBox()
        Me.lblBPInventionLines = New System.Windows.Forms.Label()
        Me.lblInventionChance1 = New System.Windows.Forms.Label()
        Me.lblBPDecryptor = New System.Windows.Forms.Label()
        Me.lblBPInventionTime = New System.Windows.Forms.Label()
        Me.lblBPDecryptorStats = New System.Windows.Forms.Label()
        Me.lblBPInventionCost = New System.Windows.Forms.Label()
        Me.cmbBPInventionDecryptor = New System.Windows.Forms.ComboBox()
        Me.lblBPInventionChance = New System.Windows.Forms.Label()
        Me.chkBPIncludeInventionTime = New System.Windows.Forms.CheckBox()
        Me.chkBPIncludeCopyTime = New System.Windows.Forms.CheckBox()
        Me.chkBPIncludeCopyCosts = New System.Windows.Forms.CheckBox()
        Me.chkBPIncludeInventionCosts = New System.Windows.Forms.CheckBox()
        Me.tabT3Calcs = New System.Windows.Forms.TabPage()
        Me.lblBPT3Decryptor = New System.Windows.Forms.Label()
        Me.cmbBPT3Decryptor = New System.Windows.Forms.ComboBox()
        Me.lblBPT3Stats = New System.Windows.Forms.Label()
        Me.lblBPRelic = New System.Windows.Forms.Label()
        Me.txtBPRelicLines = New System.Windows.Forms.TextBox()
        Me.lblBPRelicLines = New System.Windows.Forms.Label()
        Me.lblBPRETime = New System.Windows.Forms.Label()
        Me.cmbBPRelic = New System.Windows.Forms.ComboBox()
        Me.lblBPRECost = New System.Windows.Forms.Label()
        Me.lblBPT3InventionChance = New System.Windows.Forms.Label()
        Me.lblBPT3InventionChance1 = New System.Windows.Forms.Label()
        Me.lblT3InventStatus = New System.Windows.Forms.Label()
        Me.chkBPIncludeT3Time = New System.Windows.Forms.CheckBox()
        Me.chkBPIncludeT3Costs = New System.Windows.Forms.CheckBox()
        Me.btnBPSaveSettings = New System.Windows.Forms.Button()
        Me.txtBPLines = New System.Windows.Forms.TextBox()
        Me.pictBP = New System.Windows.Forms.PictureBox()
        Me.txtBPNumBPs = New System.Windows.Forms.TextBox()
        Me.btnBPRefreshBP = New System.Windows.Forms.Button()
        Me.lblBPLines = New System.Windows.Forms.Label()
        Me.txtBPME = New System.Windows.Forms.TextBox()
        Me.lblBPRuns = New System.Windows.Forms.Label()
        Me.gbBPTeam = New System.Windows.Forms.GroupBox()
        Me.txtBPTeamBonus = New System.Windows.Forms.TextBox()
        Me.cmbBPTeam = New System.Windows.Forms.ComboBox()
        Me.lblBPDefaultTeam = New System.Windows.Forms.Label()
        Me.btnBPSaveTeam = New System.Windows.Forms.Button()
        Me.cmbBPTeamActivities = New System.Windows.Forms.ComboBox()
        Me.chkBPBuildBuy = New System.Windows.Forms.CheckBox()
        Me.txtBPRuns = New System.Windows.Forms.TextBox()
        Me.txtBPAddlCosts = New System.Windows.Forms.TextBox()
        Me.lblBPAddlCosts = New System.Windows.Forms.Label()
        Me.lblBPME = New System.Windows.Forms.Label()
        Me.txtBPTE = New System.Windows.Forms.TextBox()
        Me.lblBPPE = New System.Windows.Forms.Label()
        Me.lblBPNumBPs = New System.Windows.Forms.Label()
        Me.gbBPShopandCopy = New System.Windows.Forms.GroupBox()
        Me.rbtnBPCopyInvREMats = New System.Windows.Forms.RadioButton()
        Me.rbtnBPComponentCopy = New System.Windows.Forms.RadioButton()
        Me.rbtnBPRawmatCopy = New System.Windows.Forms.RadioButton()
        Me.btnBPCopyMatstoClip = New System.Windows.Forms.Button()
        Me.btnBPAddBPMatstoShoppingList = New System.Windows.Forms.Button()
        Me.lblBPCanMakeBPAll = New System.Windows.Forms.Label()
        Me.lblBPRawMatCost = New System.Windows.Forms.Label()
        Me.lblBPRawMatCost1 = New System.Windows.Forms.Label()
        Me.lblBPCanMakeBP = New System.Windows.Forms.Label()
        Me.lblBPRawMats = New System.Windows.Forms.Label()
        Me.lblBPComponentMatCost = New System.Windows.Forms.Label()
        Me.lblBPComponentMats = New System.Windows.Forms.Label()
        Me.lblBPComponentMatCost1 = New System.Windows.Forms.Label()
        Me.gbBPBlueprintTech = New System.Windows.Forms.GroupBox()
        Me.chkBPPirateFaction = New System.Windows.Forms.CheckBox()
        Me.chkBPStoryline = New System.Windows.Forms.CheckBox()
        Me.chkBPNavyFaction = New System.Windows.Forms.CheckBox()
        Me.chkBPT3 = New System.Windows.Forms.CheckBox()
        Me.chkBPT2 = New System.Windows.Forms.CheckBox()
        Me.chkBPT1 = New System.Windows.Forms.CheckBox()
        Me.cmbBPBlueprintSelection = New System.Windows.Forms.ComboBox()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabPI = New System.Windows.Forms.TabPage()
        Me.btnPISaveSettings = New System.Windows.Forms.Button()
        Me.gbPIPlanets = New System.Windows.Forms.GroupBox()
        Me.chkPILava = New System.Windows.Forms.CheckBox()
        Me.chkPIPlasma = New System.Windows.Forms.CheckBox()
        Me.chkPIIce = New System.Windows.Forms.CheckBox()
        Me.chkPIGas = New System.Windows.Forms.CheckBox()
        Me.chkPIOcean = New System.Windows.Forms.CheckBox()
        Me.chkPIBarren = New System.Windows.Forms.CheckBox()
        Me.chkPIStorm = New System.Windows.Forms.CheckBox()
        Me.chkPITemperate = New System.Windows.Forms.CheckBox()
        Me.btnPIReset = New System.Windows.Forms.Button()
        Me.cmbCalcManufacturingTeamActivity = New System.Windows.Forms.ComboBox()
        Me.ListOptionsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenMarketDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstBPComponentMats = New EVE_Isk_per_Hour.MyListView()
        Me.lstBPRawMats = New EVE_Isk_per_Hour.MyListView()
        Me.lstPricesView = New EVE_Isk_per_Hour.MyListView()
        Me.MyListView6 = New EVE_Isk_per_Hour.MyListView()
        Me.MyListView5 = New EVE_Isk_per_Hour.MyListView()
        Me.MyListView4 = New EVE_Isk_per_Hour.MyListView()
        Me.MyListView3 = New EVE_Isk_per_Hour.MyListView()
        Me.MyListView2 = New EVE_Isk_per_Hour.MyListView()
        Me.MyListView1 = New EVE_Isk_per_Hour.MyListView()
        Me.mnuStripMain.SuspendLayout
        Me.pnlMain.SuspendLayout
        Me.tabMining.SuspendLayout
        Me.gbMineOreProcessingType.SuspendLayout
        Me.gbMineTaxBroker.SuspendLayout
        Me.gbMineStripStats.SuspendLayout
        Me.gbMineMiningDroneM3.SuspendLayout
        Me.gbMineJumpCosts.SuspendLayout
        Me.gbMineHauling.SuspendLayout
        Me.gbMineBooster.SuspendLayout
        CType(Me.pictMineLaserOptmize,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pictMineRangeLink,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pictMineFleetBoostShip,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMineRefining.SuspendLayout
        Me.gbMineStationYield.SuspendLayout
        Me.gbMineBaseRefineSkills.SuspendLayout
        Me.gbMineShipSetup.SuspendLayout
        Me.gbMineSelectShip.SuspendLayout
        CType(Me.pictMineSelectedShip,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbMineShipEquipment.SuspendLayout
        Me.gbMiningRigs.SuspendLayout
        Me.gbMineCrystals.SuspendLayout
        Me.gbMineSkills.SuspendLayout
        Me.gbMineMain.SuspendLayout
        Me.gbMineIncludeOres.SuspendLayout
        Me.gbMineOreLocSov.SuspendLayout
        Me.gbMineWHSpace.SuspendLayout
        Me.tabReactions.SuspendLayout
        Me.gbReactionsTaxesFees.SuspendLayout
        Me.gbReactionsSelectedMats.SuspendLayout
        Me.gbReactions.SuspendLayout
        Me.gbReactionsHybrid.SuspendLayout
        Me.gbReactionsBiochem.SuspendLayout
        Me.gbReactionsOptions.SuspendLayout
        Me.gbReactionsMoonMats.SuspendLayout
        Me.tabDatacores.SuspendLayout
        Me.gbDCOptions.SuspendLayout
        Me.gbDCAgentLocSov.SuspendLayout
        Me.gbDCTotalIPH.SuspendLayout
        Me.gbDCPrices.SuspendLayout
        Me.gbDCAgentTypes.SuspendLayout
        Me.gbDCBaseSkills.SuspendLayout
        Me.gbDCDatacores.SuspendLayout
        Me.gbDCCodes.SuspendLayout
        Me.gbDCCorpMinmatar.SuspendLayout
        Me.gbDCCorpAmarr.SuspendLayout
        Me.gbDCCorpsCaldari.SuspendLayout
        Me.gbDCCorpsGallente.SuspendLayout
        Me.tabManufacturing.SuspendLayout
        Me.gbCalcBPSelectOptions.SuspendLayout
        Me.gbCalcIncludeNoTeam.SuspendLayout
        Me.gbIncludeItems.SuspendLayout
        Me.gbSize.SuspendLayout
        Me.gbCalcProdLines.SuspendLayout
        Me.gbCalcCompareType.SuspendLayout
        Me.gbCalcTextColors.SuspendLayout
        Me.gbCalcInvention.SuspendLayout
        Me.gbBPRace.SuspendLayout
        Me.tabCalcFacilities.SuspendLayout
        Me.tabCalcFacilityBase.SuspendLayout
        Me.tabCalcFacilityComponents.SuspendLayout
        Me.tabCalcFacilityCopy.SuspendLayout
        Me.tabCalcFacilityT2Invention.SuspendLayout
        Me.tabCalcFacilityT3Invention.SuspendLayout
        Me.tabCalcFacilityCapitals.SuspendLayout
        Me.tabCalcFacilitySupers.SuspendLayout
        Me.tabCalcFacilityT3Ships.SuspendLayout
        Me.tabCalcFacilitySubsystems.SuspendLayout
        Me.tabCalcFacilityBoosters.SuspendLayout
        Me.tabCalcFacilityNoPOS.SuspendLayout
        Me.gbCalcFilter.SuspendLayout
        Me.gbCalcBPTech.SuspendLayout
        Me.gbCalcType.SuspendLayout
        Me.gbCalcIncludeOwned.SuspendLayout
        Me.gbCalcAvgPrice.SuspendLayout
        Me.gbIncludeTaxesFees.SuspendLayout
        Me.gbCalcTextFilter.SuspendLayout
        Me.gbCalcBPType.SuspendLayout
        Me.gbCalcBPSelect.SuspendLayout
        Me.gbCalcRelics.SuspendLayout
        Me.tabCalcTeams.SuspendLayout
        Me.tabCalcTeamManufacturing.SuspendLayout
        Me.tabCalcTeamComponents.SuspendLayout
        Me.tabCalcTeamInvention.SuspendLayout
        Me.tabCalcTeamCopy.SuspendLayout
        Me.gbTempMEPE.SuspendLayout
        Me.tabUpdatePrices.SuspendLayout
        Me.gbTradeHubSystems.SuspendLayout
        Me.gbSplitPrices.SuspendLayout
        Me.gbManufacturedItems.SuspendLayout
        Me.gbPriceTools.SuspendLayout
        Me.gbComponents.SuspendLayout
        Me.gbItems.SuspendLayout
        Me.gbPricesTech.SuspendLayout
        Me.gbPrice.SuspendLayout
        Me.gbRawMaterials.SuspendLayout
        Me.gbRegions.SuspendLayout
        Me.tabBlueprints.SuspendLayout
        Me.gbFilters.SuspendLayout
        Me.gbBPBlueprintType.SuspendLayout
        Me.gbBPInventionStats.SuspendLayout
        Me.gbBPMEPEImage.SuspendLayout
        Me.tabBPInventionEquip.SuspendLayout
        Me.tabFacility.SuspendLayout
        Me.tabInventionCalcs.SuspendLayout
        Me.tabT3Calcs.SuspendLayout
        CType(Me.pictBP,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbBPTeam.SuspendLayout
        Me.gbBPShopandCopy.SuspendLayout
        Me.gbBPBlueprintTech.SuspendLayout
        Me.tabMain.SuspendLayout
        Me.tabPI.SuspendLayout
        Me.gbPIPlanets.SuspendLayout
        Me.ListOptionsMenu.SuspendLayout
        Me.SuspendLayout
        '
        'mnuStripMain
        '
        Me.mnuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuUpdateData, Me.ViewToolStripMenuItem, Me.mnuSettings, Me.mnuTools, Me.mnuAbout})
        Me.mnuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripMain.Name = "mnuStripMain"
        Me.mnuStripMain.Size = New System.Drawing.Size(1146, 24)
        Me.mnuStripMain.TabIndex = 0
        Me.mnuStripMain.Text = "MainMenu"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSelectionAddChar, Me.mnuSelectionManageAPI, Me.ToolStripSeparator1, Me.mnuSelectionExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuSelectionAddChar
        '
        Me.mnuSelectionAddChar.Name = "mnuSelectionAddChar"
        Me.mnuSelectionAddChar.Size = New System.Drawing.Size(170, 22)
        Me.mnuSelectionAddChar.Text = "Add Characters"
        '
        'mnuSelectionManageAPI
        '
        Me.mnuSelectionManageAPI.Name = "mnuSelectionManageAPI"
        Me.mnuSelectionManageAPI.Size = New System.Drawing.Size(170, 22)
        Me.mnuSelectionManageAPI.Text = "Manage Accounts"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'mnuSelectionExit
        '
        Me.mnuSelectionExit.Name = "mnuSelectionExit"
        Me.mnuSelectionExit.Size = New System.Drawing.Size(170, 22)
        Me.mnuSelectionExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemUpdatePrices, Me.SetPOSDataToolStripMenuItem, Me.mnuManageBlueprintsToolStripMenuItem})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuItemUpdatePrices
        '
        Me.mnuItemUpdatePrices.Name = "mnuItemUpdatePrices"
        Me.mnuItemUpdatePrices.Size = New System.Drawing.Size(173, 22)
        Me.mnuItemUpdatePrices.Text = "Prices"
        '
        'SetPOSDataToolStripMenuItem
        '
        Me.SetPOSDataToolStripMenuItem.Name = "SetPOSDataToolStripMenuItem"
        Me.SetPOSDataToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SetPOSDataToolStripMenuItem.Text = "POS Data"
        Me.SetPOSDataToolStripMenuItem.Visible = false
        '
        'mnuManageBlueprintsToolStripMenuItem
        '
        Me.mnuManageBlueprintsToolStripMenuItem.Name = "mnuManageBlueprintsToolStripMenuItem"
        Me.mnuManageBlueprintsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.mnuManageBlueprintsToolStripMenuItem.Text = "Manage Blueprints"
        '
        'mnuUpdateData
        '
        Me.mnuUpdateData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUpdateCRESTTeams, Me.mnuUpdateIndustryFacilities, Me.mnuUpdateCRESTMarketPrices, Me.ToolStripSeparator6, Me.mnuResetData})
        Me.mnuUpdateData.Name = "mnuUpdateData"
        Me.mnuUpdateData.Size = New System.Drawing.Size(43, 20)
        Me.mnuUpdateData.Text = "Data"
        '
        'mnuUpdateCRESTTeams
        '
        Me.mnuUpdateCRESTTeams.Enabled = false
        Me.mnuUpdateCRESTTeams.Name = "mnuUpdateCRESTTeams"
        Me.mnuUpdateCRESTTeams.Size = New System.Drawing.Size(206, 22)
        Me.mnuUpdateCRESTTeams.Text = "Update Teams"
        '
        'mnuUpdateIndustryFacilities
        '
        Me.mnuUpdateIndustryFacilities.Name = "mnuUpdateIndustryFacilities"
        Me.mnuUpdateIndustryFacilities.Size = New System.Drawing.Size(206, 22)
        Me.mnuUpdateIndustryFacilities.Text = "Update Industry Facilities"
        '
        'mnuUpdateCRESTMarketPrices
        '
        Me.mnuUpdateCRESTMarketPrices.Name = "mnuUpdateCRESTMarketPrices"
        Me.mnuUpdateCRESTMarketPrices.Size = New System.Drawing.Size(206, 22)
        Me.mnuUpdateCRESTMarketPrices.Text = "Update Market Prices"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(203, 6)
        '
        'mnuResetData
        '
        Me.mnuResetData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResetBlueprintData, Me.mnuResetPriceData, Me.mnuResetAgents, Me.mnuResetIndustryJobs, Me.mnuResetAssets, Me.mnuResetCRESTDates, Me.ToolStripSeparator4, Me.mnuResetAllData})
        Me.mnuResetData.Name = "mnuResetData"
        Me.mnuResetData.Size = New System.Drawing.Size(206, 22)
        Me.mnuResetData.Text = "Reset Data"
        '
        'mnuResetBlueprintData
        '
        Me.mnuResetBlueprintData.Name = "mnuResetBlueprintData"
        Me.mnuResetBlueprintData.Size = New System.Drawing.Size(224, 22)
        Me.mnuResetBlueprintData.Text = "Reset Blueprint Data"
        '
        'mnuResetPriceData
        '
        Me.mnuResetPriceData.Name = "mnuResetPriceData"
        Me.mnuResetPriceData.Size = New System.Drawing.Size(224, 22)
        Me.mnuResetPriceData.Text = "Reset Price Data"
        '
        'mnuResetAgents
        '
        Me.mnuResetAgents.Name = "mnuResetAgents"
        Me.mnuResetAgents.Size = New System.Drawing.Size(224, 22)
        Me.mnuResetAgents.Text = "Reset Research Agents"
        '
        'mnuResetIndustryJobs
        '
        Me.mnuResetIndustryJobs.Name = "mnuResetIndustryJobs"
        Me.mnuResetIndustryJobs.Size = New System.Drawing.Size(224, 22)
        Me.mnuResetIndustryJobs.Text = "Reset Industry Jobs"
        '
        'mnuResetAssets
        '
        Me.mnuResetAssets.Name = "mnuResetAssets"
        Me.mnuResetAssets.Size = New System.Drawing.Size(224, 22)
        Me.mnuResetAssets.Text = "Reset Assets"
        '
        'mnuResetCRESTDates
        '
        Me.mnuResetCRESTDates.Name = "mnuResetCRESTDates"
        Me.mnuResetCRESTDates.Size = New System.Drawing.Size(224, 22)
        Me.mnuResetCRESTDates.Text = "Reset All CREST Cache Dates"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(221, 6)
        '
        'mnuResetAllData
        '
        Me.mnuResetAllData.Name = "mnuResetAllData"
        Me.mnuResetAllData.Size = New System.Drawing.Size(224, 22)
        Me.mnuResetAllData.Text = "Reset All Data"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSelectionShoppingList, Me.mnuViewAssets, Me.mnuCharacterSkills, Me.mnuCharacterStandings, Me.ToolStripSeparator5, Me.mnuCurrentResearchAgents, Me.mnuCurrentIndustryJobs})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'mnuSelectionShoppingList
        '
        Me.mnuSelectionShoppingList.Name = "mnuSelectionShoppingList"
        Me.mnuSelectionShoppingList.Size = New System.Drawing.Size(204, 22)
        Me.mnuSelectionShoppingList.Text = "Shopping List"
        '
        'mnuViewAssets
        '
        Me.mnuViewAssets.Name = "mnuViewAssets"
        Me.mnuViewAssets.Size = New System.Drawing.Size(204, 22)
        Me.mnuViewAssets.Text = "Assets"
        '
        'mnuCharacterSkills
        '
        Me.mnuCharacterSkills.Name = "mnuCharacterSkills"
        Me.mnuCharacterSkills.Size = New System.Drawing.Size(204, 22)
        Me.mnuCharacterSkills.Text = "Character Skills"
        '
        'mnuCharacterStandings
        '
        Me.mnuCharacterStandings.Name = "mnuCharacterStandings"
        Me.mnuCharacterStandings.Size = New System.Drawing.Size(204, 22)
        Me.mnuCharacterStandings.Text = "Character Standings"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(201, 6)
        '
        'mnuCurrentResearchAgents
        '
        Me.mnuCurrentResearchAgents.Name = "mnuCurrentResearchAgents"
        Me.mnuCurrentResearchAgents.Size = New System.Drawing.Size(204, 22)
        Me.mnuCurrentResearchAgents.Text = "Current Research Agents"
        '
        'mnuCurrentIndustryJobs
        '
        Me.mnuCurrentIndustryJobs.Name = "mnuCurrentIndustryJobs"
        Me.mnuCurrentIndustryJobs.Size = New System.Drawing.Size(204, 22)
        Me.mnuCurrentIndustryJobs.Text = "Current Industry Jobs"
        '
        'mnuSettings
        '
        Me.mnuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSaveCurrentTabSettings, Me.mnuRestoreDefaultTabSettings, Me.mnuSelectDefaultChar, Me.mnuUserSettings})
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnuSettings.Text = "Settings"
        '
        'mnuSaveCurrentTabSettings
        '
        Me.mnuSaveCurrentTabSettings.Name = "mnuSaveCurrentTabSettings"
        Me.mnuSaveCurrentTabSettings.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
        Me.mnuSaveCurrentTabSettings.Size = New System.Drawing.Size(249, 22)
        Me.mnuSaveCurrentTabSettings.Text = "Save Current Tab Settings"
        '
        'mnuRestoreDefaultTabSettings
        '
        Me.mnuRestoreDefaultTabSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRestoreDefaultBP, Me.mnuRestoreDefaultUpdatePrices, Me.mnuRestoreDefaultManufacturing, Me.mnuRestoreDefaultDatacores, Me.mnuRestoreDefaultReactions, Me.mnuRestoreDefaultMining})
        Me.mnuRestoreDefaultTabSettings.Name = "mnuRestoreDefaultTabSettings"
        Me.mnuRestoreDefaultTabSettings.Size = New System.Drawing.Size(249, 22)
        Me.mnuRestoreDefaultTabSettings.Text = "Restore Default Tab Settings"
        '
        'mnuRestoreDefaultBP
        '
        Me.mnuRestoreDefaultBP.Name = "mnuRestoreDefaultBP"
        Me.mnuRestoreDefaultBP.Size = New System.Drawing.Size(153, 22)
        Me.mnuRestoreDefaultBP.Text = "Blueprints"
        '
        'mnuRestoreDefaultUpdatePrices
        '
        Me.mnuRestoreDefaultUpdatePrices.Name = "mnuRestoreDefaultUpdatePrices"
        Me.mnuRestoreDefaultUpdatePrices.Size = New System.Drawing.Size(153, 22)
        Me.mnuRestoreDefaultUpdatePrices.Text = "Update Prices"
        '
        'mnuRestoreDefaultManufacturing
        '
        Me.mnuRestoreDefaultManufacturing.Name = "mnuRestoreDefaultManufacturing"
        Me.mnuRestoreDefaultManufacturing.Size = New System.Drawing.Size(153, 22)
        Me.mnuRestoreDefaultManufacturing.Text = "Manufacturing"
        '
        'mnuRestoreDefaultDatacores
        '
        Me.mnuRestoreDefaultDatacores.Name = "mnuRestoreDefaultDatacores"
        Me.mnuRestoreDefaultDatacores.Size = New System.Drawing.Size(153, 22)
        Me.mnuRestoreDefaultDatacores.Text = "Datacores"
        '
        'mnuRestoreDefaultReactions
        '
        Me.mnuRestoreDefaultReactions.Name = "mnuRestoreDefaultReactions"
        Me.mnuRestoreDefaultReactions.Size = New System.Drawing.Size(153, 22)
        Me.mnuRestoreDefaultReactions.Text = "Reactions"
        '
        'mnuRestoreDefaultMining
        '
        Me.mnuRestoreDefaultMining.Name = "mnuRestoreDefaultMining"
        Me.mnuRestoreDefaultMining.Size = New System.Drawing.Size(153, 22)
        Me.mnuRestoreDefaultMining.Text = "Mining"
        '
        'mnuSelectDefaultChar
        '
        Me.mnuSelectDefaultChar.Name = "mnuSelectDefaultChar"
        Me.mnuSelectDefaultChar.Size = New System.Drawing.Size(249, 22)
        Me.mnuSelectDefaultChar.Text = "Select Default Character"
        '
        'mnuUserSettings
        '
        Me.mnuUserSettings.Name = "mnuUserSettings"
        Me.mnuUserSettings.Size = New System.Drawing.Size(249, 22)
        Me.mnuUserSettings.Text = "Select Application Settings"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInventionSuccessMonitor, Me.mnuIndustryUpgradeBelts, Me.mnuRefinery})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(48, 20)
        Me.mnuTools.Text = "Tools"
        '
        'mnuInventionSuccessMonitor
        '
        Me.mnuInventionSuccessMonitor.Name = "mnuInventionSuccessMonitor"
        Me.mnuInventionSuccessMonitor.Size = New System.Drawing.Size(214, 22)
        Me.mnuInventionSuccessMonitor.Text = "Invention Success Monitor"
        Me.mnuInventionSuccessMonitor.Visible = false
        '
        'mnuIndustryUpgradeBelts
        '
        Me.mnuIndustryUpgradeBelts.Name = "mnuIndustryUpgradeBelts"
        Me.mnuIndustryUpgradeBelts.Size = New System.Drawing.Size(214, 22)
        Me.mnuIndustryUpgradeBelts.Text = "Industry Upgrade Belts"
        '
        'mnuRefinery
        '
        Me.mnuRefinery.Name = "mnuRefinery"
        Me.mnuRefinery.Size = New System.Drawing.Size(214, 22)
        Me.mnuRefinery.Text = "Refinery"
        '
        'mnuAbout
        '
        Me.mnuAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPatchNotes, Me.mnuCheckforUpdates, Me.ToolStripSeparator2, Me.mnuSelectionAbout})
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "About"
        '
        'mnuPatchNotes
        '
        Me.mnuPatchNotes.Name = "mnuPatchNotes"
        Me.mnuPatchNotes.Size = New System.Drawing.Size(171, 22)
        Me.mnuPatchNotes.Text = "View Patch Notes"
        '
        'mnuCheckforUpdates
        '
        Me.mnuCheckforUpdates.Name = "mnuCheckforUpdates"
        Me.mnuCheckforUpdates.Size = New System.Drawing.Size(171, 22)
        Me.mnuCheckforUpdates.Text = "Check for Updates"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'mnuSelectionAbout
        '
        Me.mnuSelectionAbout.Name = "mnuSelectionAbout"
        Me.mnuSelectionAbout.Size = New System.Drawing.Size(171, 22)
        Me.mnuSelectionAbout.Text = "About IPH"
        '
        'pnlMain
        '
        Me.pnlMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pnlCharacter, Me.pnlSkills, Me.pnlShoppingList, Me.pnlStatus, Me.pnlProgressBar})
        Me.pnlMain.Location = New System.Drawing.Point(0, 670)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1146, 22)
        Me.pnlMain.TabIndex = 1
        Me.pnlMain.Text = "pnlMain"
        '
        'pnlCharacter
        '
        Me.pnlCharacter.AutoSize = false
        Me.pnlCharacter.Name = "pnlCharacter"
        Me.pnlCharacter.Size = New System.Drawing.Size(250, 17)
        Me.pnlCharacter.Text = "Character Loaded:"
        Me.pnlCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSkills
        '
        Me.pnlSkills.AutoSize = false
        Me.pnlSkills.Name = "pnlSkills"
        Me.pnlSkills.Size = New System.Drawing.Size(90, 17)
        Me.pnlSkills.Text = "Skills Overidden"
        Me.pnlSkills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlShoppingList
        '
        Me.pnlShoppingList.AutoSize = false
        Me.pnlShoppingList.Name = "pnlShoppingList"
        Me.pnlShoppingList.Size = New System.Drawing.Size(200, 17)
        Me.pnlShoppingList.ToolTipText = "Click to Open Shopping List"
        '
        'pnlStatus
        '
        Me.pnlStatus.AutoSize = false
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(215, 17)
        Me.pnlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlProgressBar
        '
        Me.pnlProgressBar.AutoSize = false
        Me.pnlProgressBar.Name = "pnlProgressBar"
        Me.pnlProgressBar.Size = New System.Drawing.Size(363, 16)
        Me.pnlProgressBar.Step = 1
        Me.pnlProgressBar.Visible = false
        '
        'txtListEdit
        '
        Me.txtListEdit.Location = New System.Drawing.Point(1032, 4)
        Me.txtListEdit.Name = "txtListEdit"
        Me.txtListEdit.Size = New System.Drawing.Size(48, 20)
        Me.txtListEdit.TabIndex = 59
        Me.txtListEdit.TabStop = false
        Me.txtListEdit.Visible = false
        '
        'ttMain
        '
        Me.ttMain.IsBalloon = true
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'gbSystems
        '
        Me.gbSystems.Location = New System.Drawing.Point(0, 0)
        Me.gbSystems.Name = "gbSystems"
        Me.gbSystems.Size = New System.Drawing.Size(200, 100)
        Me.gbSystems.TabIndex = 0
        Me.gbSystems.TabStop = false
        '
        'tabMining
        '
        Me.tabMining.Controls.Add(Me.gbMineOreProcessingType)
        Me.tabMining.Controls.Add(Me.btnMineSaveAllSettings)
        Me.tabMining.Controls.Add(Me.gbMineTaxBroker)
        Me.tabMining.Controls.Add(Me.gbMineStripStats)
        Me.tabMining.Controls.Add(Me.gbMineMiningDroneM3)
        Me.tabMining.Controls.Add(Me.chkMineUseFleetBooster)
        Me.tabMining.Controls.Add(Me.gbMineJumpCosts)
        Me.tabMining.Controls.Add(Me.btnMineReset)
        Me.tabMining.Controls.Add(Me.gbMineHauling)
        Me.tabMining.Controls.Add(Me.btnMineRefresh)
        Me.tabMining.Controls.Add(Me.gbMineBooster)
        Me.tabMining.Controls.Add(Me.gbMineRefining)
        Me.tabMining.Controls.Add(Me.gbMineShipSetup)
        Me.tabMining.Controls.Add(Me.gbMineMain)
        Me.tabMining.Controls.Add(Me.lstMineGrid)
        Me.tabMining.Location = New System.Drawing.Point(4, 22)
        Me.tabMining.Name = "tabMining"
        Me.tabMining.Size = New System.Drawing.Size(1137, 615)
        Me.tabMining.TabIndex = 5
        Me.tabMining.Text = "Mining"
        Me.tabMining.UseVisualStyleBackColor = true
        '
        'gbMineOreProcessingType
        '
        Me.gbMineOreProcessingType.Controls.Add(Me.chkMineUnrefinedOre)
        Me.gbMineOreProcessingType.Controls.Add(Me.chkMineRefinedOre)
        Me.gbMineOreProcessingType.Controls.Add(Me.chkMineCompressedOre)
        Me.gbMineOreProcessingType.Location = New System.Drawing.Point(580, 156)
        Me.gbMineOreProcessingType.Name = "gbMineOreProcessingType"
        Me.gbMineOreProcessingType.Size = New System.Drawing.Size(125, 117)
        Me.gbMineOreProcessingType.TabIndex = 118
        Me.gbMineOreProcessingType.TabStop = false
        Me.gbMineOreProcessingType.Text = "Ore Processing Types"
        '
        'chkMineUnrefinedOre
        '
        Me.chkMineUnrefinedOre.AutoSize = true
        Me.chkMineUnrefinedOre.BackColor = System.Drawing.Color.White
        Me.chkMineUnrefinedOre.Location = New System.Drawing.Point(13, 50)
        Me.chkMineUnrefinedOre.Name = "chkMineUnrefinedOre"
        Me.chkMineUnrefinedOre.Size = New System.Drawing.Size(92, 17)
        Me.chkMineUnrefinedOre.TabIndex = 118
        Me.chkMineUnrefinedOre.Text = "Unrefined Ore"
        Me.chkMineUnrefinedOre.UseVisualStyleBackColor = false
        '
        'chkMineRefinedOre
        '
        Me.chkMineRefinedOre.AutoSize = true
        Me.chkMineRefinedOre.BackColor = System.Drawing.Color.White
        Me.chkMineRefinedOre.Location = New System.Drawing.Point(13, 27)
        Me.chkMineRefinedOre.Name = "chkMineRefinedOre"
        Me.chkMineRefinedOre.Size = New System.Drawing.Size(83, 17)
        Me.chkMineRefinedOre.TabIndex = 19
        Me.chkMineRefinedOre.Text = "Refined Ore"
        Me.chkMineRefinedOre.UseVisualStyleBackColor = false
        '
        'chkMineCompressedOre
        '
        Me.chkMineCompressedOre.AutoSize = true
        Me.chkMineCompressedOre.BackColor = System.Drawing.Color.White
        Me.chkMineCompressedOre.Location = New System.Drawing.Point(13, 73)
        Me.chkMineCompressedOre.Name = "chkMineCompressedOre"
        Me.chkMineCompressedOre.Size = New System.Drawing.Size(104, 17)
        Me.chkMineCompressedOre.TabIndex = 117
        Me.chkMineCompressedOre.Text = "Compressed Ore"
        Me.chkMineCompressedOre.UseVisualStyleBackColor = false
        '
        'btnMineSaveAllSettings
        '
        Me.btnMineSaveAllSettings.Location = New System.Drawing.Point(580, 101)
        Me.btnMineSaveAllSettings.Name = "btnMineSaveAllSettings"
        Me.btnMineSaveAllSettings.Size = New System.Drawing.Size(125, 36)
        Me.btnMineSaveAllSettings.TabIndex = 3
        Me.btnMineSaveAllSettings.Text = "Save Settings"
        Me.btnMineSaveAllSettings.UseVisualStyleBackColor = true
        '
        'gbMineTaxBroker
        '
        Me.gbMineTaxBroker.Controls.Add(Me.chkMineIncludeTaxes)
        Me.gbMineTaxBroker.Controls.Add(Me.chkMineIncludeBrokerFees)
        Me.gbMineTaxBroker.Location = New System.Drawing.Point(1057, 255)
        Me.gbMineTaxBroker.Name = "gbMineTaxBroker"
        Me.gbMineTaxBroker.Size = New System.Drawing.Size(72, 69)
        Me.gbMineTaxBroker.TabIndex = 7
        Me.gbMineTaxBroker.TabStop = false
        Me.gbMineTaxBroker.Text = "Include:"
        '
        'chkMineIncludeTaxes
        '
        Me.chkMineIncludeTaxes.AutoSize = true
        Me.chkMineIncludeTaxes.Checked = true
        Me.chkMineIncludeTaxes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMineIncludeTaxes.Location = New System.Drawing.Point(10, 44)
        Me.chkMineIncludeTaxes.Name = "chkMineIncludeTaxes"
        Me.chkMineIncludeTaxes.Size = New System.Drawing.Size(55, 17)
        Me.chkMineIncludeTaxes.TabIndex = 1
        Me.chkMineIncludeTaxes.Text = "Taxes"
        Me.chkMineIncludeTaxes.UseVisualStyleBackColor = true
        '
        'chkMineIncludeBrokerFees
        '
        Me.chkMineIncludeBrokerFees.Checked = true
        Me.chkMineIncludeBrokerFees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMineIncludeBrokerFees.Location = New System.Drawing.Point(10, 11)
        Me.chkMineIncludeBrokerFees.Name = "chkMineIncludeBrokerFees"
        Me.chkMineIncludeBrokerFees.Size = New System.Drawing.Size(61, 36)
        Me.chkMineIncludeBrokerFees.TabIndex = 0
        Me.chkMineIncludeBrokerFees.Text = "Broker Fees"
        Me.chkMineIncludeBrokerFees.UseVisualStyleBackColor = true
        '
        'gbMineStripStats
        '
        Me.gbMineStripStats.Controls.Add(Me.lblMineRange)
        Me.gbMineStripStats.Controls.Add(Me.lblMineCycleTime1)
        Me.gbMineStripStats.Controls.Add(Me.lblMineRange1)
        Me.gbMineStripStats.Controls.Add(Me.lblMineCycleTime)
        Me.gbMineStripStats.Location = New System.Drawing.Point(711, 255)
        Me.gbMineStripStats.Name = "gbMineStripStats"
        Me.gbMineStripStats.Size = New System.Drawing.Size(140, 69)
        Me.gbMineStripStats.TabIndex = 5
        Me.gbMineStripStats.TabStop = false
        Me.gbMineStripStats.Text = "Miner Stats:"
        '
        'lblMineRange
        '
        Me.lblMineRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMineRange.Location = New System.Drawing.Point(79, 42)
        Me.lblMineRange.Name = "lblMineRange"
        Me.lblMineRange.Size = New System.Drawing.Size(53, 18)
        Me.lblMineRange.TabIndex = 135
        Me.lblMineRange.Text = "99.99 km"
        Me.lblMineRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMineCycleTime1
        '
        Me.lblMineCycleTime1.AutoSize = true
        Me.lblMineCycleTime1.Location = New System.Drawing.Point(9, 21)
        Me.lblMineCycleTime1.Name = "lblMineCycleTime1"
        Me.lblMineCycleTime1.Size = New System.Drawing.Size(62, 13)
        Me.lblMineCycleTime1.TabIndex = 132
        Me.lblMineCycleTime1.Text = "Cycle Time:"
        '
        'lblMineRange1
        '
        Me.lblMineRange1.AutoSize = true
        Me.lblMineRange1.Location = New System.Drawing.Point(9, 45)
        Me.lblMineRange1.Name = "lblMineRange1"
        Me.lblMineRange1.Size = New System.Drawing.Size(71, 13)
        Me.lblMineRange1.TabIndex = 134
        Me.lblMineRange1.Text = "Laser Range:"
        '
        'lblMineCycleTime
        '
        Me.lblMineCycleTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMineCycleTime.Location = New System.Drawing.Point(79, 18)
        Me.lblMineCycleTime.Name = "lblMineCycleTime"
        Me.lblMineCycleTime.Size = New System.Drawing.Size(53, 18)
        Me.lblMineCycleTime.TabIndex = 133
        Me.lblMineCycleTime.Text = "999.99 s"
        Me.lblMineCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbMineMiningDroneM3
        '
        Me.gbMineMiningDroneM3.Controls.Add(Me.lblMineMiningDroneM3)
        Me.gbMineMiningDroneM3.Controls.Add(Me.txtMineMiningDroneM3)
        Me.gbMineMiningDroneM3.Location = New System.Drawing.Point(408, 110)
        Me.gbMineMiningDroneM3.Name = "gbMineMiningDroneM3"
        Me.gbMineMiningDroneM3.Size = New System.Drawing.Size(166, 42)
        Me.gbMineMiningDroneM3.TabIndex = 2
        Me.gbMineMiningDroneM3.TabStop = false
        '
        'lblMineMiningDroneM3
        '
        Me.lblMineMiningDroneM3.Location = New System.Drawing.Point(7, 9)
        Me.lblMineMiningDroneM3.Name = "lblMineMiningDroneM3"
        Me.lblMineMiningDroneM3.Size = New System.Drawing.Size(75, 30)
        Me.lblMineMiningDroneM3.TabIndex = 9
        Me.lblMineMiningDroneM3.Text = "Mining Drone Yield (m3/Hr):"
        '
        'txtMineMiningDroneM3
        '
        Me.txtMineMiningDroneM3.Location = New System.Drawing.Point(84, 14)
        Me.txtMineMiningDroneM3.MaxLength = 5
        Me.txtMineMiningDroneM3.Name = "txtMineMiningDroneM3"
        Me.txtMineMiningDroneM3.Size = New System.Drawing.Size(78, 20)
        Me.txtMineMiningDroneM3.TabIndex = 3
        Me.txtMineMiningDroneM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkMineUseFleetBooster
        '
        Me.chkMineUseFleetBooster.AutoSize = true
        Me.chkMineUseFleetBooster.BackColor = System.Drawing.Color.White
        Me.chkMineUseFleetBooster.Location = New System.Drawing.Point(14, 155)
        Me.chkMineUseFleetBooster.Name = "chkMineUseFleetBooster"
        Me.chkMineUseFleetBooster.Size = New System.Drawing.Size(110, 17)
        Me.chkMineUseFleetBooster.TabIndex = 0
        Me.chkMineUseFleetBooster.Text = "Use Fleet Booster"
        Me.chkMineUseFleetBooster.UseVisualStyleBackColor = false
        '
        'gbMineJumpCosts
        '
        Me.gbMineJumpCosts.Controls.Add(Me.rbtnMineJumpMinerals)
        Me.gbMineJumpCosts.Controls.Add(Me.rbtnMineJumpCompress)
        Me.gbMineJumpCosts.Controls.Add(Me.chkMineIncludeJumpCosts)
        Me.gbMineJumpCosts.Controls.Add(Me.lblMineTotalJumpFuel)
        Me.gbMineJumpCosts.Controls.Add(Me.txtMineTotalJumpFuel)
        Me.gbMineJumpCosts.Controls.Add(Me.lblMineTotalJumpM3)
        Me.gbMineJumpCosts.Controls.Add(Me.txtMineTotalJumpM3)
        Me.gbMineJumpCosts.Location = New System.Drawing.Point(408, 8)
        Me.gbMineJumpCosts.Name = "gbMineJumpCosts"
        Me.gbMineJumpCosts.Size = New System.Drawing.Size(166, 101)
        Me.gbMineJumpCosts.TabIndex = 1
        Me.gbMineJumpCosts.TabStop = false
        Me.gbMineJumpCosts.Text = "Jump Fuel Costs:"
        '
        'rbtnMineJumpMinerals
        '
        Me.rbtnMineJumpMinerals.AutoSize = true
        Me.rbtnMineJumpMinerals.Location = New System.Drawing.Point(100, 78)
        Me.rbtnMineJumpMinerals.Name = "rbtnMineJumpMinerals"
        Me.rbtnMineJumpMinerals.Size = New System.Drawing.Size(64, 17)
        Me.rbtnMineJumpMinerals.TabIndex = 4
        Me.rbtnMineJumpMinerals.TabStop = true
        Me.rbtnMineJumpMinerals.Text = "Minerals"
        Me.rbtnMineJumpMinerals.UseVisualStyleBackColor = true
        '
        'rbtnMineJumpCompress
        '
        Me.rbtnMineJumpCompress.AutoSize = true
        Me.rbtnMineJumpCompress.Location = New System.Drawing.Point(10, 78)
        Me.rbtnMineJumpCompress.Name = "rbtnMineJumpCompress"
        Me.rbtnMineJumpCompress.Size = New System.Drawing.Size(91, 17)
        Me.rbtnMineJumpCompress.TabIndex = 3
        Me.rbtnMineJumpCompress.TabStop = true
        Me.rbtnMineJumpCompress.Text = "Compress Ore"
        Me.rbtnMineJumpCompress.UseVisualStyleBackColor = true
        '
        'chkMineIncludeJumpCosts
        '
        Me.chkMineIncludeJumpCosts.AutoSize = true
        Me.chkMineIncludeJumpCosts.Location = New System.Drawing.Point(10, 15)
        Me.chkMineIncludeJumpCosts.Name = "chkMineIncludeJumpCosts"
        Me.chkMineIncludeJumpCosts.Size = New System.Drawing.Size(141, 17)
        Me.chkMineIncludeJumpCosts.TabIndex = 0
        Me.chkMineIncludeJumpCosts.Text = "Include Jump Fuel Costs"
        Me.chkMineIncludeJumpCosts.UseVisualStyleBackColor = true
        '
        'lblMineTotalJumpFuel
        '
        Me.lblMineTotalJumpFuel.AutoSize = true
        Me.lblMineTotalJumpFuel.Location = New System.Drawing.Point(2, 38)
        Me.lblMineTotalJumpFuel.Name = "lblMineTotalJumpFuel"
        Me.lblMineTotalJumpFuel.Size = New System.Drawing.Size(81, 13)
        Me.lblMineTotalJumpFuel.TabIndex = 8
        Me.lblMineTotalJumpFuel.Text = "Total Fuel Cost:"
        '
        'txtMineTotalJumpFuel
        '
        Me.txtMineTotalJumpFuel.Location = New System.Drawing.Point(5, 52)
        Me.txtMineTotalJumpFuel.Name = "txtMineTotalJumpFuel"
        Me.txtMineTotalJumpFuel.Size = New System.Drawing.Size(77, 20)
        Me.txtMineTotalJumpFuel.TabIndex = 1
        Me.txtMineTotalJumpFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMineTotalJumpM3
        '
        Me.lblMineTotalJumpM3.AutoSize = true
        Me.lblMineTotalJumpM3.Location = New System.Drawing.Point(82, 38)
        Me.lblMineTotalJumpM3.Name = "lblMineTotalJumpM3"
        Me.lblMineTotalJumpM3.Size = New System.Drawing.Size(51, 13)
        Me.lblMineTotalJumpM3.TabIndex = 6
        Me.lblMineTotalJumpM3.Text = "Total m3:"
        '
        'txtMineTotalJumpM3
        '
        Me.txtMineTotalJumpM3.Location = New System.Drawing.Point(85, 52)
        Me.txtMineTotalJumpM3.Name = "txtMineTotalJumpM3"
        Me.txtMineTotalJumpM3.Size = New System.Drawing.Size(77, 20)
        Me.txtMineTotalJumpM3.TabIndex = 2
        Me.txtMineTotalJumpM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMineReset
        '
        Me.btnMineReset.Location = New System.Drawing.Point(580, 57)
        Me.btnMineReset.Name = "btnMineReset"
        Me.btnMineReset.Size = New System.Drawing.Size(125, 36)
        Me.btnMineReset.TabIndex = 2
        Me.btnMineReset.Text = "Reset"
        Me.btnMineReset.UseVisualStyleBackColor = true
        '
        'gbMineHauling
        '
        Me.gbMineHauling.Controls.Add(Me.lblMineHaulerM3)
        Me.gbMineHauling.Controls.Add(Me.txtMineHaulerM3)
        Me.gbMineHauling.Controls.Add(Me.lblMineRTSec)
        Me.gbMineHauling.Controls.Add(Me.chkMineUseHauler)
        Me.gbMineHauling.Controls.Add(Me.lblMineRTMin)
        Me.gbMineHauling.Controls.Add(Me.txtMineRTMin)
        Me.gbMineHauling.Controls.Add(Me.txtMineRTSec)
        Me.gbMineHauling.Controls.Add(Me.lblMineRoundTripTime)
        Me.gbMineHauling.Location = New System.Drawing.Point(856, 255)
        Me.gbMineHauling.Name = "gbMineHauling"
        Me.gbMineHauling.Size = New System.Drawing.Size(195, 69)
        Me.gbMineHauling.TabIndex = 6
        Me.gbMineHauling.TabStop = false
        Me.gbMineHauling.Text = "Hauling:"
        '
        'lblMineHaulerM3
        '
        Me.lblMineHaulerM3.AutoSize = true
        Me.lblMineHaulerM3.Location = New System.Drawing.Point(8, 43)
        Me.lblMineHaulerM3.Name = "lblMineHaulerM3"
        Me.lblMineHaulerM3.Size = New System.Drawing.Size(24, 13)
        Me.lblMineHaulerM3.TabIndex = 7
        Me.lblMineHaulerM3.Text = "m3:"
        '
        'txtMineHaulerM3
        '
        Me.txtMineHaulerM3.Location = New System.Drawing.Point(32, 40)
        Me.txtMineHaulerM3.Name = "txtMineHaulerM3"
        Me.txtMineHaulerM3.Size = New System.Drawing.Size(58, 20)
        Me.txtMineHaulerM3.TabIndex = 1
        '
        'lblMineRTSec
        '
        Me.lblMineRTSec.AutoSize = true
        Me.lblMineRTSec.Location = New System.Drawing.Point(151, 27)
        Me.lblMineRTSec.Name = "lblMineRTSec"
        Me.lblMineRTSec.Size = New System.Drawing.Size(29, 13)
        Me.lblMineRTSec.TabIndex = 5
        Me.lblMineRTSec.Text = "Sec:"
        '
        'chkMineUseHauler
        '
        Me.chkMineUseHauler.AutoSize = true
        Me.chkMineUseHauler.Location = New System.Drawing.Point(11, 21)
        Me.chkMineUseHauler.Name = "chkMineUseHauler"
        Me.chkMineUseHauler.Size = New System.Drawing.Size(79, 17)
        Me.chkMineUseHauler.TabIndex = 0
        Me.chkMineUseHauler.Text = "Use Hauler"
        Me.chkMineUseHauler.UseVisualStyleBackColor = true
        '
        'lblMineRTMin
        '
        Me.lblMineRTMin.AutoSize = true
        Me.lblMineRTMin.Location = New System.Drawing.Point(101, 27)
        Me.lblMineRTMin.Name = "lblMineRTMin"
        Me.lblMineRTMin.Size = New System.Drawing.Size(27, 13)
        Me.lblMineRTMin.TabIndex = 4
        Me.lblMineRTMin.Text = "Min:"
        '
        'txtMineRTMin
        '
        Me.txtMineRTMin.Location = New System.Drawing.Point(93, 40)
        Me.txtMineRTMin.Name = "txtMineRTMin"
        Me.txtMineRTMin.Size = New System.Drawing.Size(43, 20)
        Me.txtMineRTMin.TabIndex = 2
        Me.txtMineRTMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMineRTSec
        '
        Me.txtMineRTSec.Location = New System.Drawing.Point(144, 40)
        Me.txtMineRTSec.Name = "txtMineRTSec"
        Me.txtMineRTSec.Size = New System.Drawing.Size(43, 20)
        Me.txtMineRTSec.TabIndex = 3
        Me.txtMineRTSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMineRoundTripTime
        '
        Me.lblMineRoundTripTime.AutoSize = true
        Me.lblMineRoundTripTime.Location = New System.Drawing.Point(80, 11)
        Me.lblMineRoundTripTime.Name = "lblMineRoundTripTime"
        Me.lblMineRoundTripTime.Size = New System.Drawing.Size(111, 13)
        Me.lblMineRoundTripTime.TabIndex = 1
        Me.lblMineRoundTripTime.Text = "Round Trip to Station:"
        Me.lblMineRoundTripTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMineRefresh
        '
        Me.btnMineRefresh.Location = New System.Drawing.Point(580, 13)
        Me.btnMineRefresh.Name = "btnMineRefresh"
        Me.btnMineRefresh.Size = New System.Drawing.Size(125, 36)
        Me.btnMineRefresh.TabIndex = 1
        Me.btnMineRefresh.Text = "Calculate"
        Me.btnMineRefresh.UseVisualStyleBackColor = true
        '
        'gbMineBooster
        '
        Me.gbMineBooster.Controls.Add(Me.pictMineLaserOptmize)
        Me.gbMineBooster.Controls.Add(Me.pictMineRangeLink)
        Me.gbMineBooster.Controls.Add(Me.pictMineFleetBoostShip)
        Me.gbMineBooster.Controls.Add(Me.chkMineForemanLaserRangeBoost)
        Me.gbMineBooster.Controls.Add(Me.cmbMineIndustReconfig)
        Me.gbMineBooster.Controls.Add(Me.lblMineIndustrialReconfig)
        Me.gbMineBooster.Controls.Add(Me.chkMineRorqDeployedMode)
        Me.gbMineBooster.Controls.Add(Me.cmbMineWarfareLinkSpec)
        Me.gbMineBooster.Controls.Add(Me.lblMineWarfareLinkSpec)
        Me.gbMineBooster.Controls.Add(Me.cmbMineBoosterShipSkill)
        Me.gbMineBooster.Controls.Add(Me.chkMineForemanMindlink)
        Me.gbMineBooster.Controls.Add(Me.cmbMineBoosterShip)
        Me.gbMineBooster.Controls.Add(Me.cmbMineMiningDirector)
        Me.gbMineBooster.Controls.Add(Me.chkMineForemanLaserOpBoost)
        Me.gbMineBooster.Controls.Add(Me.lblMineMiningDirector)
        Me.gbMineBooster.Controls.Add(Me.cmbMineMiningForeman)
        Me.gbMineBooster.Controls.Add(Me.lblMineFleetBoosterShip)
        Me.gbMineBooster.Controls.Add(Me.lblMineMiningForeman)
        Me.gbMineBooster.Controls.Add(Me.lblMineBoosterShipSkill)
        Me.gbMineBooster.Location = New System.Drawing.Point(6, 156)
        Me.gbMineBooster.Name = "gbMineBooster"
        Me.gbMineBooster.Size = New System.Drawing.Size(568, 117)
        Me.gbMineBooster.TabIndex = 3
        Me.gbMineBooster.TabStop = false
        '
        'pictMineLaserOptmize
        '
        Me.pictMineLaserOptmize.Location = New System.Drawing.Point(525, 64)
        Me.pictMineLaserOptmize.Name = "pictMineLaserOptmize"
        Me.pictMineLaserOptmize.Size = New System.Drawing.Size(32, 32)
        Me.pictMineLaserOptmize.TabIndex = 139
        Me.pictMineLaserOptmize.TabStop = false
        '
        'pictMineRangeLink
        '
        Me.pictMineRangeLink.Location = New System.Drawing.Point(525, 24)
        Me.pictMineRangeLink.Name = "pictMineRangeLink"
        Me.pictMineRangeLink.Size = New System.Drawing.Size(32, 32)
        Me.pictMineRangeLink.TabIndex = 138
        Me.pictMineRangeLink.TabStop = false
        '
        'pictMineFleetBoostShip
        '
        Me.pictMineFleetBoostShip.BackColor = System.Drawing.Color.White
        Me.pictMineFleetBoostShip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictMineFleetBoostShip.Location = New System.Drawing.Point(179, 17)
        Me.pictMineFleetBoostShip.Name = "pictMineFleetBoostShip"
        Me.pictMineFleetBoostShip.Size = New System.Drawing.Size(68, 69)
        Me.pictMineFleetBoostShip.TabIndex = 137
        Me.pictMineFleetBoostShip.TabStop = false
        '
        'chkMineForemanLaserRangeBoost
        '
        Me.chkMineForemanLaserRangeBoost.Location = New System.Drawing.Point(394, 18)
        Me.chkMineForemanLaserRangeBoost.Name = "chkMineForemanLaserRangeBoost"
        Me.chkMineForemanLaserRangeBoost.Size = New System.Drawing.Size(132, 44)
        Me.chkMineForemanLaserRangeBoost.TabIndex = 9
        Me.chkMineForemanLaserRangeBoost.Text = "Mining Foreman Link - Mining Laser Field Enhancement "
        Me.chkMineForemanLaserRangeBoost.ThreeState = true
        Me.chkMineForemanLaserRangeBoost.UseVisualStyleBackColor = true
        '
        'cmbMineIndustReconfig
        '
        Me.cmbMineIndustReconfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineIndustReconfig.FormattingEnabled = true
        Me.cmbMineIndustReconfig.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineIndustReconfig.Location = New System.Drawing.Point(342, 87)
        Me.cmbMineIndustReconfig.Name = "cmbMineIndustReconfig"
        Me.cmbMineIndustReconfig.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineIndustReconfig.TabIndex = 8
        '
        'lblMineIndustrialReconfig
        '
        Me.lblMineIndustrialReconfig.AutoSize = true
        Me.lblMineIndustrialReconfig.Location = New System.Drawing.Point(211, 90)
        Me.lblMineIndustrialReconfig.Name = "lblMineIndustrialReconfig"
        Me.lblMineIndustrialReconfig.Size = New System.Drawing.Size(130, 13)
        Me.lblMineIndustrialReconfig.TabIndex = 135
        Me.lblMineIndustrialReconfig.Text = "Industrial Reconfiguration:"
        Me.lblMineIndustrialReconfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkMineRorqDeployedMode
        '
        Me.chkMineRorqDeployedMode.AutoSize = true
        Me.chkMineRorqDeployedMode.Location = New System.Drawing.Point(18, 87)
        Me.chkMineRorqDeployedMode.Name = "chkMineRorqDeployedMode"
        Me.chkMineRorqDeployedMode.Size = New System.Drawing.Size(152, 17)
        Me.chkMineRorqDeployedMode.TabIndex = 4
        Me.chkMineRorqDeployedMode.Text = "Rorqual in Deployed Mode"
        Me.chkMineRorqDeployedMode.UseVisualStyleBackColor = true
        '
        'cmbMineWarfareLinkSpec
        '
        Me.cmbMineWarfareLinkSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineWarfareLinkSpec.FormattingEnabled = true
        Me.cmbMineWarfareLinkSpec.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineWarfareLinkSpec.Location = New System.Drawing.Point(342, 64)
        Me.cmbMineWarfareLinkSpec.Name = "cmbMineWarfareLinkSpec"
        Me.cmbMineWarfareLinkSpec.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineWarfareLinkSpec.TabIndex = 7
        '
        'lblMineWarfareLinkSpec
        '
        Me.lblMineWarfareLinkSpec.Location = New System.Drawing.Point(255, 67)
        Me.lblMineWarfareLinkSpec.Name = "lblMineWarfareLinkSpec"
        Me.lblMineWarfareLinkSpec.Size = New System.Drawing.Size(86, 13)
        Me.lblMineWarfareLinkSpec.TabIndex = 132
        Me.lblMineWarfareLinkSpec.Text = "War Link Spec:"
        Me.lblMineWarfareLinkSpec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMineBoosterShipSkill
        '
        Me.cmbMineBoosterShipSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineBoosterShipSkill.FormattingEnabled = true
        Me.cmbMineBoosterShipSkill.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineBoosterShipSkill.Location = New System.Drawing.Point(77, 41)
        Me.cmbMineBoosterShipSkill.Name = "cmbMineBoosterShipSkill"
        Me.cmbMineBoosterShipSkill.Size = New System.Drawing.Size(46, 21)
        Me.cmbMineBoosterShipSkill.TabIndex = 2
        '
        'chkMineForemanMindlink
        '
        Me.chkMineForemanMindlink.AutoSize = true
        Me.chkMineForemanMindlink.Location = New System.Drawing.Point(18, 69)
        Me.chkMineForemanMindlink.Name = "chkMineForemanMindlink"
        Me.chkMineForemanMindlink.Size = New System.Drawing.Size(143, 17)
        Me.chkMineForemanMindlink.TabIndex = 3
        Me.chkMineForemanMindlink.Text = "Mining Foreman Mindlink"
        Me.chkMineForemanMindlink.UseVisualStyleBackColor = true
        '
        'cmbMineBoosterShip
        '
        Me.cmbMineBoosterShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineBoosterShip.FormattingEnabled = true
        Me.cmbMineBoosterShip.Items.AddRange(New Object() {"Orca", "Rorqual", "Battlecruiser", "Other"})
        Me.cmbMineBoosterShip.Location = New System.Drawing.Point(77, 17)
        Me.cmbMineBoosterShip.Name = "cmbMineBoosterShip"
        Me.cmbMineBoosterShip.Size = New System.Drawing.Size(85, 21)
        Me.cmbMineBoosterShip.TabIndex = 1
        '
        'cmbMineMiningDirector
        '
        Me.cmbMineMiningDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineMiningDirector.FormattingEnabled = true
        Me.cmbMineMiningDirector.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineMiningDirector.Location = New System.Drawing.Point(342, 41)
        Me.cmbMineMiningDirector.Name = "cmbMineMiningDirector"
        Me.cmbMineMiningDirector.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineMiningDirector.TabIndex = 6
        '
        'chkMineForemanLaserOpBoost
        '
        Me.chkMineForemanLaserOpBoost.Location = New System.Drawing.Point(394, 60)
        Me.chkMineForemanLaserOpBoost.Name = "chkMineForemanLaserOpBoost"
        Me.chkMineForemanLaserOpBoost.Size = New System.Drawing.Size(132, 40)
        Me.chkMineForemanLaserOpBoost.TabIndex = 10
        Me.chkMineForemanLaserOpBoost.Text = "Mining Foreman Link - Laser Optimization"
        Me.chkMineForemanLaserOpBoost.ThreeState = true
        Me.chkMineForemanLaserOpBoost.UseVisualStyleBackColor = true
        '
        'lblMineMiningDirector
        '
        Me.lblMineMiningDirector.Location = New System.Drawing.Point(255, 44)
        Me.lblMineMiningDirector.Name = "lblMineMiningDirector"
        Me.lblMineMiningDirector.Size = New System.Drawing.Size(86, 13)
        Me.lblMineMiningDirector.TabIndex = 115
        Me.lblMineMiningDirector.Text = "Mining Director:"
        Me.lblMineMiningDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMineMiningForeman
        '
        Me.cmbMineMiningForeman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineMiningForeman.FormattingEnabled = true
        Me.cmbMineMiningForeman.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineMiningForeman.Location = New System.Drawing.Point(342, 18)
        Me.cmbMineMiningForeman.Name = "cmbMineMiningForeman"
        Me.cmbMineMiningForeman.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineMiningForeman.TabIndex = 5
        '
        'lblMineFleetBoosterShip
        '
        Me.lblMineFleetBoosterShip.AutoSize = true
        Me.lblMineFleetBoosterShip.Location = New System.Drawing.Point(15, 21)
        Me.lblMineFleetBoosterShip.Name = "lblMineFleetBoosterShip"
        Me.lblMineFleetBoosterShip.Size = New System.Drawing.Size(64, 13)
        Me.lblMineFleetBoosterShip.TabIndex = 119
        Me.lblMineFleetBoosterShip.Text = "Select Ship:"
        '
        'lblMineMiningForeman
        '
        Me.lblMineMiningForeman.Location = New System.Drawing.Point(255, 21)
        Me.lblMineMiningForeman.Name = "lblMineMiningForeman"
        Me.lblMineMiningForeman.Size = New System.Drawing.Size(86, 13)
        Me.lblMineMiningForeman.TabIndex = 113
        Me.lblMineMiningForeman.Text = "Mining Foreman:"
        Me.lblMineMiningForeman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMineBoosterShipSkill
        '
        Me.lblMineBoosterShipSkill.AutoSize = true
        Me.lblMineBoosterShipSkill.Location = New System.Drawing.Point(16, 45)
        Me.lblMineBoosterShipSkill.Name = "lblMineBoosterShipSkill"
        Me.lblMineBoosterShipSkill.Size = New System.Drawing.Size(53, 13)
        Me.lblMineBoosterShipSkill.TabIndex = 131
        Me.lblMineBoosterShipSkill.Text = "Ship Skill:"
        '
        'gbMineRefining
        '
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing17)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing17)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing17)
        Me.gbMineRefining.Controls.Add(Me.gbMineStationYield)
        Me.gbMineRefining.Controls.Add(Me.gbMineBaseRefineSkills)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing16)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing15)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing14)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing13)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing12)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing16)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing15)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing14)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing13)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing12)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing12)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing13)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing14)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing16)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing15)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing6)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing6)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing6)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing8)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing7)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing11)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing10)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing9)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing5)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing4)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing3)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing2)
        Me.gbMineRefining.Controls.Add(Me.cmbOreProcessing1)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing8)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing7)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing11)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing10)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing9)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing5)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing8)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing4)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing7)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing3)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing11)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing2)
        Me.gbMineRefining.Controls.Add(Me.chkOreProcessing1)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing1)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing2)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing3)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing10)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing9)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing5)
        Me.gbMineRefining.Controls.Add(Me.lblOreProcessing4)
        Me.gbMineRefining.Location = New System.Drawing.Point(711, 330)
        Me.gbMineRefining.Name = "gbMineRefining"
        Me.gbMineRefining.Size = New System.Drawing.Size(417, 278)
        Me.gbMineRefining.TabIndex = 8
        Me.gbMineRefining.TabStop = false
        '
        'cmbOreProcessing17
        '
        Me.cmbOreProcessing17.FormattingEnabled = true
        Me.cmbOreProcessing17.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing17.Location = New System.Drawing.Point(162, 250)
        Me.cmbOreProcessing17.Name = "cmbOreProcessing17"
        Me.cmbOreProcessing17.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing17.TabIndex = 35
        '
        'chkOreProcessing17
        '
        Me.chkOreProcessing17.AutoSize = true
        Me.chkOreProcessing17.Location = New System.Drawing.Point(12, 253)
        Me.chkOreProcessing17.Name = "chkOreProcessing17"
        Me.chkOreProcessing17.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing17.TabIndex = 34
        Me.chkOreProcessing17.UseVisualStyleBackColor = true
        '
        'lblOreProcessing17
        '
        Me.lblOreProcessing17.Location = New System.Drawing.Point(33, 253)
        Me.lblOreProcessing17.Name = "lblOreProcessing17"
        Me.lblOreProcessing17.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing17.TabIndex = 116
        Me.lblOreProcessing17.Text = "Ice Processing"
        '
        'gbMineStationYield
        '
        Me.gbMineStationYield.Controls.Add(Me.cmbMineRefineStationTax)
        Me.gbMineStationYield.Controls.Add(Me.lblMineRefineStationTax)
        Me.gbMineStationYield.Controls.Add(Me.cmbMineStationEff)
        Me.gbMineStationYield.Controls.Add(Me.lblMineStationEff)
        Me.gbMineStationYield.Controls.Add(Me.lblMineStationStanding)
        Me.gbMineStationYield.Controls.Add(Me.txtMineRefineStanding)
        Me.gbMineStationYield.Location = New System.Drawing.Point(242, 13)
        Me.gbMineStationYield.Name = "gbMineStationYield"
        Me.gbMineStationYield.Size = New System.Drawing.Size(166, 55)
        Me.gbMineStationYield.TabIndex = 1
        Me.gbMineStationYield.TabStop = false
        Me.gbMineStationYield.Text = "Refine Station:"
        '
        'cmbMineRefineStationTax
        '
        Me.cmbMineRefineStationTax.FormattingEnabled = true
        Me.cmbMineRefineStationTax.Items.AddRange(New Object() {"0%", "1%", "2%", "3%", "4%", "5%", "6%", "7%", "8%", "9%", "10%"})
        Me.cmbMineRefineStationTax.Location = New System.Drawing.Point(55, 28)
        Me.cmbMineRefineStationTax.Name = "cmbMineRefineStationTax"
        Me.cmbMineRefineStationTax.Size = New System.Drawing.Size(52, 21)
        Me.cmbMineRefineStationTax.TabIndex = 1
        Me.cmbMineRefineStationTax.Text = "10.2%"
        '
        'lblMineRefineStationTax
        '
        Me.lblMineRefineStationTax.AutoSize = true
        Me.lblMineRefineStationTax.Location = New System.Drawing.Point(53, 14)
        Me.lblMineRefineStationTax.Name = "lblMineRefineStationTax"
        Me.lblMineRefineStationTax.Size = New System.Drawing.Size(28, 13)
        Me.lblMineRefineStationTax.TabIndex = 119
        Me.lblMineRefineStationTax.Text = "Tax:"
        '
        'cmbMineStationEff
        '
        Me.cmbMineStationEff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineStationEff.FormattingEnabled = true
        Me.cmbMineStationEff.Items.AddRange(New Object() {"50%", "52%", "53%", "54%", "57%", "60%"})
        Me.cmbMineStationEff.Location = New System.Drawing.Point(111, 28)
        Me.cmbMineStationEff.Name = "cmbMineStationEff"
        Me.cmbMineStationEff.Size = New System.Drawing.Size(48, 21)
        Me.cmbMineStationEff.TabIndex = 2
        '
        'lblMineStationEff
        '
        Me.lblMineStationEff.AutoSize = true
        Me.lblMineStationEff.Location = New System.Drawing.Point(108, 14)
        Me.lblMineStationEff.Name = "lblMineStationEff"
        Me.lblMineStationEff.Size = New System.Drawing.Size(56, 13)
        Me.lblMineStationEff.TabIndex = 110
        Me.lblMineStationEff.Text = "Efficiency:"
        '
        'lblMineStationStanding
        '
        Me.lblMineStationStanding.AutoSize = true
        Me.lblMineStationStanding.Location = New System.Drawing.Point(5, 14)
        Me.lblMineStationStanding.Name = "lblMineStationStanding"
        Me.lblMineStationStanding.Size = New System.Drawing.Size(52, 13)
        Me.lblMineStationStanding.TabIndex = 109
        Me.lblMineStationStanding.Text = "Standing:"
        '
        'txtMineRefineStanding
        '
        Me.txtMineRefineStanding.Location = New System.Drawing.Point(7, 29)
        Me.txtMineRefineStanding.Name = "txtMineRefineStanding"
        Me.txtMineRefineStanding.Size = New System.Drawing.Size(44, 20)
        Me.txtMineRefineStanding.TabIndex = 0
        Me.txtMineRefineStanding.Text = "6.67"
        Me.txtMineRefineStanding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbMineBaseRefineSkills
        '
        Me.gbMineBaseRefineSkills.Controls.Add(Me.lblMineRefineryEfficiency)
        Me.gbMineBaseRefineSkills.Controls.Add(Me.cmbMineRefining)
        Me.gbMineBaseRefineSkills.Controls.Add(Me.lblMineRefining)
        Me.gbMineBaseRefineSkills.Controls.Add(Me.cmbMineRefineryEff)
        Me.gbMineBaseRefineSkills.Location = New System.Drawing.Point(8, 13)
        Me.gbMineBaseRefineSkills.Name = "gbMineBaseRefineSkills"
        Me.gbMineBaseRefineSkills.Size = New System.Drawing.Size(227, 55)
        Me.gbMineBaseRefineSkills.TabIndex = 0
        Me.gbMineBaseRefineSkills.TabStop = false
        '
        'lblMineRefineryEfficiency
        '
        Me.lblMineRefineryEfficiency.AutoSize = true
        Me.lblMineRefineryEfficiency.Location = New System.Drawing.Point(87, 26)
        Me.lblMineRefineryEfficiency.Name = "lblMineRefineryEfficiency"
        Me.lblMineRefineryEfficiency.Size = New System.Drawing.Size(98, 13)
        Me.lblMineRefineryEfficiency.TabIndex = 109
        Me.lblMineRefineryEfficiency.Text = "Refinery Efficiency:"
        '
        'cmbMineRefining
        '
        Me.cmbMineRefining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineRefining.FormattingEnabled = true
        Me.cmbMineRefining.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineRefining.Location = New System.Drawing.Point(50, 21)
        Me.cmbMineRefining.Name = "cmbMineRefining"
        Me.cmbMineRefining.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineRefining.TabIndex = 0
        '
        'lblMineRefining
        '
        Me.lblMineRefining.AutoSize = true
        Me.lblMineRefining.Location = New System.Drawing.Point(1, 25)
        Me.lblMineRefining.Name = "lblMineRefining"
        Me.lblMineRefining.Size = New System.Drawing.Size(49, 13)
        Me.lblMineRefining.TabIndex = 108
        Me.lblMineRefining.Text = "Refining:"
        '
        'cmbMineRefineryEff
        '
        Me.cmbMineRefineryEff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineRefineryEff.FormattingEnabled = true
        Me.cmbMineRefineryEff.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineRefineryEff.Location = New System.Drawing.Point(185, 22)
        Me.cmbMineRefineryEff.Name = "cmbMineRefineryEff"
        Me.cmbMineRefineryEff.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineRefineryEff.TabIndex = 1
        '
        'cmbOreProcessing16
        '
        Me.cmbOreProcessing16.FormattingEnabled = true
        Me.cmbOreProcessing16.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing16.Location = New System.Drawing.Point(366, 228)
        Me.cmbOreProcessing16.Name = "cmbOreProcessing16"
        Me.cmbOreProcessing16.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing16.TabIndex = 33
        '
        'cmbOreProcessing15
        '
        Me.cmbOreProcessing15.FormattingEnabled = true
        Me.cmbOreProcessing15.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing15.Location = New System.Drawing.Point(366, 206)
        Me.cmbOreProcessing15.Name = "cmbOreProcessing15"
        Me.cmbOreProcessing15.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing15.TabIndex = 29
        '
        'cmbOreProcessing14
        '
        Me.cmbOreProcessing14.FormattingEnabled = true
        Me.cmbOreProcessing14.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing14.Location = New System.Drawing.Point(366, 184)
        Me.cmbOreProcessing14.Name = "cmbOreProcessing14"
        Me.cmbOreProcessing14.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing14.TabIndex = 25
        '
        'cmbOreProcessing13
        '
        Me.cmbOreProcessing13.FormattingEnabled = true
        Me.cmbOreProcessing13.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing13.Location = New System.Drawing.Point(366, 162)
        Me.cmbOreProcessing13.Name = "cmbOreProcessing13"
        Me.cmbOreProcessing13.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing13.TabIndex = 21
        '
        'cmbOreProcessing12
        '
        Me.cmbOreProcessing12.FormattingEnabled = true
        Me.cmbOreProcessing12.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing12.Location = New System.Drawing.Point(366, 140)
        Me.cmbOreProcessing12.Name = "cmbOreProcessing12"
        Me.cmbOreProcessing12.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing12.TabIndex = 17
        '
        'chkOreProcessing16
        '
        Me.chkOreProcessing16.AutoSize = true
        Me.chkOreProcessing16.Location = New System.Drawing.Point(216, 231)
        Me.chkOreProcessing16.Name = "chkOreProcessing16"
        Me.chkOreProcessing16.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing16.TabIndex = 32
        Me.chkOreProcessing16.UseVisualStyleBackColor = true
        '
        'chkOreProcessing15
        '
        Me.chkOreProcessing15.AutoSize = true
        Me.chkOreProcessing15.Location = New System.Drawing.Point(216, 209)
        Me.chkOreProcessing15.Name = "chkOreProcessing15"
        Me.chkOreProcessing15.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing15.TabIndex = 28
        Me.chkOreProcessing15.UseVisualStyleBackColor = true
        '
        'chkOreProcessing14
        '
        Me.chkOreProcessing14.AutoSize = true
        Me.chkOreProcessing14.Location = New System.Drawing.Point(216, 187)
        Me.chkOreProcessing14.Name = "chkOreProcessing14"
        Me.chkOreProcessing14.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing14.TabIndex = 24
        Me.chkOreProcessing14.UseVisualStyleBackColor = true
        '
        'chkOreProcessing13
        '
        Me.chkOreProcessing13.AutoSize = true
        Me.chkOreProcessing13.Location = New System.Drawing.Point(216, 165)
        Me.chkOreProcessing13.Name = "chkOreProcessing13"
        Me.chkOreProcessing13.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing13.TabIndex = 20
        Me.chkOreProcessing13.UseVisualStyleBackColor = true
        '
        'chkOreProcessing12
        '
        Me.chkOreProcessing12.AutoSize = true
        Me.chkOreProcessing12.Location = New System.Drawing.Point(216, 143)
        Me.chkOreProcessing12.Name = "chkOreProcessing12"
        Me.chkOreProcessing12.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing12.TabIndex = 16
        Me.chkOreProcessing12.UseVisualStyleBackColor = true
        '
        'lblOreProcessing12
        '
        Me.lblOreProcessing12.Location = New System.Drawing.Point(237, 144)
        Me.lblOreProcessing12.Name = "lblOreProcessing12"
        Me.lblOreProcessing12.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing12.TabIndex = 90
        Me.lblOreProcessing12.Text = "Jaspet Processing"
        '
        'lblOreProcessing13
        '
        Me.lblOreProcessing13.Location = New System.Drawing.Point(237, 166)
        Me.lblOreProcessing13.Name = "lblOreProcessing13"
        Me.lblOreProcessing13.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing13.TabIndex = 91
        Me.lblOreProcessing13.Text = "Gneiss Processing"
        '
        'lblOreProcessing14
        '
        Me.lblOreProcessing14.Location = New System.Drawing.Point(237, 188)
        Me.lblOreProcessing14.Name = "lblOreProcessing14"
        Me.lblOreProcessing14.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing14.TabIndex = 92
        Me.lblOreProcessing14.Text = "Spodumain Processing"
        '
        'lblOreProcessing16
        '
        Me.lblOreProcessing16.Location = New System.Drawing.Point(237, 232)
        Me.lblOreProcessing16.Name = "lblOreProcessing16"
        Me.lblOreProcessing16.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing16.TabIndex = 94
        Me.lblOreProcessing16.Text = "Mercoxit Processing"
        '
        'lblOreProcessing15
        '
        Me.lblOreProcessing15.Location = New System.Drawing.Point(237, 210)
        Me.lblOreProcessing15.Name = "lblOreProcessing15"
        Me.lblOreProcessing15.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing15.TabIndex = 93
        Me.lblOreProcessing15.Text = "Crokite Processing"
        '
        'cmbOreProcessing6
        '
        Me.cmbOreProcessing6.FormattingEnabled = true
        Me.cmbOreProcessing6.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing6.Location = New System.Drawing.Point(162, 184)
        Me.cmbOreProcessing6.Name = "cmbOreProcessing6"
        Me.cmbOreProcessing6.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing6.TabIndex = 23
        '
        'chkOreProcessing6
        '
        Me.chkOreProcessing6.AutoSize = true
        Me.chkOreProcessing6.Location = New System.Drawing.Point(12, 187)
        Me.chkOreProcessing6.Name = "chkOreProcessing6"
        Me.chkOreProcessing6.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing6.TabIndex = 22
        Me.chkOreProcessing6.UseVisualStyleBackColor = true
        '
        'lblOreProcessing6
        '
        Me.lblOreProcessing6.Location = New System.Drawing.Point(33, 188)
        Me.lblOreProcessing6.Name = "lblOreProcessing6"
        Me.lblOreProcessing6.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing6.TabIndex = 84
        Me.lblOreProcessing6.Text = "Hedbergite Processing"
        '
        'cmbOreProcessing8
        '
        Me.cmbOreProcessing8.FormattingEnabled = true
        Me.cmbOreProcessing8.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing8.Location = New System.Drawing.Point(162, 228)
        Me.cmbOreProcessing8.Name = "cmbOreProcessing8"
        Me.cmbOreProcessing8.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing8.TabIndex = 31
        '
        'cmbOreProcessing7
        '
        Me.cmbOreProcessing7.FormattingEnabled = true
        Me.cmbOreProcessing7.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing7.Location = New System.Drawing.Point(162, 206)
        Me.cmbOreProcessing7.Name = "cmbOreProcessing7"
        Me.cmbOreProcessing7.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing7.TabIndex = 27
        '
        'cmbOreProcessing11
        '
        Me.cmbOreProcessing11.FormattingEnabled = true
        Me.cmbOreProcessing11.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing11.Location = New System.Drawing.Point(366, 118)
        Me.cmbOreProcessing11.Name = "cmbOreProcessing11"
        Me.cmbOreProcessing11.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing11.TabIndex = 13
        '
        'cmbOreProcessing10
        '
        Me.cmbOreProcessing10.FormattingEnabled = true
        Me.cmbOreProcessing10.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing10.Location = New System.Drawing.Point(366, 96)
        Me.cmbOreProcessing10.Name = "cmbOreProcessing10"
        Me.cmbOreProcessing10.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing10.TabIndex = 9
        '
        'cmbOreProcessing9
        '
        Me.cmbOreProcessing9.FormattingEnabled = true
        Me.cmbOreProcessing9.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing9.Location = New System.Drawing.Point(366, 74)
        Me.cmbOreProcessing9.Name = "cmbOreProcessing9"
        Me.cmbOreProcessing9.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing9.TabIndex = 5
        '
        'cmbOreProcessing5
        '
        Me.cmbOreProcessing5.FormattingEnabled = true
        Me.cmbOreProcessing5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing5.Location = New System.Drawing.Point(162, 162)
        Me.cmbOreProcessing5.Name = "cmbOreProcessing5"
        Me.cmbOreProcessing5.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing5.TabIndex = 19
        '
        'cmbOreProcessing4
        '
        Me.cmbOreProcessing4.FormattingEnabled = true
        Me.cmbOreProcessing4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing4.Location = New System.Drawing.Point(162, 140)
        Me.cmbOreProcessing4.Name = "cmbOreProcessing4"
        Me.cmbOreProcessing4.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing4.TabIndex = 15
        '
        'cmbOreProcessing3
        '
        Me.cmbOreProcessing3.FormattingEnabled = true
        Me.cmbOreProcessing3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing3.Location = New System.Drawing.Point(162, 118)
        Me.cmbOreProcessing3.Name = "cmbOreProcessing3"
        Me.cmbOreProcessing3.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing3.TabIndex = 11
        '
        'cmbOreProcessing2
        '
        Me.cmbOreProcessing2.FormattingEnabled = true
        Me.cmbOreProcessing2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing2.Location = New System.Drawing.Point(162, 96)
        Me.cmbOreProcessing2.Name = "cmbOreProcessing2"
        Me.cmbOreProcessing2.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing2.TabIndex = 7
        '
        'cmbOreProcessing1
        '
        Me.cmbOreProcessing1.FormattingEnabled = true
        Me.cmbOreProcessing1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbOreProcessing1.Location = New System.Drawing.Point(162, 74)
        Me.cmbOreProcessing1.Name = "cmbOreProcessing1"
        Me.cmbOreProcessing1.Size = New System.Drawing.Size(36, 21)
        Me.cmbOreProcessing1.TabIndex = 3
        '
        'chkOreProcessing8
        '
        Me.chkOreProcessing8.AutoSize = true
        Me.chkOreProcessing8.Location = New System.Drawing.Point(12, 231)
        Me.chkOreProcessing8.Name = "chkOreProcessing8"
        Me.chkOreProcessing8.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing8.TabIndex = 30
        Me.chkOreProcessing8.UseVisualStyleBackColor = true
        '
        'chkOreProcessing7
        '
        Me.chkOreProcessing7.AutoSize = true
        Me.chkOreProcessing7.Location = New System.Drawing.Point(12, 209)
        Me.chkOreProcessing7.Name = "chkOreProcessing7"
        Me.chkOreProcessing7.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing7.TabIndex = 26
        Me.chkOreProcessing7.UseVisualStyleBackColor = true
        '
        'chkOreProcessing11
        '
        Me.chkOreProcessing11.AutoSize = true
        Me.chkOreProcessing11.Location = New System.Drawing.Point(216, 121)
        Me.chkOreProcessing11.Name = "chkOreProcessing11"
        Me.chkOreProcessing11.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing11.TabIndex = 12
        Me.chkOreProcessing11.UseVisualStyleBackColor = true
        '
        'chkOreProcessing10
        '
        Me.chkOreProcessing10.AutoSize = true
        Me.chkOreProcessing10.Location = New System.Drawing.Point(216, 99)
        Me.chkOreProcessing10.Name = "chkOreProcessing10"
        Me.chkOreProcessing10.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing10.TabIndex = 8
        Me.chkOreProcessing10.UseVisualStyleBackColor = true
        '
        'chkOreProcessing9
        '
        Me.chkOreProcessing9.AutoSize = true
        Me.chkOreProcessing9.Location = New System.Drawing.Point(216, 77)
        Me.chkOreProcessing9.Name = "chkOreProcessing9"
        Me.chkOreProcessing9.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing9.TabIndex = 4
        Me.chkOreProcessing9.UseVisualStyleBackColor = true
        '
        'chkOreProcessing5
        '
        Me.chkOreProcessing5.AutoSize = true
        Me.chkOreProcessing5.Location = New System.Drawing.Point(12, 165)
        Me.chkOreProcessing5.Name = "chkOreProcessing5"
        Me.chkOreProcessing5.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing5.TabIndex = 18
        Me.chkOreProcessing5.UseVisualStyleBackColor = true
        '
        'lblOreProcessing8
        '
        Me.lblOreProcessing8.Location = New System.Drawing.Point(33, 232)
        Me.lblOreProcessing8.Name = "lblOreProcessing8"
        Me.lblOreProcessing8.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing8.TabIndex = 63
        Me.lblOreProcessing8.Text = "Arkonor Processing"
        '
        'chkOreProcessing4
        '
        Me.chkOreProcessing4.AutoSize = true
        Me.chkOreProcessing4.Location = New System.Drawing.Point(12, 143)
        Me.chkOreProcessing4.Name = "chkOreProcessing4"
        Me.chkOreProcessing4.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing4.TabIndex = 14
        Me.chkOreProcessing4.UseVisualStyleBackColor = true
        '
        'lblOreProcessing7
        '
        Me.lblOreProcessing7.Location = New System.Drawing.Point(33, 210)
        Me.lblOreProcessing7.Name = "lblOreProcessing7"
        Me.lblOreProcessing7.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing7.TabIndex = 62
        Me.lblOreProcessing7.Text = "Bistot Processing"
        '
        'chkOreProcessing3
        '
        Me.chkOreProcessing3.AutoSize = true
        Me.chkOreProcessing3.Location = New System.Drawing.Point(12, 121)
        Me.chkOreProcessing3.Name = "chkOreProcessing3"
        Me.chkOreProcessing3.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing3.TabIndex = 10
        Me.chkOreProcessing3.UseVisualStyleBackColor = true
        '
        'lblOreProcessing11
        '
        Me.lblOreProcessing11.Location = New System.Drawing.Point(237, 122)
        Me.lblOreProcessing11.Name = "lblOreProcessing11"
        Me.lblOreProcessing11.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing11.TabIndex = 61
        Me.lblOreProcessing11.Text = "Kernite Processing"
        '
        'chkOreProcessing2
        '
        Me.chkOreProcessing2.AutoSize = true
        Me.chkOreProcessing2.Location = New System.Drawing.Point(12, 99)
        Me.chkOreProcessing2.Name = "chkOreProcessing2"
        Me.chkOreProcessing2.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing2.TabIndex = 6
        Me.chkOreProcessing2.UseVisualStyleBackColor = true
        '
        'chkOreProcessing1
        '
        Me.chkOreProcessing1.AutoSize = true
        Me.chkOreProcessing1.Location = New System.Drawing.Point(12, 77)
        Me.chkOreProcessing1.Name = "chkOreProcessing1"
        Me.chkOreProcessing1.Size = New System.Drawing.Size(15, 14)
        Me.chkOreProcessing1.TabIndex = 2
        Me.chkOreProcessing1.UseVisualStyleBackColor = true
        '
        'lblOreProcessing1
        '
        Me.lblOreProcessing1.Location = New System.Drawing.Point(33, 78)
        Me.lblOreProcessing1.Name = "lblOreProcessing1"
        Me.lblOreProcessing1.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing1.TabIndex = 54
        Me.lblOreProcessing1.Text = "Veldspar Processing"
        '
        'lblOreProcessing2
        '
        Me.lblOreProcessing2.Location = New System.Drawing.Point(33, 100)
        Me.lblOreProcessing2.Name = "lblOreProcessing2"
        Me.lblOreProcessing2.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing2.TabIndex = 55
        Me.lblOreProcessing2.Text = "Pyroxeres Processing"
        '
        'lblOreProcessing3
        '
        Me.lblOreProcessing3.Location = New System.Drawing.Point(33, 122)
        Me.lblOreProcessing3.Name = "lblOreProcessing3"
        Me.lblOreProcessing3.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing3.TabIndex = 56
        Me.lblOreProcessing3.Text = "Omber Processing"
        '
        'lblOreProcessing10
        '
        Me.lblOreProcessing10.Location = New System.Drawing.Point(237, 100)
        Me.lblOreProcessing10.Name = "lblOreProcessing10"
        Me.lblOreProcessing10.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing10.TabIndex = 60
        Me.lblOreProcessing10.Text = "Plagioclase Processing"
        '
        'lblOreProcessing9
        '
        Me.lblOreProcessing9.Location = New System.Drawing.Point(237, 78)
        Me.lblOreProcessing9.Name = "lblOreProcessing9"
        Me.lblOreProcessing9.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing9.TabIndex = 59
        Me.lblOreProcessing9.Text = "Scordite Processing"
        '
        'lblOreProcessing5
        '
        Me.lblOreProcessing5.Location = New System.Drawing.Point(33, 166)
        Me.lblOreProcessing5.Name = "lblOreProcessing5"
        Me.lblOreProcessing5.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing5.TabIndex = 58
        Me.lblOreProcessing5.Text = "Dark Ochre Processing"
        '
        'lblOreProcessing4
        '
        Me.lblOreProcessing4.Location = New System.Drawing.Point(33, 144)
        Me.lblOreProcessing4.Name = "lblOreProcessing4"
        Me.lblOreProcessing4.Size = New System.Drawing.Size(123, 13)
        Me.lblOreProcessing4.TabIndex = 57
        Me.lblOreProcessing4.Text = "Hemorphite Processing"
        '
        'gbMineShipSetup
        '
        Me.gbMineShipSetup.Controls.Add(Me.gbMineSelectShip)
        Me.gbMineShipSetup.Controls.Add(Me.gbMineShipEquipment)
        Me.gbMineShipSetup.Controls.Add(Me.gbMineSkills)
        Me.gbMineShipSetup.Location = New System.Drawing.Point(711, 8)
        Me.gbMineShipSetup.Name = "gbMineShipSetup"
        Me.gbMineShipSetup.Size = New System.Drawing.Size(418, 245)
        Me.gbMineShipSetup.TabIndex = 4
        Me.gbMineShipSetup.TabStop = false
        Me.gbMineShipSetup.Text = "Mining Skills/Ship Setup:"
        '
        'gbMineSelectShip
        '
        Me.gbMineSelectShip.Controls.Add(Me.pictMineSelectedShip)
        Me.gbMineSelectShip.Controls.Add(Me.lblMineSelectShip)
        Me.gbMineSelectShip.Controls.Add(Me.cmbMineBaseShipSkill)
        Me.gbMineSelectShip.Controls.Add(Me.cmbMineExhumers)
        Me.gbMineSelectShip.Controls.Add(Me.cmbMineShipType)
        Me.gbMineSelectShip.Controls.Add(Me.lblMineBaseShipSkill)
        Me.gbMineSelectShip.Controls.Add(Me.lblMineExhumers)
        Me.gbMineSelectShip.Location = New System.Drawing.Point(6, 18)
        Me.gbMineSelectShip.Name = "gbMineSelectShip"
        Me.gbMineSelectShip.Size = New System.Drawing.Size(111, 174)
        Me.gbMineSelectShip.TabIndex = 0
        Me.gbMineSelectShip.TabStop = false
        Me.gbMineSelectShip.Text = "Select Ship:"
        '
        'pictMineSelectedShip
        '
        Me.pictMineSelectedShip.BackColor = System.Drawing.Color.White
        Me.pictMineSelectedShip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictMineSelectedShip.Location = New System.Drawing.Point(21, 95)
        Me.pictMineSelectedShip.Name = "pictMineSelectedShip"
        Me.pictMineSelectedShip.Size = New System.Drawing.Size(68, 69)
        Me.pictMineSelectedShip.TabIndex = 138
        Me.pictMineSelectedShip.TabStop = false
        '
        'lblMineSelectShip
        '
        Me.lblMineSelectShip.AutoSize = true
        Me.lblMineSelectShip.Location = New System.Drawing.Point(3, 15)
        Me.lblMineSelectShip.Name = "lblMineSelectShip"
        Me.lblMineSelectShip.Size = New System.Drawing.Size(62, 13)
        Me.lblMineSelectShip.TabIndex = 0
        Me.lblMineSelectShip.Text = "Ship Name:"
        '
        'cmbMineBaseShipSkill
        '
        Me.cmbMineBaseShipSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineBaseShipSkill.FormattingEnabled = true
        Me.cmbMineBaseShipSkill.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbMineBaseShipSkill.Location = New System.Drawing.Point(6, 70)
        Me.cmbMineBaseShipSkill.Name = "cmbMineBaseShipSkill"
        Me.cmbMineBaseShipSkill.Size = New System.Drawing.Size(48, 21)
        Me.cmbMineBaseShipSkill.TabIndex = 1
        '
        'cmbMineExhumers
        '
        Me.cmbMineExhumers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineExhumers.FormattingEnabled = true
        Me.cmbMineExhumers.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineExhumers.Location = New System.Drawing.Point(57, 70)
        Me.cmbMineExhumers.Name = "cmbMineExhumers"
        Me.cmbMineExhumers.Size = New System.Drawing.Size(48, 21)
        Me.cmbMineExhumers.TabIndex = 2
        '
        'cmbMineShipType
        '
        Me.cmbMineShipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineShipType.FormattingEnabled = true
        Me.cmbMineShipType.Location = New System.Drawing.Point(6, 30)
        Me.cmbMineShipType.Name = "cmbMineShipType"
        Me.cmbMineShipType.Size = New System.Drawing.Size(99, 21)
        Me.cmbMineShipType.TabIndex = 0
        '
        'lblMineBaseShipSkill
        '
        Me.lblMineBaseShipSkill.AutoSize = true
        Me.lblMineBaseShipSkill.Location = New System.Drawing.Point(3, 54)
        Me.lblMineBaseShipSkill.Name = "lblMineBaseShipSkill"
        Me.lblMineBaseShipSkill.Size = New System.Drawing.Size(53, 13)
        Me.lblMineBaseShipSkill.TabIndex = 130
        Me.lblMineBaseShipSkill.Text = "Ship Skill:"
        '
        'lblMineExhumers
        '
        Me.lblMineExhumers.AutoSize = true
        Me.lblMineExhumers.Location = New System.Drawing.Point(54, 54)
        Me.lblMineExhumers.Name = "lblMineExhumers"
        Me.lblMineExhumers.Size = New System.Drawing.Size(56, 13)
        Me.lblMineExhumers.TabIndex = 128
        Me.lblMineExhumers.Text = "Exhumers:"
        '
        'gbMineShipEquipment
        '
        Me.gbMineShipEquipment.Controls.Add(Me.gbMiningRigs)
        Me.gbMineShipEquipment.Controls.Add(Me.cmbMineMiningLaser)
        Me.gbMineShipEquipment.Controls.Add(Me.lblMineMiningUpgrade)
        Me.gbMineShipEquipment.Controls.Add(Me.gbMineCrystals)
        Me.gbMineShipEquipment.Controls.Add(Me.cmbMineNumMiningUpgrades)
        Me.gbMineShipEquipment.Controls.Add(Me.cmbMineNumLasers)
        Me.gbMineShipEquipment.Controls.Add(Me.cmbMineMiningUpgrade)
        Me.gbMineShipEquipment.Controls.Add(Me.cmbMineImplant)
        Me.gbMineShipEquipment.Controls.Add(Me.chkMineMichiImplant)
        Me.gbMineShipEquipment.Controls.Add(Me.lblMineImplants)
        Me.gbMineShipEquipment.Controls.Add(Me.lblMineLaserNumber)
        Me.gbMineShipEquipment.Controls.Add(Me.lblMineNumMiningUpgrades)
        Me.gbMineShipEquipment.Controls.Add(Me.lblMineMinerTurret)
        Me.gbMineShipEquipment.Location = New System.Drawing.Point(122, 18)
        Me.gbMineShipEquipment.Name = "gbMineShipEquipment"
        Me.gbMineShipEquipment.Size = New System.Drawing.Size(290, 174)
        Me.gbMineShipEquipment.TabIndex = 1
        Me.gbMineShipEquipment.TabStop = false
        Me.gbMineShipEquipment.Text = "Select Ship Equipment:"
        '
        'gbMiningRigs
        '
        Me.gbMiningRigs.Controls.Add(Me.rbtnMineNoRigs)
        Me.gbMiningRigs.Controls.Add(Me.rbtnMineIceRig)
        Me.gbMiningRigs.Controls.Add(Me.rbtnMineMercoxitRig)
        Me.gbMiningRigs.Location = New System.Drawing.Point(6, 127)
        Me.gbMiningRigs.Name = "gbMiningRigs"
        Me.gbMiningRigs.Size = New System.Drawing.Size(279, 38)
        Me.gbMiningRigs.TabIndex = 136
        Me.gbMiningRigs.TabStop = false
        Me.gbMiningRigs.Text = "Mining Rigs:"
        '
        'rbtnMineNoRigs
        '
        Me.rbtnMineNoRigs.AutoSize = true
        Me.rbtnMineNoRigs.Location = New System.Drawing.Point(11, 15)
        Me.rbtnMineNoRigs.Name = "rbtnMineNoRigs"
        Me.rbtnMineNoRigs.Size = New System.Drawing.Size(51, 17)
        Me.rbtnMineNoRigs.TabIndex = 1
        Me.rbtnMineNoRigs.TabStop = true
        Me.rbtnMineNoRigs.Text = "None"
        Me.rbtnMineNoRigs.UseVisualStyleBackColor = true
        '
        'rbtnMineIceRig
        '
        Me.rbtnMineIceRig.AutoSize = true
        Me.rbtnMineIceRig.Location = New System.Drawing.Point(85, 15)
        Me.rbtnMineIceRig.Name = "rbtnMineIceRig"
        Me.rbtnMineIceRig.Size = New System.Drawing.Size(94, 17)
        Me.rbtnMineIceRig.TabIndex = 2
        Me.rbtnMineIceRig.TabStop = true
        Me.rbtnMineIceRig.Text = "Ice Harvesting"
        Me.rbtnMineIceRig.UseVisualStyleBackColor = true
        '
        'rbtnMineMercoxitRig
        '
        Me.rbtnMineMercoxitRig.AutoSize = true
        Me.rbtnMineMercoxitRig.Location = New System.Drawing.Point(202, 15)
        Me.rbtnMineMercoxitRig.Name = "rbtnMineMercoxitRig"
        Me.rbtnMineMercoxitRig.Size = New System.Drawing.Size(65, 17)
        Me.rbtnMineMercoxitRig.TabIndex = 3
        Me.rbtnMineMercoxitRig.TabStop = true
        Me.rbtnMineMercoxitRig.Text = "Mercoxit"
        Me.rbtnMineMercoxitRig.UseVisualStyleBackColor = true
        '
        'cmbMineMiningLaser
        '
        Me.cmbMineMiningLaser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineMiningLaser.FormattingEnabled = true
        Me.cmbMineMiningLaser.Location = New System.Drawing.Point(67, 17)
        Me.cmbMineMiningLaser.Name = "cmbMineMiningLaser"
        Me.cmbMineMiningLaser.Size = New System.Drawing.Size(218, 21)
        Me.cmbMineMiningLaser.TabIndex = 0
        '
        'lblMineMiningUpgrade
        '
        Me.lblMineMiningUpgrade.AutoSize = true
        Me.lblMineMiningUpgrade.Location = New System.Drawing.Point(1, 47)
        Me.lblMineMiningUpgrade.Name = "lblMineMiningUpgrade"
        Me.lblMineMiningUpgrade.Size = New System.Drawing.Size(85, 13)
        Me.lblMineMiningUpgrade.TabIndex = 132
        Me.lblMineMiningUpgrade.Text = "Mining Upgrade:"
        '
        'gbMineCrystals
        '
        Me.gbMineCrystals.Controls.Add(Me.rbtnMineT1Crystals)
        Me.gbMineCrystals.Controls.Add(Me.rbtnMineT2Crystals)
        Me.gbMineCrystals.Location = New System.Drawing.Point(205, 37)
        Me.gbMineCrystals.Name = "gbMineCrystals"
        Me.gbMineCrystals.Size = New System.Drawing.Size(80, 54)
        Me.gbMineCrystals.TabIndex = 4
        Me.gbMineCrystals.TabStop = false
        '
        'rbtnMineT1Crystals
        '
        Me.rbtnMineT1Crystals.AutoSize = true
        Me.rbtnMineT1Crystals.Location = New System.Drawing.Point(5, 11)
        Me.rbtnMineT1Crystals.Name = "rbtnMineT1Crystals"
        Me.rbtnMineT1Crystals.Size = New System.Drawing.Size(77, 17)
        Me.rbtnMineT1Crystals.TabIndex = 0
        Me.rbtnMineT1Crystals.TabStop = true
        Me.rbtnMineT1Crystals.Text = "T1 Crystals"
        Me.rbtnMineT1Crystals.UseVisualStyleBackColor = true
        '
        'rbtnMineT2Crystals
        '
        Me.rbtnMineT2Crystals.AutoSize = true
        Me.rbtnMineT2Crystals.Location = New System.Drawing.Point(5, 30)
        Me.rbtnMineT2Crystals.Name = "rbtnMineT2Crystals"
        Me.rbtnMineT2Crystals.Size = New System.Drawing.Size(77, 17)
        Me.rbtnMineT2Crystals.TabIndex = 1
        Me.rbtnMineT2Crystals.TabStop = true
        Me.rbtnMineT2Crystals.Text = "T2 Crystals"
        Me.rbtnMineT2Crystals.UseVisualStyleBackColor = true
        '
        'cmbMineNumMiningUpgrades
        '
        Me.cmbMineNumMiningUpgrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineNumMiningUpgrades.FormattingEnabled = true
        Me.cmbMineNumMiningUpgrades.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineNumMiningUpgrades.Location = New System.Drawing.Point(166, 69)
        Me.cmbMineNumMiningUpgrades.Name = "cmbMineNumMiningUpgrades"
        Me.cmbMineNumMiningUpgrades.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineNumMiningUpgrades.TabIndex = 3
        '
        'cmbMineNumLasers
        '
        Me.cmbMineNumLasers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineNumLasers.FormattingEnabled = true
        Me.cmbMineNumLasers.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineNumLasers.Location = New System.Drawing.Point(55, 69)
        Me.cmbMineNumLasers.Name = "cmbMineNumLasers"
        Me.cmbMineNumLasers.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineNumLasers.TabIndex = 2
        '
        'cmbMineMiningUpgrade
        '
        Me.cmbMineMiningUpgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineMiningUpgrade.FormattingEnabled = true
        Me.cmbMineMiningUpgrade.Items.AddRange(New Object() {"None", "5% (T1)", "8% (M1)", "9% (T2)", "9% (M6)", "10% (M6)"})
        Me.cmbMineMiningUpgrade.Location = New System.Drawing.Point(92, 44)
        Me.cmbMineMiningUpgrade.Name = "cmbMineMiningUpgrade"
        Me.cmbMineMiningUpgrade.Size = New System.Drawing.Size(110, 21)
        Me.cmbMineMiningUpgrade.TabIndex = 1
        '
        'cmbMineImplant
        '
        Me.cmbMineImplant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineImplant.FormattingEnabled = true
        Me.cmbMineImplant.Location = New System.Drawing.Point(45, 101)
        Me.cmbMineImplant.Name = "cmbMineImplant"
        Me.cmbMineImplant.Size = New System.Drawing.Size(120, 21)
        Me.cmbMineImplant.TabIndex = 5
        '
        'chkMineMichiImplant
        '
        Me.chkMineMichiImplant.Location = New System.Drawing.Point(172, 94)
        Me.chkMineMichiImplant.Name = "chkMineMichiImplant"
        Me.chkMineMichiImplant.Size = New System.Drawing.Size(124, 34)
        Me.chkMineMichiImplant.TabIndex = 6
        Me.chkMineMichiImplant.Text = "Michi's Excavation Augmentor"
        Me.chkMineMichiImplant.UseVisualStyleBackColor = true
        '
        'lblMineImplants
        '
        Me.lblMineImplants.Location = New System.Drawing.Point(1, 97)
        Me.lblMineImplants.Name = "lblMineImplants"
        Me.lblMineImplants.Size = New System.Drawing.Size(60, 29)
        Me.lblMineImplants.TabIndex = 23
        Me.lblMineImplants.Text = "Mining Implant:"
        '
        'lblMineLaserNumber
        '
        Me.lblMineLaserNumber.AutoSize = true
        Me.lblMineLaserNumber.Location = New System.Drawing.Point(1, 73)
        Me.lblMineLaserNumber.Name = "lblMineLaserNumber"
        Me.lblMineLaserNumber.Size = New System.Drawing.Size(51, 13)
        Me.lblMineLaserNumber.TabIndex = 125
        Me.lblMineLaserNumber.Text = "# Miners:"
        '
        'lblMineNumMiningUpgrades
        '
        Me.lblMineNumMiningUpgrades.AutoSize = true
        Me.lblMineNumMiningUpgrades.Location = New System.Drawing.Point(97, 73)
        Me.lblMineNumMiningUpgrades.Name = "lblMineNumMiningUpgrades"
        Me.lblMineNumMiningUpgrades.Size = New System.Drawing.Size(66, 13)
        Me.lblMineNumMiningUpgrades.TabIndex = 129
        Me.lblMineNumMiningUpgrades.Text = "# Upgrades:"
        '
        'lblMineMinerTurret
        '
        Me.lblMineMinerTurret.AutoSize = true
        Me.lblMineMinerTurret.Location = New System.Drawing.Point(1, 20)
        Me.lblMineMinerTurret.Name = "lblMineMinerTurret"
        Me.lblMineMinerTurret.Size = New System.Drawing.Size(67, 13)
        Me.lblMineMinerTurret.TabIndex = 131
        Me.lblMineMinerTurret.Text = "Miner Name:"
        '
        'gbMineSkills
        '
        Me.gbMineSkills.Controls.Add(Me.cmbMineGasIceHarvesting)
        Me.gbMineSkills.Controls.Add(Me.lblMineGasIceHarvesting)
        Me.gbMineSkills.Controls.Add(Me.cmbMineDeepCore)
        Me.gbMineSkills.Controls.Add(Me.lblMineAstrogeology)
        Me.gbMineSkills.Controls.Add(Me.cmbMineSkill)
        Me.gbMineSkills.Controls.Add(Me.lblMineSkill)
        Me.gbMineSkills.Controls.Add(Me.cmbMineAstrogeology)
        Me.gbMineSkills.Controls.Add(Me.lblMineDeepCore)
        Me.gbMineSkills.Location = New System.Drawing.Point(6, 195)
        Me.gbMineSkills.Name = "gbMineSkills"
        Me.gbMineSkills.Size = New System.Drawing.Size(406, 41)
        Me.gbMineSkills.TabIndex = 2
        Me.gbMineSkills.TabStop = false
        Me.gbMineSkills.Text = "Skills:"
        '
        'cmbMineGasIceHarvesting
        '
        Me.cmbMineGasIceHarvesting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineGasIceHarvesting.FormattingEnabled = true
        Me.cmbMineGasIceHarvesting.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineGasIceHarvesting.Location = New System.Drawing.Point(141, 13)
        Me.cmbMineGasIceHarvesting.Name = "cmbMineGasIceHarvesting"
        Me.cmbMineGasIceHarvesting.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineGasIceHarvesting.TabIndex = 1
        '
        'lblMineGasIceHarvesting
        '
        Me.lblMineGasIceHarvesting.AutoSize = true
        Me.lblMineGasIceHarvesting.Location = New System.Drawing.Point(89, 17)
        Me.lblMineGasIceHarvesting.Name = "lblMineGasIceHarvesting"
        Me.lblMineGasIceHarvesting.Size = New System.Drawing.Size(51, 13)
        Me.lblMineGasIceHarvesting.TabIndex = 117
        Me.lblMineGasIceHarvesting.Text = "Ice Harv:"
        '
        'cmbMineDeepCore
        '
        Me.cmbMineDeepCore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineDeepCore.FormattingEnabled = true
        Me.cmbMineDeepCore.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineDeepCore.Location = New System.Drawing.Point(356, 13)
        Me.cmbMineDeepCore.Name = "cmbMineDeepCore"
        Me.cmbMineDeepCore.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineDeepCore.TabIndex = 3
        '
        'lblMineAstrogeology
        '
        Me.lblMineAstrogeology.AutoSize = true
        Me.lblMineAstrogeology.Location = New System.Drawing.Point(183, 17)
        Me.lblMineAstrogeology.Name = "lblMineAstrogeology"
        Me.lblMineAstrogeology.Size = New System.Drawing.Size(71, 13)
        Me.lblMineAstrogeology.TabIndex = 109
        Me.lblMineAstrogeology.Text = "Astrogeology:"
        '
        'cmbMineSkill
        '
        Me.cmbMineSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineSkill.FormattingEnabled = true
        Me.cmbMineSkill.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineSkill.Location = New System.Drawing.Point(48, 13)
        Me.cmbMineSkill.Name = "cmbMineSkill"
        Me.cmbMineSkill.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineSkill.TabIndex = 0
        '
        'lblMineSkill
        '
        Me.lblMineSkill.AutoSize = true
        Me.lblMineSkill.Location = New System.Drawing.Point(6, 17)
        Me.lblMineSkill.Name = "lblMineSkill"
        Me.lblMineSkill.Size = New System.Drawing.Size(41, 13)
        Me.lblMineSkill.TabIndex = 108
        Me.lblMineSkill.Text = "Mining:"
        '
        'cmbMineAstrogeology
        '
        Me.cmbMineAstrogeology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMineAstrogeology.FormattingEnabled = true
        Me.cmbMineAstrogeology.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbMineAstrogeology.Location = New System.Drawing.Point(255, 13)
        Me.cmbMineAstrogeology.Name = "cmbMineAstrogeology"
        Me.cmbMineAstrogeology.Size = New System.Drawing.Size(36, 21)
        Me.cmbMineAstrogeology.TabIndex = 2
        '
        'lblMineDeepCore
        '
        Me.lblMineDeepCore.Location = New System.Drawing.Point(297, 10)
        Me.lblMineDeepCore.Name = "lblMineDeepCore"
        Me.lblMineDeepCore.Size = New System.Drawing.Size(60, 27)
        Me.lblMineDeepCore.TabIndex = 114
        Me.lblMineDeepCore.Text = "Deep Core Mining:"
        '
        'gbMineMain
        '
        Me.gbMineMain.Controls.Add(Me.gbMineIncludeOres)
        Me.gbMineMain.Controls.Add(Me.lblMineType)
        Me.gbMineMain.Controls.Add(Me.cmbMineOreType)
        Me.gbMineMain.Controls.Add(Me.gbMineOreLocSov)
        Me.gbMineMain.Location = New System.Drawing.Point(6, 8)
        Me.gbMineMain.Name = "gbMineMain"
        Me.gbMineMain.Size = New System.Drawing.Size(396, 144)
        Me.gbMineMain.TabIndex = 0
        Me.gbMineMain.TabStop = false
        Me.gbMineMain.Text = "Options:"
        '
        'gbMineIncludeOres
        '
        Me.gbMineIncludeOres.Controls.Add(Me.chkMineIncludeHighSec)
        Me.gbMineIncludeOres.Controls.Add(Me.chkMineIncludeNullSec)
        Me.gbMineIncludeOres.Controls.Add(Me.chkMineIncludeLowSec)
        Me.gbMineIncludeOres.Controls.Add(Me.chkMineIncludeHighYieldOre)
        Me.gbMineIncludeOres.Location = New System.Drawing.Point(9, 36)
        Me.gbMineIncludeOres.Name = "gbMineIncludeOres"
        Me.gbMineIncludeOres.Size = New System.Drawing.Size(114, 103)
        Me.gbMineIncludeOres.TabIndex = 4
        Me.gbMineIncludeOres.TabStop = false
        Me.gbMineIncludeOres.Text = "Include:"
        '
        'chkMineIncludeHighSec
        '
        Me.chkMineIncludeHighSec.AutoSize = true
        Me.chkMineIncludeHighSec.Location = New System.Drawing.Point(9, 23)
        Me.chkMineIncludeHighSec.Name = "chkMineIncludeHighSec"
        Me.chkMineIncludeHighSec.Size = New System.Drawing.Size(95, 17)
        Me.chkMineIncludeHighSec.TabIndex = 0
        Me.chkMineIncludeHighSec.Text = "High Sec Ores"
        Me.chkMineIncludeHighSec.UseVisualStyleBackColor = true
        '
        'chkMineIncludeNullSec
        '
        Me.chkMineIncludeNullSec.AutoSize = true
        Me.chkMineIncludeNullSec.Location = New System.Drawing.Point(9, 55)
        Me.chkMineIncludeNullSec.Name = "chkMineIncludeNullSec"
        Me.chkMineIncludeNullSec.Size = New System.Drawing.Size(91, 17)
        Me.chkMineIncludeNullSec.TabIndex = 2
        Me.chkMineIncludeNullSec.Text = "Null Sec Ores"
        Me.chkMineIncludeNullSec.UseVisualStyleBackColor = true
        '
        'chkMineIncludeLowSec
        '
        Me.chkMineIncludeLowSec.AutoSize = true
        Me.chkMineIncludeLowSec.Location = New System.Drawing.Point(9, 39)
        Me.chkMineIncludeLowSec.Name = "chkMineIncludeLowSec"
        Me.chkMineIncludeLowSec.Size = New System.Drawing.Size(93, 17)
        Me.chkMineIncludeLowSec.TabIndex = 1
        Me.chkMineIncludeLowSec.Text = "Low Sec Ores"
        Me.chkMineIncludeLowSec.UseVisualStyleBackColor = true
        '
        'chkMineIncludeHighYieldOre
        '
        Me.chkMineIncludeHighYieldOre.AutoSize = true
        Me.chkMineIncludeHighYieldOre.Location = New System.Drawing.Point(9, 78)
        Me.chkMineIncludeHighYieldOre.Name = "chkMineIncludeHighYieldOre"
        Me.chkMineIncludeHighYieldOre.Size = New System.Drawing.Size(99, 17)
        Me.chkMineIncludeHighYieldOre.TabIndex = 3
        Me.chkMineIncludeHighYieldOre.Text = "High Yield Ores"
        Me.chkMineIncludeHighYieldOre.UseVisualStyleBackColor = true
        '
        'lblMineType
        '
        Me.lblMineType.AutoSize = true
        Me.lblMineType.Location = New System.Drawing.Point(6, 16)
        Me.lblMineType.Name = "lblMineType"
        Me.lblMineType.Size = New System.Drawing.Size(67, 13)
        Me.lblMineType.TabIndex = 60
        Me.lblMineType.Text = "Select Type:"
        '
        'cmbMineOreType
        '
        Me.cmbMineOreType.FormattingEnabled = true
        Me.cmbMineOreType.Items.AddRange(New Object() {"Ore", "Ice", "Gas"})
        Me.cmbMineOreType.Location = New System.Drawing.Point(79, 12)
        Me.cmbMineOreType.Name = "cmbMineOreType"
        Me.cmbMineOreType.Size = New System.Drawing.Size(44, 21)
        Me.cmbMineOreType.TabIndex = 0
        '
        'gbMineOreLocSov
        '
        Me.gbMineOreLocSov.Controls.Add(Me.chkMineWH)
        Me.gbMineOreLocSov.Controls.Add(Me.gbMineWHSpace)
        Me.gbMineOreLocSov.Controls.Add(Me.chkMineCaldari)
        Me.gbMineOreLocSov.Controls.Add(Me.chkMineMinmatar)
        Me.gbMineOreLocSov.Controls.Add(Me.chkMineGallente)
        Me.gbMineOreLocSov.Controls.Add(Me.chkMineAmarr)
        Me.gbMineOreLocSov.Location = New System.Drawing.Point(129, 10)
        Me.gbMineOreLocSov.Name = "gbMineOreLocSov"
        Me.gbMineOreLocSov.Size = New System.Drawing.Size(257, 129)
        Me.gbMineOreLocSov.TabIndex = 5
        Me.gbMineOreLocSov.TabStop = false
        Me.gbMineOreLocSov.Text = "Ore Location:"
        '
        'chkMineWH
        '
        Me.chkMineWH.AutoSize = true
        Me.chkMineWH.Location = New System.Drawing.Point(11, 69)
        Me.chkMineWH.Name = "chkMineWH"
        Me.chkMineWH.Size = New System.Drawing.Size(108, 17)
        Me.chkMineWH.TabIndex = 4
        Me.chkMineWH.Text = "Wormhole Space"
        Me.chkMineWH.UseVisualStyleBackColor = true
        '
        'gbMineWHSpace
        '
        Me.gbMineWHSpace.Controls.Add(Me.chkMineC6)
        Me.gbMineWHSpace.Controls.Add(Me.chkMineC2)
        Me.gbMineWHSpace.Controls.Add(Me.chkMineC4)
        Me.gbMineWHSpace.Controls.Add(Me.chkMineC1)
        Me.gbMineWHSpace.Controls.Add(Me.chkMineC5)
        Me.gbMineWHSpace.Controls.Add(Me.chkMineC3)
        Me.gbMineWHSpace.Location = New System.Drawing.Point(6, 87)
        Me.gbMineWHSpace.Name = "gbMineWHSpace"
        Me.gbMineWHSpace.Size = New System.Drawing.Size(245, 37)
        Me.gbMineWHSpace.TabIndex = 5
        Me.gbMineWHSpace.TabStop = false
        '
        'chkMineC6
        '
        Me.chkMineC6.AutoSize = true
        Me.chkMineC6.Location = New System.Drawing.Point(200, 13)
        Me.chkMineC6.Name = "chkMineC6"
        Me.chkMineC6.Size = New System.Drawing.Size(39, 17)
        Me.chkMineC6.TabIndex = 10
        Me.chkMineC6.Text = "C6"
        Me.chkMineC6.UseVisualStyleBackColor = true
        '
        'chkMineC2
        '
        Me.chkMineC2.AutoSize = true
        Me.chkMineC2.Location = New System.Drawing.Point(44, 13)
        Me.chkMineC2.Name = "chkMineC2"
        Me.chkMineC2.Size = New System.Drawing.Size(39, 17)
        Me.chkMineC2.TabIndex = 6
        Me.chkMineC2.Text = "C2"
        Me.chkMineC2.UseVisualStyleBackColor = true
        '
        'chkMineC4
        '
        Me.chkMineC4.AutoSize = true
        Me.chkMineC4.Location = New System.Drawing.Point(122, 13)
        Me.chkMineC4.Name = "chkMineC4"
        Me.chkMineC4.Size = New System.Drawing.Size(39, 17)
        Me.chkMineC4.TabIndex = 8
        Me.chkMineC4.Text = "C4"
        Me.chkMineC4.UseVisualStyleBackColor = true
        '
        'chkMineC1
        '
        Me.chkMineC1.AutoSize = true
        Me.chkMineC1.Location = New System.Drawing.Point(5, 13)
        Me.chkMineC1.Name = "chkMineC1"
        Me.chkMineC1.Size = New System.Drawing.Size(39, 17)
        Me.chkMineC1.TabIndex = 5
        Me.chkMineC1.Text = "C1"
        Me.chkMineC1.UseVisualStyleBackColor = true
        '
        'chkMineC5
        '
        Me.chkMineC5.AutoSize = true
        Me.chkMineC5.Location = New System.Drawing.Point(161, 13)
        Me.chkMineC5.Name = "chkMineC5"
        Me.chkMineC5.Size = New System.Drawing.Size(39, 17)
        Me.chkMineC5.TabIndex = 9
        Me.chkMineC5.Text = "C5"
        Me.chkMineC5.UseVisualStyleBackColor = true
        '
        'chkMineC3
        '
        Me.chkMineC3.AutoSize = true
        Me.chkMineC3.Location = New System.Drawing.Point(83, 13)
        Me.chkMineC3.Name = "chkMineC3"
        Me.chkMineC3.Size = New System.Drawing.Size(39, 17)
        Me.chkMineC3.TabIndex = 7
        Me.chkMineC3.Text = "C3"
        Me.chkMineC3.UseVisualStyleBackColor = true
        '
        'chkMineCaldari
        '
        Me.chkMineCaldari.AutoSize = true
        Me.chkMineCaldari.Location = New System.Drawing.Point(128, 23)
        Me.chkMineCaldari.Name = "chkMineCaldari"
        Me.chkMineCaldari.Size = New System.Drawing.Size(92, 17)
        Me.chkMineCaldari.TabIndex = 1
        Me.chkMineCaldari.Text = "Caldari Space"
        Me.chkMineCaldari.UseVisualStyleBackColor = true
        '
        'chkMineMinmatar
        '
        Me.chkMineMinmatar.AutoSize = true
        Me.chkMineMinmatar.Location = New System.Drawing.Point(128, 44)
        Me.chkMineMinmatar.Name = "chkMineMinmatar"
        Me.chkMineMinmatar.Size = New System.Drawing.Size(103, 17)
        Me.chkMineMinmatar.TabIndex = 3
        Me.chkMineMinmatar.Text = "Minmatar Space"
        Me.chkMineMinmatar.UseVisualStyleBackColor = true
        '
        'chkMineGallente
        '
        Me.chkMineGallente.AutoSize = true
        Me.chkMineGallente.Location = New System.Drawing.Point(11, 44)
        Me.chkMineGallente.Name = "chkMineGallente"
        Me.chkMineGallente.Size = New System.Drawing.Size(99, 17)
        Me.chkMineGallente.TabIndex = 2
        Me.chkMineGallente.Text = "Gallente Space"
        Me.chkMineGallente.UseVisualStyleBackColor = true
        '
        'chkMineAmarr
        '
        Me.chkMineAmarr.AutoSize = true
        Me.chkMineAmarr.Location = New System.Drawing.Point(11, 23)
        Me.chkMineAmarr.Name = "chkMineAmarr"
        Me.chkMineAmarr.Size = New System.Drawing.Size(87, 17)
        Me.chkMineAmarr.TabIndex = 0
        Me.chkMineAmarr.Text = "Amarr Space"
        Me.chkMineAmarr.UseVisualStyleBackColor = true
        '
        'lstMineGrid
        '
        Me.lstMineGrid.FullRowSelect = true
        Me.lstMineGrid.GridLines = true
        Me.lstMineGrid.HideSelection = false
        Me.lstMineGrid.Location = New System.Drawing.Point(5, 276)
        Me.lstMineGrid.MultiSelect = false
        Me.lstMineGrid.Name = "lstMineGrid"
        Me.lstMineGrid.Size = New System.Drawing.Size(700, 332)
        Me.lstMineGrid.TabIndex = 8
        Me.lstMineGrid.UseCompatibleStateImageBehavior = false
        Me.lstMineGrid.View = System.Windows.Forms.View.Details
        '
        'tabReactions
        '
        Me.tabReactions.Controls.Add(Me.gbReactionsTaxesFees)
        Me.tabReactions.Controls.Add(Me.gbReactionsSelectedMats)
        Me.tabReactions.Controls.Add(Me.gbReactions)
        Me.tabReactions.Controls.Add(Me.lstReactions)
        Me.tabReactions.Location = New System.Drawing.Point(4, 22)
        Me.tabReactions.Name = "tabReactions"
        Me.tabReactions.Size = New System.Drawing.Size(1137, 615)
        Me.tabReactions.TabIndex = 4
        Me.tabReactions.Text = "Reactions"
        Me.tabReactions.UseVisualStyleBackColor = true
        '
        'gbReactionsTaxesFees
        '
        Me.gbReactionsTaxesFees.Controls.Add(Me.chkReactionsFees)
        Me.gbReactionsTaxesFees.Controls.Add(Me.chkReactionsTaxes)
        Me.gbReactionsTaxesFees.Controls.Add(Me.lblReactionsFees)
        Me.gbReactionsTaxesFees.Controls.Add(Me.lblReactionsTaxes)
        Me.gbReactionsTaxesFees.Location = New System.Drawing.Point(928, 524)
        Me.gbReactionsTaxesFees.Name = "gbReactionsTaxesFees"
        Me.gbReactionsTaxesFees.Size = New System.Drawing.Size(204, 84)
        Me.gbReactionsTaxesFees.TabIndex = 18
        Me.gbReactionsTaxesFees.TabStop = false
        Me.gbReactionsTaxesFees.Text = "Broker Fees and Taxes:"
        '
        'chkReactionsFees
        '
        Me.chkReactionsFees.AutoSize = true
        Me.chkReactionsFees.Checked = true
        Me.chkReactionsFees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReactionsFees.Location = New System.Drawing.Point(9, 39)
        Me.chkReactionsFees.Name = "chkReactionsFees"
        Me.chkReactionsFees.Size = New System.Drawing.Size(52, 17)
        Me.chkReactionsFees.TabIndex = 10
        Me.chkReactionsFees.Text = "Fees:"
        Me.chkReactionsFees.UseVisualStyleBackColor = true
        '
        'chkReactionsTaxes
        '
        Me.chkReactionsTaxes.AutoSize = true
        Me.chkReactionsTaxes.Checked = true
        Me.chkReactionsTaxes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReactionsTaxes.Location = New System.Drawing.Point(9, 16)
        Me.chkReactionsTaxes.Name = "chkReactionsTaxes"
        Me.chkReactionsTaxes.Size = New System.Drawing.Size(58, 17)
        Me.chkReactionsTaxes.TabIndex = 9
        Me.chkReactionsTaxes.Text = "Taxes:"
        Me.chkReactionsTaxes.UseVisualStyleBackColor = true
        '
        'lblReactionsFees
        '
        Me.lblReactionsFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReactionsFees.Location = New System.Drawing.Point(73, 39)
        Me.lblReactionsFees.Name = "lblReactionsFees"
        Me.lblReactionsFees.Size = New System.Drawing.Size(125, 17)
        Me.lblReactionsFees.TabIndex = 36
        Me.lblReactionsFees.Text = "0.00"
        Me.lblReactionsFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReactionsTaxes
        '
        Me.lblReactionsTaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReactionsTaxes.Location = New System.Drawing.Point(73, 16)
        Me.lblReactionsTaxes.Name = "lblReactionsTaxes"
        Me.lblReactionsTaxes.Size = New System.Drawing.Size(125, 17)
        Me.lblReactionsTaxes.TabIndex = 35
        Me.lblReactionsTaxes.Text = "0.00"
        Me.lblReactionsTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbReactionsSelectedMats
        '
        Me.gbReactionsSelectedMats.Controls.Add(Me.lstReactionMats)
        Me.gbReactionsSelectedMats.Location = New System.Drawing.Point(928, 393)
        Me.gbReactionsSelectedMats.Name = "gbReactionsSelectedMats"
        Me.gbReactionsSelectedMats.Size = New System.Drawing.Size(204, 125)
        Me.gbReactionsSelectedMats.TabIndex = 17
        Me.gbReactionsSelectedMats.TabStop = false
        Me.gbReactionsSelectedMats.Text = "Required Materials for Selection"
        '
        'lstReactionMats
        '
        Me.lstReactionMats.FullRowSelect = true
        Me.lstReactionMats.GridLines = true
        Me.lstReactionMats.HideSelection = false
        Me.lstReactionMats.Location = New System.Drawing.Point(8, 19)
        Me.lstReactionMats.MultiSelect = false
        Me.lstReactionMats.Name = "lstReactionMats"
        Me.lstReactionMats.Size = New System.Drawing.Size(190, 100)
        Me.lstReactionMats.TabIndex = 5
        Me.lstReactionMats.TabStop = false
        Me.lstReactionMats.UseCompatibleStateImageBehavior = false
        Me.lstReactionMats.View = System.Windows.Forms.View.Details
        '
        'gbReactions
        '
        Me.gbReactions.Controls.Add(Me.lblReactionsNumPOS)
        Me.gbReactions.Controls.Add(Me.txtReactionsNumPOS)
        Me.gbReactions.Controls.Add(Me.btnReactionsSaveSettings)
        Me.gbReactions.Controls.Add(Me.gbReactionsHybrid)
        Me.gbReactions.Controls.Add(Me.gbReactionsBiochem)
        Me.gbReactions.Controls.Add(Me.gbReactionsOptions)
        Me.gbReactions.Controls.Add(Me.gbReactionsMoonMats)
        Me.gbReactions.Controls.Add(Me.lblReactionPOSFuelCost)
        Me.gbReactions.Controls.Add(Me.btnReactionRefresh)
        Me.gbReactions.Controls.Add(Me.txtReactionPOSFuelCost)
        Me.gbReactions.Location = New System.Drawing.Point(930, 3)
        Me.gbReactions.Name = "gbReactions"
        Me.gbReactions.Size = New System.Drawing.Size(204, 384)
        Me.gbReactions.TabIndex = 16
        Me.gbReactions.TabStop = false
        '
        'lblReactionsNumPOS
        '
        Me.lblReactionsNumPOS.AutoSize = true
        Me.lblReactionsNumPOS.Location = New System.Drawing.Point(130, 13)
        Me.lblReactionsNumPOS.Name = "lblReactionsNumPOS"
        Me.lblReactionsNumPOS.Size = New System.Drawing.Size(72, 13)
        Me.lblReactionsNumPOS.TabIndex = 18
        Me.lblReactionsNumPOS.Text = "Number POS:"
        '
        'txtReactionsNumPOS
        '
        Me.txtReactionsNumPOS.Location = New System.Drawing.Point(134, 29)
        Me.txtReactionsNumPOS.MaxLength = 2
        Me.txtReactionsNumPOS.Name = "txtReactionsNumPOS"
        Me.txtReactionsNumPOS.Size = New System.Drawing.Size(64, 20)
        Me.txtReactionsNumPOS.TabIndex = 17
        Me.txtReactionsNumPOS.Text = "1"
        Me.txtReactionsNumPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnReactionsSaveSettings
        '
        Me.btnReactionsSaveSettings.Location = New System.Drawing.Point(105, 351)
        Me.btnReactionsSaveSettings.Name = "btnReactionsSaveSettings"
        Me.btnReactionsSaveSettings.Size = New System.Drawing.Size(93, 27)
        Me.btnReactionsSaveSettings.TabIndex = 16
        Me.btnReactionsSaveSettings.Text = "Save Settings"
        Me.btnReactionsSaveSettings.UseVisualStyleBackColor = true
        '
        'gbReactionsHybrid
        '
        Me.gbReactionsHybrid.Controls.Add(Me.chkReactionsHybrid)
        Me.gbReactionsHybrid.Location = New System.Drawing.Point(8, 123)
        Me.gbReactionsHybrid.Name = "gbReactionsHybrid"
        Me.gbReactionsHybrid.Size = New System.Drawing.Size(190, 44)
        Me.gbReactionsHybrid.TabIndex = 4
        Me.gbReactionsHybrid.TabStop = false
        Me.gbReactionsHybrid.Text = "Hybrid Gas"
        '
        'chkReactionsHybrid
        '
        Me.chkReactionsHybrid.AutoSize = true
        Me.chkReactionsHybrid.Location = New System.Drawing.Point(12, 19)
        Me.chkReactionsHybrid.Name = "chkReactionsHybrid"
        Me.chkReactionsHybrid.Size = New System.Drawing.Size(101, 17)
        Me.chkReactionsHybrid.TabIndex = 5
        Me.chkReactionsHybrid.Text = "Hybrid Polymers"
        Me.chkReactionsHybrid.UseVisualStyleBackColor = true
        '
        'gbReactionsBiochem
        '
        Me.gbReactionsBiochem.Controls.Add(Me.chkReactionsSimpleBio)
        Me.gbReactionsBiochem.Controls.Add(Me.chkReactionsComplexBio)
        Me.gbReactionsBiochem.Location = New System.Drawing.Point(8, 173)
        Me.gbReactionsBiochem.Name = "gbReactionsBiochem"
        Me.gbReactionsBiochem.Size = New System.Drawing.Size(190, 69)
        Me.gbReactionsBiochem.TabIndex = 6
        Me.gbReactionsBiochem.TabStop = false
        Me.gbReactionsBiochem.Text = "BioChemical (Boosters)"
        '
        'chkReactionsSimpleBio
        '
        Me.chkReactionsSimpleBio.AutoSize = true
        Me.chkReactionsSimpleBio.Location = New System.Drawing.Point(12, 42)
        Me.chkReactionsSimpleBio.Name = "chkReactionsSimpleBio"
        Me.chkReactionsSimpleBio.Size = New System.Drawing.Size(117, 17)
        Me.chkReactionsSimpleBio.TabIndex = 8
        Me.chkReactionsSimpleBio.Text = "Simple Biochemical"
        Me.chkReactionsSimpleBio.UseVisualStyleBackColor = true
        '
        'chkReactionsComplexBio
        '
        Me.chkReactionsComplexBio.AutoSize = true
        Me.chkReactionsComplexBio.Location = New System.Drawing.Point(12, 19)
        Me.chkReactionsComplexBio.Name = "chkReactionsComplexBio"
        Me.chkReactionsComplexBio.Size = New System.Drawing.Size(126, 17)
        Me.chkReactionsComplexBio.TabIndex = 7
        Me.chkReactionsComplexBio.Text = "Complex Biochemical"
        Me.chkReactionsComplexBio.UseVisualStyleBackColor = true
        '
        'gbReactionsOptions
        '
        Me.gbReactionsOptions.Controls.Add(Me.chkReactionsRefine)
        Me.gbReactionsOptions.Controls.Add(Me.chkReactionsIgnoreBaseMatPrice)
        Me.gbReactionsOptions.Controls.Add(Me.chkReactionsBuildBasic)
        Me.gbReactionsOptions.Location = New System.Drawing.Point(8, 248)
        Me.gbReactionsOptions.Name = "gbReactionsOptions"
        Me.gbReactionsOptions.Size = New System.Drawing.Size(190, 100)
        Me.gbReactionsOptions.TabIndex = 9
        Me.gbReactionsOptions.TabStop = false
        Me.gbReactionsOptions.Text = "Complex Material Options"
        '
        'chkReactionsRefine
        '
        Me.chkReactionsRefine.AutoSize = true
        Me.chkReactionsRefine.Location = New System.Drawing.Point(12, 74)
        Me.chkReactionsRefine.Name = "chkReactionsRefine"
        Me.chkReactionsRefine.Size = New System.Drawing.Size(138, 17)
        Me.chkReactionsRefine.TabIndex = 12
        Me.chkReactionsRefine.Text = "Refine 'Unrefined' Items"
        Me.chkReactionsRefine.UseVisualStyleBackColor = true
        '
        'chkReactionsIgnoreBaseMatPrice
        '
        Me.chkReactionsIgnoreBaseMatPrice.Location = New System.Drawing.Point(12, 41)
        Me.chkReactionsIgnoreBaseMatPrice.Name = "chkReactionsIgnoreBaseMatPrice"
        Me.chkReactionsIgnoreBaseMatPrice.Size = New System.Drawing.Size(152, 32)
        Me.chkReactionsIgnoreBaseMatPrice.TabIndex = 11
        Me.chkReactionsIgnoreBaseMatPrice.Text = "Ignore Market Price for Base Materials"
        Me.chkReactionsIgnoreBaseMatPrice.UseVisualStyleBackColor = true
        '
        'chkReactionsBuildBasic
        '
        Me.chkReactionsBuildBasic.Location = New System.Drawing.Point(12, 14)
        Me.chkReactionsBuildBasic.Name = "chkReactionsBuildBasic"
        Me.chkReactionsBuildBasic.Size = New System.Drawing.Size(152, 32)
        Me.chkReactionsBuildBasic.TabIndex = 10
        Me.chkReactionsBuildBasic.Text = "Build Basic Compounds for Advanced Materials"
        Me.chkReactionsBuildBasic.UseVisualStyleBackColor = true
        '
        'gbReactionsMoonMats
        '
        Me.gbReactionsMoonMats.Controls.Add(Me.chkReactionsAdvMoonMats)
        Me.gbReactionsMoonMats.Controls.Add(Me.chkReactionsProcMoonMats)
        Me.gbReactionsMoonMats.Location = New System.Drawing.Point(8, 52)
        Me.gbReactionsMoonMats.Name = "gbReactionsMoonMats"
        Me.gbReactionsMoonMats.Size = New System.Drawing.Size(190, 65)
        Me.gbReactionsMoonMats.TabIndex = 1
        Me.gbReactionsMoonMats.TabStop = false
        Me.gbReactionsMoonMats.Text = "Moon Materials"
        '
        'chkReactionsAdvMoonMats
        '
        Me.chkReactionsAdvMoonMats.AutoSize = true
        Me.chkReactionsAdvMoonMats.Location = New System.Drawing.Point(12, 19)
        Me.chkReactionsAdvMoonMats.Name = "chkReactionsAdvMoonMats"
        Me.chkReactionsAdvMoonMats.Size = New System.Drawing.Size(150, 17)
        Me.chkReactionsAdvMoonMats.TabIndex = 2
        Me.chkReactionsAdvMoonMats.Text = "Advanced Moon Materials"
        Me.chkReactionsAdvMoonMats.UseVisualStyleBackColor = true
        '
        'chkReactionsProcMoonMats
        '
        Me.chkReactionsProcMoonMats.AutoSize = true
        Me.chkReactionsProcMoonMats.Location = New System.Drawing.Point(12, 42)
        Me.chkReactionsProcMoonMats.Name = "chkReactionsProcMoonMats"
        Me.chkReactionsProcMoonMats.Size = New System.Drawing.Size(151, 17)
        Me.chkReactionsProcMoonMats.TabIndex = 3
        Me.chkReactionsProcMoonMats.Text = "Processed Moon Materials"
        Me.chkReactionsProcMoonMats.UseVisualStyleBackColor = true
        '
        'lblReactionPOSFuelCost
        '
        Me.lblReactionPOSFuelCost.AutoSize = true
        Me.lblReactionPOSFuelCost.Location = New System.Drawing.Point(6, 13)
        Me.lblReactionPOSFuelCost.Name = "lblReactionPOSFuelCost"
        Me.lblReactionPOSFuelCost.Size = New System.Drawing.Size(112, 13)
        Me.lblReactionPOSFuelCost.TabIndex = 15
        Me.lblReactionPOSFuelCost.Text = "Hourly POS Fuel Cost:"
        '
        'btnReactionRefresh
        '
        Me.btnReactionRefresh.Location = New System.Drawing.Point(8, 351)
        Me.btnReactionRefresh.Name = "btnReactionRefresh"
        Me.btnReactionRefresh.Size = New System.Drawing.Size(93, 27)
        Me.btnReactionRefresh.TabIndex = 12
        Me.btnReactionRefresh.Text = "Refresh"
        Me.btnReactionRefresh.UseVisualStyleBackColor = true
        '
        'txtReactionPOSFuelCost
        '
        Me.txtReactionPOSFuelCost.Location = New System.Drawing.Point(8, 29)
        Me.txtReactionPOSFuelCost.Name = "txtReactionPOSFuelCost"
        Me.txtReactionPOSFuelCost.Size = New System.Drawing.Size(118, 20)
        Me.txtReactionPOSFuelCost.TabIndex = 0
        Me.txtReactionPOSFuelCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstReactions
        '
        Me.lstReactions.FullRowSelect = true
        Me.lstReactions.GridLines = true
        Me.lstReactions.HideSelection = false
        Me.lstReactions.Location = New System.Drawing.Point(2, 8)
        Me.lstReactions.MultiSelect = false
        Me.lstReactions.Name = "lstReactions"
        Me.lstReactions.Size = New System.Drawing.Size(922, 600)
        Me.lstReactions.TabIndex = 4
        Me.lstReactions.TabStop = false
        Me.lstReactions.UseCompatibleStateImageBehavior = false
        Me.lstReactions.View = System.Windows.Forms.View.Details
        '
        'tabDatacores
        '
        Me.tabDatacores.Controls.Add(Me.lstDC)
        Me.tabDatacores.Controls.Add(Me.gbDCOptions)
        Me.tabDatacores.Location = New System.Drawing.Point(4, 22)
        Me.tabDatacores.Name = "tabDatacores"
        Me.tabDatacores.Size = New System.Drawing.Size(1137, 615)
        Me.tabDatacores.TabIndex = 3
        Me.tabDatacores.Text = "Datacores"
        Me.tabDatacores.UseVisualStyleBackColor = true
        '
        'lstDC
        '
        Me.lstDC.CheckBoxes = true
        Me.lstDC.FullRowSelect = true
        Me.lstDC.GridLines = true
        Me.lstDC.HideSelection = false
        Me.lstDC.Location = New System.Drawing.Point(5, 8)
        Me.lstDC.Name = "lstDC"
        Me.lstDC.Size = New System.Drawing.Size(1124, 282)
        Me.lstDC.TabIndex = 10
        Me.lstDC.UseCompatibleStateImageBehavior = false
        Me.lstDC.View = System.Windows.Forms.View.Details
        '
        'gbDCOptions
        '
        Me.gbDCOptions.Controls.Add(Me.btnDCSaveSettings)
        Me.gbDCOptions.Controls.Add(Me.gbDCAgentLocSov)
        Me.gbDCOptions.Controls.Add(Me.gbDCTotalIPH)
        Me.gbDCOptions.Controls.Add(Me.gbDCPrices)
        Me.gbDCOptions.Controls.Add(Me.gbDCAgentTypes)
        Me.gbDCOptions.Controls.Add(Me.gbDCBaseSkills)
        Me.gbDCOptions.Controls.Add(Me.gbDCDatacores)
        Me.gbDCOptions.Controls.Add(Me.gbDCCorpMinmatar)
        Me.gbDCOptions.Controls.Add(Me.btnDCExporttoClip)
        Me.gbDCOptions.Controls.Add(Me.gbDCCorpAmarr)
        Me.gbDCOptions.Controls.Add(Me.btnDCReset)
        Me.gbDCOptions.Controls.Add(Me.gbDCCorpsCaldari)
        Me.gbDCOptions.Controls.Add(Me.gbDCCorpsGallente)
        Me.gbDCOptions.Controls.Add(Me.btnDCRefresh)
        Me.gbDCOptions.Location = New System.Drawing.Point(5, 286)
        Me.gbDCOptions.Name = "gbDCOptions"
        Me.gbDCOptions.Size = New System.Drawing.Size(1124, 323)
        Me.gbDCOptions.TabIndex = 9
        Me.gbDCOptions.TabStop = false
        '
        'btnDCSaveSettings
        '
        Me.btnDCSaveSettings.Location = New System.Drawing.Point(980, 176)
        Me.btnDCSaveSettings.Name = "btnDCSaveSettings"
        Me.btnDCSaveSettings.Size = New System.Drawing.Size(138, 30)
        Me.btnDCSaveSettings.TabIndex = 71
        Me.btnDCSaveSettings.Text = "Save Settings"
        Me.btnDCSaveSettings.UseVisualStyleBackColor = true
        '
        'gbDCAgentLocSov
        '
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCThukkerSov)
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCKhanidSov)
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCMinmatarSov)
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCSyndicateSov)
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCGallenteSov)
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCAmarrSov)
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCAmmatarSov)
        Me.gbDCAgentLocSov.Controls.Add(Me.chkDCCaldariSov)
        Me.gbDCAgentLocSov.Location = New System.Drawing.Point(746, 241)
        Me.gbDCAgentLocSov.Name = "gbDCAgentLocSov"
        Me.gbDCAgentLocSov.Size = New System.Drawing.Size(372, 76)
        Me.gbDCAgentLocSov.TabIndex = 63
        Me.gbDCAgentLocSov.TabStop = false
        Me.gbDCAgentLocSov.Text = "Agent Location Sovergnity:"
        '
        'chkDCThukkerSov
        '
        Me.chkDCThukkerSov.AutoSize = true
        Me.chkDCThukkerSov.Location = New System.Drawing.Point(272, 36)
        Me.chkDCThukkerSov.Name = "chkDCThukkerSov"
        Me.chkDCThukkerSov.Size = New System.Drawing.Size(93, 17)
        Me.chkDCThukkerSov.TabIndex = 34
        Me.chkDCThukkerSov.Text = "Thukker Tribe"
        Me.chkDCThukkerSov.UseVisualStyleBackColor = true
        '
        'chkDCKhanidSov
        '
        Me.chkDCKhanidSov.AutoSize = true
        Me.chkDCKhanidSov.Location = New System.Drawing.Point(127, 36)
        Me.chkDCKhanidSov.Name = "chkDCKhanidSov"
        Me.chkDCKhanidSov.Size = New System.Drawing.Size(103, 17)
        Me.chkDCKhanidSov.TabIndex = 31
        Me.chkDCKhanidSov.Text = "Khanid Kingdom"
        Me.chkDCKhanidSov.UseVisualStyleBackColor = true
        '
        'chkDCMinmatarSov
        '
        Me.chkDCMinmatarSov.AutoSize = true
        Me.chkDCMinmatarSov.Location = New System.Drawing.Point(127, 53)
        Me.chkDCMinmatarSov.Name = "chkDCMinmatarSov"
        Me.chkDCMinmatarSov.Size = New System.Drawing.Size(114, 17)
        Me.chkDCMinmatarSov.TabIndex = 32
        Me.chkDCMinmatarSov.Text = "Minmatar Republic"
        Me.chkDCMinmatarSov.UseVisualStyleBackColor = true
        '
        'chkDCSyndicateSov
        '
        Me.chkDCSyndicateSov.AutoSize = true
        Me.chkDCSyndicateSov.Location = New System.Drawing.Point(272, 19)
        Me.chkDCSyndicateSov.Name = "chkDCSyndicateSov"
        Me.chkDCSyndicateSov.Size = New System.Drawing.Size(95, 17)
        Me.chkDCSyndicateSov.TabIndex = 33
        Me.chkDCSyndicateSov.Text = "The Syndicate"
        Me.chkDCSyndicateSov.UseVisualStyleBackColor = true
        '
        'chkDCGallenteSov
        '
        Me.chkDCGallenteSov.AutoSize = true
        Me.chkDCGallenteSov.Location = New System.Drawing.Point(127, 19)
        Me.chkDCGallenteSov.Name = "chkDCGallenteSov"
        Me.chkDCGallenteSov.Size = New System.Drawing.Size(118, 17)
        Me.chkDCGallenteSov.TabIndex = 30
        Me.chkDCGallenteSov.Text = "Gallente Federation"
        Me.chkDCGallenteSov.UseVisualStyleBackColor = true
        '
        'chkDCAmarrSov
        '
        Me.chkDCAmarrSov.AutoSize = true
        Me.chkDCAmarrSov.Location = New System.Drawing.Point(12, 19)
        Me.chkDCAmarrSov.Name = "chkDCAmarrSov"
        Me.chkDCAmarrSov.Size = New System.Drawing.Size(88, 17)
        Me.chkDCAmarrSov.TabIndex = 27
        Me.chkDCAmarrSov.Text = "Amarr Empire"
        Me.chkDCAmarrSov.UseVisualStyleBackColor = true
        '
        'chkDCAmmatarSov
        '
        Me.chkDCAmmatarSov.AutoSize = true
        Me.chkDCAmmatarSov.Location = New System.Drawing.Point(12, 36)
        Me.chkDCAmmatarSov.Name = "chkDCAmmatarSov"
        Me.chkDCAmmatarSov.Size = New System.Drawing.Size(112, 17)
        Me.chkDCAmmatarSov.TabIndex = 28
        Me.chkDCAmmatarSov.Text = "Ammatar Mandate"
        Me.chkDCAmmatarSov.UseVisualStyleBackColor = true
        '
        'chkDCCaldariSov
        '
        Me.chkDCCaldariSov.AutoSize = true
        Me.chkDCCaldariSov.Location = New System.Drawing.Point(12, 53)
        Me.chkDCCaldariSov.Name = "chkDCCaldariSov"
        Me.chkDCCaldariSov.Size = New System.Drawing.Size(86, 17)
        Me.chkDCCaldariSov.TabIndex = 29
        Me.chkDCCaldariSov.Text = "Caldari State"
        Me.chkDCCaldariSov.UseVisualStyleBackColor = true
        '
        'gbDCTotalIPH
        '
        Me.gbDCTotalIPH.Controls.Add(Me.lblDCTotalOptIPH)
        Me.gbDCTotalIPH.Controls.Add(Me.lblDCTotalSelectedIPH)
        Me.gbDCTotalIPH.Controls.Add(Me.txtDCTotalSelectedIPH)
        Me.gbDCTotalIPH.Controls.Add(Me.txtDCTotalOptIPH)
        Me.gbDCTotalIPH.Location = New System.Drawing.Point(978, 11)
        Me.gbDCTotalIPH.Name = "gbDCTotalIPH"
        Me.gbDCTotalIPH.Size = New System.Drawing.Size(140, 101)
        Me.gbDCTotalIPH.TabIndex = 70
        Me.gbDCTotalIPH.TabStop = false
        Me.gbDCTotalIPH.Text = "Total Isk per Hour:"
        '
        'lblDCTotalOptIPH
        '
        Me.lblDCTotalOptIPH.Location = New System.Drawing.Point(5, 56)
        Me.lblDCTotalOptIPH.Name = "lblDCTotalOptIPH"
        Me.lblDCTotalOptIPH.Size = New System.Drawing.Size(81, 13)
        Me.lblDCTotalOptIPH.TabIndex = 47
        Me.lblDCTotalOptIPH.Text = "Total Optimal:"
        '
        'lblDCTotalSelectedIPH
        '
        Me.lblDCTotalSelectedIPH.Location = New System.Drawing.Point(5, 19)
        Me.lblDCTotalSelectedIPH.Name = "lblDCTotalSelectedIPH"
        Me.lblDCTotalSelectedIPH.Size = New System.Drawing.Size(81, 13)
        Me.lblDCTotalSelectedIPH.TabIndex = 46
        Me.lblDCTotalSelectedIPH.Text = "Total Selected:"
        '
        'txtDCTotalSelectedIPH
        '
        Me.txtDCTotalSelectedIPH.Location = New System.Drawing.Point(5, 33)
        Me.txtDCTotalSelectedIPH.Name = "txtDCTotalSelectedIPH"
        Me.txtDCTotalSelectedIPH.Size = New System.Drawing.Size(129, 20)
        Me.txtDCTotalSelectedIPH.TabIndex = 41
        Me.txtDCTotalSelectedIPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDCTotalOptIPH
        '
        Me.txtDCTotalOptIPH.Location = New System.Drawing.Point(5, 71)
        Me.txtDCTotalOptIPH.Name = "txtDCTotalOptIPH"
        Me.txtDCTotalOptIPH.Size = New System.Drawing.Size(129, 20)
        Me.txtDCTotalOptIPH.TabIndex = 40
        Me.txtDCTotalOptIPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbDCPrices
        '
        Me.gbDCPrices.Controls.Add(Me.rbtnDCSystemPrices)
        Me.gbDCPrices.Controls.Add(Me.rbtnDCRegionPrices)
        Me.gbDCPrices.Controls.Add(Me.rbtnDCUpdatedPrices)
        Me.gbDCPrices.Location = New System.Drawing.Point(6, 277)
        Me.gbDCPrices.Name = "gbDCPrices"
        Me.gbDCPrices.Size = New System.Drawing.Size(506, 40)
        Me.gbDCPrices.TabIndex = 7
        Me.gbDCPrices.TabStop = false
        Me.gbDCPrices.Text = "Use Prices From:"
        '
        'rbtnDCSystemPrices
        '
        Me.rbtnDCSystemPrices.AutoSize = true
        Me.rbtnDCSystemPrices.Location = New System.Drawing.Point(313, 16)
        Me.rbtnDCSystemPrices.Name = "rbtnDCSystemPrices"
        Me.rbtnDCSystemPrices.Size = New System.Drawing.Size(90, 17)
        Me.rbtnDCSystemPrices.TabIndex = 2
        Me.rbtnDCSystemPrices.TabStop = true
        Me.rbtnDCSystemPrices.Text = "Agent System"
        Me.rbtnDCSystemPrices.UseVisualStyleBackColor = true
        '
        'rbtnDCRegionPrices
        '
        Me.rbtnDCRegionPrices.AutoSize = true
        Me.rbtnDCRegionPrices.Location = New System.Drawing.Point(164, 16)
        Me.rbtnDCRegionPrices.Name = "rbtnDCRegionPrices"
        Me.rbtnDCRegionPrices.Size = New System.Drawing.Size(90, 17)
        Me.rbtnDCRegionPrices.TabIndex = 1
        Me.rbtnDCRegionPrices.TabStop = true
        Me.rbtnDCRegionPrices.Text = "Agent Region"
        Me.rbtnDCRegionPrices.UseVisualStyleBackColor = true
        '
        'rbtnDCUpdatedPrices
        '
        Me.rbtnDCUpdatedPrices.AutoSize = true
        Me.rbtnDCUpdatedPrices.Location = New System.Drawing.Point(7, 16)
        Me.rbtnDCUpdatedPrices.Name = "rbtnDCUpdatedPrices"
        Me.rbtnDCUpdatedPrices.Size = New System.Drawing.Size(98, 17)
        Me.rbtnDCUpdatedPrices.TabIndex = 0
        Me.rbtnDCUpdatedPrices.TabStop = true
        Me.rbtnDCUpdatedPrices.Text = "Updated Prices"
        Me.rbtnDCUpdatedPrices.UseVisualStyleBackColor = true
        '
        'gbDCAgentTypes
        '
        Me.gbDCAgentTypes.Controls.Add(Me.cmbDCRegions)
        Me.gbDCAgentTypes.Controls.Add(Me.lblDCRegion)
        Me.gbDCAgentTypes.Controls.Add(Me.chkDCLowSecAgents)
        Me.gbDCAgentTypes.Controls.Add(Me.chkDCHighSecAgents)
        Me.gbDCAgentTypes.Controls.Add(Me.chkDCIncludeAllAgents)
        Me.gbDCAgentTypes.Location = New System.Drawing.Point(518, 214)
        Me.gbDCAgentTypes.Name = "gbDCAgentTypes"
        Me.gbDCAgentTypes.Size = New System.Drawing.Size(222, 104)
        Me.gbDCAgentTypes.TabIndex = 69
        Me.gbDCAgentTypes.TabStop = false
        Me.gbDCAgentTypes.Text = "Agents:"
        '
        'cmbDCRegions
        '
        Me.cmbDCRegions.FormattingEnabled = true
        Me.cmbDCRegions.Location = New System.Drawing.Point(65, 70)
        Me.cmbDCRegions.Name = "cmbDCRegions"
        Me.cmbDCRegions.Size = New System.Drawing.Size(144, 21)
        Me.cmbDCRegions.TabIndex = 6
        Me.cmbDCRegions.Text = "All Regions"
        '
        'lblDCRegion
        '
        Me.lblDCRegion.Location = New System.Drawing.Point(9, 73)
        Me.lblDCRegion.Name = "lblDCRegion"
        Me.lblDCRegion.Size = New System.Drawing.Size(59, 13)
        Me.lblDCRegion.TabIndex = 7
        Me.lblDCRegion.Text = "In Region:"
        '
        'chkDCLowSecAgents
        '
        Me.chkDCLowSecAgents.AutoSize = true
        Me.chkDCLowSecAgents.Location = New System.Drawing.Point(97, 21)
        Me.chkDCLowSecAgents.Name = "chkDCLowSecAgents"
        Me.chkDCLowSecAgents.Size = New System.Drawing.Size(91, 17)
        Me.chkDCLowSecAgents.TabIndex = 1
        Me.chkDCLowSecAgents.Text = "Low/Null Sec"
        Me.chkDCLowSecAgents.UseVisualStyleBackColor = true
        '
        'chkDCHighSecAgents
        '
        Me.chkDCHighSecAgents.AutoSize = true
        Me.chkDCHighSecAgents.Location = New System.Drawing.Point(12, 21)
        Me.chkDCHighSecAgents.Name = "chkDCHighSecAgents"
        Me.chkDCHighSecAgents.Size = New System.Drawing.Size(70, 17)
        Me.chkDCHighSecAgents.TabIndex = 0
        Me.chkDCHighSecAgents.Text = "High Sec"
        Me.chkDCHighSecAgents.UseVisualStyleBackColor = true
        '
        'chkDCIncludeAllAgents
        '
        Me.chkDCIncludeAllAgents.AutoSize = true
        Me.chkDCIncludeAllAgents.Location = New System.Drawing.Point(12, 44)
        Me.chkDCIncludeAllAgents.Name = "chkDCIncludeAllAgents"
        Me.chkDCIncludeAllAgents.Size = New System.Drawing.Size(178, 17)
        Me.chkDCIncludeAllAgents.TabIndex = 0
        Me.chkDCIncludeAllAgents.Text = "Include Agents I Cannot Access"
        Me.chkDCIncludeAllAgents.UseVisualStyleBackColor = true
        '
        'gbDCBaseSkills
        '
        Me.gbDCBaseSkills.Controls.Add(Me.cmbDCResearchMgmt)
        Me.gbDCBaseSkills.Controls.Add(Me.lblDCResearchManagement)
        Me.gbDCBaseSkills.Controls.Add(Me.lblDCNegotiation)
        Me.gbDCBaseSkills.Controls.Add(Me.cmbDCConnections)
        Me.gbDCBaseSkills.Controls.Add(Me.lblDCConnections)
        Me.gbDCBaseSkills.Controls.Add(Me.cmbDCNegotiation)
        Me.gbDCBaseSkills.Location = New System.Drawing.Point(6, 236)
        Me.gbDCBaseSkills.Name = "gbDCBaseSkills"
        Me.gbDCBaseSkills.Size = New System.Drawing.Size(506, 40)
        Me.gbDCBaseSkills.TabIndex = 9
        Me.gbDCBaseSkills.TabStop = false
        Me.gbDCBaseSkills.Text = "Base Skills:"
        '
        'cmbDCResearchMgmt
        '
        Me.cmbDCResearchMgmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCResearchMgmt.FormattingEnabled = true
        Me.cmbDCResearchMgmt.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCResearchMgmt.Location = New System.Drawing.Point(396, 13)
        Me.cmbDCResearchMgmt.Name = "cmbDCResearchMgmt"
        Me.cmbDCResearchMgmt.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCResearchMgmt.TabIndex = 60
        '
        'lblDCResearchManagement
        '
        Me.lblDCResearchManagement.AutoSize = true
        Me.lblDCResearchManagement.Location = New System.Drawing.Point(269, 17)
        Me.lblDCResearchManagement.Name = "lblDCResearchManagement"
        Me.lblDCResearchManagement.Size = New System.Drawing.Size(121, 13)
        Me.lblDCResearchManagement.TabIndex = 59
        Me.lblDCResearchManagement.Text = "Research Project Mgmt:"
        '
        'lblDCNegotiation
        '
        Me.lblDCNegotiation.AutoSize = true
        Me.lblDCNegotiation.Location = New System.Drawing.Point(6, 17)
        Me.lblDCNegotiation.Name = "lblDCNegotiation"
        Me.lblDCNegotiation.Size = New System.Drawing.Size(64, 13)
        Me.lblDCNegotiation.TabIndex = 58
        Me.lblDCNegotiation.Text = "Negotiation:"
        '
        'cmbDCConnections
        '
        Me.cmbDCConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCConnections.FormattingEnabled = true
        Me.cmbDCConnections.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCConnections.Location = New System.Drawing.Point(218, 13)
        Me.cmbDCConnections.Name = "cmbDCConnections"
        Me.cmbDCConnections.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCConnections.TabIndex = 55
        '
        'lblDCConnections
        '
        Me.lblDCConnections.AutoSize = true
        Me.lblDCConnections.Location = New System.Drawing.Point(143, 17)
        Me.lblDCConnections.Name = "lblDCConnections"
        Me.lblDCConnections.Size = New System.Drawing.Size(69, 13)
        Me.lblDCConnections.TabIndex = 57
        Me.lblDCConnections.Text = "Connections:"
        '
        'cmbDCNegotiation
        '
        Me.cmbDCNegotiation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCNegotiation.FormattingEnabled = true
        Me.cmbDCNegotiation.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCNegotiation.Location = New System.Drawing.Point(76, 13)
        Me.cmbDCNegotiation.Name = "cmbDCNegotiation"
        Me.cmbDCNegotiation.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCNegotiation.TabIndex = 56
        '
        'gbDCDatacores
        '
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel17)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel16)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel15)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel14)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel13)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel12)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel11)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel10)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel9)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel8)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel7)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel6)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel5)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel4)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel3)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel2)
        Me.gbDCDatacores.Controls.Add(Me.cmbDCSkillLevel1)
        Me.gbDCDatacores.Controls.Add(Me.chkDC17)
        Me.gbDCDatacores.Controls.Add(Me.chkDC4)
        Me.gbDCDatacores.Controls.Add(Me.chkDC16)
        Me.gbDCDatacores.Controls.Add(Me.chkDC3)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore17)
        Me.gbDCDatacores.Controls.Add(Me.chkDC15)
        Me.gbDCDatacores.Controls.Add(Me.chkDC2)
        Me.gbDCDatacores.Controls.Add(Me.chkDC14)
        Me.gbDCDatacores.Controls.Add(Me.chkDC1)
        Me.gbDCDatacores.Controls.Add(Me.chkDC13)
        Me.gbDCDatacores.Controls.Add(Me.chkDC12)
        Me.gbDCDatacores.Controls.Add(Me.chkDC11)
        Me.gbDCDatacores.Controls.Add(Me.chkDC10)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore16)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore4)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore15)
        Me.gbDCDatacores.Controls.Add(Me.chkDC9)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore14)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore3)
        Me.gbDCDatacores.Controls.Add(Me.chkDC8)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore13)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore2)
        Me.gbDCDatacores.Controls.Add(Me.chkDC7)
        Me.gbDCDatacores.Controls.Add(Me.chkDC6)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore1)
        Me.gbDCDatacores.Controls.Add(Me.chkDC5)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore5)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore6)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore7)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore8)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore12)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore11)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore10)
        Me.gbDCDatacores.Controls.Add(Me.lblDatacore9)
        Me.gbDCDatacores.Controls.Add(Me.gbDCCodes)
        Me.gbDCDatacores.Location = New System.Drawing.Point(6, 11)
        Me.gbDCDatacores.Name = "gbDCDatacores"
        Me.gbDCDatacores.Size = New System.Drawing.Size(506, 224)
        Me.gbDCDatacores.TabIndex = 3
        Me.gbDCDatacores.TabStop = false
        Me.gbDCDatacores.Text = "Datacore Skills:"
        '
        'cmbDCSkillLevel17
        '
        Me.cmbDCSkillLevel17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel17.FormattingEnabled = true
        Me.cmbDCSkillLevel17.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel17.Location = New System.Drawing.Point(465, 167)
        Me.cmbDCSkillLevel17.Name = "cmbDCSkillLevel17"
        Me.cmbDCSkillLevel17.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel17.TabIndex = 55
        '
        'cmbDCSkillLevel16
        '
        Me.cmbDCSkillLevel16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel16.FormattingEnabled = true
        Me.cmbDCSkillLevel16.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel16.Location = New System.Drawing.Point(465, 145)
        Me.cmbDCSkillLevel16.Name = "cmbDCSkillLevel16"
        Me.cmbDCSkillLevel16.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel16.TabIndex = 54
        '
        'cmbDCSkillLevel15
        '
        Me.cmbDCSkillLevel15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel15.FormattingEnabled = true
        Me.cmbDCSkillLevel15.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel15.Location = New System.Drawing.Point(465, 122)
        Me.cmbDCSkillLevel15.Name = "cmbDCSkillLevel15"
        Me.cmbDCSkillLevel15.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel15.TabIndex = 53
        '
        'cmbDCSkillLevel14
        '
        Me.cmbDCSkillLevel14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel14.FormattingEnabled = true
        Me.cmbDCSkillLevel14.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel14.Location = New System.Drawing.Point(465, 100)
        Me.cmbDCSkillLevel14.Name = "cmbDCSkillLevel14"
        Me.cmbDCSkillLevel14.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel14.TabIndex = 52
        '
        'cmbDCSkillLevel13
        '
        Me.cmbDCSkillLevel13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel13.FormattingEnabled = true
        Me.cmbDCSkillLevel13.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel13.Location = New System.Drawing.Point(465, 78)
        Me.cmbDCSkillLevel13.Name = "cmbDCSkillLevel13"
        Me.cmbDCSkillLevel13.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel13.TabIndex = 51
        '
        'cmbDCSkillLevel12
        '
        Me.cmbDCSkillLevel12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel12.FormattingEnabled = true
        Me.cmbDCSkillLevel12.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel12.Location = New System.Drawing.Point(465, 55)
        Me.cmbDCSkillLevel12.Name = "cmbDCSkillLevel12"
        Me.cmbDCSkillLevel12.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel12.TabIndex = 50
        '
        'cmbDCSkillLevel11
        '
        Me.cmbDCSkillLevel11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel11.FormattingEnabled = true
        Me.cmbDCSkillLevel11.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel11.Location = New System.Drawing.Point(465, 33)
        Me.cmbDCSkillLevel11.Name = "cmbDCSkillLevel11"
        Me.cmbDCSkillLevel11.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel11.TabIndex = 49
        '
        'cmbDCSkillLevel10
        '
        Me.cmbDCSkillLevel10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel10.FormattingEnabled = true
        Me.cmbDCSkillLevel10.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel10.Location = New System.Drawing.Point(218, 191)
        Me.cmbDCSkillLevel10.Name = "cmbDCSkillLevel10"
        Me.cmbDCSkillLevel10.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel10.TabIndex = 48
        '
        'cmbDCSkillLevel9
        '
        Me.cmbDCSkillLevel9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel9.FormattingEnabled = true
        Me.cmbDCSkillLevel9.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel9.Location = New System.Drawing.Point(465, 11)
        Me.cmbDCSkillLevel9.Name = "cmbDCSkillLevel9"
        Me.cmbDCSkillLevel9.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel9.TabIndex = 47
        '
        'cmbDCSkillLevel8
        '
        Me.cmbDCSkillLevel8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel8.FormattingEnabled = true
        Me.cmbDCSkillLevel8.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel8.Location = New System.Drawing.Point(218, 169)
        Me.cmbDCSkillLevel8.Name = "cmbDCSkillLevel8"
        Me.cmbDCSkillLevel8.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel8.TabIndex = 46
        '
        'cmbDCSkillLevel7
        '
        Me.cmbDCSkillLevel7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel7.FormattingEnabled = true
        Me.cmbDCSkillLevel7.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel7.Location = New System.Drawing.Point(218, 147)
        Me.cmbDCSkillLevel7.Name = "cmbDCSkillLevel7"
        Me.cmbDCSkillLevel7.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel7.TabIndex = 45
        '
        'cmbDCSkillLevel6
        '
        Me.cmbDCSkillLevel6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel6.FormattingEnabled = true
        Me.cmbDCSkillLevel6.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel6.Location = New System.Drawing.Point(218, 124)
        Me.cmbDCSkillLevel6.Name = "cmbDCSkillLevel6"
        Me.cmbDCSkillLevel6.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel6.TabIndex = 44
        '
        'cmbDCSkillLevel5
        '
        Me.cmbDCSkillLevel5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel5.FormattingEnabled = true
        Me.cmbDCSkillLevel5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel5.Location = New System.Drawing.Point(218, 102)
        Me.cmbDCSkillLevel5.Name = "cmbDCSkillLevel5"
        Me.cmbDCSkillLevel5.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel5.TabIndex = 43
        '
        'cmbDCSkillLevel4
        '
        Me.cmbDCSkillLevel4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel4.FormattingEnabled = true
        Me.cmbDCSkillLevel4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel4.Location = New System.Drawing.Point(218, 80)
        Me.cmbDCSkillLevel4.Name = "cmbDCSkillLevel4"
        Me.cmbDCSkillLevel4.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel4.TabIndex = 42
        '
        'cmbDCSkillLevel3
        '
        Me.cmbDCSkillLevel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel3.FormattingEnabled = true
        Me.cmbDCSkillLevel3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel3.Location = New System.Drawing.Point(218, 57)
        Me.cmbDCSkillLevel3.Name = "cmbDCSkillLevel3"
        Me.cmbDCSkillLevel3.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel3.TabIndex = 41
        '
        'cmbDCSkillLevel2
        '
        Me.cmbDCSkillLevel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel2.FormattingEnabled = true
        Me.cmbDCSkillLevel2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel2.Location = New System.Drawing.Point(218, 35)
        Me.cmbDCSkillLevel2.Name = "cmbDCSkillLevel2"
        Me.cmbDCSkillLevel2.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel2.TabIndex = 40
        '
        'cmbDCSkillLevel1
        '
        Me.cmbDCSkillLevel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDCSkillLevel1.FormattingEnabled = true
        Me.cmbDCSkillLevel1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbDCSkillLevel1.Location = New System.Drawing.Point(218, 13)
        Me.cmbDCSkillLevel1.Name = "cmbDCSkillLevel1"
        Me.cmbDCSkillLevel1.Size = New System.Drawing.Size(36, 21)
        Me.cmbDCSkillLevel1.TabIndex = 39
        '
        'chkDC17
        '
        Me.chkDC17.AutoSize = true
        Me.chkDC17.Location = New System.Drawing.Point(277, 172)
        Me.chkDC17.Name = "chkDC17"
        Me.chkDC17.Size = New System.Drawing.Size(15, 14)
        Me.chkDC17.TabIndex = 38
        Me.chkDC17.UseVisualStyleBackColor = true
        '
        'chkDC4
        '
        Me.chkDC4.AutoSize = true
        Me.chkDC4.Location = New System.Drawing.Point(7, 83)
        Me.chkDC4.Name = "chkDC4"
        Me.chkDC4.Size = New System.Drawing.Size(15, 14)
        Me.chkDC4.TabIndex = 30
        Me.chkDC4.UseVisualStyleBackColor = true
        '
        'chkDC16
        '
        Me.chkDC16.AutoSize = true
        Me.chkDC16.Location = New System.Drawing.Point(277, 150)
        Me.chkDC16.Name = "chkDC16"
        Me.chkDC16.Size = New System.Drawing.Size(15, 14)
        Me.chkDC16.TabIndex = 37
        Me.chkDC16.UseVisualStyleBackColor = true
        '
        'chkDC3
        '
        Me.chkDC3.AutoSize = true
        Me.chkDC3.Location = New System.Drawing.Point(7, 60)
        Me.chkDC3.Name = "chkDC3"
        Me.chkDC3.Size = New System.Drawing.Size(15, 14)
        Me.chkDC3.TabIndex = 29
        Me.chkDC3.UseVisualStyleBackColor = true
        '
        'lblDatacore17
        '
        Me.lblDatacore17.Location = New System.Drawing.Point(298, 173)
        Me.lblDatacore17.Name = "lblDatacore17"
        Me.lblDatacore17.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore17.TabIndex = 24
        Me.lblDatacore17.Text = "Rocket Science"
        '
        'chkDC15
        '
        Me.chkDC15.AutoSize = true
        Me.chkDC15.Location = New System.Drawing.Point(277, 127)
        Me.chkDC15.Name = "chkDC15"
        Me.chkDC15.Size = New System.Drawing.Size(15, 14)
        Me.chkDC15.TabIndex = 36
        Me.chkDC15.UseVisualStyleBackColor = true
        '
        'chkDC2
        '
        Me.chkDC2.AutoSize = true
        Me.chkDC2.Location = New System.Drawing.Point(7, 38)
        Me.chkDC2.Name = "chkDC2"
        Me.chkDC2.Size = New System.Drawing.Size(15, 14)
        Me.chkDC2.TabIndex = 28
        Me.chkDC2.UseVisualStyleBackColor = true
        '
        'chkDC14
        '
        Me.chkDC14.AutoSize = true
        Me.chkDC14.Location = New System.Drawing.Point(277, 105)
        Me.chkDC14.Name = "chkDC14"
        Me.chkDC14.Size = New System.Drawing.Size(15, 14)
        Me.chkDC14.TabIndex = 35
        Me.chkDC14.UseVisualStyleBackColor = true
        '
        'chkDC1
        '
        Me.chkDC1.AutoSize = true
        Me.chkDC1.Location = New System.Drawing.Point(7, 16)
        Me.chkDC1.Name = "chkDC1"
        Me.chkDC1.Size = New System.Drawing.Size(15, 14)
        Me.chkDC1.TabIndex = 27
        Me.chkDC1.UseVisualStyleBackColor = true
        '
        'chkDC13
        '
        Me.chkDC13.AutoSize = true
        Me.chkDC13.Location = New System.Drawing.Point(277, 83)
        Me.chkDC13.Name = "chkDC13"
        Me.chkDC13.Size = New System.Drawing.Size(15, 14)
        Me.chkDC13.TabIndex = 34
        Me.chkDC13.UseVisualStyleBackColor = true
        '
        'chkDC12
        '
        Me.chkDC12.AutoSize = true
        Me.chkDC12.Location = New System.Drawing.Point(277, 60)
        Me.chkDC12.Name = "chkDC12"
        Me.chkDC12.Size = New System.Drawing.Size(15, 14)
        Me.chkDC12.TabIndex = 33
        Me.chkDC12.UseVisualStyleBackColor = true
        '
        'chkDC11
        '
        Me.chkDC11.AutoSize = true
        Me.chkDC11.Location = New System.Drawing.Point(277, 38)
        Me.chkDC11.Name = "chkDC11"
        Me.chkDC11.Size = New System.Drawing.Size(15, 14)
        Me.chkDC11.TabIndex = 32
        Me.chkDC11.UseVisualStyleBackColor = true
        '
        'chkDC10
        '
        Me.chkDC10.AutoSize = true
        Me.chkDC10.Location = New System.Drawing.Point(7, 194)
        Me.chkDC10.Name = "chkDC10"
        Me.chkDC10.Size = New System.Drawing.Size(15, 14)
        Me.chkDC10.TabIndex = 31
        Me.chkDC10.UseVisualStyleBackColor = true
        '
        'lblDatacore16
        '
        Me.lblDatacore16.Location = New System.Drawing.Point(298, 151)
        Me.lblDatacore16.Name = "lblDatacore16"
        Me.lblDatacore16.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore16.TabIndex = 20
        Me.lblDatacore16.Text = "Quantum Physics"
        '
        'lblDatacore4
        '
        Me.lblDatacore4.Location = New System.Drawing.Point(28, 84)
        Me.lblDatacore4.Name = "lblDatacore4"
        Me.lblDatacore4.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore4.TabIndex = 4
        Me.lblDatacore4.Text = "Minmatar Starship Engineering"
        '
        'lblDatacore15
        '
        Me.lblDatacore15.Location = New System.Drawing.Point(298, 128)
        Me.lblDatacore15.Name = "lblDatacore15"
        Me.lblDatacore15.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore15.TabIndex = 19
        Me.lblDatacore15.Text = "Plasma Physics"
        '
        'chkDC9
        '
        Me.chkDC9.AutoSize = true
        Me.chkDC9.Location = New System.Drawing.Point(277, 16)
        Me.chkDC9.Name = "chkDC9"
        Me.chkDC9.Size = New System.Drawing.Size(15, 14)
        Me.chkDC9.TabIndex = 30
        Me.chkDC9.UseVisualStyleBackColor = true
        '
        'lblDatacore14
        '
        Me.lblDatacore14.Location = New System.Drawing.Point(298, 106)
        Me.lblDatacore14.Name = "lblDatacore14"
        Me.lblDatacore14.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore14.TabIndex = 18
        Me.lblDatacore14.Text = "Nuclear Physics"
        '
        'lblDatacore3
        '
        Me.lblDatacore3.Location = New System.Drawing.Point(28, 61)
        Me.lblDatacore3.Name = "lblDatacore3"
        Me.lblDatacore3.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore3.TabIndex = 3
        Me.lblDatacore3.Text = "Gallente Starship Engineering"
        '
        'chkDC8
        '
        Me.chkDC8.AutoSize = true
        Me.chkDC8.Location = New System.Drawing.Point(7, 172)
        Me.chkDC8.Name = "chkDC8"
        Me.chkDC8.Size = New System.Drawing.Size(15, 14)
        Me.chkDC8.TabIndex = 29
        Me.chkDC8.UseVisualStyleBackColor = true
        '
        'lblDatacore13
        '
        Me.lblDatacore13.Location = New System.Drawing.Point(298, 84)
        Me.lblDatacore13.Name = "lblDatacore13"
        Me.lblDatacore13.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore13.TabIndex = 17
        Me.lblDatacore13.Text = "Nanite Engineering"
        '
        'lblDatacore2
        '
        Me.lblDatacore2.Location = New System.Drawing.Point(28, 39)
        Me.lblDatacore2.Name = "lblDatacore2"
        Me.lblDatacore2.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore2.TabIndex = 2
        Me.lblDatacore2.Text = "Caldari Starship Engineering"
        '
        'chkDC7
        '
        Me.chkDC7.AutoSize = true
        Me.chkDC7.Location = New System.Drawing.Point(7, 150)
        Me.chkDC7.Name = "chkDC7"
        Me.chkDC7.Size = New System.Drawing.Size(15, 14)
        Me.chkDC7.TabIndex = 28
        Me.chkDC7.UseVisualStyleBackColor = true
        '
        'chkDC6
        '
        Me.chkDC6.AutoSize = true
        Me.chkDC6.Location = New System.Drawing.Point(7, 127)
        Me.chkDC6.Name = "chkDC6"
        Me.chkDC6.Size = New System.Drawing.Size(15, 14)
        Me.chkDC6.TabIndex = 27
        Me.chkDC6.UseVisualStyleBackColor = true
        '
        'lblDatacore1
        '
        Me.lblDatacore1.Location = New System.Drawing.Point(28, 17)
        Me.lblDatacore1.Name = "lblDatacore1"
        Me.lblDatacore1.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore1.TabIndex = 1
        Me.lblDatacore1.Text = "Amarr Starship Engineering"
        '
        'chkDC5
        '
        Me.chkDC5.AutoSize = true
        Me.chkDC5.Location = New System.Drawing.Point(7, 105)
        Me.chkDC5.Name = "chkDC5"
        Me.chkDC5.Size = New System.Drawing.Size(15, 14)
        Me.chkDC5.TabIndex = 26
        Me.chkDC5.UseVisualStyleBackColor = true
        '
        'lblDatacore5
        '
        Me.lblDatacore5.Location = New System.Drawing.Point(28, 106)
        Me.lblDatacore5.Name = "lblDatacore5"
        Me.lblDatacore5.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore5.TabIndex = 1
        Me.lblDatacore5.Text = "Electromagnetic Physics"
        '
        'lblDatacore6
        '
        Me.lblDatacore6.Location = New System.Drawing.Point(28, 128)
        Me.lblDatacore6.Name = "lblDatacore6"
        Me.lblDatacore6.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore6.TabIndex = 2
        Me.lblDatacore6.Text = "Electronic Engineering"
        '
        'lblDatacore7
        '
        Me.lblDatacore7.Location = New System.Drawing.Point(28, 151)
        Me.lblDatacore7.Name = "lblDatacore7"
        Me.lblDatacore7.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore7.TabIndex = 3
        Me.lblDatacore7.Text = "Graviton Physics"
        '
        'lblDatacore8
        '
        Me.lblDatacore8.Location = New System.Drawing.Point(28, 173)
        Me.lblDatacore8.Name = "lblDatacore8"
        Me.lblDatacore8.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore8.TabIndex = 4
        Me.lblDatacore8.Text = "High Energy Physics"
        '
        'lblDatacore12
        '
        Me.lblDatacore12.Location = New System.Drawing.Point(298, 61)
        Me.lblDatacore12.Name = "lblDatacore12"
        Me.lblDatacore12.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore12.TabIndex = 12
        Me.lblDatacore12.Text = "Molecular Engineering"
        '
        'lblDatacore11
        '
        Me.lblDatacore11.Location = New System.Drawing.Point(298, 39)
        Me.lblDatacore11.Name = "lblDatacore11"
        Me.lblDatacore11.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore11.TabIndex = 11
        Me.lblDatacore11.Text = "Mechanical Engineering"
        '
        'lblDatacore10
        '
        Me.lblDatacore10.Location = New System.Drawing.Point(28, 195)
        Me.lblDatacore10.Name = "lblDatacore10"
        Me.lblDatacore10.Size = New System.Drawing.Size(158, 13)
        Me.lblDatacore10.TabIndex = 10
        Me.lblDatacore10.Text = "Laser Physics"
        '
        'lblDatacore9
        '
        Me.lblDatacore9.Location = New System.Drawing.Point(298, 17)
        Me.lblDatacore9.Name = "lblDatacore9"
        Me.lblDatacore9.Size = New System.Drawing.Size(122, 13)
        Me.lblDatacore9.TabIndex = 9
        Me.lblDatacore9.Text = "Hydromagnetic Physics"
        '
        'gbDCCodes
        '
        Me.gbDCCodes.Controls.Add(Me.lblDCColors)
        Me.gbDCCodes.Controls.Add(Me.lblDCRedText)
        Me.gbDCCodes.Controls.Add(Me.lblDCOrangeText)
        Me.gbDCCodes.Controls.Add(Me.lblDCGrayText)
        Me.gbDCCodes.Controls.Add(Me.lblDCBlueText)
        Me.gbDCCodes.Controls.Add(Me.lblDCGreenBackColor)
        Me.gbDCCodes.Location = New System.Drawing.Point(277, 187)
        Me.gbDCCodes.Name = "gbDCCodes"
        Me.gbDCCodes.Size = New System.Drawing.Size(224, 30)
        Me.gbDCCodes.TabIndex = 56
        Me.gbDCCodes.TabStop = false
        '
        'lblDCColors
        '
        Me.lblDCColors.AutoSize = true
        Me.lblDCColors.Location = New System.Drawing.Point(8, 11)
        Me.lblDCColors.Name = "lblDCColors"
        Me.lblDCColors.Size = New System.Drawing.Size(63, 13)
        Me.lblDCColors.TabIndex = 5
        Me.lblDCColors.Text = "Text Colors:"
        Me.lblDCColors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDCRedText
        '
        Me.lblDCRedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDCRedText.ForeColor = System.Drawing.Color.Red
        Me.lblDCRedText.Location = New System.Drawing.Point(200, 10)
        Me.lblDCRedText.Name = "lblDCRedText"
        Me.lblDCRedText.Size = New System.Drawing.Size(15, 15)
        Me.lblDCRedText.TabIndex = 4
        Me.lblDCRedText.Text = "T"
        Me.lblDCRedText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDCOrangeText
        '
        Me.lblDCOrangeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDCOrangeText.ForeColor = System.Drawing.Color.Orange
        Me.lblDCOrangeText.Location = New System.Drawing.Point(170, 10)
        Me.lblDCOrangeText.Name = "lblDCOrangeText"
        Me.lblDCOrangeText.Size = New System.Drawing.Size(15, 15)
        Me.lblDCOrangeText.TabIndex = 3
        Me.lblDCOrangeText.Text = "T"
        Me.lblDCOrangeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDCGrayText
        '
        Me.lblDCGrayText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDCGrayText.ForeColor = System.Drawing.Color.Gray
        Me.lblDCGrayText.Location = New System.Drawing.Point(140, 10)
        Me.lblDCGrayText.Name = "lblDCGrayText"
        Me.lblDCGrayText.Size = New System.Drawing.Size(15, 15)
        Me.lblDCGrayText.TabIndex = 2
        Me.lblDCGrayText.Text = "T"
        Me.lblDCGrayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDCBlueText
        '
        Me.lblDCBlueText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDCBlueText.ForeColor = System.Drawing.Color.Blue
        Me.lblDCBlueText.Location = New System.Drawing.Point(110, 10)
        Me.lblDCBlueText.Name = "lblDCBlueText"
        Me.lblDCBlueText.Size = New System.Drawing.Size(15, 15)
        Me.lblDCBlueText.TabIndex = 1
        Me.lblDCBlueText.Text = "T"
        Me.lblDCBlueText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDCGreenBackColor
        '
        Me.lblDCGreenBackColor.BackColor = System.Drawing.Color.LightGreen
        Me.lblDCGreenBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDCGreenBackColor.Location = New System.Drawing.Point(80, 10)
        Me.lblDCGreenBackColor.Name = "lblDCGreenBackColor"
        Me.lblDCGreenBackColor.Size = New System.Drawing.Size(15, 15)
        Me.lblDCGreenBackColor.TabIndex = 0
        Me.lblDCGreenBackColor.Text = "T"
        Me.lblDCGreenBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbDCCorpMinmatar
        '
        Me.gbDCCorpMinmatar.Controls.Add(Me.lblDCCorp13)
        Me.gbDCCorpMinmatar.Controls.Add(Me.chkDCCorp13)
        Me.gbDCCorpMinmatar.Controls.Add(Me.txtDCStanding13)
        Me.gbDCCorpMinmatar.Controls.Add(Me.lblDCCorpLabel4)
        Me.gbDCCorpMinmatar.Controls.Add(Me.lblDCCorp10)
        Me.gbDCCorpMinmatar.Controls.Add(Me.lblDCCorp11)
        Me.gbDCCorpMinmatar.Controls.Add(Me.lblDCCorp12)
        Me.gbDCCorpMinmatar.Controls.Add(Me.chkDCCorp10)
        Me.gbDCCorpMinmatar.Controls.Add(Me.chkDCCorp11)
        Me.gbDCCorpMinmatar.Controls.Add(Me.chkDCCorp12)
        Me.gbDCCorpMinmatar.Controls.Add(Me.txtDCStanding10)
        Me.gbDCCorpMinmatar.Controls.Add(Me.txtDCStanding11)
        Me.gbDCCorpMinmatar.Controls.Add(Me.txtDCStanding12)
        Me.gbDCCorpMinmatar.Controls.Add(Me.lblDCStanding4)
        Me.gbDCCorpMinmatar.Location = New System.Drawing.Point(746, 119)
        Me.gbDCCorpMinmatar.Name = "gbDCCorpMinmatar"
        Me.gbDCCorpMinmatar.Size = New System.Drawing.Size(228, 122)
        Me.gbDCCorpMinmatar.TabIndex = 64
        Me.gbDCCorpMinmatar.TabStop = false
        Me.gbDCCorpMinmatar.Text = "Minmatar Republic/Thukker Tribe/Khanid"
        '
        'lblDCCorp13
        '
        Me.lblDCCorp13.Location = New System.Drawing.Point(33, 101)
        Me.lblDCCorp13.Name = "lblDCCorp13"
        Me.lblDCCorp13.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp13.TabIndex = 46
        Me.lblDCCorp13.Text = "Thukker Mix"
        '
        'chkDCCorp13
        '
        Me.chkDCCorp13.AutoSize = true
        Me.chkDCCorp13.Location = New System.Drawing.Point(12, 100)
        Me.chkDCCorp13.Name = "chkDCCorp13"
        Me.chkDCCorp13.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp13.TabIndex = 47
        Me.chkDCCorp13.UseVisualStyleBackColor = true
        '
        'txtDCStanding13
        '
        Me.txtDCStanding13.Location = New System.Drawing.Point(176, 97)
        Me.txtDCStanding13.Name = "txtDCStanding13"
        Me.txtDCStanding13.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding13.TabIndex = 48
        Me.txtDCStanding13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDCCorpLabel4
        '
        Me.lblDCCorpLabel4.AutoSize = true
        Me.lblDCCorpLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDCCorpLabel4.Location = New System.Drawing.Point(33, 16)
        Me.lblDCCorpLabel4.Name = "lblDCCorpLabel4"
        Me.lblDCCorpLabel4.Size = New System.Drawing.Size(72, 13)
        Me.lblDCCorpLabel4.TabIndex = 45
        Me.lblDCCorpLabel4.Text = "Corporation"
        Me.lblDCCorpLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDCCorp10
        '
        Me.lblDCCorp10.Location = New System.Drawing.Point(33, 35)
        Me.lblDCCorp10.Name = "lblDCCorp10"
        Me.lblDCCorp10.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp10.TabIndex = 1
        Me.lblDCCorp10.Text = "Boundless Creation"
        '
        'lblDCCorp11
        '
        Me.lblDCCorp11.Location = New System.Drawing.Point(33, 57)
        Me.lblDCCorp11.Name = "lblDCCorp11"
        Me.lblDCCorp11.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp11.TabIndex = 2
        Me.lblDCCorp11.Text = "Core Complexion Inc."
        '
        'lblDCCorp12
        '
        Me.lblDCCorp12.Location = New System.Drawing.Point(33, 79)
        Me.lblDCCorp12.Name = "lblDCCorp12"
        Me.lblDCCorp12.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp12.TabIndex = 3
        Me.lblDCCorp12.Text = "Khanid Innovation"
        '
        'chkDCCorp10
        '
        Me.chkDCCorp10.AutoSize = true
        Me.chkDCCorp10.Location = New System.Drawing.Point(12, 34)
        Me.chkDCCorp10.Name = "chkDCCorp10"
        Me.chkDCCorp10.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp10.TabIndex = 27
        Me.chkDCCorp10.UseVisualStyleBackColor = true
        '
        'chkDCCorp11
        '
        Me.chkDCCorp11.AutoSize = true
        Me.chkDCCorp11.Location = New System.Drawing.Point(12, 56)
        Me.chkDCCorp11.Name = "chkDCCorp11"
        Me.chkDCCorp11.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp11.TabIndex = 28
        Me.chkDCCorp11.UseVisualStyleBackColor = true
        '
        'chkDCCorp12
        '
        Me.chkDCCorp12.AutoSize = true
        Me.chkDCCorp12.Location = New System.Drawing.Point(12, 78)
        Me.chkDCCorp12.Name = "chkDCCorp12"
        Me.chkDCCorp12.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp12.TabIndex = 29
        Me.chkDCCorp12.UseVisualStyleBackColor = true
        '
        'txtDCStanding10
        '
        Me.txtDCStanding10.Location = New System.Drawing.Point(176, 31)
        Me.txtDCStanding10.Name = "txtDCStanding10"
        Me.txtDCStanding10.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding10.TabIndex = 39
        Me.txtDCStanding10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding11
        '
        Me.txtDCStanding11.Location = New System.Drawing.Point(176, 53)
        Me.txtDCStanding11.Name = "txtDCStanding11"
        Me.txtDCStanding11.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding11.TabIndex = 40
        Me.txtDCStanding11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding12
        '
        Me.txtDCStanding12.Location = New System.Drawing.Point(176, 75)
        Me.txtDCStanding12.Name = "txtDCStanding12"
        Me.txtDCStanding12.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding12.TabIndex = 41
        Me.txtDCStanding12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDCStanding4
        '
        Me.lblDCStanding4.AutoSize = true
        Me.lblDCStanding4.Location = New System.Drawing.Point(169, 16)
        Me.lblDCStanding4.Name = "lblDCStanding4"
        Me.lblDCStanding4.Size = New System.Drawing.Size(49, 13)
        Me.lblDCStanding4.TabIndex = 44
        Me.lblDCStanding4.Text = "Standing"
        Me.lblDCStanding4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDCExporttoClip
        '
        Me.btnDCExporttoClip.Location = New System.Drawing.Point(980, 206)
        Me.btnDCExporttoClip.Name = "btnDCExporttoClip"
        Me.btnDCExporttoClip.Size = New System.Drawing.Size(138, 35)
        Me.btnDCExporttoClip.TabIndex = 68
        Me.btnDCExporttoClip.Text = "Copy Selected to Clipboard"
        Me.btnDCExporttoClip.UseVisualStyleBackColor = true
        '
        'gbDCCorpAmarr
        '
        Me.gbDCCorpAmarr.Controls.Add(Me.lblDCCorpLabel1)
        Me.gbDCCorpAmarr.Controls.Add(Me.lblDCCorp1)
        Me.gbDCCorpAmarr.Controls.Add(Me.lblDCCorp2)
        Me.gbDCCorpAmarr.Controls.Add(Me.lblDCCorp3)
        Me.gbDCCorpAmarr.Controls.Add(Me.chkDCCorp1)
        Me.gbDCCorpAmarr.Controls.Add(Me.chkDCCorp2)
        Me.gbDCCorpAmarr.Controls.Add(Me.chkDCCorp3)
        Me.gbDCCorpAmarr.Controls.Add(Me.txtDCStanding1)
        Me.gbDCCorpAmarr.Controls.Add(Me.txtDCStanding2)
        Me.gbDCCorpAmarr.Controls.Add(Me.txtDCStanding3)
        Me.gbDCCorpAmarr.Controls.Add(Me.lblDCStanding1)
        Me.gbDCCorpAmarr.Location = New System.Drawing.Point(518, 12)
        Me.gbDCCorpAmarr.Name = "gbDCCorpAmarr"
        Me.gbDCCorpAmarr.Size = New System.Drawing.Size(222, 100)
        Me.gbDCCorpAmarr.TabIndex = 63
        Me.gbDCCorpAmarr.TabStop = false
        Me.gbDCCorpAmarr.Text = "Amarr Empire/Ammatar Mandate"
        '
        'lblDCCorpLabel1
        '
        Me.lblDCCorpLabel1.AutoSize = true
        Me.lblDCCorpLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDCCorpLabel1.Location = New System.Drawing.Point(33, 15)
        Me.lblDCCorpLabel1.Name = "lblDCCorpLabel1"
        Me.lblDCCorpLabel1.Size = New System.Drawing.Size(72, 13)
        Me.lblDCCorpLabel1.TabIndex = 45
        Me.lblDCCorpLabel1.Text = "Corporation"
        Me.lblDCCorpLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDCCorp1
        '
        Me.lblDCCorp1.Location = New System.Drawing.Point(33, 34)
        Me.lblDCCorp1.Name = "lblDCCorp1"
        Me.lblDCCorp1.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp1.TabIndex = 1
        Me.lblDCCorp1.Text = "Carthum Conglomerate"
        '
        'lblDCCorp2
        '
        Me.lblDCCorp2.Location = New System.Drawing.Point(33, 56)
        Me.lblDCCorp2.Name = "lblDCCorp2"
        Me.lblDCCorp2.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp2.TabIndex = 2
        Me.lblDCCorp2.Text = "Viziam"
        '
        'lblDCCorp3
        '
        Me.lblDCCorp3.Location = New System.Drawing.Point(33, 78)
        Me.lblDCCorp3.Name = "lblDCCorp3"
        Me.lblDCCorp3.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp3.TabIndex = 3
        Me.lblDCCorp3.Text = "Nefantar Miner Association"
        '
        'chkDCCorp1
        '
        Me.chkDCCorp1.AutoSize = true
        Me.chkDCCorp1.Location = New System.Drawing.Point(12, 33)
        Me.chkDCCorp1.Name = "chkDCCorp1"
        Me.chkDCCorp1.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp1.TabIndex = 27
        Me.chkDCCorp1.UseVisualStyleBackColor = true
        '
        'chkDCCorp2
        '
        Me.chkDCCorp2.AutoSize = true
        Me.chkDCCorp2.Location = New System.Drawing.Point(12, 55)
        Me.chkDCCorp2.Name = "chkDCCorp2"
        Me.chkDCCorp2.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp2.TabIndex = 28
        Me.chkDCCorp2.UseVisualStyleBackColor = true
        '
        'chkDCCorp3
        '
        Me.chkDCCorp3.AutoSize = true
        Me.chkDCCorp3.Location = New System.Drawing.Point(12, 77)
        Me.chkDCCorp3.Name = "chkDCCorp3"
        Me.chkDCCorp3.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp3.TabIndex = 29
        Me.chkDCCorp3.UseVisualStyleBackColor = true
        '
        'txtDCStanding1
        '
        Me.txtDCStanding1.Location = New System.Drawing.Point(174, 30)
        Me.txtDCStanding1.Name = "txtDCStanding1"
        Me.txtDCStanding1.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding1.TabIndex = 39
        Me.txtDCStanding1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding2
        '
        Me.txtDCStanding2.Location = New System.Drawing.Point(174, 52)
        Me.txtDCStanding2.Name = "txtDCStanding2"
        Me.txtDCStanding2.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding2.TabIndex = 40
        Me.txtDCStanding2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding3
        '
        Me.txtDCStanding3.Location = New System.Drawing.Point(174, 74)
        Me.txtDCStanding3.Name = "txtDCStanding3"
        Me.txtDCStanding3.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding3.TabIndex = 41
        Me.txtDCStanding3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDCStanding1
        '
        Me.lblDCStanding1.AutoSize = true
        Me.lblDCStanding1.Location = New System.Drawing.Point(165, 14)
        Me.lblDCStanding1.Name = "lblDCStanding1"
        Me.lblDCStanding1.Size = New System.Drawing.Size(49, 13)
        Me.lblDCStanding1.TabIndex = 44
        Me.lblDCStanding1.Text = "Standing"
        Me.lblDCStanding1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDCReset
        '
        Me.btnDCReset.Location = New System.Drawing.Point(980, 146)
        Me.btnDCReset.Name = "btnDCReset"
        Me.btnDCReset.Size = New System.Drawing.Size(138, 30)
        Me.btnDCReset.TabIndex = 67
        Me.btnDCReset.Text = "Reset"
        Me.btnDCReset.UseVisualStyleBackColor = true
        '
        'gbDCCorpsCaldari
        '
        Me.gbDCCorpsCaldari.Controls.Add(Me.lblDCCorpLabel2)
        Me.gbDCCorpsCaldari.Controls.Add(Me.lblDCCorp4)
        Me.gbDCCorpsCaldari.Controls.Add(Me.lblDCCorp5)
        Me.gbDCCorpsCaldari.Controls.Add(Me.lblDCCorp6)
        Me.gbDCCorpsCaldari.Controls.Add(Me.chkDCCorp4)
        Me.gbDCCorpsCaldari.Controls.Add(Me.chkDCCorp5)
        Me.gbDCCorpsCaldari.Controls.Add(Me.chkDCCorp6)
        Me.gbDCCorpsCaldari.Controls.Add(Me.txtDCStanding4)
        Me.gbDCCorpsCaldari.Controls.Add(Me.txtDCStanding5)
        Me.gbDCCorpsCaldari.Controls.Add(Me.txtDCStanding6)
        Me.gbDCCorpsCaldari.Controls.Add(Me.lblDCStanding2)
        Me.gbDCCorpsCaldari.Location = New System.Drawing.Point(518, 114)
        Me.gbDCCorpsCaldari.Name = "gbDCCorpsCaldari"
        Me.gbDCCorpsCaldari.Size = New System.Drawing.Size(222, 100)
        Me.gbDCCorpsCaldari.TabIndex = 62
        Me.gbDCCorpsCaldari.TabStop = false
        Me.gbDCCorpsCaldari.Text = "Caldari State"
        '
        'lblDCCorpLabel2
        '
        Me.lblDCCorpLabel2.AutoSize = true
        Me.lblDCCorpLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDCCorpLabel2.Location = New System.Drawing.Point(33, 16)
        Me.lblDCCorpLabel2.Name = "lblDCCorpLabel2"
        Me.lblDCCorpLabel2.Size = New System.Drawing.Size(72, 13)
        Me.lblDCCorpLabel2.TabIndex = 45
        Me.lblDCCorpLabel2.Text = "Corporation"
        Me.lblDCCorpLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDCCorp4
        '
        Me.lblDCCorp4.Location = New System.Drawing.Point(33, 34)
        Me.lblDCCorp4.Name = "lblDCCorp4"
        Me.lblDCCorp4.Size = New System.Drawing.Size(131, 13)
        Me.lblDCCorp4.TabIndex = 1
        Me.lblDCCorp4.Text = "Ishukone Corporation"
        '
        'lblDCCorp5
        '
        Me.lblDCCorp5.Location = New System.Drawing.Point(33, 56)
        Me.lblDCCorp5.Name = "lblDCCorp5"
        Me.lblDCCorp5.Size = New System.Drawing.Size(131, 13)
        Me.lblDCCorp5.TabIndex = 2
        Me.lblDCCorp5.Text = "Kaalakiota Corporation"
        '
        'lblDCCorp6
        '
        Me.lblDCCorp6.Location = New System.Drawing.Point(33, 78)
        Me.lblDCCorp6.Name = "lblDCCorp6"
        Me.lblDCCorp6.Size = New System.Drawing.Size(131, 13)
        Me.lblDCCorp6.TabIndex = 3
        Me.lblDCCorp6.Text = "Lai Dai Corporation"
        '
        'chkDCCorp4
        '
        Me.chkDCCorp4.AutoSize = true
        Me.chkDCCorp4.Location = New System.Drawing.Point(10, 33)
        Me.chkDCCorp4.Name = "chkDCCorp4"
        Me.chkDCCorp4.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp4.TabIndex = 27
        Me.chkDCCorp4.UseVisualStyleBackColor = true
        '
        'chkDCCorp5
        '
        Me.chkDCCorp5.AutoSize = true
        Me.chkDCCorp5.Location = New System.Drawing.Point(10, 55)
        Me.chkDCCorp5.Name = "chkDCCorp5"
        Me.chkDCCorp5.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp5.TabIndex = 28
        Me.chkDCCorp5.UseVisualStyleBackColor = true
        '
        'chkDCCorp6
        '
        Me.chkDCCorp6.AutoSize = true
        Me.chkDCCorp6.Location = New System.Drawing.Point(10, 77)
        Me.chkDCCorp6.Name = "chkDCCorp6"
        Me.chkDCCorp6.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp6.TabIndex = 29
        Me.chkDCCorp6.UseVisualStyleBackColor = true
        '
        'txtDCStanding4
        '
        Me.txtDCStanding4.Location = New System.Drawing.Point(174, 32)
        Me.txtDCStanding4.Name = "txtDCStanding4"
        Me.txtDCStanding4.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding4.TabIndex = 39
        Me.txtDCStanding4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding5
        '
        Me.txtDCStanding5.Location = New System.Drawing.Point(174, 54)
        Me.txtDCStanding5.Name = "txtDCStanding5"
        Me.txtDCStanding5.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding5.TabIndex = 40
        Me.txtDCStanding5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding6
        '
        Me.txtDCStanding6.Location = New System.Drawing.Point(174, 76)
        Me.txtDCStanding6.Name = "txtDCStanding6"
        Me.txtDCStanding6.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding6.TabIndex = 41
        Me.txtDCStanding6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDCStanding2
        '
        Me.lblDCStanding2.AutoSize = true
        Me.lblDCStanding2.Location = New System.Drawing.Point(163, 16)
        Me.lblDCStanding2.Name = "lblDCStanding2"
        Me.lblDCStanding2.Size = New System.Drawing.Size(49, 13)
        Me.lblDCStanding2.TabIndex = 44
        Me.lblDCStanding2.Text = "Standing"
        Me.lblDCStanding2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbDCCorpsGallente
        '
        Me.gbDCCorpsGallente.Controls.Add(Me.lblDCCorpLabel3)
        Me.gbDCCorpsGallente.Controls.Add(Me.lblDCCorp7)
        Me.gbDCCorpsGallente.Controls.Add(Me.lblDCCorp8)
        Me.gbDCCorpsGallente.Controls.Add(Me.lblDCCorp9)
        Me.gbDCCorpsGallente.Controls.Add(Me.chkDCCorp7)
        Me.gbDCCorpsGallente.Controls.Add(Me.chkDCCorp8)
        Me.gbDCCorpsGallente.Controls.Add(Me.chkDCCorp9)
        Me.gbDCCorpsGallente.Controls.Add(Me.txtDCStanding7)
        Me.gbDCCorpsGallente.Controls.Add(Me.txtDCStanding8)
        Me.gbDCCorpsGallente.Controls.Add(Me.txtDCStanding9)
        Me.gbDCCorpsGallente.Controls.Add(Me.lblDCStanding3)
        Me.gbDCCorpsGallente.Location = New System.Drawing.Point(746, 12)
        Me.gbDCCorpsGallente.Name = "gbDCCorpsGallente"
        Me.gbDCCorpsGallente.Size = New System.Drawing.Size(226, 100)
        Me.gbDCCorpsGallente.TabIndex = 61
        Me.gbDCCorpsGallente.TabStop = false
        Me.gbDCCorpsGallente.Text = "Gallente Federation"
        '
        'lblDCCorpLabel3
        '
        Me.lblDCCorpLabel3.AutoSize = true
        Me.lblDCCorpLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDCCorpLabel3.Location = New System.Drawing.Point(33, 16)
        Me.lblDCCorpLabel3.Name = "lblDCCorpLabel3"
        Me.lblDCCorpLabel3.Size = New System.Drawing.Size(72, 13)
        Me.lblDCCorpLabel3.TabIndex = 45
        Me.lblDCCorpLabel3.Text = "Corporation"
        Me.lblDCCorpLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDCCorp7
        '
        Me.lblDCCorp7.Location = New System.Drawing.Point(33, 35)
        Me.lblDCCorp7.Name = "lblDCCorp7"
        Me.lblDCCorp7.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp7.TabIndex = 1
        Me.lblDCCorp7.Text = "CreoDron"
        '
        'lblDCCorp8
        '
        Me.lblDCCorp8.Location = New System.Drawing.Point(33, 57)
        Me.lblDCCorp8.Name = "lblDCCorp8"
        Me.lblDCCorp8.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp8.TabIndex = 2
        Me.lblDCCorp8.Text = "Duvolle Laboratories"
        '
        'lblDCCorp9
        '
        Me.lblDCCorp9.Location = New System.Drawing.Point(33, 79)
        Me.lblDCCorp9.Name = "lblDCCorp9"
        Me.lblDCCorp9.Size = New System.Drawing.Size(139, 13)
        Me.lblDCCorp9.TabIndex = 3
        Me.lblDCCorp9.Text = "Roden Shipyards"
        '
        'chkDCCorp7
        '
        Me.chkDCCorp7.AutoSize = true
        Me.chkDCCorp7.Location = New System.Drawing.Point(12, 34)
        Me.chkDCCorp7.Name = "chkDCCorp7"
        Me.chkDCCorp7.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp7.TabIndex = 27
        Me.chkDCCorp7.UseVisualStyleBackColor = true
        '
        'chkDCCorp8
        '
        Me.chkDCCorp8.AutoSize = true
        Me.chkDCCorp8.Location = New System.Drawing.Point(12, 56)
        Me.chkDCCorp8.Name = "chkDCCorp8"
        Me.chkDCCorp8.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp8.TabIndex = 28
        Me.chkDCCorp8.UseVisualStyleBackColor = true
        '
        'chkDCCorp9
        '
        Me.chkDCCorp9.AutoSize = true
        Me.chkDCCorp9.Location = New System.Drawing.Point(12, 78)
        Me.chkDCCorp9.Name = "chkDCCorp9"
        Me.chkDCCorp9.Size = New System.Drawing.Size(15, 14)
        Me.chkDCCorp9.TabIndex = 29
        Me.chkDCCorp9.UseVisualStyleBackColor = true
        '
        'txtDCStanding7
        '
        Me.txtDCStanding7.Location = New System.Drawing.Point(178, 31)
        Me.txtDCStanding7.Name = "txtDCStanding7"
        Me.txtDCStanding7.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding7.TabIndex = 39
        Me.txtDCStanding7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding8
        '
        Me.txtDCStanding8.Location = New System.Drawing.Point(178, 53)
        Me.txtDCStanding8.Name = "txtDCStanding8"
        Me.txtDCStanding8.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding8.TabIndex = 40
        Me.txtDCStanding8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDCStanding9
        '
        Me.txtDCStanding9.Location = New System.Drawing.Point(178, 75)
        Me.txtDCStanding9.Name = "txtDCStanding9"
        Me.txtDCStanding9.Size = New System.Drawing.Size(35, 20)
        Me.txtDCStanding9.TabIndex = 41
        Me.txtDCStanding9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDCStanding3
        '
        Me.lblDCStanding3.AutoSize = true
        Me.lblDCStanding3.Location = New System.Drawing.Point(169, 15)
        Me.lblDCStanding3.Name = "lblDCStanding3"
        Me.lblDCStanding3.Size = New System.Drawing.Size(49, 13)
        Me.lblDCStanding3.TabIndex = 44
        Me.lblDCStanding3.Text = "Standing"
        Me.lblDCStanding3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDCRefresh
        '
        Me.btnDCRefresh.Location = New System.Drawing.Point(980, 116)
        Me.btnDCRefresh.Name = "btnDCRefresh"
        Me.btnDCRefresh.Size = New System.Drawing.Size(138, 30)
        Me.btnDCRefresh.TabIndex = 66
        Me.btnDCRefresh.Text = "Refresh"
        Me.btnDCRefresh.UseVisualStyleBackColor = true
        '
        'tabManufacturing
        '
        Me.tabManufacturing.Controls.Add(Me.gbCalcBPSelectOptions)
        Me.tabManufacturing.Controls.Add(Me.lstManufacturing)
        Me.tabManufacturing.Location = New System.Drawing.Point(4, 22)
        Me.tabManufacturing.Name = "tabManufacturing"
        Me.tabManufacturing.Size = New System.Drawing.Size(1137, 615)
        Me.tabManufacturing.TabIndex = 2
        Me.tabManufacturing.Text = "Manufacturing List"
        Me.tabManufacturing.UseVisualStyleBackColor = true
        '
        'gbCalcBPSelectOptions
        '
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcIncludeNoTeam)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbIncludeItems)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.btnCalcSelectColumns)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbSize)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcProdLines)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcCompareType)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcTextColors)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcInvention)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbBPRace)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.tabCalcFacilities)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcFilter)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcBPTech)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcType)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcIncludeOwned)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcAvgPrice)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.btnCalcSaveSettings)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbIncludeTaxesFees)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.btnCalcExportList)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.btnCalcPreview)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.btnCalculate)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.btnCalcReset)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcTextFilter)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcBPType)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcBPSelect)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbCalcRelics)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.tabCalcTeams)
        Me.gbCalcBPSelectOptions.Controls.Add(Me.gbTempMEPE)
        Me.gbCalcBPSelectOptions.Location = New System.Drawing.Point(8, 308)
        Me.gbCalcBPSelectOptions.Name = "gbCalcBPSelectOptions"
        Me.gbCalcBPSelectOptions.Size = New System.Drawing.Size(1121, 300)
        Me.gbCalcBPSelectOptions.TabIndex = 0
        Me.gbCalcBPSelectOptions.TabStop = false
        Me.gbCalcBPSelectOptions.Text = "Blueprint Filters:"
        '
        'gbCalcIncludeNoTeam
        '
        Me.gbCalcIncludeNoTeam.Controls.Add(Me.chkCalcIncludeNoTeamComponents)
        Me.gbCalcIncludeNoTeam.Controls.Add(Me.chkCalcIncludeNoTeamCopy)
        Me.gbCalcIncludeNoTeam.Controls.Add(Me.chkCalcIncludeNoTeamInvention)
        Me.gbCalcIncludeNoTeam.Controls.Add(Me.chkCalcIncludeNoTeamManufacturing)
        Me.gbCalcIncludeNoTeam.Enabled = false
        Me.gbCalcIncludeNoTeam.Location = New System.Drawing.Point(850, 222)
        Me.gbCalcIncludeNoTeam.Name = "gbCalcIncludeNoTeam"
        Me.gbCalcIncludeNoTeam.Size = New System.Drawing.Size(165, 72)
        Me.gbCalcIncludeNoTeam.TabIndex = 18
        Me.gbCalcIncludeNoTeam.TabStop = false
        Me.gbCalcIncludeNoTeam.Text = "Include 'No Team' for:"
        '
        'chkCalcIncludeNoTeamComponents
        '
        Me.chkCalcIncludeNoTeamComponents.AutoSize = true
        Me.chkCalcIncludeNoTeamComponents.Location = New System.Drawing.Point(9, 35)
        Me.chkCalcIncludeNoTeamComponents.Name = "chkCalcIncludeNoTeamComponents"
        Me.chkCalcIncludeNoTeamComponents.Size = New System.Drawing.Size(151, 17)
        Me.chkCalcIncludeNoTeamComponents.TabIndex = 1
        Me.chkCalcIncludeNoTeamComponents.Text = "Component Manufacturing"
        Me.chkCalcIncludeNoTeamComponents.UseVisualStyleBackColor = true
        '
        'chkCalcIncludeNoTeamCopy
        '
        Me.chkCalcIncludeNoTeamCopy.AutoSize = true
        Me.chkCalcIncludeNoTeamCopy.Location = New System.Drawing.Point(9, 52)
        Me.chkCalcIncludeNoTeamCopy.Name = "chkCalcIncludeNoTeamCopy"
        Me.chkCalcIncludeNoTeamCopy.Size = New System.Drawing.Size(64, 17)
        Me.chkCalcIncludeNoTeamCopy.TabIndex = 2
        Me.chkCalcIncludeNoTeamCopy.Text = "Copying"
        Me.chkCalcIncludeNoTeamCopy.UseVisualStyleBackColor = true
        '
        'chkCalcIncludeNoTeamInvention
        '
        Me.chkCalcIncludeNoTeamInvention.AutoSize = true
        Me.chkCalcIncludeNoTeamInvention.Location = New System.Drawing.Point(86, 52)
        Me.chkCalcIncludeNoTeamInvention.Name = "chkCalcIncludeNoTeamInvention"
        Me.chkCalcIncludeNoTeamInvention.Size = New System.Drawing.Size(70, 17)
        Me.chkCalcIncludeNoTeamInvention.TabIndex = 3
        Me.chkCalcIncludeNoTeamInvention.Text = "Invention"
        Me.chkCalcIncludeNoTeamInvention.UseVisualStyleBackColor = true
        Me.chkCalcIncludeNoTeamInvention.Visible = false
        '
        'chkCalcIncludeNoTeamManufacturing
        '
        Me.chkCalcIncludeNoTeamManufacturing.AutoSize = true
        Me.chkCalcIncludeNoTeamManufacturing.Location = New System.Drawing.Point(9, 18)
        Me.chkCalcIncludeNoTeamManufacturing.Name = "chkCalcIncludeNoTeamManufacturing"
        Me.chkCalcIncludeNoTeamManufacturing.Size = New System.Drawing.Size(94, 17)
        Me.chkCalcIncludeNoTeamManufacturing.TabIndex = 0
        Me.chkCalcIncludeNoTeamManufacturing.Text = "Manufacturing"
        Me.chkCalcIncludeNoTeamManufacturing.UseVisualStyleBackColor = true
        '
        'gbIncludeItems
        '
        Me.gbIncludeItems.Controls.Add(Me.chkCalcCanRE)
        Me.gbIncludeItems.Controls.Add(Me.chkCalcCanInvent)
        Me.gbIncludeItems.Controls.Add(Me.chkCalcCanBuild)
        Me.gbIncludeItems.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gbIncludeItems.Location = New System.Drawing.Point(409, 241)
        Me.gbIncludeItems.Name = "gbIncludeItems"
        Me.gbIncludeItems.Size = New System.Drawing.Size(133, 53)
        Me.gbIncludeItems.TabIndex = 12
        Me.gbIncludeItems.TabStop = false
        Me.gbIncludeItems.Text = "Only Calc Items I Can:"
        '
        'chkCalcCanRE
        '
        Me.chkCalcCanRE.AutoSize = true
        Me.chkCalcCanRE.Location = New System.Drawing.Point(9, 34)
        Me.chkCalcCanRE.Name = "chkCalcCanRE"
        Me.chkCalcCanRE.Size = New System.Drawing.Size(111, 17)
        Me.chkCalcCanRE.TabIndex = 2
        Me.chkCalcCanRE.Text = "Reverse Engineer"
        Me.chkCalcCanRE.UseVisualStyleBackColor = true
        '
        'chkCalcCanInvent
        '
        Me.chkCalcCanInvent.AutoSize = true
        Me.chkCalcCanInvent.Location = New System.Drawing.Point(66, 17)
        Me.chkCalcCanInvent.Name = "chkCalcCanInvent"
        Me.chkCalcCanInvent.Size = New System.Drawing.Size(56, 17)
        Me.chkCalcCanInvent.TabIndex = 1
        Me.chkCalcCanInvent.Text = "Invent"
        Me.chkCalcCanInvent.UseVisualStyleBackColor = true
        '
        'chkCalcCanBuild
        '
        Me.chkCalcCanBuild.AutoSize = true
        Me.chkCalcCanBuild.Location = New System.Drawing.Point(9, 17)
        Me.chkCalcCanBuild.Name = "chkCalcCanBuild"
        Me.chkCalcCanBuild.Size = New System.Drawing.Size(49, 17)
        Me.chkCalcCanBuild.TabIndex = 0
        Me.chkCalcCanBuild.Text = "Build"
        Me.chkCalcCanBuild.UseVisualStyleBackColor = true
        '
        'btnCalcSelectColumns
        '
        Me.btnCalcSelectColumns.Location = New System.Drawing.Point(1019, 211)
        Me.btnCalcSelectColumns.Name = "btnCalcSelectColumns"
        Me.btnCalcSelectColumns.Size = New System.Drawing.Size(96, 27)
        Me.btnCalcSelectColumns.TabIndex = 23
        Me.btnCalcSelectColumns.Text = "Select Columns"
        Me.btnCalcSelectColumns.UseVisualStyleBackColor = true
        '
        'gbSize
        '
        Me.gbSize.Controls.Add(Me.chkCalcXL)
        Me.gbSize.Controls.Add(Me.chkCalcLarge)
        Me.gbSize.Controls.Add(Me.chkCalcMedium)
        Me.gbSize.Controls.Add(Me.chkCalcSmall)
        Me.gbSize.Location = New System.Drawing.Point(6, 81)
        Me.gbSize.Name = "gbSize"
        Me.gbSize.Size = New System.Drawing.Size(148, 38)
        Me.gbSize.TabIndex = 3
        Me.gbSize.TabStop = false
        Me.gbSize.Text = "Size Limit"
        '
        'chkCalcXL
        '
        Me.chkCalcXL.AutoSize = true
        Me.chkCalcXL.Location = New System.Drawing.Point(109, 17)
        Me.chkCalcXL.Name = "chkCalcXL"
        Me.chkCalcXL.Size = New System.Drawing.Size(39, 17)
        Me.chkCalcXL.TabIndex = 3
        Me.chkCalcXL.Text = "XL"
        Me.chkCalcXL.UseVisualStyleBackColor = true
        '
        'chkCalcLarge
        '
        Me.chkCalcLarge.AutoSize = true
        Me.chkCalcLarge.Location = New System.Drawing.Point(77, 17)
        Me.chkCalcLarge.Name = "chkCalcLarge"
        Me.chkCalcLarge.Size = New System.Drawing.Size(32, 17)
        Me.chkCalcLarge.TabIndex = 2
        Me.chkCalcLarge.Text = "L"
        Me.chkCalcLarge.UseVisualStyleBackColor = true
        '
        'chkCalcMedium
        '
        Me.chkCalcMedium.AutoSize = true
        Me.chkCalcMedium.Location = New System.Drawing.Point(42, 17)
        Me.chkCalcMedium.Name = "chkCalcMedium"
        Me.chkCalcMedium.Size = New System.Drawing.Size(35, 17)
        Me.chkCalcMedium.TabIndex = 1
        Me.chkCalcMedium.Text = "M"
        Me.chkCalcMedium.UseVisualStyleBackColor = true
        '
        'chkCalcSmall
        '
        Me.chkCalcSmall.AutoSize = true
        Me.chkCalcSmall.Location = New System.Drawing.Point(9, 17)
        Me.chkCalcSmall.Name = "chkCalcSmall"
        Me.chkCalcSmall.Size = New System.Drawing.Size(33, 17)
        Me.chkCalcSmall.TabIndex = 0
        Me.chkCalcSmall.Text = "S"
        Me.chkCalcSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCalcSmall.UseVisualStyleBackColor = true
        '
        'gbCalcProdLines
        '
        Me.gbCalcProdLines.Controls.Add(Me.chkCalcAutoCalcT2NumBPs)
        Me.gbCalcProdLines.Controls.Add(Me.lblCalcBPs)
        Me.gbCalcProdLines.Controls.Add(Me.txtCalcNumBPs)
        Me.gbCalcProdLines.Controls.Add(Me.txtCalcRuns)
        Me.gbCalcProdLines.Controls.Add(Me.txtCalcLabLines)
        Me.gbCalcProdLines.Controls.Add(Me.lblCalcRuns)
        Me.gbCalcProdLines.Controls.Add(Me.lblCalcLabLines1)
        Me.gbCalcProdLines.Controls.Add(Me.lblCalcProdLines1)
        Me.gbCalcProdLines.Controls.Add(Me.txtCalcProdLines)
        Me.gbCalcProdLines.Location = New System.Drawing.Point(850, 15)
        Me.gbCalcProdLines.Name = "gbCalcProdLines"
        Me.gbCalcProdLines.Size = New System.Drawing.Size(165, 72)
        Me.gbCalcProdLines.TabIndex = 15
        Me.gbCalcProdLines.TabStop = false
        Me.gbCalcProdLines.Text = "Runs / Lines:"
        '
        'chkCalcAutoCalcT2NumBPs
        '
        Me.chkCalcAutoCalcT2NumBPs.AutoSize = true
        Me.chkCalcAutoCalcT2NumBPs.Location = New System.Drawing.Point(16, 52)
        Me.chkCalcAutoCalcT2NumBPs.Name = "chkCalcAutoCalcT2NumBPs"
        Me.chkCalcAutoCalcT2NumBPs.Size = New System.Drawing.Size(135, 17)
        Me.chkCalcAutoCalcT2NumBPs.TabIndex = 8
        Me.chkCalcAutoCalcT2NumBPs.Text = "Auto Calc T2 Num BPs"
        Me.chkCalcAutoCalcT2NumBPs.UseVisualStyleBackColor = true
        '
        'lblCalcBPs
        '
        Me.lblCalcBPs.AutoSize = true
        Me.lblCalcBPs.Location = New System.Drawing.Point(43, 13)
        Me.lblCalcBPs.Name = "lblCalcBPs"
        Me.lblCalcBPs.Size = New System.Drawing.Size(29, 13)
        Me.lblCalcBPs.TabIndex = 2
        Me.lblCalcBPs.Text = "BPs:"
        '
        'txtCalcNumBPs
        '
        Me.txtCalcNumBPs.Location = New System.Drawing.Point(46, 28)
        Me.txtCalcNumBPs.MaxLength = 3
        Me.txtCalcNumBPs.Name = "txtCalcNumBPs"
        Me.txtCalcNumBPs.Size = New System.Drawing.Size(32, 20)
        Me.txtCalcNumBPs.TabIndex = 3
        Me.txtCalcNumBPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCalcRuns
        '
        Me.txtCalcRuns.Location = New System.Drawing.Point(6, 28)
        Me.txtCalcRuns.MaxLength = 3
        Me.txtCalcRuns.Name = "txtCalcRuns"
        Me.txtCalcRuns.Size = New System.Drawing.Size(32, 20)
        Me.txtCalcRuns.TabIndex = 1
        Me.txtCalcRuns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCalcLabLines
        '
        Me.txtCalcLabLines.Location = New System.Drawing.Point(126, 28)
        Me.txtCalcLabLines.MaxLength = 3
        Me.txtCalcLabLines.Name = "txtCalcLabLines"
        Me.txtCalcLabLines.Size = New System.Drawing.Size(32, 20)
        Me.txtCalcLabLines.TabIndex = 7
        Me.txtCalcLabLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCalcRuns
        '
        Me.lblCalcRuns.AutoSize = true
        Me.lblCalcRuns.Location = New System.Drawing.Point(3, 13)
        Me.lblCalcRuns.Name = "lblCalcRuns"
        Me.lblCalcRuns.Size = New System.Drawing.Size(35, 13)
        Me.lblCalcRuns.TabIndex = 0
        Me.lblCalcRuns.Text = "Runs:"
        '
        'lblCalcLabLines1
        '
        Me.lblCalcLabLines1.AutoSize = true
        Me.lblCalcLabLines1.Location = New System.Drawing.Point(123, 13)
        Me.lblCalcLabLines1.Name = "lblCalcLabLines1"
        Me.lblCalcLabLines1.Size = New System.Drawing.Size(33, 13)
        Me.lblCalcLabLines1.TabIndex = 6
        Me.lblCalcLabLines1.Text = "Labs:"
        '
        'lblCalcProdLines1
        '
        Me.lblCalcProdLines1.AutoSize = true
        Me.lblCalcProdLines1.Location = New System.Drawing.Point(83, 13)
        Me.lblCalcProdLines1.Name = "lblCalcProdLines1"
        Me.lblCalcProdLines1.Size = New System.Drawing.Size(32, 13)
        Me.lblCalcProdLines1.TabIndex = 4
        Me.lblCalcProdLines1.Text = "Prod:"
        '
        'txtCalcProdLines
        '
        Me.txtCalcProdLines.Location = New System.Drawing.Point(86, 28)
        Me.txtCalcProdLines.MaxLength = 3
        Me.txtCalcProdLines.Name = "txtCalcProdLines"
        Me.txtCalcProdLines.Size = New System.Drawing.Size(32, 20)
        Me.txtCalcProdLines.TabIndex = 5
        Me.txtCalcProdLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbCalcCompareType
        '
        Me.gbCalcCompareType.Controls.Add(Me.rbtnCalcCompareBuildBuy)
        Me.gbCalcCompareType.Controls.Add(Me.rbtnCalcCompareRawMats)
        Me.gbCalcCompareType.Controls.Add(Me.rbtnCalcCompareComponents)
        Me.gbCalcCompareType.Controls.Add(Me.rbtnCalcCompareAll)
        Me.gbCalcCompareType.Location = New System.Drawing.Point(850, 89)
        Me.gbCalcCompareType.Name = "gbCalcCompareType"
        Me.gbCalcCompareType.Size = New System.Drawing.Size(165, 90)
        Me.gbCalcCompareType.TabIndex = 16
        Me.gbCalcCompareType.TabStop = false
        Me.gbCalcCompareType.Text = "Price Comparison:"
        '
        'rbtnCalcCompareBuildBuy
        '
        Me.rbtnCalcCompareBuildBuy.AutoSize = true
        Me.rbtnCalcCompareBuildBuy.Location = New System.Drawing.Point(9, 32)
        Me.rbtnCalcCompareBuildBuy.Name = "rbtnCalcCompareBuildBuy"
        Me.rbtnCalcCompareBuildBuy.Size = New System.Drawing.Size(116, 17)
        Me.rbtnCalcCompareBuildBuy.TabIndex = 1
        Me.rbtnCalcCompareBuildBuy.Text = "Compare Build/Buy"
        Me.rbtnCalcCompareBuildBuy.UseVisualStyleBackColor = true
        '
        'rbtnCalcCompareRawMats
        '
        Me.rbtnCalcCompareRawMats.AutoSize = true
        Me.rbtnCalcCompareRawMats.Location = New System.Drawing.Point(9, 49)
        Me.rbtnCalcCompareRawMats.Name = "rbtnCalcCompareRawMats"
        Me.rbtnCalcCompareRawMats.Size = New System.Drawing.Size(137, 17)
        Me.rbtnCalcCompareRawMats.TabIndex = 2
        Me.rbtnCalcCompareRawMats.Text = "Compare Raw Materials"
        Me.rbtnCalcCompareRawMats.UseVisualStyleBackColor = true
        '
        'rbtnCalcCompareComponents
        '
        Me.rbtnCalcCompareComponents.AutoSize = true
        Me.rbtnCalcCompareComponents.Location = New System.Drawing.Point(9, 66)
        Me.rbtnCalcCompareComponents.Name = "rbtnCalcCompareComponents"
        Me.rbtnCalcCompareComponents.Size = New System.Drawing.Size(129, 17)
        Me.rbtnCalcCompareComponents.TabIndex = 3
        Me.rbtnCalcCompareComponents.Text = "Compare Components"
        Me.rbtnCalcCompareComponents.UseVisualStyleBackColor = true
        '
        'rbtnCalcCompareAll
        '
        Me.rbtnCalcCompareAll.AutoSize = true
        Me.rbtnCalcCompareAll.Location = New System.Drawing.Point(9, 15)
        Me.rbtnCalcCompareAll.Name = "rbtnCalcCompareAll"
        Me.rbtnCalcCompareAll.Size = New System.Drawing.Size(81, 17)
        Me.rbtnCalcCompareAll.TabIndex = 0
        Me.rbtnCalcCompareAll.Text = "Compare All"
        Me.rbtnCalcCompareAll.UseVisualStyleBackColor = true
        '
        'gbCalcTextColors
        '
        Me.gbCalcTextColors.Controls.Add(Me.lblCalcText)
        Me.gbCalcTextColors.Controls.Add(Me.lblCalcColorCode3)
        Me.gbCalcTextColors.Controls.Add(Me.lblCalcColorCode4)
        Me.gbCalcTextColors.Controls.Add(Me.lblCalcColorCode5)
        Me.gbCalcTextColors.Controls.Add(Me.lblCalcColorCode2)
        Me.gbCalcTextColors.Controls.Add(Me.lblCalcColorCode1)
        Me.gbCalcTextColors.Location = New System.Drawing.Point(6, 116)
        Me.gbCalcTextColors.Name = "gbCalcTextColors"
        Me.gbCalcTextColors.Size = New System.Drawing.Size(148, 30)
        Me.gbCalcTextColors.TabIndex = 5
        Me.gbCalcTextColors.TabStop = false
        '
        'lblCalcText
        '
        Me.lblCalcText.AutoSize = true
        Me.lblCalcText.Location = New System.Drawing.Point(6, 11)
        Me.lblCalcText.Name = "lblCalcText"
        Me.lblCalcText.Size = New System.Drawing.Size(31, 13)
        Me.lblCalcText.TabIndex = 0
        Me.lblCalcText.Text = "Text:"
        '
        'lblCalcColorCode3
        '
        Me.lblCalcColorCode3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcColorCode3.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCalcColorCode3.Location = New System.Drawing.Point(80, 10)
        Me.lblCalcColorCode3.Name = "lblCalcColorCode3"
        Me.lblCalcColorCode3.Size = New System.Drawing.Size(15, 15)
        Me.lblCalcColorCode3.TabIndex = 2
        Me.lblCalcColorCode3.Text = "T"
        Me.lblCalcColorCode3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalcColorCode4
        '
        Me.lblCalcColorCode4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcColorCode4.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCalcColorCode4.Location = New System.Drawing.Point(100, 10)
        Me.lblCalcColorCode4.Name = "lblCalcColorCode4"
        Me.lblCalcColorCode4.Size = New System.Drawing.Size(15, 15)
        Me.lblCalcColorCode4.TabIndex = 3
        Me.lblCalcColorCode4.Text = "T"
        Me.lblCalcColorCode4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalcColorCode5
        '
        Me.lblCalcColorCode5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcColorCode5.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCalcColorCode5.Location = New System.Drawing.Point(120, 10)
        Me.lblCalcColorCode5.Name = "lblCalcColorCode5"
        Me.lblCalcColorCode5.Size = New System.Drawing.Size(15, 15)
        Me.lblCalcColorCode5.TabIndex = 4
        Me.lblCalcColorCode5.Text = "T"
        Me.lblCalcColorCode5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalcColorCode2
        '
        Me.lblCalcColorCode2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblCalcColorCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcColorCode2.ForeColor = System.Drawing.Color.Black
        Me.lblCalcColorCode2.Location = New System.Drawing.Point(60, 10)
        Me.lblCalcColorCode2.Name = "lblCalcColorCode2"
        Me.lblCalcColorCode2.Size = New System.Drawing.Size(15, 15)
        Me.lblCalcColorCode2.TabIndex = 1
        Me.lblCalcColorCode2.Text = "T"
        Me.lblCalcColorCode2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalcColorCode1
        '
        Me.lblCalcColorCode1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCalcColorCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcColorCode1.Location = New System.Drawing.Point(40, 10)
        Me.lblCalcColorCode1.Name = "lblCalcColorCode1"
        Me.lblCalcColorCode1.Size = New System.Drawing.Size(15, 15)
        Me.lblCalcColorCode1.TabIndex = 0
        Me.lblCalcColorCode1.Text = "T"
        Me.lblCalcColorCode1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbCalcInvention
        '
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptorforT3)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptorforT2)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor0)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor9)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor8)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor7)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor6)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor5)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor4)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor3)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor2)
        Me.gbCalcInvention.Controls.Add(Me.chkCalcDecryptor1)
        Me.gbCalcInvention.Controls.Add(Me.lblCalcDecryptorUse)
        Me.gbCalcInvention.Location = New System.Drawing.Point(6, 147)
        Me.gbCalcInvention.Name = "gbCalcInvention"
        Me.gbCalcInvention.Size = New System.Drawing.Size(400, 52)
        Me.gbCalcInvention.TabIndex = 6
        Me.gbCalcInvention.TabStop = false
        Me.gbCalcInvention.Text = "Invention Decryptors (Probability Multiplier):"
        '
        'chkCalcDecryptorforT3
        '
        Me.chkCalcDecryptorforT3.AutoSize = true
        Me.chkCalcDecryptorforT3.Location = New System.Drawing.Point(354, 30)
        Me.chkCalcDecryptorforT3.Name = "chkCalcDecryptorforT3"
        Me.chkCalcDecryptorforT3.Size = New System.Drawing.Size(39, 17)
        Me.chkCalcDecryptorforT3.TabIndex = 12
        Me.chkCalcDecryptorforT3.Text = "T3"
        Me.chkCalcDecryptorforT3.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptorforT2
        '
        Me.chkCalcDecryptorforT2.AutoSize = true
        Me.chkCalcDecryptorforT2.Location = New System.Drawing.Point(354, 14)
        Me.chkCalcDecryptorforT2.Name = "chkCalcDecryptorforT2"
        Me.chkCalcDecryptorforT2.Size = New System.Drawing.Size(39, 17)
        Me.chkCalcDecryptorforT2.TabIndex = 11
        Me.chkCalcDecryptorforT2.Text = "T2"
        Me.chkCalcDecryptorforT2.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor0
        '
        Me.chkCalcDecryptor0.AutoSize = true
        Me.chkCalcDecryptor0.Location = New System.Drawing.Point(9, 30)
        Me.chkCalcDecryptor0.Name = "chkCalcDecryptor0"
        Me.chkCalcDecryptor0.Size = New System.Drawing.Size(61, 17)
        Me.chkCalcDecryptor0.TabIndex = 1
        Me.chkCalcDecryptor0.Text = "Optimal"
        Me.chkCalcDecryptor0.UseVisualStyleBackColor = true
        Me.chkCalcDecryptor0.Visible = false
        '
        'chkCalcDecryptor9
        '
        Me.chkCalcDecryptor9.AutoSize = true
        Me.chkCalcDecryptor9.Location = New System.Drawing.Point(267, 30)
        Me.chkCalcDecryptor9.Name = "chkCalcDecryptor9"
        Me.chkCalcDecryptor9.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor9.TabIndex = 9
        Me.chkCalcDecryptor9.Text = "1.9x"
        Me.chkCalcDecryptor9.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor8
        '
        Me.chkCalcDecryptor8.AutoSize = true
        Me.chkCalcDecryptor8.Location = New System.Drawing.Point(204, 30)
        Me.chkCalcDecryptor8.Name = "chkCalcDecryptor8"
        Me.chkCalcDecryptor8.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor8.TabIndex = 7
        Me.chkCalcDecryptor8.Text = "1.8x"
        Me.chkCalcDecryptor8.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor7
        '
        Me.chkCalcDecryptor7.AutoSize = true
        Me.chkCalcDecryptor7.Location = New System.Drawing.Point(141, 30)
        Me.chkCalcDecryptor7.Name = "chkCalcDecryptor7"
        Me.chkCalcDecryptor7.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor7.TabIndex = 5
        Me.chkCalcDecryptor7.Text = "1.5x"
        Me.chkCalcDecryptor7.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor6
        '
        Me.chkCalcDecryptor6.AutoSize = true
        Me.chkCalcDecryptor6.Location = New System.Drawing.Point(78, 30)
        Me.chkCalcDecryptor6.Name = "chkCalcDecryptor6"
        Me.chkCalcDecryptor6.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor6.TabIndex = 3
        Me.chkCalcDecryptor6.Text = "1.2x"
        Me.chkCalcDecryptor6.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor5
        '
        Me.chkCalcDecryptor5.AutoSize = true
        Me.chkCalcDecryptor5.Location = New System.Drawing.Point(267, 14)
        Me.chkCalcDecryptor5.Name = "chkCalcDecryptor5"
        Me.chkCalcDecryptor5.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor5.TabIndex = 8
        Me.chkCalcDecryptor5.Text = "1.1x"
        Me.chkCalcDecryptor5.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor4
        '
        Me.chkCalcDecryptor4.AutoSize = true
        Me.chkCalcDecryptor4.Location = New System.Drawing.Point(204, 14)
        Me.chkCalcDecryptor4.Name = "chkCalcDecryptor4"
        Me.chkCalcDecryptor4.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor4.TabIndex = 6
        Me.chkCalcDecryptor4.Text = "1.0x"
        Me.chkCalcDecryptor4.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor3
        '
        Me.chkCalcDecryptor3.AutoSize = true
        Me.chkCalcDecryptor3.Location = New System.Drawing.Point(141, 14)
        Me.chkCalcDecryptor3.Name = "chkCalcDecryptor3"
        Me.chkCalcDecryptor3.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor3.TabIndex = 4
        Me.chkCalcDecryptor3.Text = "0.9x"
        Me.chkCalcDecryptor3.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor2
        '
        Me.chkCalcDecryptor2.AutoSize = true
        Me.chkCalcDecryptor2.Location = New System.Drawing.Point(78, 14)
        Me.chkCalcDecryptor2.Name = "chkCalcDecryptor2"
        Me.chkCalcDecryptor2.Size = New System.Drawing.Size(46, 17)
        Me.chkCalcDecryptor2.TabIndex = 2
        Me.chkCalcDecryptor2.Text = "0.6x"
        Me.chkCalcDecryptor2.UseVisualStyleBackColor = true
        '
        'chkCalcDecryptor1
        '
        Me.chkCalcDecryptor1.AutoSize = true
        Me.chkCalcDecryptor1.Location = New System.Drawing.Point(9, 14)
        Me.chkCalcDecryptor1.Name = "chkCalcDecryptor1"
        Me.chkCalcDecryptor1.Size = New System.Drawing.Size(52, 17)
        Me.chkCalcDecryptor1.TabIndex = 0
        Me.chkCalcDecryptor1.Text = "None"
        Me.chkCalcDecryptor1.UseVisualStyleBackColor = true
        '
        'lblCalcDecryptorUse
        '
        Me.lblCalcDecryptorUse.Location = New System.Drawing.Point(319, 13)
        Me.lblCalcDecryptorUse.Name = "lblCalcDecryptorUse"
        Me.lblCalcDecryptorUse.Size = New System.Drawing.Size(36, 33)
        Me.lblCalcDecryptorUse.TabIndex = 10
        Me.lblCalcDecryptorUse.Text = "Use For:"
        Me.lblCalcDecryptorUse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbBPRace
        '
        Me.gbBPRace.Controls.Add(Me.chkCalcRaceOther)
        Me.gbBPRace.Controls.Add(Me.chkCalcRacePirate)
        Me.gbBPRace.Controls.Add(Me.chkCalcRaceMinmatar)
        Me.gbBPRace.Controls.Add(Me.chkCalcRaceGallente)
        Me.gbBPRace.Controls.Add(Me.chkCalcRaceCaldari)
        Me.gbBPRace.Controls.Add(Me.chkCalcRaceAmarr)
        Me.gbBPRace.Location = New System.Drawing.Point(159, 81)
        Me.gbBPRace.Name = "gbBPRace"
        Me.gbBPRace.Size = New System.Drawing.Size(192, 65)
        Me.gbBPRace.TabIndex = 4
        Me.gbBPRace.TabStop = false
        Me.gbBPRace.Text = "BP Race"
        '
        'chkCalcRaceOther
        '
        Me.chkCalcRaceOther.AutoSize = true
        Me.chkCalcRaceOther.Location = New System.Drawing.Point(136, 40)
        Me.chkCalcRaceOther.Name = "chkCalcRaceOther"
        Me.chkCalcRaceOther.Size = New System.Drawing.Size(52, 17)
        Me.chkCalcRaceOther.TabIndex = 5
        Me.chkCalcRaceOther.Text = "Other"
        Me.chkCalcRaceOther.UseVisualStyleBackColor = true
        '
        'chkCalcRacePirate
        '
        Me.chkCalcRacePirate.AutoSize = true
        Me.chkCalcRacePirate.Location = New System.Drawing.Point(136, 17)
        Me.chkCalcRacePirate.Name = "chkCalcRacePirate"
        Me.chkCalcRacePirate.Size = New System.Drawing.Size(53, 17)
        Me.chkCalcRacePirate.TabIndex = 2
        Me.chkCalcRacePirate.Text = "Pirate"
        Me.chkCalcRacePirate.UseVisualStyleBackColor = true
        '
        'chkCalcRaceMinmatar
        '
        Me.chkCalcRaceMinmatar.AutoSize = true
        Me.chkCalcRaceMinmatar.Location = New System.Drawing.Point(69, 40)
        Me.chkCalcRaceMinmatar.Name = "chkCalcRaceMinmatar"
        Me.chkCalcRaceMinmatar.Size = New System.Drawing.Size(69, 17)
        Me.chkCalcRaceMinmatar.TabIndex = 4
        Me.chkCalcRaceMinmatar.Text = "Minmatar"
        Me.chkCalcRaceMinmatar.UseVisualStyleBackColor = true
        '
        'chkCalcRaceGallente
        '
        Me.chkCalcRaceGallente.AutoSize = true
        Me.chkCalcRaceGallente.Location = New System.Drawing.Point(6, 40)
        Me.chkCalcRaceGallente.Name = "chkCalcRaceGallente"
        Me.chkCalcRaceGallente.Size = New System.Drawing.Size(65, 17)
        Me.chkCalcRaceGallente.TabIndex = 3
        Me.chkCalcRaceGallente.Text = "Gallente"
        Me.chkCalcRaceGallente.UseVisualStyleBackColor = true
        '
        'chkCalcRaceCaldari
        '
        Me.chkCalcRaceCaldari.AutoSize = true
        Me.chkCalcRaceCaldari.Location = New System.Drawing.Point(69, 17)
        Me.chkCalcRaceCaldari.Name = "chkCalcRaceCaldari"
        Me.chkCalcRaceCaldari.Size = New System.Drawing.Size(58, 17)
        Me.chkCalcRaceCaldari.TabIndex = 1
        Me.chkCalcRaceCaldari.Text = "Caldari"
        Me.chkCalcRaceCaldari.UseVisualStyleBackColor = true
        '
        'chkCalcRaceAmarr
        '
        Me.chkCalcRaceAmarr.AutoSize = true
        Me.chkCalcRaceAmarr.Location = New System.Drawing.Point(6, 17)
        Me.chkCalcRaceAmarr.Name = "chkCalcRaceAmarr"
        Me.chkCalcRaceAmarr.Size = New System.Drawing.Size(53, 17)
        Me.chkCalcRaceAmarr.TabIndex = 0
        Me.chkCalcRaceAmarr.Text = "Amarr"
        Me.chkCalcRaceAmarr.UseVisualStyleBackColor = true
        '
        'tabCalcFacilities
        '
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityBase)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityComponents)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityCopy)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityT2Invention)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityT3Invention)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityCapitals)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilitySupers)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityT3Ships)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilitySubsystems)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityBoosters)
        Me.tabCalcFacilities.Controls.Add(Me.tabCalcFacilityNoPOS)
        Me.tabCalcFacilities.ItemSize = New System.Drawing.Size(49, 20)
        Me.tabCalcFacilities.Location = New System.Drawing.Point(546, 13)
        Me.tabCalcFacilities.Multiline = true
        Me.tabCalcFacilities.Name = "tabCalcFacilities"
        Me.tabCalcFacilities.Padding = New System.Drawing.Point(0, 0)
        Me.tabCalcFacilities.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabCalcFacilities.SelectedIndex = 0
        Me.tabCalcFacilities.Size = New System.Drawing.Size(301, 161)
        Me.tabCalcFacilities.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabCalcFacilities.TabIndex = 13
        '
        'tabCalcFacilityBase
        '
        Me.tabCalcFacilityBase.Controls.Add(Me.txtCalcBaseFacilityManualTax)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityManualTax)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityDefault)
        Me.tabCalcFacilityBase.Controls.Add(Me.btnCalcBaseFacilitySave)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityTaxRate)
        Me.tabCalcFacilityBase.Controls.Add(Me.txtCalcBaseFacilityManualTE)
        Me.tabCalcFacilityBase.Controls.Add(Me.txtCalcBaseFacilityManualME)
        Me.tabCalcFacilityBase.Controls.Add(Me.cmbCalcBaseFacilityorArray)
        Me.tabCalcFacilityBase.Controls.Add(Me.cmbCalcBaseFacilitySystem)
        Me.tabCalcFacilityBase.Controls.Add(Me.cmbCalcBaseFacilityRegion)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityManualTE)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityLocation)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityType)
        Me.tabCalcFacilityBase.Controls.Add(Me.chkCalcBaseFacilityIncludeUsage)
        Me.tabCalcFacilityBase.Controls.Add(Me.cmbCalcBaseFacilityType)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityManualME)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcBaseFacilityBonus)
        Me.tabCalcFacilityBase.Controls.Add(Me.cmbCalcPOSLargeShips)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcPOSLargeShips)
        Me.tabCalcFacilityBase.Controls.Add(Me.cmbCalcPOSFuelBlocks)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcPOSFuelBlocks)
        Me.tabCalcFacilityBase.Controls.Add(Me.cmbCalcPOSModules)
        Me.tabCalcFacilityBase.Controls.Add(Me.lblCalcPOSModules)
        Me.tabCalcFacilityBase.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityBase.Margin = New System.Windows.Forms.Padding(0)
        Me.tabCalcFacilityBase.Name = "tabCalcFacilityBase"
        Me.tabCalcFacilityBase.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalcFacilityBase.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityBase.TabIndex = 1
        Me.tabCalcFacilityBase.Text = "Base"
        Me.tabCalcFacilityBase.UseVisualStyleBackColor = true
        '
        'txtCalcBaseFacilityManualTax
        '
        Me.txtCalcBaseFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcBaseFacilityManualTax.MaxLength = 5
        Me.txtCalcBaseFacilityManualTax.Name = "txtCalcBaseFacilityManualTax"
        Me.txtCalcBaseFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcBaseFacilityManualTax.TabIndex = 21
        Me.txtCalcBaseFacilityManualTax.Text = "0%"
        Me.txtCalcBaseFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcBaseFacilityManualTax.Visible = False
        '
        'lblCalcBaseFacilityManualTax
        '
        Me.lblCalcBaseFacilityManualTax.AutoSize = True
        Me.lblCalcBaseFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcBaseFacilityManualTax.Name = "lblCalcBaseFacilityManualTax"
        Me.lblCalcBaseFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcBaseFacilityManualTax.TabIndex = 20
        Me.lblCalcBaseFacilityManualTax.Text = "Tax:"
        Me.lblCalcBaseFacilityManualTax.Visible = False
        '
        'lblCalcBaseFacilityDefault
        '
        Me.lblCalcBaseFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcBaseFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcBaseFacilityDefault.Name = "lblCalcBaseFacilityDefault"
        Me.lblCalcBaseFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcBaseFacilityDefault.TabIndex = 2
        Me.lblCalcBaseFacilityDefault.Text = "Default Facility"
        Me.lblCalcBaseFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcBaseFacilitySave
        '
        Me.btnCalcBaseFacilitySave.Enabled = False
        Me.btnCalcBaseFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcBaseFacilitySave.Name = "btnCalcBaseFacilitySave"
        Me.btnCalcBaseFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcBaseFacilitySave.TabIndex = 22
        Me.btnCalcBaseFacilitySave.Text = "Save"
        Me.btnCalcBaseFacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcBaseFacilityTaxRate
        '
        Me.lblCalcBaseFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcBaseFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcBaseFacilityTaxRate.Name = "lblCalcBaseFacilityTaxRate"
        Me.lblCalcBaseFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcBaseFacilityTaxRate.TabIndex = 19
        Me.lblCalcBaseFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcBaseFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcBaseFacilityTaxRate.Visible = False
        '
        'txtCalcBaseFacilityManualTE
        '
        Me.txtCalcBaseFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcBaseFacilityManualTE.MaxLength = 5
        Me.txtCalcBaseFacilityManualTE.Name = "txtCalcBaseFacilityManualTE"
        Me.txtCalcBaseFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcBaseFacilityManualTE.TabIndex = 17
        Me.txtCalcBaseFacilityManualTE.Text = "0%"
        Me.txtCalcBaseFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcBaseFacilityManualTE.Visible = False
        '
        'txtCalcBaseFacilityManualME
        '
        Me.txtCalcBaseFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcBaseFacilityManualME.MaxLength = 5
        Me.txtCalcBaseFacilityManualME.Name = "txtCalcBaseFacilityManualME"
        Me.txtCalcBaseFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcBaseFacilityManualME.TabIndex = 15
        Me.txtCalcBaseFacilityManualME.Text = "0%"
        Me.txtCalcBaseFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcBaseFacilityManualME.Visible = False
        '
        'cmbCalcBaseFacilityorArray
        '
        Me.cmbCalcBaseFacilityorArray.FormattingEnabled = True
        Me.cmbCalcBaseFacilityorArray.ItemHeight = 13
        Me.cmbCalcBaseFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcBaseFacilityorArray.Name = "cmbCalcBaseFacilityorArray"
        Me.cmbCalcBaseFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcBaseFacilityorArray.TabIndex = 7
        Me.cmbCalcBaseFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcBaseFacilitySystem
        '
        Me.cmbCalcBaseFacilitySystem.FormattingEnabled = True
        Me.cmbCalcBaseFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcBaseFacilitySystem.Name = "cmbCalcBaseFacilitySystem"
        Me.cmbCalcBaseFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcBaseFacilitySystem.TabIndex = 6
        Me.cmbCalcBaseFacilitySystem.Text = "Select System"
        '
        'cmbCalcBaseFacilityRegion
        '
        Me.cmbCalcBaseFacilityRegion.FormattingEnabled = True
        Me.cmbCalcBaseFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcBaseFacilityRegion.Name = "cmbCalcBaseFacilityRegion"
        Me.cmbCalcBaseFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcBaseFacilityRegion.TabIndex = 5
        Me.cmbCalcBaseFacilityRegion.Text = "Select Region"
        '
        'lblCalcBaseFacilityManualTE
        '
        Me.lblCalcBaseFacilityManualTE.AutoSize = True
        Me.lblCalcBaseFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcBaseFacilityManualTE.Name = "lblCalcBaseFacilityManualTE"
        Me.lblCalcBaseFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcBaseFacilityManualTE.TabIndex = 16
        Me.lblCalcBaseFacilityManualTE.Text = "TE:"
        Me.lblCalcBaseFacilityManualTE.Visible = False
        '
        'lblCalcBaseFacilityLocation
        '
        Me.lblCalcBaseFacilityLocation.AutoSize = True
        Me.lblCalcBaseFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcBaseFacilityLocation.Name = "lblCalcBaseFacilityLocation"
        Me.lblCalcBaseFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcBaseFacilityLocation.TabIndex = 3
        Me.lblCalcBaseFacilityLocation.Text = "Location:"
        '
        'lblCalcBaseFacilityType
        '
        Me.lblCalcBaseFacilityType.AutoSize = True
        Me.lblCalcBaseFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcBaseFacilityType.Name = "lblCalcBaseFacilityType"
        Me.lblCalcBaseFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcBaseFacilityType.TabIndex = 0
        Me.lblCalcBaseFacilityType.Text = "Facility Type:"
        '
        'chkCalcBaseFacilityIncludeUsage
        '
        Me.chkCalcBaseFacilityIncludeUsage.AutoSize = True
        Me.chkCalcBaseFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcBaseFacilityIncludeUsage.Name = "chkCalcBaseFacilityIncludeUsage"
        Me.chkCalcBaseFacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcBaseFacilityIncludeUsage.TabIndex = 4
        Me.chkCalcBaseFacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcBaseFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'cmbCalcBaseFacilityType
        '
        Me.cmbCalcBaseFacilityType.Enabled = False
        Me.cmbCalcBaseFacilityType.FormattingEnabled = True
        Me.cmbCalcBaseFacilityType.ItemHeight = 13
        Me.cmbCalcBaseFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcBaseFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcBaseFacilityType.Name = "cmbCalcBaseFacilityType"
        Me.cmbCalcBaseFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcBaseFacilityType.TabIndex = 1
        Me.cmbCalcBaseFacilityType.Text = "Type"
        '
        'lblCalcBaseFacilityManualME
        '
        Me.lblCalcBaseFacilityManualME.AutoSize = True
        Me.lblCalcBaseFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcBaseFacilityManualME.Name = "lblCalcBaseFacilityManualME"
        Me.lblCalcBaseFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcBaseFacilityManualME.TabIndex = 14
        Me.lblCalcBaseFacilityManualME.Text = "ME:"
        Me.lblCalcBaseFacilityManualME.Visible = False
        '
        'lblCalcBaseFacilityBonus
        '
        Me.lblCalcBaseFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcBaseFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcBaseFacilityBonus.Name = "lblCalcBaseFacilityBonus"
        Me.lblCalcBaseFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcBaseFacilityBonus.TabIndex = 18
        Me.lblCalcBaseFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcBaseFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcBaseFacilityBonus.Visible = False
        '
        'cmbCalcPOSLargeShips
        '
        Me.cmbCalcPOSLargeShips.FormattingEnabled = True
        Me.cmbCalcPOSLargeShips.Items.AddRange(New Object() {"All", "Capital", "Large"})
        Me.cmbCalcPOSLargeShips.Location = New System.Drawing.Point(165, 90)
        Me.cmbCalcPOSLargeShips.Name = "cmbCalcPOSLargeShips"
        Me.cmbCalcPOSLargeShips.Size = New System.Drawing.Size(66, 21)
        Me.cmbCalcPOSLargeShips.TabIndex = 13
        Me.cmbCalcPOSLargeShips.Text = "All"
        '
        'lblCalcPOSLargeShips
        '
        Me.lblCalcPOSLargeShips.Location = New System.Drawing.Point(163, 63)
        Me.lblCalcPOSLargeShips.Name = "lblCalcPOSLargeShips"
        Me.lblCalcPOSLargeShips.Size = New System.Drawing.Size(110, 30)
        Me.lblCalcPOSLargeShips.TabIndex = 10
        Me.lblCalcPOSLargeShips.Text = "Large Ships Assembly Array:"
        '
        'cmbCalcPOSFuelBlocks
        '
        Me.cmbCalcPOSFuelBlocks.FormattingEnabled = True
        Me.cmbCalcPOSFuelBlocks.Items.AddRange(New Object() {"All", "Ammunition", "Component"})
        Me.cmbCalcPOSFuelBlocks.Location = New System.Drawing.Point(85, 90)
        Me.cmbCalcPOSFuelBlocks.Name = "cmbCalcPOSFuelBlocks"
        Me.cmbCalcPOSFuelBlocks.Size = New System.Drawing.Size(78, 21)
        Me.cmbCalcPOSFuelBlocks.TabIndex = 12
        Me.cmbCalcPOSFuelBlocks.Text = "All"
        '
        'lblCalcPOSFuelBlocks
        '
        Me.lblCalcPOSFuelBlocks.Location = New System.Drawing.Point(83, 63)
        Me.lblCalcPOSFuelBlocks.Name = "lblCalcPOSFuelBlocks"
        Me.lblCalcPOSFuelBlocks.Size = New System.Drawing.Size(81, 30)
        Me.lblCalcPOSFuelBlocks.TabIndex = 9
        Me.lblCalcPOSFuelBlocks.Text = "Fuel Block Assembly Array:"
        '
        'cmbCalcPOSModules
        '
        Me.cmbCalcPOSModules.FormattingEnabled = True
        Me.cmbCalcPOSModules.Items.AddRange(New Object() {"All", "Equipment", "Rapid"})
        Me.cmbCalcPOSModules.Location = New System.Drawing.Point(5, 90)
        Me.cmbCalcPOSModules.Name = "cmbCalcPOSModules"
        Me.cmbCalcPOSModules.Size = New System.Drawing.Size(78, 21)
        Me.cmbCalcPOSModules.TabIndex = 11
        Me.cmbCalcPOSModules.Text = "All"
        '
        'lblCalcPOSModules
        '
        Me.lblCalcPOSModules.Location = New System.Drawing.Point(3, 63)
        Me.lblCalcPOSModules.Name = "lblCalcPOSModules"
        Me.lblCalcPOSModules.Size = New System.Drawing.Size(81, 30)
        Me.lblCalcPOSModules.TabIndex = 8
        Me.lblCalcPOSModules.Text = "Module Assembly Array:"
        '
        'tabCalcFacilityComponents
        '
        Me.tabCalcFacilityComponents.Controls.Add(Me.txtCalcComponentFacilityManualTax)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityManualTax)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityDefault)
        Me.tabCalcFacilityComponents.Controls.Add(Me.btnCalcComponentFacilitySave)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityTaxRate)
        Me.tabCalcFacilityComponents.Controls.Add(Me.txtCalcComponentFacilityManualTE)
        Me.tabCalcFacilityComponents.Controls.Add(Me.txtCalcComponentFacilityManualME)
        Me.tabCalcFacilityComponents.Controls.Add(Me.cmbCalcComponentFacilityorArray)
        Me.tabCalcFacilityComponents.Controls.Add(Me.cmbCalcComponentFacilitySystem)
        Me.tabCalcFacilityComponents.Controls.Add(Me.cmbCalcComponentFacilityRegion)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityManualTE)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityLocation)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityType)
        Me.tabCalcFacilityComponents.Controls.Add(Me.chkCalcComponentFacilityIncludeUsage)
        Me.tabCalcFacilityComponents.Controls.Add(Me.cmbCalcComponentFacilityType)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityManualME)
        Me.tabCalcFacilityComponents.Controls.Add(Me.lblCalcComponentFacilityBonus)
        Me.tabCalcFacilityComponents.Controls.Add(Me.chkCalcCapComponentsFacility)
        Me.tabCalcFacilityComponents.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityComponents.Name = "tabCalcFacilityComponents"
        Me.tabCalcFacilityComponents.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityComponents.TabIndex = 10
        Me.tabCalcFacilityComponents.Text = "Components"
        Me.tabCalcFacilityComponents.UseVisualStyleBackColor = True
        '
        'txtCalcComponentFacilityManualTax
        '
        Me.txtCalcComponentFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcComponentFacilityManualTax.MaxLength = 5
        Me.txtCalcComponentFacilityManualTax.Name = "txtCalcComponentFacilityManualTax"
        Me.txtCalcComponentFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcComponentFacilityManualTax.TabIndex = 21
        Me.txtCalcComponentFacilityManualTax.Text = "0%"
        Me.txtCalcComponentFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcComponentFacilityManualTax.Visible = False
        '
        'lblCalcComponentFacilityManualTax
        '
        Me.lblCalcComponentFacilityManualTax.AutoSize = True
        Me.lblCalcComponentFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcComponentFacilityManualTax.Name = "lblCalcComponentFacilityManualTax"
        Me.lblCalcComponentFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcComponentFacilityManualTax.TabIndex = 20
        Me.lblCalcComponentFacilityManualTax.Text = "Tax:"
        Me.lblCalcComponentFacilityManualTax.Visible = False
        '
        'lblCalcComponentFacilityDefault
        '
        Me.lblCalcComponentFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcComponentFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcComponentFacilityDefault.Name = "lblCalcComponentFacilityDefault"
        Me.lblCalcComponentFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcComponentFacilityDefault.TabIndex = 4
        Me.lblCalcComponentFacilityDefault.Text = "Default Facility"
        Me.lblCalcComponentFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcComponentFacilitySave
        '
        Me.btnCalcComponentFacilitySave.Enabled = False
        Me.btnCalcComponentFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcComponentFacilitySave.Name = "btnCalcComponentFacilitySave"
        Me.btnCalcComponentFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcComponentFacilitySave.TabIndex = 22
        Me.btnCalcComponentFacilitySave.Text = "Save"
        Me.btnCalcComponentFacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcComponentFacilityTaxRate
        '
        Me.lblCalcComponentFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcComponentFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcComponentFacilityTaxRate.Name = "lblCalcComponentFacilityTaxRate"
        Me.lblCalcComponentFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcComponentFacilityTaxRate.TabIndex = 14
        Me.lblCalcComponentFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcComponentFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcComponentFacilityTaxRate.Visible = False
        '
        'txtCalcComponentFacilityManualTE
        '
        Me.txtCalcComponentFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcComponentFacilityManualTE.MaxLength = 5
        Me.txtCalcComponentFacilityManualTE.Name = "txtCalcComponentFacilityManualTE"
        Me.txtCalcComponentFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcComponentFacilityManualTE.TabIndex = 13
        Me.txtCalcComponentFacilityManualTE.Text = "0%"
        Me.txtCalcComponentFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcComponentFacilityManualTE.Visible = False
        '
        'txtCalcComponentFacilityManualME
        '
        Me.txtCalcComponentFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcComponentFacilityManualME.MaxLength = 5
        Me.txtCalcComponentFacilityManualME.Name = "txtCalcComponentFacilityManualME"
        Me.txtCalcComponentFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcComponentFacilityManualME.TabIndex = 11
        Me.txtCalcComponentFacilityManualME.Text = "0%"
        Me.txtCalcComponentFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcComponentFacilityManualME.Visible = False
        '
        'cmbCalcComponentFacilityorArray
        '
        Me.cmbCalcComponentFacilityorArray.FormattingEnabled = True
        Me.cmbCalcComponentFacilityorArray.ItemHeight = 13
        Me.cmbCalcComponentFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcComponentFacilityorArray.Name = "cmbCalcComponentFacilityorArray"
        Me.cmbCalcComponentFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcComponentFacilityorArray.TabIndex = 8
        Me.cmbCalcComponentFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcComponentFacilitySystem
        '
        Me.cmbCalcComponentFacilitySystem.FormattingEnabled = True
        Me.cmbCalcComponentFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcComponentFacilitySystem.Name = "cmbCalcComponentFacilitySystem"
        Me.cmbCalcComponentFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcComponentFacilitySystem.TabIndex = 7
        Me.cmbCalcComponentFacilitySystem.Text = "Select System"
        '
        'cmbCalcComponentFacilityRegion
        '
        Me.cmbCalcComponentFacilityRegion.FormattingEnabled = True
        Me.cmbCalcComponentFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcComponentFacilityRegion.Name = "cmbCalcComponentFacilityRegion"
        Me.cmbCalcComponentFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcComponentFacilityRegion.TabIndex = 6
        Me.cmbCalcComponentFacilityRegion.Text = "Select Region"
        '
        'lblCalcComponentFacilityManualTE
        '
        Me.lblCalcComponentFacilityManualTE.AutoSize = True
        Me.lblCalcComponentFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcComponentFacilityManualTE.Name = "lblCalcComponentFacilityManualTE"
        Me.lblCalcComponentFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcComponentFacilityManualTE.TabIndex = 12
        Me.lblCalcComponentFacilityManualTE.Text = "TE:"
        Me.lblCalcComponentFacilityManualTE.Visible = False
        '
        'lblCalcComponentFacilityLocation
        '
        Me.lblCalcComponentFacilityLocation.AutoSize = True
        Me.lblCalcComponentFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcComponentFacilityLocation.Name = "lblCalcComponentFacilityLocation"
        Me.lblCalcComponentFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcComponentFacilityLocation.TabIndex = 5
        Me.lblCalcComponentFacilityLocation.Text = "Location:"
        '
        'lblCalcComponentFacilityType
        '
        Me.lblCalcComponentFacilityType.AutoSize = True
        Me.lblCalcComponentFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcComponentFacilityType.Name = "lblCalcComponentFacilityType"
        Me.lblCalcComponentFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcComponentFacilityType.TabIndex = 0
        Me.lblCalcComponentFacilityType.Text = "Facility Type:"
        '
        'chkCalcComponentFacilityIncludeUsage
        '
        Me.chkCalcComponentFacilityIncludeUsage.AutoSize = True
        Me.chkCalcComponentFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcComponentFacilityIncludeUsage.Name = "chkCalcComponentFacilityIncludeUsage"
        Me.chkCalcComponentFacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcComponentFacilityIncludeUsage.TabIndex = 3
        Me.chkCalcComponentFacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcComponentFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'cmbCalcComponentFacilityType
        '
        Me.cmbCalcComponentFacilityType.Enabled = False
        Me.cmbCalcComponentFacilityType.FormattingEnabled = True
        Me.cmbCalcComponentFacilityType.ItemHeight = 13
        Me.cmbCalcComponentFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcComponentFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcComponentFacilityType.Name = "cmbCalcComponentFacilityType"
        Me.cmbCalcComponentFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcComponentFacilityType.TabIndex = 1
        Me.cmbCalcComponentFacilityType.Text = "Type"
        '
        'lblCalcComponentFacilityManualME
        '
        Me.lblCalcComponentFacilityManualME.AutoSize = True
        Me.lblCalcComponentFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcComponentFacilityManualME.Name = "lblCalcComponentFacilityManualME"
        Me.lblCalcComponentFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcComponentFacilityManualME.TabIndex = 10
        Me.lblCalcComponentFacilityManualME.Text = "ME:"
        Me.lblCalcComponentFacilityManualME.Visible = False
        '
        'lblCalcComponentFacilityBonus
        '
        Me.lblCalcComponentFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcComponentFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcComponentFacilityBonus.Name = "lblCalcComponentFacilityBonus"
        Me.lblCalcComponentFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcComponentFacilityBonus.TabIndex = 9
        Me.lblCalcComponentFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcComponentFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcComponentFacilityBonus.Visible = False
        '
        'chkCalcCapComponentsFacility
        '
        Me.chkCalcCapComponentsFacility.AutoSize = True
        Me.chkCalcCapComponentsFacility.Location = New System.Drawing.Point(139, 6)
        Me.chkCalcCapComponentsFacility.Name = "chkCalcCapComponentsFacility"
        Me.chkCalcCapComponentsFacility.Size = New System.Drawing.Size(72, 17)
        Me.chkCalcCapComponentsFacility.TabIndex = 2
        Me.chkCalcCapComponentsFacility.Text = "Cap Parts"
        Me.chkCalcCapComponentsFacility.UseVisualStyleBackColor = True
        '
        'tabCalcFacilityCopy
        '
        Me.tabCalcFacilityCopy.Controls.Add(Me.txtCalcCopyFacilityManualTax)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityManualTax)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyInclude)
        Me.tabCalcFacilityCopy.Controls.Add(Me.chkCalcCopyFacilityIncludeUsage)
        Me.tabCalcFacilityCopy.Controls.Add(Me.chkCalcCopyFacilityIncludeTime)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityDefault)
        Me.tabCalcFacilityCopy.Controls.Add(Me.chkCalcCopyFacilityIncludeCost)
        Me.tabCalcFacilityCopy.Controls.Add(Me.btnCalcCopyFacilitySave)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityTaxRate)
        Me.tabCalcFacilityCopy.Controls.Add(Me.txtCalcCopyFacilityManualTE)
        Me.tabCalcFacilityCopy.Controls.Add(Me.txtCalcCopyFacilityManualME)
        Me.tabCalcFacilityCopy.Controls.Add(Me.cmbCalcCopyFacilityorArray)
        Me.tabCalcFacilityCopy.Controls.Add(Me.cmbCalcCopyFacilitySystem)
        Me.tabCalcFacilityCopy.Controls.Add(Me.cmbCalcCopyFacilityRegion)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityManualTE)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityLocation)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityType)
        Me.tabCalcFacilityCopy.Controls.Add(Me.cmbCalcCopyFacilityType)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityManualME)
        Me.tabCalcFacilityCopy.Controls.Add(Me.lblCalcCopyFacilityBonus)
        Me.tabCalcFacilityCopy.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityCopy.Name = "tabCalcFacilityCopy"
        Me.tabCalcFacilityCopy.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityCopy.TabIndex = 3
        Me.tabCalcFacilityCopy.Text = "Copy"
        Me.tabCalcFacilityCopy.UseVisualStyleBackColor = True
        '
        'txtCalcCopyFacilityManualTax
        '
        Me.txtCalcCopyFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcCopyFacilityManualTax.MaxLength = 5
        Me.txtCalcCopyFacilityManualTax.Name = "txtCalcCopyFacilityManualTax"
        Me.txtCalcCopyFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcCopyFacilityManualTax.TabIndex = 21
        Me.txtCalcCopyFacilityManualTax.Text = "0%"
        Me.txtCalcCopyFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcCopyFacilityManualTax.Visible = False
        '
        'lblCalcCopyFacilityManualTax
        '
        Me.lblCalcCopyFacilityManualTax.AutoSize = True
        Me.lblCalcCopyFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcCopyFacilityManualTax.Name = "lblCalcCopyFacilityManualTax"
        Me.lblCalcCopyFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcCopyFacilityManualTax.TabIndex = 20
        Me.lblCalcCopyFacilityManualTax.Text = "Tax:"
        Me.lblCalcCopyFacilityManualTax.Visible = False
        '
        'lblCalcCopyInclude
        '
        Me.lblCalcCopyInclude.AutoSize = True
        Me.lblCalcCopyInclude.Location = New System.Drawing.Point(136, 9)
        Me.lblCalcCopyInclude.Name = "lblCalcCopyInclude"
        Me.lblCalcCopyInclude.Size = New System.Drawing.Size(45, 13)
        Me.lblCalcCopyInclude.TabIndex = 2
        Me.lblCalcCopyInclude.Text = "Include:"
        '
        'chkCalcCopyFacilityIncludeUsage
        '
        Me.chkCalcCopyFacilityIncludeUsage.AutoSize = True
        Me.chkCalcCopyFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcCopyFacilityIncludeUsage.Name = "chkCalcCopyFacilityIncludeUsage"
        Me.chkCalcCopyFacilityIncludeUsage.Size = New System.Drawing.Size(57, 17)
        Me.chkCalcCopyFacilityIncludeUsage.TabIndex = 3
        Me.chkCalcCopyFacilityIncludeUsage.Text = "Usage"
        Me.chkCalcCopyFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'chkCalcCopyFacilityIncludeTime
        '
        Me.chkCalcCopyFacilityIncludeTime.AutoSize = True
        Me.chkCalcCopyFacilityIncludeTime.Location = New System.Drawing.Point(243, 25)
        Me.chkCalcCopyFacilityIncludeTime.Name = "chkCalcCopyFacilityIncludeTime"
        Me.chkCalcCopyFacilityIncludeTime.Size = New System.Drawing.Size(49, 17)
        Me.chkCalcCopyFacilityIncludeTime.TabIndex = 5
        Me.chkCalcCopyFacilityIncludeTime.Text = "Time"
        Me.chkCalcCopyFacilityIncludeTime.UseVisualStyleBackColor = True
        '
        'lblCalcCopyFacilityDefault
        '
        Me.lblCalcCopyFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcCopyFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcCopyFacilityDefault.Name = "lblCalcCopyFacilityDefault"
        Me.lblCalcCopyFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcCopyFacilityDefault.TabIndex = 6
        Me.lblCalcCopyFacilityDefault.Text = "Default Facility"
        Me.lblCalcCopyFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCalcCopyFacilityIncludeCost
        '
        Me.chkCalcCopyFacilityIncludeCost.AutoSize = True
        Me.chkCalcCopyFacilityIncludeCost.Location = New System.Drawing.Point(196, 25)
        Me.chkCalcCopyFacilityIncludeCost.Name = "chkCalcCopyFacilityIncludeCost"
        Me.chkCalcCopyFacilityIncludeCost.Size = New System.Drawing.Size(47, 17)
        Me.chkCalcCopyFacilityIncludeCost.TabIndex = 4
        Me.chkCalcCopyFacilityIncludeCost.Text = "Cost"
        Me.chkCalcCopyFacilityIncludeCost.UseVisualStyleBackColor = True
        '
        'btnCalcCopyFacilitySave
        '
        Me.btnCalcCopyFacilitySave.Enabled = False
        Me.btnCalcCopyFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcCopyFacilitySave.Name = "btnCalcCopyFacilitySave"
        Me.btnCalcCopyFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcCopyFacilitySave.TabIndex = 22
        Me.btnCalcCopyFacilitySave.Text = "Save"
        Me.btnCalcCopyFacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcCopyFacilityTaxRate
        '
        Me.lblCalcCopyFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcCopyFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcCopyFacilityTaxRate.Name = "lblCalcCopyFacilityTaxRate"
        Me.lblCalcCopyFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcCopyFacilityTaxRate.TabIndex = 16
        Me.lblCalcCopyFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcCopyFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcCopyFacilityTaxRate.Visible = False
        '
        'txtCalcCopyFacilityManualTE
        '
        Me.txtCalcCopyFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcCopyFacilityManualTE.MaxLength = 5
        Me.txtCalcCopyFacilityManualTE.Name = "txtCalcCopyFacilityManualTE"
        Me.txtCalcCopyFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcCopyFacilityManualTE.TabIndex = 15
        Me.txtCalcCopyFacilityManualTE.Text = "0%"
        Me.txtCalcCopyFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcCopyFacilityManualTE.Visible = False
        '
        'txtCalcCopyFacilityManualME
        '
        Me.txtCalcCopyFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcCopyFacilityManualME.MaxLength = 5
        Me.txtCalcCopyFacilityManualME.Name = "txtCalcCopyFacilityManualME"
        Me.txtCalcCopyFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcCopyFacilityManualME.TabIndex = 13
        Me.txtCalcCopyFacilityManualME.Text = "0%"
        Me.txtCalcCopyFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcCopyFacilityManualME.Visible = False
        '
        'cmbCalcCopyFacilityorArray
        '
        Me.cmbCalcCopyFacilityorArray.FormattingEnabled = True
        Me.cmbCalcCopyFacilityorArray.ItemHeight = 13
        Me.cmbCalcCopyFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcCopyFacilityorArray.Name = "cmbCalcCopyFacilityorArray"
        Me.cmbCalcCopyFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcCopyFacilityorArray.TabIndex = 10
        Me.cmbCalcCopyFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcCopyFacilitySystem
        '
        Me.cmbCalcCopyFacilitySystem.FormattingEnabled = True
        Me.cmbCalcCopyFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcCopyFacilitySystem.Name = "cmbCalcCopyFacilitySystem"
        Me.cmbCalcCopyFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcCopyFacilitySystem.TabIndex = 9
        Me.cmbCalcCopyFacilitySystem.Text = "Select System"
        '
        'cmbCalcCopyFacilityRegion
        '
        Me.cmbCalcCopyFacilityRegion.FormattingEnabled = True
        Me.cmbCalcCopyFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcCopyFacilityRegion.Name = "cmbCalcCopyFacilityRegion"
        Me.cmbCalcCopyFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcCopyFacilityRegion.TabIndex = 8
        Me.cmbCalcCopyFacilityRegion.Text = "Select Region"
        '
        'lblCalcCopyFacilityManualTE
        '
        Me.lblCalcCopyFacilityManualTE.AutoSize = True
        Me.lblCalcCopyFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcCopyFacilityManualTE.Name = "lblCalcCopyFacilityManualTE"
        Me.lblCalcCopyFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcCopyFacilityManualTE.TabIndex = 14
        Me.lblCalcCopyFacilityManualTE.Text = "TE:"
        Me.lblCalcCopyFacilityManualTE.Visible = False
        '
        'lblCalcCopyFacilityLocation
        '
        Me.lblCalcCopyFacilityLocation.AutoSize = True
        Me.lblCalcCopyFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcCopyFacilityLocation.Name = "lblCalcCopyFacilityLocation"
        Me.lblCalcCopyFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcCopyFacilityLocation.TabIndex = 7
        Me.lblCalcCopyFacilityLocation.Text = "Location:"
        '
        'lblCalcCopyFacilityType
        '
        Me.lblCalcCopyFacilityType.AutoSize = True
        Me.lblCalcCopyFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcCopyFacilityType.Name = "lblCalcCopyFacilityType"
        Me.lblCalcCopyFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcCopyFacilityType.TabIndex = 0
        Me.lblCalcCopyFacilityType.Text = "Facility Type:"
        '
        'cmbCalcCopyFacilityType
        '
        Me.cmbCalcCopyFacilityType.Enabled = False
        Me.cmbCalcCopyFacilityType.FormattingEnabled = True
        Me.cmbCalcCopyFacilityType.ItemHeight = 13
        Me.cmbCalcCopyFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcCopyFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcCopyFacilityType.Name = "cmbCalcCopyFacilityType"
        Me.cmbCalcCopyFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcCopyFacilityType.TabIndex = 1
        Me.cmbCalcCopyFacilityType.Text = "Type"
        '
        'lblCalcCopyFacilityManualME
        '
        Me.lblCalcCopyFacilityManualME.AutoSize = True
        Me.lblCalcCopyFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcCopyFacilityManualME.Name = "lblCalcCopyFacilityManualME"
        Me.lblCalcCopyFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcCopyFacilityManualME.TabIndex = 12
        Me.lblCalcCopyFacilityManualME.Text = "ME:"
        Me.lblCalcCopyFacilityManualME.Visible = False
        '
        'lblCalcCopyFacilityBonus
        '
        Me.lblCalcCopyFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcCopyFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcCopyFacilityBonus.Name = "lblCalcCopyFacilityBonus"
        Me.lblCalcCopyFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcCopyFacilityBonus.TabIndex = 11
        Me.lblCalcCopyFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcCopyFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcCopyFacilityBonus.Visible = False
        '
        'tabCalcFacilityT2Invention
        '
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.txtCalcInventionFacilityManualTax)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityManualTax)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionInclude)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.chkCalcInventionFacilityIncludeUsage)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityDefault)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.chkCalcInventionFacilityIncludeTime)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.btnCalcInventionFacilitySave)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.chkCalcInventionFacilityIncludeCost)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityTaxRate)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.txtCalcInventionFacilityManualTE)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.txtCalcInventionFacilityManualME)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.cmbCalcInventionFacilityorArray)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.cmbCalcInventionFacilitySystem)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.cmbCalcInventionFacilityRegion)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityManualTE)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityLocation)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityType)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.cmbCalcInventionFacilityType)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityManualME)
        Me.tabCalcFacilityT2Invention.Controls.Add(Me.lblCalcInventionFacilityBonus)
        Me.tabCalcFacilityT2Invention.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityT2Invention.Name = "tabCalcFacilityT2Invention"
        Me.tabCalcFacilityT2Invention.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityT2Invention.TabIndex = 2
        Me.tabCalcFacilityT2Invention.Text = "T2 Inv."
        Me.tabCalcFacilityT2Invention.UseVisualStyleBackColor = True
        '
        'txtCalcInventionFacilityManualTax
        '
        Me.txtCalcInventionFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcInventionFacilityManualTax.MaxLength = 5
        Me.txtCalcInventionFacilityManualTax.Name = "txtCalcInventionFacilityManualTax"
        Me.txtCalcInventionFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcInventionFacilityManualTax.TabIndex = 21
        Me.txtCalcInventionFacilityManualTax.Text = "0%"
        Me.txtCalcInventionFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcInventionFacilityManualTax.Visible = False
        '
        'lblCalcInventionFacilityManualTax
        '
        Me.lblCalcInventionFacilityManualTax.AutoSize = True
        Me.lblCalcInventionFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcInventionFacilityManualTax.Name = "lblCalcInventionFacilityManualTax"
        Me.lblCalcInventionFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcInventionFacilityManualTax.TabIndex = 20
        Me.lblCalcInventionFacilityManualTax.Text = "Tax:"
        Me.lblCalcInventionFacilityManualTax.Visible = False
        '
        'lblCalcInventionInclude
        '
        Me.lblCalcInventionInclude.AutoSize = True
        Me.lblCalcInventionInclude.Location = New System.Drawing.Point(136, 9)
        Me.lblCalcInventionInclude.Name = "lblCalcInventionInclude"
        Me.lblCalcInventionInclude.Size = New System.Drawing.Size(45, 13)
        Me.lblCalcInventionInclude.TabIndex = 2
        Me.lblCalcInventionInclude.Text = "Include:"
        '
        'chkCalcInventionFacilityIncludeUsage
        '
        Me.chkCalcInventionFacilityIncludeUsage.AutoSize = True
        Me.chkCalcInventionFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcInventionFacilityIncludeUsage.Name = "chkCalcInventionFacilityIncludeUsage"
        Me.chkCalcInventionFacilityIncludeUsage.Size = New System.Drawing.Size(57, 17)
        Me.chkCalcInventionFacilityIncludeUsage.TabIndex = 3
        Me.chkCalcInventionFacilityIncludeUsage.Text = "Usage"
        Me.chkCalcInventionFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'lblCalcInventionFacilityDefault
        '
        Me.lblCalcInventionFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcInventionFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcInventionFacilityDefault.Name = "lblCalcInventionFacilityDefault"
        Me.lblCalcInventionFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcInventionFacilityDefault.TabIndex = 6
        Me.lblCalcInventionFacilityDefault.Text = "Default Facility"
        Me.lblCalcInventionFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCalcInventionFacilityIncludeTime
        '
        Me.chkCalcInventionFacilityIncludeTime.AutoSize = True
        Me.chkCalcInventionFacilityIncludeTime.Location = New System.Drawing.Point(243, 25)
        Me.chkCalcInventionFacilityIncludeTime.Name = "chkCalcInventionFacilityIncludeTime"
        Me.chkCalcInventionFacilityIncludeTime.Size = New System.Drawing.Size(49, 17)
        Me.chkCalcInventionFacilityIncludeTime.TabIndex = 5
        Me.chkCalcInventionFacilityIncludeTime.Text = "Time"
        Me.chkCalcInventionFacilityIncludeTime.UseVisualStyleBackColor = True
        '
        'btnCalcInventionFacilitySave
        '
        Me.btnCalcInventionFacilitySave.Enabled = False
        Me.btnCalcInventionFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcInventionFacilitySave.Name = "btnCalcInventionFacilitySave"
        Me.btnCalcInventionFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcInventionFacilitySave.TabIndex = 22
        Me.btnCalcInventionFacilitySave.Text = "Save"
        Me.btnCalcInventionFacilitySave.UseVisualStyleBackColor = True
        '
        'chkCalcInventionFacilityIncludeCost
        '
        Me.chkCalcInventionFacilityIncludeCost.AutoSize = True
        Me.chkCalcInventionFacilityIncludeCost.Location = New System.Drawing.Point(196, 25)
        Me.chkCalcInventionFacilityIncludeCost.Name = "chkCalcInventionFacilityIncludeCost"
        Me.chkCalcInventionFacilityIncludeCost.Size = New System.Drawing.Size(47, 17)
        Me.chkCalcInventionFacilityIncludeCost.TabIndex = 4
        Me.chkCalcInventionFacilityIncludeCost.Text = "Cost"
        Me.chkCalcInventionFacilityIncludeCost.UseVisualStyleBackColor = True
        '
        'lblCalcInventionFacilityTaxRate
        '
        Me.lblCalcInventionFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcInventionFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcInventionFacilityTaxRate.Name = "lblCalcInventionFacilityTaxRate"
        Me.lblCalcInventionFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcInventionFacilityTaxRate.TabIndex = 16
        Me.lblCalcInventionFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcInventionFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcInventionFacilityTaxRate.Visible = False
        '
        'txtCalcInventionFacilityManualTE
        '
        Me.txtCalcInventionFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcInventionFacilityManualTE.MaxLength = 5
        Me.txtCalcInventionFacilityManualTE.Name = "txtCalcInventionFacilityManualTE"
        Me.txtCalcInventionFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcInventionFacilityManualTE.TabIndex = 15
        Me.txtCalcInventionFacilityManualTE.Text = "0%"
        Me.txtCalcInventionFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcInventionFacilityManualTE.Visible = False
        '
        'txtCalcInventionFacilityManualME
        '
        Me.txtCalcInventionFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcInventionFacilityManualME.MaxLength = 5
        Me.txtCalcInventionFacilityManualME.Name = "txtCalcInventionFacilityManualME"
        Me.txtCalcInventionFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcInventionFacilityManualME.TabIndex = 13
        Me.txtCalcInventionFacilityManualME.Text = "0%"
        Me.txtCalcInventionFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcInventionFacilityManualME.Visible = False
        '
        'cmbCalcInventionFacilityorArray
        '
        Me.cmbCalcInventionFacilityorArray.FormattingEnabled = True
        Me.cmbCalcInventionFacilityorArray.ItemHeight = 13
        Me.cmbCalcInventionFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcInventionFacilityorArray.Name = "cmbCalcInventionFacilityorArray"
        Me.cmbCalcInventionFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcInventionFacilityorArray.TabIndex = 10
        Me.cmbCalcInventionFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcInventionFacilitySystem
        '
        Me.cmbCalcInventionFacilitySystem.FormattingEnabled = True
        Me.cmbCalcInventionFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcInventionFacilitySystem.Name = "cmbCalcInventionFacilitySystem"
        Me.cmbCalcInventionFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcInventionFacilitySystem.TabIndex = 9
        Me.cmbCalcInventionFacilitySystem.Text = "Select System"
        '
        'cmbCalcInventionFacilityRegion
        '
        Me.cmbCalcInventionFacilityRegion.FormattingEnabled = True
        Me.cmbCalcInventionFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcInventionFacilityRegion.Name = "cmbCalcInventionFacilityRegion"
        Me.cmbCalcInventionFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcInventionFacilityRegion.TabIndex = 8
        Me.cmbCalcInventionFacilityRegion.Text = "Select Region"
        '
        'lblCalcInventionFacilityManualTE
        '
        Me.lblCalcInventionFacilityManualTE.AutoSize = True
        Me.lblCalcInventionFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcInventionFacilityManualTE.Name = "lblCalcInventionFacilityManualTE"
        Me.lblCalcInventionFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcInventionFacilityManualTE.TabIndex = 14
        Me.lblCalcInventionFacilityManualTE.Text = "TE:"
        Me.lblCalcInventionFacilityManualTE.Visible = False
        '
        'lblCalcInventionFacilityLocation
        '
        Me.lblCalcInventionFacilityLocation.AutoSize = True
        Me.lblCalcInventionFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcInventionFacilityLocation.Name = "lblCalcInventionFacilityLocation"
        Me.lblCalcInventionFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcInventionFacilityLocation.TabIndex = 7
        Me.lblCalcInventionFacilityLocation.Text = "Location:"
        '
        'lblCalcInventionFacilityType
        '
        Me.lblCalcInventionFacilityType.AutoSize = True
        Me.lblCalcInventionFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcInventionFacilityType.Name = "lblCalcInventionFacilityType"
        Me.lblCalcInventionFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcInventionFacilityType.TabIndex = 0
        Me.lblCalcInventionFacilityType.Text = "Facility Type:"
        '
        'cmbCalcInventionFacilityType
        '
        Me.cmbCalcInventionFacilityType.Enabled = False
        Me.cmbCalcInventionFacilityType.FormattingEnabled = True
        Me.cmbCalcInventionFacilityType.ItemHeight = 13
        Me.cmbCalcInventionFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcInventionFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcInventionFacilityType.Name = "cmbCalcInventionFacilityType"
        Me.cmbCalcInventionFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcInventionFacilityType.TabIndex = 1
        Me.cmbCalcInventionFacilityType.Text = "Type"
        '
        'lblCalcInventionFacilityManualME
        '
        Me.lblCalcInventionFacilityManualME.AutoSize = True
        Me.lblCalcInventionFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcInventionFacilityManualME.Name = "lblCalcInventionFacilityManualME"
        Me.lblCalcInventionFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcInventionFacilityManualME.TabIndex = 12
        Me.lblCalcInventionFacilityManualME.Text = "ME:"
        Me.lblCalcInventionFacilityManualME.Visible = False
        '
        'lblCalcInventionFacilityBonus
        '
        Me.lblCalcInventionFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcInventionFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcInventionFacilityBonus.Name = "lblCalcInventionFacilityBonus"
        Me.lblCalcInventionFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcInventionFacilityBonus.TabIndex = 11
        Me.lblCalcInventionFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcInventionFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcInventionFacilityBonus.Visible = False
        '
        'tabCalcFacilityT3Invention
        '
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.txtCalcT3InventionFacilityManualTax)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.lblCalcT3InventionFacilityManualTax)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.lblCalcT3InventionInclude)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.chkCalcT3InventionFacilityIncludeUsage)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.lblCalcT3InventionFacilityManualTE)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.lblCalcT3InventionFacilityDefault)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.chkCalcT3InventionFacilityIncludeTime)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.btnCalcT3InventionFacilitySave)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.chkCalcT3InventionFacilityIncludeCost)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.lblCalcT3InventionFacilityTaxRate)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.txtCalcT3InventionFacilityManualTE)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.txtCalcT3InventionFacilityManualME)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.cmbCalcT3InventionFacilityorArray)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.cmbCalcT3InventionFacilitySystem)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.cmbCalcT3InventionFacilityRegion)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.Label3)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.Label4)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.cmbCalcT3InventionFacilityType)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.lblCalcT3InventionFacilityManualME)
        Me.tabCalcFacilityT3Invention.Controls.Add(Me.lblCalcT3InventionFacilityBonus)
        Me.tabCalcFacilityT3Invention.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityT3Invention.Name = "tabCalcFacilityT3Invention"
        Me.tabCalcFacilityT3Invention.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityT3Invention.TabIndex = 11
        Me.tabCalcFacilityT3Invention.Text = "T3 Inv."
        Me.tabCalcFacilityT3Invention.UseVisualStyleBackColor = True
        '
        'txtCalcT3InventionFacilityManualTax
        '
        Me.txtCalcT3InventionFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcT3InventionFacilityManualTax.MaxLength = 5
        Me.txtCalcT3InventionFacilityManualTax.Name = "txtCalcT3InventionFacilityManualTax"
        Me.txtCalcT3InventionFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcT3InventionFacilityManualTax.TabIndex = 21
        Me.txtCalcT3InventionFacilityManualTax.Text = "0%"
        Me.txtCalcT3InventionFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcT3InventionFacilityManualTax.Visible = False
        '
        'lblCalcT3InventionFacilityManualTax
        '
        Me.lblCalcT3InventionFacilityManualTax.AutoSize = True
        Me.lblCalcT3InventionFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcT3InventionFacilityManualTax.Name = "lblCalcT3InventionFacilityManualTax"
        Me.lblCalcT3InventionFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcT3InventionFacilityManualTax.TabIndex = 20
        Me.lblCalcT3InventionFacilityManualTax.Text = "Tax:"
        Me.lblCalcT3InventionFacilityManualTax.Visible = False
        '
        'lblCalcT3InventionInclude
        '
        Me.lblCalcT3InventionInclude.AutoSize = True
        Me.lblCalcT3InventionInclude.Location = New System.Drawing.Point(136, 9)
        Me.lblCalcT3InventionInclude.Name = "lblCalcT3InventionInclude"
        Me.lblCalcT3InventionInclude.Size = New System.Drawing.Size(45, 13)
        Me.lblCalcT3InventionInclude.TabIndex = 2
        Me.lblCalcT3InventionInclude.Text = "Include:"
        '
        'chkCalcT3InventionFacilityIncludeUsage
        '
        Me.chkCalcT3InventionFacilityIncludeUsage.AutoSize = True
        Me.chkCalcT3InventionFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcT3InventionFacilityIncludeUsage.Name = "chkCalcT3InventionFacilityIncludeUsage"
        Me.chkCalcT3InventionFacilityIncludeUsage.Size = New System.Drawing.Size(57, 17)
        Me.chkCalcT3InventionFacilityIncludeUsage.TabIndex = 3
        Me.chkCalcT3InventionFacilityIncludeUsage.Text = "Usage"
        Me.chkCalcT3InventionFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'lblCalcT3InventionFacilityManualTE
        '
        Me.lblCalcT3InventionFacilityManualTE.AutoSize = True
        Me.lblCalcT3InventionFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcT3InventionFacilityManualTE.Name = "lblCalcT3InventionFacilityManualTE"
        Me.lblCalcT3InventionFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcT3InventionFacilityManualTE.TabIndex = 14
        Me.lblCalcT3InventionFacilityManualTE.Text = "TE:"
        Me.lblCalcT3InventionFacilityManualTE.Visible = False
        '
        'lblCalcT3InventionFacilityDefault
        '
        Me.lblCalcT3InventionFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcT3InventionFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcT3InventionFacilityDefault.Name = "lblCalcT3InventionFacilityDefault"
        Me.lblCalcT3InventionFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcT3InventionFacilityDefault.TabIndex = 6
        Me.lblCalcT3InventionFacilityDefault.Text = "Default Facility"
        Me.lblCalcT3InventionFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCalcT3InventionFacilityIncludeTime
        '
        Me.chkCalcT3InventionFacilityIncludeTime.AutoSize = True
        Me.chkCalcT3InventionFacilityIncludeTime.Location = New System.Drawing.Point(243, 25)
        Me.chkCalcT3InventionFacilityIncludeTime.Name = "chkCalcT3InventionFacilityIncludeTime"
        Me.chkCalcT3InventionFacilityIncludeTime.Size = New System.Drawing.Size(49, 17)
        Me.chkCalcT3InventionFacilityIncludeTime.TabIndex = 5
        Me.chkCalcT3InventionFacilityIncludeTime.Text = "Time"
        Me.chkCalcT3InventionFacilityIncludeTime.UseVisualStyleBackColor = True
        '
        'btnCalcT3InventionFacilitySave
        '
        Me.btnCalcT3InventionFacilitySave.Enabled = False
        Me.btnCalcT3InventionFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcT3InventionFacilitySave.Name = "btnCalcT3InventionFacilitySave"
        Me.btnCalcT3InventionFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcT3InventionFacilitySave.TabIndex = 22
        Me.btnCalcT3InventionFacilitySave.Text = "Save"
        Me.btnCalcT3InventionFacilitySave.UseVisualStyleBackColor = True
        '
        'chkCalcT3InventionFacilityIncludeCost
        '
        Me.chkCalcT3InventionFacilityIncludeCost.AutoSize = True
        Me.chkCalcT3InventionFacilityIncludeCost.Location = New System.Drawing.Point(196, 25)
        Me.chkCalcT3InventionFacilityIncludeCost.Name = "chkCalcT3InventionFacilityIncludeCost"
        Me.chkCalcT3InventionFacilityIncludeCost.Size = New System.Drawing.Size(47, 17)
        Me.chkCalcT3InventionFacilityIncludeCost.TabIndex = 4
        Me.chkCalcT3InventionFacilityIncludeCost.Text = "Cost"
        Me.chkCalcT3InventionFacilityIncludeCost.UseVisualStyleBackColor = True
        '
        'lblCalcT3InventionFacilityTaxRate
        '
        Me.lblCalcT3InventionFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcT3InventionFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcT3InventionFacilityTaxRate.Name = "lblCalcT3InventionFacilityTaxRate"
        Me.lblCalcT3InventionFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcT3InventionFacilityTaxRate.TabIndex = 16
        Me.lblCalcT3InventionFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcT3InventionFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcT3InventionFacilityTaxRate.Visible = False
        '
        'txtCalcT3InventionFacilityManualTE
        '
        Me.txtCalcT3InventionFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcT3InventionFacilityManualTE.MaxLength = 5
        Me.txtCalcT3InventionFacilityManualTE.Name = "txtCalcT3InventionFacilityManualTE"
        Me.txtCalcT3InventionFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcT3InventionFacilityManualTE.TabIndex = 14
        Me.txtCalcT3InventionFacilityManualTE.Text = "0%"
        Me.txtCalcT3InventionFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcT3InventionFacilityManualTE.Visible = False
        '
        'txtCalcT3InventionFacilityManualME
        '
        Me.txtCalcT3InventionFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcT3InventionFacilityManualME.MaxLength = 5
        Me.txtCalcT3InventionFacilityManualME.Name = "txtCalcT3InventionFacilityManualME"
        Me.txtCalcT3InventionFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcT3InventionFacilityManualME.TabIndex = 13
        Me.txtCalcT3InventionFacilityManualME.Text = "0%"
        Me.txtCalcT3InventionFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcT3InventionFacilityManualME.Visible = False
        '
        'cmbCalcT3InventionFacilityorArray
        '
        Me.cmbCalcT3InventionFacilityorArray.FormattingEnabled = True
        Me.cmbCalcT3InventionFacilityorArray.ItemHeight = 13
        Me.cmbCalcT3InventionFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcT3InventionFacilityorArray.Name = "cmbCalcT3InventionFacilityorArray"
        Me.cmbCalcT3InventionFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcT3InventionFacilityorArray.TabIndex = 10
        Me.cmbCalcT3InventionFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcT3InventionFacilitySystem
        '
        Me.cmbCalcT3InventionFacilitySystem.FormattingEnabled = True
        Me.cmbCalcT3InventionFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcT3InventionFacilitySystem.Name = "cmbCalcT3InventionFacilitySystem"
        Me.cmbCalcT3InventionFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcT3InventionFacilitySystem.TabIndex = 9
        Me.cmbCalcT3InventionFacilitySystem.Text = "Select System"
        '
        'cmbCalcT3InventionFacilityRegion
        '
        Me.cmbCalcT3InventionFacilityRegion.FormattingEnabled = True
        Me.cmbCalcT3InventionFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcT3InventionFacilityRegion.Name = "cmbCalcT3InventionFacilityRegion"
        Me.cmbCalcT3InventionFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcT3InventionFacilityRegion.TabIndex = 8
        Me.cmbCalcT3InventionFacilityRegion.Text = "Select Region"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Facility Type:"
        '
        'cmbCalcT3InventionFacilityType
        '
        Me.cmbCalcT3InventionFacilityType.Enabled = False
        Me.cmbCalcT3InventionFacilityType.FormattingEnabled = True
        Me.cmbCalcT3InventionFacilityType.ItemHeight = 13
        Me.cmbCalcT3InventionFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcT3InventionFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcT3InventionFacilityType.Name = "cmbCalcT3InventionFacilityType"
        Me.cmbCalcT3InventionFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcT3InventionFacilityType.TabIndex = 1
        Me.cmbCalcT3InventionFacilityType.Text = "Type"
        '
        'lblCalcT3InventionFacilityManualME
        '
        Me.lblCalcT3InventionFacilityManualME.AutoSize = True
        Me.lblCalcT3InventionFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcT3InventionFacilityManualME.Name = "lblCalcT3InventionFacilityManualME"
        Me.lblCalcT3InventionFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcT3InventionFacilityManualME.TabIndex = 12
        Me.lblCalcT3InventionFacilityManualME.Text = "ME:"
        Me.lblCalcT3InventionFacilityManualME.Visible = False
        '
        'lblCalcT3InventionFacilityBonus
        '
        Me.lblCalcT3InventionFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcT3InventionFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcT3InventionFacilityBonus.Name = "lblCalcT3InventionFacilityBonus"
        Me.lblCalcT3InventionFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcT3InventionFacilityBonus.TabIndex = 11
        Me.lblCalcT3InventionFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcT3InventionFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcT3InventionFacilityBonus.Visible = False
        '
        'tabCalcFacilityCapitals
        '
        Me.tabCalcFacilityCapitals.Controls.Add(Me.txtCalcCapitalFacilityManualTax)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityManualTax)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityDefault)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.btnCalcCapitalFacilitySave)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityTaxRate)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.txtCalcCapitalFacilityManualTE)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.txtCalcCapitalFacilityManualME)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.cmbCalcCapitalFacilityorArray)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.cmbCalcCapitalFacilitySystem)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.cmbCalcCapitalFacilityRegion)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityManualTE)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityLocation)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityType)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.chkCalcCapitalFacilityIncludeUsage)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.cmbCalcCapitalFacilityType)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityManualME)
        Me.tabCalcFacilityCapitals.Controls.Add(Me.lblCalcCapitalFacilityBonus)
        Me.tabCalcFacilityCapitals.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityCapitals.Name = "tabCalcFacilityCapitals"
        Me.tabCalcFacilityCapitals.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityCapitals.TabIndex = 5
        Me.tabCalcFacilityCapitals.Text = "Capitals"
        Me.tabCalcFacilityCapitals.UseVisualStyleBackColor = True
        '
        'txtCalcCapitalFacilityManualTax
        '
        Me.txtCalcCapitalFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcCapitalFacilityManualTax.MaxLength = 5
        Me.txtCalcCapitalFacilityManualTax.Name = "txtCalcCapitalFacilityManualTax"
        Me.txtCalcCapitalFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcCapitalFacilityManualTax.TabIndex = 21
        Me.txtCalcCapitalFacilityManualTax.Text = "0%"
        Me.txtCalcCapitalFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcCapitalFacilityManualTax.Visible = False
        '
        'lblCalcCapitalFacilityManualTax
        '
        Me.lblCalcCapitalFacilityManualTax.AutoSize = True
        Me.lblCalcCapitalFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcCapitalFacilityManualTax.Name = "lblCalcCapitalFacilityManualTax"
        Me.lblCalcCapitalFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcCapitalFacilityManualTax.TabIndex = 20
        Me.lblCalcCapitalFacilityManualTax.Text = "Tax:"
        Me.lblCalcCapitalFacilityManualTax.Visible = False
        '
        'lblCalcCapitalFacilityDefault
        '
        Me.lblCalcCapitalFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcCapitalFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcCapitalFacilityDefault.Name = "lblCalcCapitalFacilityDefault"
        Me.lblCalcCapitalFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcCapitalFacilityDefault.TabIndex = 3
        Me.lblCalcCapitalFacilityDefault.Text = "Default Facility"
        Me.lblCalcCapitalFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcCapitalFacilitySave
        '
        Me.btnCalcCapitalFacilitySave.Enabled = False
        Me.btnCalcCapitalFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcCapitalFacilitySave.Name = "btnCalcCapitalFacilitySave"
        Me.btnCalcCapitalFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcCapitalFacilitySave.TabIndex = 22
        Me.btnCalcCapitalFacilitySave.Text = "Save"
        Me.btnCalcCapitalFacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcCapitalFacilityTaxRate
        '
        Me.lblCalcCapitalFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcCapitalFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcCapitalFacilityTaxRate.Name = "lblCalcCapitalFacilityTaxRate"
        Me.lblCalcCapitalFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcCapitalFacilityTaxRate.TabIndex = 13
        Me.lblCalcCapitalFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcCapitalFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcCapitalFacilityTaxRate.Visible = False
        '
        'txtCalcCapitalFacilityManualTE
        '
        Me.txtCalcCapitalFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcCapitalFacilityManualTE.MaxLength = 5
        Me.txtCalcCapitalFacilityManualTE.Name = "txtCalcCapitalFacilityManualTE"
        Me.txtCalcCapitalFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcCapitalFacilityManualTE.TabIndex = 12
        Me.txtCalcCapitalFacilityManualTE.Text = "0%"
        Me.txtCalcCapitalFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcCapitalFacilityManualTE.Visible = False
        '
        'txtCalcCapitalFacilityManualME
        '
        Me.txtCalcCapitalFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcCapitalFacilityManualME.MaxLength = 5
        Me.txtCalcCapitalFacilityManualME.Name = "txtCalcCapitalFacilityManualME"
        Me.txtCalcCapitalFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcCapitalFacilityManualME.TabIndex = 10
        Me.txtCalcCapitalFacilityManualME.Text = "0%"
        Me.txtCalcCapitalFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcCapitalFacilityManualME.Visible = False
        '
        'cmbCalcCapitalFacilityorArray
        '
        Me.cmbCalcCapitalFacilityorArray.FormattingEnabled = True
        Me.cmbCalcCapitalFacilityorArray.ItemHeight = 13
        Me.cmbCalcCapitalFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcCapitalFacilityorArray.Name = "cmbCalcCapitalFacilityorArray"
        Me.cmbCalcCapitalFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcCapitalFacilityorArray.TabIndex = 7
        Me.cmbCalcCapitalFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcCapitalFacilitySystem
        '
        Me.cmbCalcCapitalFacilitySystem.FormattingEnabled = True
        Me.cmbCalcCapitalFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcCapitalFacilitySystem.Name = "cmbCalcCapitalFacilitySystem"
        Me.cmbCalcCapitalFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcCapitalFacilitySystem.TabIndex = 6
        Me.cmbCalcCapitalFacilitySystem.Text = "Select System"
        '
        'cmbCalcCapitalFacilityRegion
        '
        Me.cmbCalcCapitalFacilityRegion.FormattingEnabled = True
        Me.cmbCalcCapitalFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcCapitalFacilityRegion.Name = "cmbCalcCapitalFacilityRegion"
        Me.cmbCalcCapitalFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcCapitalFacilityRegion.TabIndex = 5
        Me.cmbCalcCapitalFacilityRegion.Text = "Select Region"
        '
        'lblCalcCapitalFacilityManualTE
        '
        Me.lblCalcCapitalFacilityManualTE.AutoSize = True
        Me.lblCalcCapitalFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcCapitalFacilityManualTE.Name = "lblCalcCapitalFacilityManualTE"
        Me.lblCalcCapitalFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcCapitalFacilityManualTE.TabIndex = 11
        Me.lblCalcCapitalFacilityManualTE.Text = "TE:"
        Me.lblCalcCapitalFacilityManualTE.Visible = False
        '
        'lblCalcCapitalFacilityLocation
        '
        Me.lblCalcCapitalFacilityLocation.AutoSize = True
        Me.lblCalcCapitalFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcCapitalFacilityLocation.Name = "lblCalcCapitalFacilityLocation"
        Me.lblCalcCapitalFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcCapitalFacilityLocation.TabIndex = 4
        Me.lblCalcCapitalFacilityLocation.Text = "Location:"
        '
        'lblCalcCapitalFacilityType
        '
        Me.lblCalcCapitalFacilityType.AutoSize = True
        Me.lblCalcCapitalFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcCapitalFacilityType.Name = "lblCalcCapitalFacilityType"
        Me.lblCalcCapitalFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcCapitalFacilityType.TabIndex = 0
        Me.lblCalcCapitalFacilityType.Text = "Facility Type:"
        '
        'chkCalcCapitalFacilityIncludeUsage
        '
        Me.chkCalcCapitalFacilityIncludeUsage.AutoSize = True
        Me.chkCalcCapitalFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcCapitalFacilityIncludeUsage.Name = "chkCalcCapitalFacilityIncludeUsage"
        Me.chkCalcCapitalFacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcCapitalFacilityIncludeUsage.TabIndex = 2
        Me.chkCalcCapitalFacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcCapitalFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'cmbCalcCapitalFacilityType
        '
        Me.cmbCalcCapitalFacilityType.Enabled = False
        Me.cmbCalcCapitalFacilityType.FormattingEnabled = True
        Me.cmbCalcCapitalFacilityType.ItemHeight = 13
        Me.cmbCalcCapitalFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcCapitalFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcCapitalFacilityType.Name = "cmbCalcCapitalFacilityType"
        Me.cmbCalcCapitalFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcCapitalFacilityType.TabIndex = 1
        Me.cmbCalcCapitalFacilityType.Text = "Type"
        '
        'lblCalcCapitalFacilityManualME
        '
        Me.lblCalcCapitalFacilityManualME.AutoSize = True
        Me.lblCalcCapitalFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcCapitalFacilityManualME.Name = "lblCalcCapitalFacilityManualME"
        Me.lblCalcCapitalFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcCapitalFacilityManualME.TabIndex = 9
        Me.lblCalcCapitalFacilityManualME.Text = "ME:"
        Me.lblCalcCapitalFacilityManualME.Visible = False
        '
        'lblCalcCapitalFacilityBonus
        '
        Me.lblCalcCapitalFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcCapitalFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcCapitalFacilityBonus.Name = "lblCalcCapitalFacilityBonus"
        Me.lblCalcCapitalFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcCapitalFacilityBonus.TabIndex = 8
        Me.lblCalcCapitalFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcCapitalFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcCapitalFacilityBonus.Visible = False
        '
        'tabCalcFacilitySupers
        '
        Me.tabCalcFacilitySupers.Controls.Add(Me.txtCalcSuperFacilityManualTax)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityManualTax)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityDefault)
        Me.tabCalcFacilitySupers.Controls.Add(Me.btnCalcSuperFacilitySave)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityTaxRate)
        Me.tabCalcFacilitySupers.Controls.Add(Me.txtCalcSuperFacilityManualTE)
        Me.tabCalcFacilitySupers.Controls.Add(Me.txtCalcSuperFacilityManualME)
        Me.tabCalcFacilitySupers.Controls.Add(Me.cmbCalcSuperFacilityorArray)
        Me.tabCalcFacilitySupers.Controls.Add(Me.cmbCalcSuperFacilitySystem)
        Me.tabCalcFacilitySupers.Controls.Add(Me.cmbCalcSuperFacilityRegion)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityManualTE)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityLocation)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityType)
        Me.tabCalcFacilitySupers.Controls.Add(Me.chkCalcSuperFacilityIncludeUsage)
        Me.tabCalcFacilitySupers.Controls.Add(Me.cmbCalcSuperFacilityType)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityManualME)
        Me.tabCalcFacilitySupers.Controls.Add(Me.lblCalcSuperFacilityBonus)
        Me.tabCalcFacilitySupers.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilitySupers.Name = "tabCalcFacilitySupers"
        Me.tabCalcFacilitySupers.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilitySupers.TabIndex = 6
        Me.tabCalcFacilitySupers.Text = "Supers"
        Me.tabCalcFacilitySupers.UseVisualStyleBackColor = True
        '
        'txtCalcSuperFacilityManualTax
        '
        Me.txtCalcSuperFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcSuperFacilityManualTax.MaxLength = 5
        Me.txtCalcSuperFacilityManualTax.Name = "txtCalcSuperFacilityManualTax"
        Me.txtCalcSuperFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcSuperFacilityManualTax.TabIndex = 21
        Me.txtCalcSuperFacilityManualTax.Text = "0%"
        Me.txtCalcSuperFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcSuperFacilityManualTax.Visible = False
        '
        'lblCalcSuperFacilityManualTax
        '
        Me.lblCalcSuperFacilityManualTax.AutoSize = True
        Me.lblCalcSuperFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcSuperFacilityManualTax.Name = "lblCalcSuperFacilityManualTax"
        Me.lblCalcSuperFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcSuperFacilityManualTax.TabIndex = 20
        Me.lblCalcSuperFacilityManualTax.Text = "Tax:"
        Me.lblCalcSuperFacilityManualTax.Visible = False
        '
        'lblCalcSuperFacilityDefault
        '
        Me.lblCalcSuperFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcSuperFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcSuperFacilityDefault.Name = "lblCalcSuperFacilityDefault"
        Me.lblCalcSuperFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcSuperFacilityDefault.TabIndex = 2
        Me.lblCalcSuperFacilityDefault.Text = "Default Facility"
        Me.lblCalcSuperFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcSuperFacilitySave
        '
        Me.btnCalcSuperFacilitySave.Enabled = False
        Me.btnCalcSuperFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcSuperFacilitySave.Name = "btnCalcSuperFacilitySave"
        Me.btnCalcSuperFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcSuperFacilitySave.TabIndex = 22
        Me.btnCalcSuperFacilitySave.Text = "Save"
        Me.btnCalcSuperFacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcSuperFacilityTaxRate
        '
        Me.lblCalcSuperFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcSuperFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcSuperFacilityTaxRate.Name = "lblCalcSuperFacilityTaxRate"
        Me.lblCalcSuperFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcSuperFacilityTaxRate.TabIndex = 13
        Me.lblCalcSuperFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcSuperFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcSuperFacilityTaxRate.Visible = False
        '
        'txtCalcSuperFacilityManualTE
        '
        Me.txtCalcSuperFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcSuperFacilityManualTE.MaxLength = 5
        Me.txtCalcSuperFacilityManualTE.Name = "txtCalcSuperFacilityManualTE"
        Me.txtCalcSuperFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcSuperFacilityManualTE.TabIndex = 12
        Me.txtCalcSuperFacilityManualTE.Text = "0%"
        Me.txtCalcSuperFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcSuperFacilityManualTE.Visible = False
        '
        'txtCalcSuperFacilityManualME
        '
        Me.txtCalcSuperFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcSuperFacilityManualME.MaxLength = 5
        Me.txtCalcSuperFacilityManualME.Name = "txtCalcSuperFacilityManualME"
        Me.txtCalcSuperFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcSuperFacilityManualME.TabIndex = 10
        Me.txtCalcSuperFacilityManualME.Text = "0%"
        Me.txtCalcSuperFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcSuperFacilityManualME.Visible = False
        '
        'cmbCalcSuperFacilityorArray
        '
        Me.cmbCalcSuperFacilityorArray.FormattingEnabled = True
        Me.cmbCalcSuperFacilityorArray.ItemHeight = 13
        Me.cmbCalcSuperFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcSuperFacilityorArray.Name = "cmbCalcSuperFacilityorArray"
        Me.cmbCalcSuperFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcSuperFacilityorArray.TabIndex = 7
        Me.cmbCalcSuperFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcSuperFacilitySystem
        '
        Me.cmbCalcSuperFacilitySystem.FormattingEnabled = True
        Me.cmbCalcSuperFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcSuperFacilitySystem.Name = "cmbCalcSuperFacilitySystem"
        Me.cmbCalcSuperFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcSuperFacilitySystem.TabIndex = 6
        Me.cmbCalcSuperFacilitySystem.Text = "Select System"
        '
        'cmbCalcSuperFacilityRegion
        '
        Me.cmbCalcSuperFacilityRegion.FormattingEnabled = True
        Me.cmbCalcSuperFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcSuperFacilityRegion.Name = "cmbCalcSuperFacilityRegion"
        Me.cmbCalcSuperFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcSuperFacilityRegion.TabIndex = 5
        Me.cmbCalcSuperFacilityRegion.Text = "Select Region"
        '
        'lblCalcSuperFacilityManualTE
        '
        Me.lblCalcSuperFacilityManualTE.AutoSize = True
        Me.lblCalcSuperFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcSuperFacilityManualTE.Name = "lblCalcSuperFacilityManualTE"
        Me.lblCalcSuperFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcSuperFacilityManualTE.TabIndex = 11
        Me.lblCalcSuperFacilityManualTE.Text = "TE:"
        Me.lblCalcSuperFacilityManualTE.Visible = False
        '
        'lblCalcSuperFacilityLocation
        '
        Me.lblCalcSuperFacilityLocation.AutoSize = True
        Me.lblCalcSuperFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcSuperFacilityLocation.Name = "lblCalcSuperFacilityLocation"
        Me.lblCalcSuperFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcSuperFacilityLocation.TabIndex = 3
        Me.lblCalcSuperFacilityLocation.Text = "Location:"
        '
        'lblCalcSuperFacilityType
        '
        Me.lblCalcSuperFacilityType.AutoSize = True
        Me.lblCalcSuperFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcSuperFacilityType.Name = "lblCalcSuperFacilityType"
        Me.lblCalcSuperFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcSuperFacilityType.TabIndex = 0
        Me.lblCalcSuperFacilityType.Text = "Facility Type:"
        '
        'chkCalcSuperFacilityIncludeUsage
        '
        Me.chkCalcSuperFacilityIncludeUsage.AutoSize = True
        Me.chkCalcSuperFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcSuperFacilityIncludeUsage.Name = "chkCalcSuperFacilityIncludeUsage"
        Me.chkCalcSuperFacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcSuperFacilityIncludeUsage.TabIndex = 4
        Me.chkCalcSuperFacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcSuperFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'cmbCalcSuperFacilityType
        '
        Me.cmbCalcSuperFacilityType.Enabled = False
        Me.cmbCalcSuperFacilityType.FormattingEnabled = True
        Me.cmbCalcSuperFacilityType.ItemHeight = 13
        Me.cmbCalcSuperFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcSuperFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcSuperFacilityType.Name = "cmbCalcSuperFacilityType"
        Me.cmbCalcSuperFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcSuperFacilityType.TabIndex = 1
        Me.cmbCalcSuperFacilityType.Text = "Type"
        '
        'lblCalcSuperFacilityManualME
        '
        Me.lblCalcSuperFacilityManualME.AutoSize = True
        Me.lblCalcSuperFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcSuperFacilityManualME.Name = "lblCalcSuperFacilityManualME"
        Me.lblCalcSuperFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcSuperFacilityManualME.TabIndex = 9
        Me.lblCalcSuperFacilityManualME.Text = "ME:"
        Me.lblCalcSuperFacilityManualME.Visible = False
        '
        'lblCalcSuperFacilityBonus
        '
        Me.lblCalcSuperFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcSuperFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcSuperFacilityBonus.Name = "lblCalcSuperFacilityBonus"
        Me.lblCalcSuperFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcSuperFacilityBonus.TabIndex = 8
        Me.lblCalcSuperFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcSuperFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcSuperFacilityBonus.Visible = False
        '
        'tabCalcFacilityT3Ships
        '
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.txtCalcT3FacilityManualTax)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityManualTax)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.chkCalcT3DestroyersFacility)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityDefault)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.btnCalcT3FacilitySave)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityTaxRate)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.txtCalcT3FacilityManualTE)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.txtCalcT3FacilityManualME)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.cmbCalcT3FacilityorArray)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.cmbCalcT3FacilitySystem)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.cmbCalcT3FacilityRegion)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityManualTE)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityLocation)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityType)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.chkCalcT3FacilityIncludeUsage)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.cmbCalcT3FacilityType)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityManualME)
        Me.tabCalcFacilityT3Ships.Controls.Add(Me.lblCalcT3FacilityBonus)
        Me.tabCalcFacilityT3Ships.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityT3Ships.Name = "tabCalcFacilityT3Ships"
        Me.tabCalcFacilityT3Ships.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityT3Ships.TabIndex = 9
        Me.tabCalcFacilityT3Ships.Text = "T3 Ships"
        Me.tabCalcFacilityT3Ships.UseVisualStyleBackColor = True
        '
        'txtCalcT3FacilityManualTax
        '
        Me.txtCalcT3FacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcT3FacilityManualTax.MaxLength = 5
        Me.txtCalcT3FacilityManualTax.Name = "txtCalcT3FacilityManualTax"
        Me.txtCalcT3FacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcT3FacilityManualTax.TabIndex = 21
        Me.txtCalcT3FacilityManualTax.Text = "0%"
        Me.txtCalcT3FacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcT3FacilityManualTax.Visible = False
        '
        'lblCalcT3FacilityManualTax
        '
        Me.lblCalcT3FacilityManualTax.AutoSize = True
        Me.lblCalcT3FacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcT3FacilityManualTax.Name = "lblCalcT3FacilityManualTax"
        Me.lblCalcT3FacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcT3FacilityManualTax.TabIndex = 20
        Me.lblCalcT3FacilityManualTax.Text = "Tax:"
        Me.lblCalcT3FacilityManualTax.Visible = False
        '
        'chkCalcT3DestroyersFacility
        '
        Me.chkCalcT3DestroyersFacility.AutoSize = True
        Me.chkCalcT3DestroyersFacility.Location = New System.Drawing.Point(139, 6)
        Me.chkCalcT3DestroyersFacility.Name = "chkCalcT3DestroyersFacility"
        Me.chkCalcT3DestroyersFacility.Size = New System.Drawing.Size(76, 17)
        Me.chkCalcT3DestroyersFacility.TabIndex = 2
        Me.chkCalcT3DestroyersFacility.Text = "Destroyers"
        Me.chkCalcT3DestroyersFacility.UseVisualStyleBackColor = True
        '
        'lblCalcT3FacilityDefault
        '
        Me.lblCalcT3FacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcT3FacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcT3FacilityDefault.Name = "lblCalcT3FacilityDefault"
        Me.lblCalcT3FacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcT3FacilityDefault.TabIndex = 4
        Me.lblCalcT3FacilityDefault.Text = "Default Facility"
        Me.lblCalcT3FacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcT3FacilitySave
        '
        Me.btnCalcT3FacilitySave.Enabled = False
        Me.btnCalcT3FacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcT3FacilitySave.Name = "btnCalcT3FacilitySave"
        Me.btnCalcT3FacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcT3FacilitySave.TabIndex = 22
        Me.btnCalcT3FacilitySave.Text = "Save"
        Me.btnCalcT3FacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcT3FacilityTaxRate
        '
        Me.lblCalcT3FacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcT3FacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcT3FacilityTaxRate.Name = "lblCalcT3FacilityTaxRate"
        Me.lblCalcT3FacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcT3FacilityTaxRate.TabIndex = 14
        Me.lblCalcT3FacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcT3FacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcT3FacilityTaxRate.Visible = False
        '
        'txtCalcT3FacilityManualTE
        '
        Me.txtCalcT3FacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcT3FacilityManualTE.MaxLength = 5
        Me.txtCalcT3FacilityManualTE.Name = "txtCalcT3FacilityManualTE"
        Me.txtCalcT3FacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcT3FacilityManualTE.TabIndex = 13
        Me.txtCalcT3FacilityManualTE.Text = "0%"
        Me.txtCalcT3FacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcT3FacilityManualTE.Visible = False
        '
        'txtCalcT3FacilityManualME
        '
        Me.txtCalcT3FacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcT3FacilityManualME.MaxLength = 5
        Me.txtCalcT3FacilityManualME.Name = "txtCalcT3FacilityManualME"
        Me.txtCalcT3FacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcT3FacilityManualME.TabIndex = 11
        Me.txtCalcT3FacilityManualME.Text = "0%"
        Me.txtCalcT3FacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcT3FacilityManualME.Visible = False
        '
        'cmbCalcT3FacilityorArray
        '
        Me.cmbCalcT3FacilityorArray.FormattingEnabled = True
        Me.cmbCalcT3FacilityorArray.ItemHeight = 13
        Me.cmbCalcT3FacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcT3FacilityorArray.Name = "cmbCalcT3FacilityorArray"
        Me.cmbCalcT3FacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcT3FacilityorArray.TabIndex = 8
        Me.cmbCalcT3FacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcT3FacilitySystem
        '
        Me.cmbCalcT3FacilitySystem.FormattingEnabled = True
        Me.cmbCalcT3FacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcT3FacilitySystem.Name = "cmbCalcT3FacilitySystem"
        Me.cmbCalcT3FacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcT3FacilitySystem.TabIndex = 7
        Me.cmbCalcT3FacilitySystem.Text = "Select System"
        '
        'cmbCalcT3FacilityRegion
        '
        Me.cmbCalcT3FacilityRegion.FormattingEnabled = True
        Me.cmbCalcT3FacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcT3FacilityRegion.Name = "cmbCalcT3FacilityRegion"
        Me.cmbCalcT3FacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcT3FacilityRegion.TabIndex = 6
        Me.cmbCalcT3FacilityRegion.Text = "Select Region"
        '
        'lblCalcT3FacilityManualTE
        '
        Me.lblCalcT3FacilityManualTE.AutoSize = True
        Me.lblCalcT3FacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcT3FacilityManualTE.Name = "lblCalcT3FacilityManualTE"
        Me.lblCalcT3FacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcT3FacilityManualTE.TabIndex = 12
        Me.lblCalcT3FacilityManualTE.Text = "TE:"
        Me.lblCalcT3FacilityManualTE.Visible = False
        '
        'lblCalcT3FacilityLocation
        '
        Me.lblCalcT3FacilityLocation.AutoSize = True
        Me.lblCalcT3FacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcT3FacilityLocation.Name = "lblCalcT3FacilityLocation"
        Me.lblCalcT3FacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcT3FacilityLocation.TabIndex = 5
        Me.lblCalcT3FacilityLocation.Text = "Location:"
        '
        'lblCalcT3FacilityType
        '
        Me.lblCalcT3FacilityType.AutoSize = True
        Me.lblCalcT3FacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcT3FacilityType.Name = "lblCalcT3FacilityType"
        Me.lblCalcT3FacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcT3FacilityType.TabIndex = 0
        Me.lblCalcT3FacilityType.Text = "Facility Type:"
        '
        'chkCalcT3FacilityIncludeUsage
        '
        Me.chkCalcT3FacilityIncludeUsage.AutoSize = True
        Me.chkCalcT3FacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcT3FacilityIncludeUsage.Name = "chkCalcT3FacilityIncludeUsage"
        Me.chkCalcT3FacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcT3FacilityIncludeUsage.TabIndex = 3
        Me.chkCalcT3FacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcT3FacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'cmbCalcT3FacilityType
        '
        Me.cmbCalcT3FacilityType.Enabled = False
        Me.cmbCalcT3FacilityType.FormattingEnabled = True
        Me.cmbCalcT3FacilityType.ItemHeight = 13
        Me.cmbCalcT3FacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcT3FacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcT3FacilityType.Name = "cmbCalcT3FacilityType"
        Me.cmbCalcT3FacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcT3FacilityType.TabIndex = 1
        Me.cmbCalcT3FacilityType.Text = "Type"
        '
        'lblCalcT3FacilityManualME
        '
        Me.lblCalcT3FacilityManualME.AutoSize = True
        Me.lblCalcT3FacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcT3FacilityManualME.Name = "lblCalcT3FacilityManualME"
        Me.lblCalcT3FacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcT3FacilityManualME.TabIndex = 10
        Me.lblCalcT3FacilityManualME.Text = "ME:"
        Me.lblCalcT3FacilityManualME.Visible = False
        '
        'lblCalcT3FacilityBonus
        '
        Me.lblCalcT3FacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcT3FacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcT3FacilityBonus.Name = "lblCalcT3FacilityBonus"
        Me.lblCalcT3FacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcT3FacilityBonus.TabIndex = 9
        Me.lblCalcT3FacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcT3FacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcT3FacilityBonus.Visible = False
        '
        'tabCalcFacilitySubsystems
        '
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.txtCalcSubsystemFacilityManualTax)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityManualTax)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityDefault)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.btnCalcSubsystemFacilitySave)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityTaxRate)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.txtCalcSubsystemFacilityManualTE)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.txtCalcSubsystemFacilityManualME)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.cmbCalcSubsystemFacilityorArray)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.cmbCalcSubsystemFacilitySystem)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.cmbCalcSubsystemFacilityRegion)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityManualTE)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityLocation)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityType)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.chkCalcSubsystemFacilityIncludeUsage)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.cmbCalcSubsystemFacilityType)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityManualME)
        Me.tabCalcFacilitySubsystems.Controls.Add(Me.lblCalcSubsystemFacilityBonus)
        Me.tabCalcFacilitySubsystems.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilitySubsystems.Name = "tabCalcFacilitySubsystems"
        Me.tabCalcFacilitySubsystems.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilitySubsystems.TabIndex = 8
        Me.tabCalcFacilitySubsystems.Text = "Subsystems"
        Me.tabCalcFacilitySubsystems.UseVisualStyleBackColor = True
        '
        'txtCalcSubsystemFacilityManualTax
        '
        Me.txtCalcSubsystemFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcSubsystemFacilityManualTax.MaxLength = 5
        Me.txtCalcSubsystemFacilityManualTax.Name = "txtCalcSubsystemFacilityManualTax"
        Me.txtCalcSubsystemFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcSubsystemFacilityManualTax.TabIndex = 21
        Me.txtCalcSubsystemFacilityManualTax.Text = "0%"
        Me.txtCalcSubsystemFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcSubsystemFacilityManualTax.Visible = False
        '
        'lblCalcSubsystemFacilityManualTax
        '
        Me.lblCalcSubsystemFacilityManualTax.AutoSize = True
        Me.lblCalcSubsystemFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcSubsystemFacilityManualTax.Name = "lblCalcSubsystemFacilityManualTax"
        Me.lblCalcSubsystemFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcSubsystemFacilityManualTax.TabIndex = 20
        Me.lblCalcSubsystemFacilityManualTax.Text = "Tax:"
        Me.lblCalcSubsystemFacilityManualTax.Visible = False
        '
        'lblCalcSubsystemFacilityDefault
        '
        Me.lblCalcSubsystemFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcSubsystemFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcSubsystemFacilityDefault.Name = "lblCalcSubsystemFacilityDefault"
        Me.lblCalcSubsystemFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcSubsystemFacilityDefault.TabIndex = 2
        Me.lblCalcSubsystemFacilityDefault.Text = "Default Facility"
        Me.lblCalcSubsystemFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcSubsystemFacilitySave
        '
        Me.btnCalcSubsystemFacilitySave.Enabled = False
        Me.btnCalcSubsystemFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcSubsystemFacilitySave.Name = "btnCalcSubsystemFacilitySave"
        Me.btnCalcSubsystemFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcSubsystemFacilitySave.TabIndex = 22
        Me.btnCalcSubsystemFacilitySave.Text = "Save"
        Me.btnCalcSubsystemFacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcSubsystemFacilityTaxRate
        '
        Me.lblCalcSubsystemFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcSubsystemFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcSubsystemFacilityTaxRate.Name = "lblCalcSubsystemFacilityTaxRate"
        Me.lblCalcSubsystemFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcSubsystemFacilityTaxRate.TabIndex = 13
        Me.lblCalcSubsystemFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcSubsystemFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcSubsystemFacilityTaxRate.Visible = False
        '
        'txtCalcSubsystemFacilityManualTE
        '
        Me.txtCalcSubsystemFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcSubsystemFacilityManualTE.MaxLength = 5
        Me.txtCalcSubsystemFacilityManualTE.Name = "txtCalcSubsystemFacilityManualTE"
        Me.txtCalcSubsystemFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcSubsystemFacilityManualTE.TabIndex = 12
        Me.txtCalcSubsystemFacilityManualTE.Text = "0%"
        Me.txtCalcSubsystemFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcSubsystemFacilityManualTE.Visible = False
        '
        'txtCalcSubsystemFacilityManualME
        '
        Me.txtCalcSubsystemFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcSubsystemFacilityManualME.MaxLength = 5
        Me.txtCalcSubsystemFacilityManualME.Name = "txtCalcSubsystemFacilityManualME"
        Me.txtCalcSubsystemFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcSubsystemFacilityManualME.TabIndex = 10
        Me.txtCalcSubsystemFacilityManualME.Text = "0%"
        Me.txtCalcSubsystemFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcSubsystemFacilityManualME.Visible = False
        '
        'cmbCalcSubsystemFacilityorArray
        '
        Me.cmbCalcSubsystemFacilityorArray.FormattingEnabled = True
        Me.cmbCalcSubsystemFacilityorArray.ItemHeight = 13
        Me.cmbCalcSubsystemFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcSubsystemFacilityorArray.Name = "cmbCalcSubsystemFacilityorArray"
        Me.cmbCalcSubsystemFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcSubsystemFacilityorArray.TabIndex = 7
        Me.cmbCalcSubsystemFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcSubsystemFacilitySystem
        '
        Me.cmbCalcSubsystemFacilitySystem.FormattingEnabled = True
        Me.cmbCalcSubsystemFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcSubsystemFacilitySystem.Name = "cmbCalcSubsystemFacilitySystem"
        Me.cmbCalcSubsystemFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcSubsystemFacilitySystem.TabIndex = 6
        Me.cmbCalcSubsystemFacilitySystem.Text = "Select System"
        '
        'cmbCalcSubsystemFacilityRegion
        '
        Me.cmbCalcSubsystemFacilityRegion.FormattingEnabled = True
        Me.cmbCalcSubsystemFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcSubsystemFacilityRegion.Name = "cmbCalcSubsystemFacilityRegion"
        Me.cmbCalcSubsystemFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcSubsystemFacilityRegion.TabIndex = 5
        Me.cmbCalcSubsystemFacilityRegion.Text = "Select Region"
        '
        'lblCalcSubsystemFacilityManualTE
        '
        Me.lblCalcSubsystemFacilityManualTE.AutoSize = True
        Me.lblCalcSubsystemFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcSubsystemFacilityManualTE.Name = "lblCalcSubsystemFacilityManualTE"
        Me.lblCalcSubsystemFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcSubsystemFacilityManualTE.TabIndex = 11
        Me.lblCalcSubsystemFacilityManualTE.Text = "TE:"
        Me.lblCalcSubsystemFacilityManualTE.Visible = False
        '
        'lblCalcSubsystemFacilityLocation
        '
        Me.lblCalcSubsystemFacilityLocation.AutoSize = True
        Me.lblCalcSubsystemFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcSubsystemFacilityLocation.Name = "lblCalcSubsystemFacilityLocation"
        Me.lblCalcSubsystemFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcSubsystemFacilityLocation.TabIndex = 3
        Me.lblCalcSubsystemFacilityLocation.Text = "Location:"
        '
        'lblCalcSubsystemFacilityType
        '
        Me.lblCalcSubsystemFacilityType.AutoSize = True
        Me.lblCalcSubsystemFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcSubsystemFacilityType.Name = "lblCalcSubsystemFacilityType"
        Me.lblCalcSubsystemFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcSubsystemFacilityType.TabIndex = 0
        Me.lblCalcSubsystemFacilityType.Text = "Facility Type:"
        '
        'chkCalcSubsystemFacilityIncludeUsage
        '
        Me.chkCalcSubsystemFacilityIncludeUsage.AutoSize = True
        Me.chkCalcSubsystemFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcSubsystemFacilityIncludeUsage.Name = "chkCalcSubsystemFacilityIncludeUsage"
        Me.chkCalcSubsystemFacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcSubsystemFacilityIncludeUsage.TabIndex = 4
        Me.chkCalcSubsystemFacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcSubsystemFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'cmbCalcSubsystemFacilityType
        '
        Me.cmbCalcSubsystemFacilityType.Enabled = False
        Me.cmbCalcSubsystemFacilityType.FormattingEnabled = True
        Me.cmbCalcSubsystemFacilityType.ItemHeight = 13
        Me.cmbCalcSubsystemFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcSubsystemFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcSubsystemFacilityType.Name = "cmbCalcSubsystemFacilityType"
        Me.cmbCalcSubsystemFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcSubsystemFacilityType.TabIndex = 1
        Me.cmbCalcSubsystemFacilityType.Text = "Type"
        '
        'lblCalcSubsystemFacilityManualME
        '
        Me.lblCalcSubsystemFacilityManualME.AutoSize = True
        Me.lblCalcSubsystemFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcSubsystemFacilityManualME.Name = "lblCalcSubsystemFacilityManualME"
        Me.lblCalcSubsystemFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcSubsystemFacilityManualME.TabIndex = 9
        Me.lblCalcSubsystemFacilityManualME.Text = "ME:"
        Me.lblCalcSubsystemFacilityManualME.Visible = False
        '
        'lblCalcSubsystemFacilityBonus
        '
        Me.lblCalcSubsystemFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcSubsystemFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcSubsystemFacilityBonus.Name = "lblCalcSubsystemFacilityBonus"
        Me.lblCalcSubsystemFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcSubsystemFacilityBonus.TabIndex = 8
        Me.lblCalcSubsystemFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcSubsystemFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcSubsystemFacilityBonus.Visible = False
        '
        'tabCalcFacilityBoosters
        '
        Me.tabCalcFacilityBoosters.Controls.Add(Me.txtCalcBoosterFacilityManualTax)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityManualTax)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityDefault)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.btnCalcBoosterFacilitySave)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityTaxRate)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.txtCalcBoosterFacilityManualTE)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.txtCalcBoosterFacilityManualME)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.cmbCalcBoosterFacilityorArray)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.cmbCalcBoosterFacilitySystem)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.cmbCalcBoosterFacilityRegion)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityManualTE)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityLocation)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityType)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.chkCalcBoosterFacilityIncludeUsage)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.cmbCalcBoosterFacilityType)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityManualME)
        Me.tabCalcFacilityBoosters.Controls.Add(Me.lblCalcBoosterFacilityBonus)
        Me.tabCalcFacilityBoosters.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityBoosters.Name = "tabCalcFacilityBoosters"
        Me.tabCalcFacilityBoosters.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityBoosters.TabIndex = 7
        Me.tabCalcFacilityBoosters.Text = "Boosters"
        Me.tabCalcFacilityBoosters.UseVisualStyleBackColor = True
        '
        'txtCalcBoosterFacilityManualTax
        '
        Me.txtCalcBoosterFacilityManualTax.Location = New System.Drawing.Point(198, 89)
        Me.txtCalcBoosterFacilityManualTax.MaxLength = 5
        Me.txtCalcBoosterFacilityManualTax.Name = "txtCalcBoosterFacilityManualTax"
        Me.txtCalcBoosterFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcBoosterFacilityManualTax.TabIndex = 21
        Me.txtCalcBoosterFacilityManualTax.Text = "0%"
        Me.txtCalcBoosterFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcBoosterFacilityManualTax.Visible = False
        '
        'lblCalcBoosterFacilityManualTax
        '
        Me.lblCalcBoosterFacilityManualTax.AutoSize = True
        Me.lblCalcBoosterFacilityManualTax.Location = New System.Drawing.Point(172, 92)
        Me.lblCalcBoosterFacilityManualTax.Name = "lblCalcBoosterFacilityManualTax"
        Me.lblCalcBoosterFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcBoosterFacilityManualTax.TabIndex = 20
        Me.lblCalcBoosterFacilityManualTax.Text = "Tax:"
        Me.lblCalcBoosterFacilityManualTax.Visible = False
        '
        'lblCalcBoosterFacilityDefault
        '
        Me.lblCalcBoosterFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcBoosterFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcBoosterFacilityDefault.Name = "lblCalcBoosterFacilityDefault"
        Me.lblCalcBoosterFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcBoosterFacilityDefault.TabIndex = 2
        Me.lblCalcBoosterFacilityDefault.Text = "Default Facility"
        Me.lblCalcBoosterFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcBoosterFacilitySave
        '
        Me.btnCalcBoosterFacilitySave.Enabled = False
        Me.btnCalcBoosterFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcBoosterFacilitySave.Name = "btnCalcBoosterFacilitySave"
        Me.btnCalcBoosterFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcBoosterFacilitySave.TabIndex = 22
        Me.btnCalcBoosterFacilitySave.Text = "Save"
        Me.btnCalcBoosterFacilitySave.UseVisualStyleBackColor = True
        '
        'lblCalcBoosterFacilityTaxRate
        '
        Me.lblCalcBoosterFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcBoosterFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcBoosterFacilityTaxRate.Name = "lblCalcBoosterFacilityTaxRate"
        Me.lblCalcBoosterFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcBoosterFacilityTaxRate.TabIndex = 13
        Me.lblCalcBoosterFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcBoosterFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcBoosterFacilityTaxRate.Visible = False
        '
        'txtCalcBoosterFacilityManualTE
        '
        Me.txtCalcBoosterFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcBoosterFacilityManualTE.MaxLength = 5
        Me.txtCalcBoosterFacilityManualTE.Name = "txtCalcBoosterFacilityManualTE"
        Me.txtCalcBoosterFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcBoosterFacilityManualTE.TabIndex = 12
        Me.txtCalcBoosterFacilityManualTE.Text = "0%"
        Me.txtCalcBoosterFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcBoosterFacilityManualTE.Visible = False
        '
        'txtCalcBoosterFacilityManualME
        '
        Me.txtCalcBoosterFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcBoosterFacilityManualME.MaxLength = 5
        Me.txtCalcBoosterFacilityManualME.Name = "txtCalcBoosterFacilityManualME"
        Me.txtCalcBoosterFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcBoosterFacilityManualME.TabIndex = 10
        Me.txtCalcBoosterFacilityManualME.Text = "0%"
        Me.txtCalcBoosterFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcBoosterFacilityManualME.Visible = False
        '
        'cmbCalcBoosterFacilityorArray
        '
        Me.cmbCalcBoosterFacilityorArray.FormattingEnabled = True
        Me.cmbCalcBoosterFacilityorArray.ItemHeight = 13
        Me.cmbCalcBoosterFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcBoosterFacilityorArray.Name = "cmbCalcBoosterFacilityorArray"
        Me.cmbCalcBoosterFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcBoosterFacilityorArray.TabIndex = 7
        Me.cmbCalcBoosterFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcBoosterFacilitySystem
        '
        Me.cmbCalcBoosterFacilitySystem.FormattingEnabled = True
        Me.cmbCalcBoosterFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcBoosterFacilitySystem.Name = "cmbCalcBoosterFacilitySystem"
        Me.cmbCalcBoosterFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcBoosterFacilitySystem.TabIndex = 6
        Me.cmbCalcBoosterFacilitySystem.Text = "Select System"
        '
        'cmbCalcBoosterFacilityRegion
        '
        Me.cmbCalcBoosterFacilityRegion.FormattingEnabled = True
        Me.cmbCalcBoosterFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcBoosterFacilityRegion.Name = "cmbCalcBoosterFacilityRegion"
        Me.cmbCalcBoosterFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcBoosterFacilityRegion.TabIndex = 5
        Me.cmbCalcBoosterFacilityRegion.Text = "Select Region"
        '
        'lblCalcBoosterFacilityManualTE
        '
        Me.lblCalcBoosterFacilityManualTE.AutoSize = True
        Me.lblCalcBoosterFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcBoosterFacilityManualTE.Name = "lblCalcBoosterFacilityManualTE"
        Me.lblCalcBoosterFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcBoosterFacilityManualTE.TabIndex = 11
        Me.lblCalcBoosterFacilityManualTE.Text = "TE:"
        Me.lblCalcBoosterFacilityManualTE.Visible = False
        '
        'lblCalcBoosterFacilityLocation
        '
        Me.lblCalcBoosterFacilityLocation.AutoSize = True
        Me.lblCalcBoosterFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcBoosterFacilityLocation.Name = "lblCalcBoosterFacilityLocation"
        Me.lblCalcBoosterFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcBoosterFacilityLocation.TabIndex = 3
        Me.lblCalcBoosterFacilityLocation.Text = "Location:"
        '
        'lblCalcBoosterFacilityType
        '
        Me.lblCalcBoosterFacilityType.AutoSize = True
        Me.lblCalcBoosterFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcBoosterFacilityType.Name = "lblCalcBoosterFacilityType"
        Me.lblCalcBoosterFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcBoosterFacilityType.TabIndex = 0
        Me.lblCalcBoosterFacilityType.Text = "Facility Type:"
        '
        'chkCalcBoosterFacilityIncludeUsage
        '
        Me.chkCalcBoosterFacilityIncludeUsage.AutoSize = True
        Me.chkCalcBoosterFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcBoosterFacilityIncludeUsage.Name = "chkCalcBoosterFacilityIncludeUsage"
        Me.chkCalcBoosterFacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcBoosterFacilityIncludeUsage.TabIndex = 4
        Me.chkCalcBoosterFacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcBoosterFacilityIncludeUsage.UseVisualStyleBackColor = True
        '
        'cmbCalcBoosterFacilityType
        '
        Me.cmbCalcBoosterFacilityType.Enabled = False
        Me.cmbCalcBoosterFacilityType.FormattingEnabled = True
        Me.cmbCalcBoosterFacilityType.ItemHeight = 13
        Me.cmbCalcBoosterFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbCalcBoosterFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcBoosterFacilityType.Name = "cmbCalcBoosterFacilityType"
        Me.cmbCalcBoosterFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcBoosterFacilityType.TabIndex = 1
        Me.cmbCalcBoosterFacilityType.Text = "Type"
        '
        'lblCalcBoosterFacilityManualME
        '
        Me.lblCalcBoosterFacilityManualME.AutoSize = True
        Me.lblCalcBoosterFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcBoosterFacilityManualME.Name = "lblCalcBoosterFacilityManualME"
        Me.lblCalcBoosterFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcBoosterFacilityManualME.TabIndex = 9
        Me.lblCalcBoosterFacilityManualME.Text = "ME:"
        Me.lblCalcBoosterFacilityManualME.Visible = False
        '
        'lblCalcBoosterFacilityBonus
        '
        Me.lblCalcBoosterFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcBoosterFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcBoosterFacilityBonus.Name = "lblCalcBoosterFacilityBonus"
        Me.lblCalcBoosterFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcBoosterFacilityBonus.TabIndex = 8
        Me.lblCalcBoosterFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcBoosterFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcBoosterFacilityBonus.Visible = False
        '
        'tabCalcFacilityNoPOS
        '
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.txtCalcNoPOSFacilityManualTax)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityManualTax)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityDefault)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.btnCalcNoPOSFacilitySave)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityTaxRate)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.chkCalcNoPOSFacilityIncludeUsage)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.txtCalcNoPOSFacilityManualTE)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.txtCalcNoPOSFacilityManualME)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.cmbCalcNoPOSFacilityorArray)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.cmbCalcNoPOSFacilitySystem)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.cmbCalcNoPOSFacilityRegion)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityManualTE)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityLocation)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityType)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.cmbCalcNoPOSFacilityType)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityManualME)
        Me.tabCalcFacilityNoPOS.Controls.Add(Me.lblCalcNoPOSFacilityBonus)
        Me.tabCalcFacilityNoPOS.Location = New System.Drawing.Point(4, 44)
        Me.tabCalcFacilityNoPOS.Name = "tabCalcFacilityNoPOS"
        Me.tabCalcFacilityNoPOS.Size = New System.Drawing.Size(293, 113)
        Me.tabCalcFacilityNoPOS.TabIndex = 4
        Me.tabCalcFacilityNoPOS.Text = "No POS"
        Me.tabCalcFacilityNoPOS.UseVisualStyleBackColor = True
        '
        'txtCalcNoPOSFacilityManualTax
        '
        Me.txtCalcNoPOSFacilityManualTax.Location = New System.Drawing.Point(196, 89)
        Me.txtCalcNoPOSFacilityManualTax.MaxLength = 5
        Me.txtCalcNoPOSFacilityManualTax.Name = "txtCalcNoPOSFacilityManualTax"
        Me.txtCalcNoPOSFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcNoPOSFacilityManualTax.TabIndex = 21
        Me.txtCalcNoPOSFacilityManualTax.Text = "0%"
        Me.txtCalcNoPOSFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcNoPOSFacilityManualTax.Visible = False
        '
        'lblCalcNoPOSFacilityManualTax
        '
        Me.lblCalcNoPOSFacilityManualTax.AutoSize = True
        Me.lblCalcNoPOSFacilityManualTax.Location = New System.Drawing.Point(170, 92)
        Me.lblCalcNoPOSFacilityManualTax.Name = "lblCalcNoPOSFacilityManualTax"
        Me.lblCalcNoPOSFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblCalcNoPOSFacilityManualTax.TabIndex = 20
        Me.lblCalcNoPOSFacilityManualTax.Text = "Tax:"
        Me.lblCalcNoPOSFacilityManualTax.Visible = False
        '
        'lblCalcNoPOSFacilityDefault
        '
        Me.lblCalcNoPOSFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcNoPOSFacilityDefault.Location = New System.Drawing.Point(212, 3)
        Me.lblCalcNoPOSFacilityDefault.Name = "lblCalcNoPOSFacilityDefault"
        Me.lblCalcNoPOSFacilityDefault.Size = New System.Drawing.Size(79, 20)
        Me.lblCalcNoPOSFacilityDefault.TabIndex = 2
        Me.lblCalcNoPOSFacilityDefault.Text = "Default Facility"
        Me.lblCalcNoPOSFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcNoPOSFacilitySave
        '
        Me.btnCalcNoPOSFacilitySave.Enabled = False
        Me.btnCalcNoPOSFacilitySave.Location = New System.Drawing.Point(234, 88)
        Me.btnCalcNoPOSFacilitySave.Name = "btnCalcNoPOSFacilitySave"
        Me.btnCalcNoPOSFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcNoPOSFacilitySave.TabIndex = 22
        Me.btnCalcNoPOSFacilitySave.Text = "Save"
        Me.btnCalcNoPOSFacilitySave.UseVisualStyleBackColor = true
        '
        'lblCalcNoPOSFacilityTaxRate
        '
        Me.lblCalcNoPOSFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcNoPOSFacilityTaxRate.Location = New System.Drawing.Point(169, 89)
        Me.lblCalcNoPOSFacilityTaxRate.Name = "lblCalcNoPOSFacilityTaxRate"
        Me.lblCalcNoPOSFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblCalcNoPOSFacilityTaxRate.TabIndex = 13
        Me.lblCalcNoPOSFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblCalcNoPOSFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcNoPOSFacilityTaxRate.Visible = false
        '
        'chkCalcNoPOSFacilityIncludeUsage
        '
        Me.chkCalcNoPOSFacilityIncludeUsage.AutoSize = true
        Me.chkCalcNoPOSFacilityIncludeUsage.Location = New System.Drawing.Point(139, 25)
        Me.chkCalcNoPOSFacilityIncludeUsage.Name = "chkCalcNoPOSFacilityIncludeUsage"
        Me.chkCalcNoPOSFacilityIncludeUsage.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcNoPOSFacilityIncludeUsage.TabIndex = 4
        Me.chkCalcNoPOSFacilityIncludeUsage.Text = "Include Usage"
        Me.chkCalcNoPOSFacilityIncludeUsage.UseVisualStyleBackColor = true
        '
        'txtCalcNoPOSFacilityManualTE
        '
        Me.txtCalcNoPOSFacilityManualTE.Location = New System.Drawing.Point(100, 89)
        Me.txtCalcNoPOSFacilityManualTE.MaxLength = 5
        Me.txtCalcNoPOSFacilityManualTE.Name = "txtCalcNoPOSFacilityManualTE"
        Me.txtCalcNoPOSFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcNoPOSFacilityManualTE.TabIndex = 12
        Me.txtCalcNoPOSFacilityManualTE.Text = "0%"
        Me.txtCalcNoPOSFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcNoPOSFacilityManualTE.Visible = false
        '
        'txtCalcNoPOSFacilityManualME
        '
        Me.txtCalcNoPOSFacilityManualME.Location = New System.Drawing.Point(39, 89)
        Me.txtCalcNoPOSFacilityManualME.MaxLength = 5
        Me.txtCalcNoPOSFacilityManualME.Name = "txtCalcNoPOSFacilityManualME"
        Me.txtCalcNoPOSFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtCalcNoPOSFacilityManualME.TabIndex = 10
        Me.txtCalcNoPOSFacilityManualME.Text = "0%"
        Me.txtCalcNoPOSFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCalcNoPOSFacilityManualME.Visible = false
        '
        'cmbCalcNoPOSFacilityorArray
        '
        Me.cmbCalcNoPOSFacilityorArray.FormattingEnabled = true
        Me.cmbCalcNoPOSFacilityorArray.ItemHeight = 13
        Me.cmbCalcNoPOSFacilityorArray.Location = New System.Drawing.Point(5, 65)
        Me.cmbCalcNoPOSFacilityorArray.Name = "cmbCalcNoPOSFacilityorArray"
        Me.cmbCalcNoPOSFacilityorArray.Size = New System.Drawing.Size(285, 21)
        Me.cmbCalcNoPOSFacilityorArray.TabIndex = 7
        Me.cmbCalcNoPOSFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbCalcNoPOSFacilitySystem
        '
        Me.cmbCalcNoPOSFacilitySystem.FormattingEnabled = true
        Me.cmbCalcNoPOSFacilitySystem.Location = New System.Drawing.Point(139, 42)
        Me.cmbCalcNoPOSFacilitySystem.Name = "cmbCalcNoPOSFacilitySystem"
        Me.cmbCalcNoPOSFacilitySystem.Size = New System.Drawing.Size(151, 21)
        Me.cmbCalcNoPOSFacilitySystem.TabIndex = 6
        Me.cmbCalcNoPOSFacilitySystem.Text = "Select System"
        '
        'cmbCalcNoPOSFacilityRegion
        '
        Me.cmbCalcNoPOSFacilityRegion.FormattingEnabled = true
        Me.cmbCalcNoPOSFacilityRegion.Location = New System.Drawing.Point(5, 42)
        Me.cmbCalcNoPOSFacilityRegion.Name = "cmbCalcNoPOSFacilityRegion"
        Me.cmbCalcNoPOSFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbCalcNoPOSFacilityRegion.TabIndex = 5
        Me.cmbCalcNoPOSFacilityRegion.Text = "Select Region"
        '
        'lblCalcNoPOSFacilityManualTE
        '
        Me.lblCalcNoPOSFacilityManualTE.AutoSize = true
        Me.lblCalcNoPOSFacilityManualTE.Location = New System.Drawing.Point(77, 92)
        Me.lblCalcNoPOSFacilityManualTE.Name = "lblCalcNoPOSFacilityManualTE"
        Me.lblCalcNoPOSFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblCalcNoPOSFacilityManualTE.TabIndex = 11
        Me.lblCalcNoPOSFacilityManualTE.Text = "TE:"
        Me.lblCalcNoPOSFacilityManualTE.Visible = false
        '
        'lblCalcNoPOSFacilityLocation
        '
        Me.lblCalcNoPOSFacilityLocation.AutoSize = true
        Me.lblCalcNoPOSFacilityLocation.Location = New System.Drawing.Point(3, 27)
        Me.lblCalcNoPOSFacilityLocation.Name = "lblCalcNoPOSFacilityLocation"
        Me.lblCalcNoPOSFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblCalcNoPOSFacilityLocation.TabIndex = 3
        Me.lblCalcNoPOSFacilityLocation.Text = "Location:"
        '
        'lblCalcNoPOSFacilityType
        '
        Me.lblCalcNoPOSFacilityType.AutoSize = true
        Me.lblCalcNoPOSFacilityType.Location = New System.Drawing.Point(3, 9)
        Me.lblCalcNoPOSFacilityType.Name = "lblCalcNoPOSFacilityType"
        Me.lblCalcNoPOSFacilityType.Size = New System.Drawing.Size(69, 13)
        Me.lblCalcNoPOSFacilityType.TabIndex = 0
        Me.lblCalcNoPOSFacilityType.Text = "Facility Type:"
        '
        'cmbCalcNoPOSFacilityType
        '
        Me.cmbCalcNoPOSFacilityType.Enabled = false
        Me.cmbCalcNoPOSFacilityType.FormattingEnabled = true
        Me.cmbCalcNoPOSFacilityType.ItemHeight = 13
        Me.cmbCalcNoPOSFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost"})
        Me.cmbCalcNoPOSFacilityType.Location = New System.Drawing.Point(73, 6)
        Me.cmbCalcNoPOSFacilityType.Name = "cmbCalcNoPOSFacilityType"
        Me.cmbCalcNoPOSFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbCalcNoPOSFacilityType.TabIndex = 1
        Me.cmbCalcNoPOSFacilityType.Text = "Type"
        '
        'lblCalcNoPOSFacilityManualME
        '
        Me.lblCalcNoPOSFacilityManualME.AutoSize = true
        Me.lblCalcNoPOSFacilityManualME.Location = New System.Drawing.Point(14, 92)
        Me.lblCalcNoPOSFacilityManualME.Name = "lblCalcNoPOSFacilityManualME"
        Me.lblCalcNoPOSFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblCalcNoPOSFacilityManualME.TabIndex = 9
        Me.lblCalcNoPOSFacilityManualME.Text = "ME:"
        Me.lblCalcNoPOSFacilityManualME.Visible = false
        '
        'lblCalcNoPOSFacilityBonus
        '
        Me.lblCalcNoPOSFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcNoPOSFacilityBonus.Location = New System.Drawing.Point(6, 89)
        Me.lblCalcNoPOSFacilityBonus.Name = "lblCalcNoPOSFacilityBonus"
        Me.lblCalcNoPOSFacilityBonus.Size = New System.Drawing.Size(159, 20)
        Me.lblCalcNoPOSFacilityBonus.TabIndex = 8
        Me.lblCalcNoPOSFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblCalcNoPOSFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalcNoPOSFacilityBonus.Visible = false
        '
        'gbCalcFilter
        '
        Me.gbCalcFilter.Controls.Add(Me.cmbCalcBPTypeFilter)
        Me.gbCalcFilter.Location = New System.Drawing.Point(6, 201)
        Me.gbCalcFilter.Name = "gbCalcFilter"
        Me.gbCalcFilter.Size = New System.Drawing.Size(198, 49)
        Me.gbCalcFilter.TabIndex = 8
        Me.gbCalcFilter.TabStop = false
        Me.gbCalcFilter.Text = "Item Type Filter:"
        '
        'cmbCalcBPTypeFilter
        '
        Me.cmbCalcBPTypeFilter.FormattingEnabled = true
        Me.cmbCalcBPTypeFilter.Location = New System.Drawing.Point(9, 18)
        Me.cmbCalcBPTypeFilter.Name = "cmbCalcBPTypeFilter"
        Me.cmbCalcBPTypeFilter.Size = New System.Drawing.Size(183, 21)
        Me.cmbCalcBPTypeFilter.TabIndex = 0
        Me.cmbCalcBPTypeFilter.Text = "All Types"
        '
        'gbCalcBPTech
        '
        Me.gbCalcBPTech.Controls.Add(Me.chkCalcPirateFaction)
        Me.gbCalcBPTech.Controls.Add(Me.chkCalcStoryline)
        Me.gbCalcBPTech.Controls.Add(Me.chkCalcNavyFaction)
        Me.gbCalcBPTech.Controls.Add(Me.chkCalcT3)
        Me.gbCalcBPTech.Controls.Add(Me.chkCalcT2)
        Me.gbCalcBPTech.Controls.Add(Me.chkCalcT1)
        Me.gbCalcBPTech.Location = New System.Drawing.Point(209, 15)
        Me.gbCalcBPTech.Name = "gbCalcBPTech"
        Me.gbCalcBPTech.Size = New System.Drawing.Size(142, 65)
        Me.gbCalcBPTech.TabIndex = 2
        Me.gbCalcBPTech.TabStop = false
        Me.gbCalcBPTech.Text = "Tech"
        '
        'chkCalcPirateFaction
        '
        Me.chkCalcPirateFaction.AutoSize = true
        Me.chkCalcPirateFaction.Location = New System.Drawing.Point(76, 45)
        Me.chkCalcPirateFaction.Name = "chkCalcPirateFaction"
        Me.chkCalcPirateFaction.Size = New System.Drawing.Size(53, 17)
        Me.chkCalcPirateFaction.TabIndex = 5
        Me.chkCalcPirateFaction.Text = "Pirate"
        Me.chkCalcPirateFaction.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkCalcPirateFaction.UseVisualStyleBackColor = true
        '
        'chkCalcStoryline
        '
        Me.chkCalcStoryline.AutoSize = true
        Me.chkCalcStoryline.Location = New System.Drawing.Point(76, 13)
        Me.chkCalcStoryline.Name = "chkCalcStoryline"
        Me.chkCalcStoryline.Size = New System.Drawing.Size(66, 17)
        Me.chkCalcStoryline.TabIndex = 3
        Me.chkCalcStoryline.Text = "Storyline"
        Me.chkCalcStoryline.UseVisualStyleBackColor = true
        '
        'chkCalcNavyFaction
        '
        Me.chkCalcNavyFaction.AutoSize = true
        Me.chkCalcNavyFaction.Location = New System.Drawing.Point(76, 29)
        Me.chkCalcNavyFaction.Name = "chkCalcNavyFaction"
        Me.chkCalcNavyFaction.Size = New System.Drawing.Size(51, 17)
        Me.chkCalcNavyFaction.TabIndex = 4
        Me.chkCalcNavyFaction.Text = "Navy"
        Me.chkCalcNavyFaction.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkCalcNavyFaction.UseVisualStyleBackColor = true
        '
        'chkCalcT3
        '
        Me.chkCalcT3.AutoSize = true
        Me.chkCalcT3.Location = New System.Drawing.Point(14, 46)
        Me.chkCalcT3.Name = "chkCalcT3"
        Me.chkCalcT3.Size = New System.Drawing.Size(60, 17)
        Me.chkCalcT3.TabIndex = 2
        Me.chkCalcT3.Text = "Tech 3"
        Me.chkCalcT3.UseVisualStyleBackColor = true
        '
        'chkCalcT2
        '
        Me.chkCalcT2.AutoSize = true
        Me.chkCalcT2.Location = New System.Drawing.Point(14, 29)
        Me.chkCalcT2.Name = "chkCalcT2"
        Me.chkCalcT2.Size = New System.Drawing.Size(60, 17)
        Me.chkCalcT2.TabIndex = 1
        Me.chkCalcT2.Text = "Tech 2"
        Me.chkCalcT2.UseVisualStyleBackColor = true
        '
        'chkCalcT1
        '
        Me.chkCalcT1.AutoSize = true
        Me.chkCalcT1.Location = New System.Drawing.Point(14, 14)
        Me.chkCalcT1.Name = "chkCalcT1"
        Me.chkCalcT1.Size = New System.Drawing.Size(60, 17)
        Me.chkCalcT1.TabIndex = 0
        Me.chkCalcT1.Text = "Tech 1"
        Me.chkCalcT1.UseVisualStyleBackColor = true
        '
        'gbCalcType
        '
        Me.gbCalcType.Controls.Add(Me.rbtnCalcSortSVRIPH)
        Me.gbCalcType.Controls.Add(Me.rbtnCalcSortSVR)
        Me.gbCalcType.Controls.Add(Me.rbtnCalcShowProfitPercent)
        Me.gbCalcType.Controls.Add(Me.rbtnCalcProfit)
        Me.gbCalcType.Controls.Add(Me.rbtnCalcIPH)
        Me.gbCalcType.Location = New System.Drawing.Point(1019, 15)
        Me.gbCalcType.Name = "gbCalcType"
        Me.gbCalcType.Size = New System.Drawing.Size(96, 110)
        Me.gbCalcType.TabIndex = 19
        Me.gbCalcType.TabStop = false
        Me.gbCalcType.Text = "Sort By:"
        '
        'rbtnCalcSortSVRIPH
        '
        Me.rbtnCalcSortSVRIPH.AutoSize = true
        Me.rbtnCalcSortSVRIPH.Location = New System.Drawing.Point(10, 86)
        Me.rbtnCalcSortSVRIPH.Name = "rbtnCalcSortSVRIPH"
        Me.rbtnCalcSortSVRIPH.Size = New System.Drawing.Size(75, 17)
        Me.rbtnCalcSortSVRIPH.TabIndex = 4
        Me.rbtnCalcSortSVRIPH.Text = "SVR * IPH"
        Me.rbtnCalcSortSVRIPH.UseVisualStyleBackColor = true
        '
        'rbtnCalcSortSVR
        '
        Me.rbtnCalcSortSVR.AutoSize = true
        Me.rbtnCalcSortSVR.Location = New System.Drawing.Point(10, 68)
        Me.rbtnCalcSortSVR.Name = "rbtnCalcSortSVR"
        Me.rbtnCalcSortSVR.Size = New System.Drawing.Size(47, 17)
        Me.rbtnCalcSortSVR.TabIndex = 3
        Me.rbtnCalcSortSVR.Text = "SVR"
        Me.rbtnCalcSortSVR.UseVisualStyleBackColor = true
        '
        'rbtnCalcShowProfitPercent
        '
        Me.rbtnCalcShowProfitPercent.AutoSize = true
        Me.rbtnCalcShowProfitPercent.Location = New System.Drawing.Point(10, 50)
        Me.rbtnCalcShowProfitPercent.Name = "rbtnCalcShowProfitPercent"
        Me.rbtnCalcShowProfitPercent.Size = New System.Drawing.Size(60, 17)
        Me.rbtnCalcShowProfitPercent.TabIndex = 2
        Me.rbtnCalcShowProfitPercent.Text = "Profit %"
        Me.rbtnCalcShowProfitPercent.UseVisualStyleBackColor = true
        '
        'rbtnCalcProfit
        '
        Me.rbtnCalcProfit.AutoSize = true
        Me.rbtnCalcProfit.Location = New System.Drawing.Point(10, 32)
        Me.rbtnCalcProfit.Name = "rbtnCalcProfit"
        Me.rbtnCalcProfit.Size = New System.Drawing.Size(49, 17)
        Me.rbtnCalcProfit.TabIndex = 1
        Me.rbtnCalcProfit.Text = "Profit"
        Me.rbtnCalcProfit.UseVisualStyleBackColor = true
        '
        'rbtnCalcIPH
        '
        Me.rbtnCalcIPH.AutoSize = true
        Me.rbtnCalcIPH.Location = New System.Drawing.Point(10, 14)
        Me.rbtnCalcIPH.Name = "rbtnCalcIPH"
        Me.rbtnCalcIPH.Size = New System.Drawing.Size(43, 17)
        Me.rbtnCalcIPH.TabIndex = 0
        Me.rbtnCalcIPH.Text = "IPH"
        Me.rbtnCalcIPH.UseVisualStyleBackColor = true
        '
        'gbCalcIncludeOwned
        '
        Me.gbCalcIncludeOwned.Controls.Add(Me.chkCalcIncludeT3Owned)
        Me.gbCalcIncludeOwned.Controls.Add(Me.chkCalcIncludeT2Owned)
        Me.gbCalcIncludeOwned.Location = New System.Drawing.Point(110, 15)
        Me.gbCalcIncludeOwned.Name = "gbCalcIncludeOwned"
        Me.gbCalcIncludeOwned.Size = New System.Drawing.Size(94, 65)
        Me.gbCalcIncludeOwned.TabIndex = 1
        Me.gbCalcIncludeOwned.TabStop = false
        Me.gbCalcIncludeOwned.Text = "Include Owned"
        '
        'chkCalcIncludeT3Owned
        '
        Me.chkCalcIncludeT3Owned.AutoSize = true
        Me.chkCalcIncludeT3Owned.Location = New System.Drawing.Point(8, 44)
        Me.chkCalcIncludeT3Owned.Name = "chkCalcIncludeT3Owned"
        Me.chkCalcIncludeT3Owned.Size = New System.Drawing.Size(39, 17)
        Me.chkCalcIncludeT3Owned.TabIndex = 1
        Me.chkCalcIncludeT3Owned.Text = "T3"
        Me.chkCalcIncludeT3Owned.UseVisualStyleBackColor = true
        '
        'chkCalcIncludeT2Owned
        '
        Me.chkCalcIncludeT2Owned.AutoSize = true
        Me.chkCalcIncludeT2Owned.Location = New System.Drawing.Point(8, 21)
        Me.chkCalcIncludeT2Owned.Name = "chkCalcIncludeT2Owned"
        Me.chkCalcIncludeT2Owned.Size = New System.Drawing.Size(84, 17)
        Me.chkCalcIncludeT2Owned.TabIndex = 0
        Me.chkCalcIncludeT2Owned.Text = "T2 Invented"
        Me.chkCalcIncludeT2Owned.UseVisualStyleBackColor = true
        '
        'gbCalcAvgPrice
        '
        Me.gbCalcAvgPrice.Controls.Add(Me.chkCalcSVRIncludeNull)
        Me.gbCalcAvgPrice.Controls.Add(Me.lblCalcSVRRegion)
        Me.gbCalcAvgPrice.Controls.Add(Me.lblCalcAvgPrice)
        Me.gbCalcAvgPrice.Controls.Add(Me.cmbCalcSVRRegion)
        Me.gbCalcAvgPrice.Controls.Add(Me.txtCalcSVRThreshold)
        Me.gbCalcAvgPrice.Controls.Add(Me.lblCalcSVRThreshold)
        Me.gbCalcAvgPrice.Controls.Add(Me.cmbCalcAvgPriceDuration)
        Me.gbCalcAvgPrice.Location = New System.Drawing.Point(208, 201)
        Me.gbCalcAvgPrice.Name = "gbCalcAvgPrice"
        Me.gbCalcAvgPrice.Size = New System.Drawing.Size(198, 93)
        Me.gbCalcAvgPrice.TabIndex = 10
        Me.gbCalcAvgPrice.TabStop = false
        Me.gbCalcAvgPrice.Text = "SVR Settings:"
        '
        'chkCalcSVRIncludeNull
        '
        Me.chkCalcSVRIncludeNull.AutoSize = true
        Me.chkCalcSVRIncludeNull.Location = New System.Drawing.Point(9, 65)
        Me.chkCalcSVRIncludeNull.Name = "chkCalcSVRIncludeNull"
        Me.chkCalcSVRIncludeNull.Size = New System.Drawing.Size(170, 17)
        Me.chkCalcSVRIncludeNull.TabIndex = 6
        Me.chkCalcSVRIncludeNull.Text = "Include Items w/o SVR values"
        Me.chkCalcSVRIncludeNull.UseVisualStyleBackColor = true
        '
        'lblCalcSVRRegion
        '
        Me.lblCalcSVRRegion.AutoSize = true
        Me.lblCalcSVRRegion.Location = New System.Drawing.Point(6, 44)
        Me.lblCalcSVRRegion.Name = "lblCalcSVRRegion"
        Me.lblCalcSVRRegion.Size = New System.Drawing.Size(44, 13)
        Me.lblCalcSVRRegion.TabIndex = 4
        Me.lblCalcSVRRegion.Text = "Region:"
        '
        'lblCalcAvgPrice
        '
        Me.lblCalcAvgPrice.Location = New System.Drawing.Point(114, 11)
        Me.lblCalcAvgPrice.Name = "lblCalcAvgPrice"
        Me.lblCalcAvgPrice.Size = New System.Drawing.Size(35, 28)
        Me.lblCalcAvgPrice.TabIndex = 2
        Me.lblCalcAvgPrice.Text = "Avg Days:"
        Me.lblCalcAvgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCalcSVRRegion
        '
        Me.cmbCalcSVRRegion.FormattingEnabled = true
        Me.cmbCalcSVRRegion.Location = New System.Drawing.Point(55, 41)
        Me.cmbCalcSVRRegion.Name = "cmbCalcSVRRegion"
        Me.cmbCalcSVRRegion.Size = New System.Drawing.Size(137, 21)
        Me.cmbCalcSVRRegion.TabIndex = 5
        '
        'txtCalcSVRThreshold
        '
        Me.txtCalcSVRThreshold.Location = New System.Drawing.Point(63, 16)
        Me.txtCalcSVRThreshold.MaxLength = 10
        Me.txtCalcSVRThreshold.Name = "txtCalcSVRThreshold"
        Me.txtCalcSVRThreshold.Size = New System.Drawing.Size(45, 20)
        Me.txtCalcSVRThreshold.TabIndex = 1
        Me.txtCalcSVRThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCalcSVRThreshold
        '
        Me.lblCalcSVRThreshold.AutoSize = true
        Me.lblCalcSVRThreshold.Location = New System.Drawing.Point(6, 19)
        Me.lblCalcSVRThreshold.Name = "lblCalcSVRThreshold"
        Me.lblCalcSVRThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblCalcSVRThreshold.TabIndex = 0
        Me.lblCalcSVRThreshold.Text = "Threshold:"
        '
        'cmbCalcAvgPriceDuration
        '
        Me.cmbCalcAvgPriceDuration.FormattingEnabled = true
        Me.cmbCalcAvgPriceDuration.Items.AddRange(New Object() {"7", "15", "30", "60", "90"})
        Me.cmbCalcAvgPriceDuration.Location = New System.Drawing.Point(151, 15)
        Me.cmbCalcAvgPriceDuration.MaxLength = 2
        Me.cmbCalcAvgPriceDuration.Name = "cmbCalcAvgPriceDuration"
        Me.cmbCalcAvgPriceDuration.Size = New System.Drawing.Size(41, 21)
        Me.cmbCalcAvgPriceDuration.TabIndex = 3
        '
        'btnCalcSaveSettings
        '
        Me.btnCalcSaveSettings.Location = New System.Drawing.Point(1019, 239)
        Me.btnCalcSaveSettings.Name = "btnCalcSaveSettings"
        Me.btnCalcSaveSettings.Size = New System.Drawing.Size(96, 27)
        Me.btnCalcSaveSettings.TabIndex = 24
        Me.btnCalcSaveSettings.Text = "Save Settings"
        Me.btnCalcSaveSettings.UseVisualStyleBackColor = true
        '
        'gbIncludeTaxesFees
        '
        Me.gbIncludeTaxesFees.Controls.Add(Me.chkCalcFees)
        Me.gbIncludeTaxesFees.Controls.Add(Me.chkCalcTaxes)
        Me.gbIncludeTaxesFees.Location = New System.Drawing.Point(850, 181)
        Me.gbIncludeTaxesFees.Name = "gbIncludeTaxesFees"
        Me.gbIncludeTaxesFees.Size = New System.Drawing.Size(165, 39)
        Me.gbIncludeTaxesFees.TabIndex = 17
        Me.gbIncludeTaxesFees.TabStop = false
        Me.gbIncludeTaxesFees.Text = "Include:"
        '
        'chkCalcFees
        '
        Me.chkCalcFees.AutoSize = true
        Me.chkCalcFees.Location = New System.Drawing.Point(86, 16)
        Me.chkCalcFees.Name = "chkCalcFees"
        Me.chkCalcFees.Size = New System.Drawing.Size(49, 17)
        Me.chkCalcFees.TabIndex = 1
        Me.chkCalcFees.Text = "Fees"
        Me.chkCalcFees.UseVisualStyleBackColor = true
        '
        'chkCalcTaxes
        '
        Me.chkCalcTaxes.AutoSize = true
        Me.chkCalcTaxes.Location = New System.Drawing.Point(9, 16)
        Me.chkCalcTaxes.Name = "chkCalcTaxes"
        Me.chkCalcTaxes.Size = New System.Drawing.Size(55, 17)
        Me.chkCalcTaxes.TabIndex = 0
        Me.chkCalcTaxes.Text = "Taxes"
        Me.chkCalcTaxes.UseVisualStyleBackColor = true
        '
        'btnCalcExportList
        '
        Me.btnCalcExportList.Location = New System.Drawing.Point(1019, 267)
        Me.btnCalcExportList.Name = "btnCalcExportList"
        Me.btnCalcExportList.Size = New System.Drawing.Size(96, 27)
        Me.btnCalcExportList.TabIndex = 25
        Me.btnCalcExportList.Text = "Export Table"
        Me.btnCalcExportList.UseVisualStyleBackColor = true
        '
        'btnCalcPreview
        '
        Me.btnCalcPreview.Location = New System.Drawing.Point(1019, 127)
        Me.btnCalcPreview.Name = "btnCalcPreview"
        Me.btnCalcPreview.Size = New System.Drawing.Size(96, 27)
        Me.btnCalcPreview.TabIndex = 20
        Me.btnCalcPreview.Text = "Preview Item List"
        Me.btnCalcPreview.UseVisualStyleBackColor = true
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(1019, 155)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(96, 27)
        Me.btnCalculate.TabIndex = 21
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = true
        '
        'btnCalcReset
        '
        Me.btnCalcReset.Location = New System.Drawing.Point(1019, 183)
        Me.btnCalcReset.Name = "btnCalcReset"
        Me.btnCalcReset.Size = New System.Drawing.Size(96, 27)
        Me.btnCalcReset.TabIndex = 22
        Me.btnCalcReset.Text = "Reset"
        Me.btnCalcReset.UseVisualStyleBackColor = true
        '
        'gbCalcTextFilter
        '
        Me.gbCalcTextFilter.Controls.Add(Me.btnCalcResetTextSearch)
        Me.gbCalcTextFilter.Controls.Add(Me.txtCalcItemFilter)
        Me.gbCalcTextFilter.Location = New System.Drawing.Point(6, 251)
        Me.gbCalcTextFilter.Name = "gbCalcTextFilter"
        Me.gbCalcTextFilter.Size = New System.Drawing.Size(198, 43)
        Me.gbCalcTextFilter.TabIndex = 9
        Me.gbCalcTextFilter.TabStop = false
        Me.gbCalcTextFilter.Text = "Text Item Filter:"
        '
        'btnCalcResetTextSearch
        '
        Me.btnCalcResetTextSearch.Location = New System.Drawing.Point(153, 16)
        Me.btnCalcResetTextSearch.Name = "btnCalcResetTextSearch"
        Me.btnCalcResetTextSearch.Size = New System.Drawing.Size(39, 21)
        Me.btnCalcResetTextSearch.TabIndex = 1
        Me.btnCalcResetTextSearch.Text = "Clear"
        Me.btnCalcResetTextSearch.UseVisualStyleBackColor = true
        '
        'txtCalcItemFilter
        '
        Me.txtCalcItemFilter.Location = New System.Drawing.Point(11, 16)
        Me.txtCalcItemFilter.Name = "txtCalcItemFilter"
        Me.txtCalcItemFilter.Size = New System.Drawing.Size(136, 20)
        Me.txtCalcItemFilter.TabIndex = 0
        '
        'gbCalcBPType
        '
        Me.gbCalcBPType.Controls.Add(Me.chkCalcCelestials)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcMisc)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcSubsystems)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcDeployables)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcStructures)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcStationParts)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcBoosters)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcRigs)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcComponents)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcAmmo)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcDrones)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcModules)
        Me.gbCalcBPType.Controls.Add(Me.chkCalcShips)
        Me.gbCalcBPType.Location = New System.Drawing.Point(355, 15)
        Me.gbCalcBPType.Name = "gbCalcBPType"
        Me.gbCalcBPType.Size = New System.Drawing.Size(186, 132)
        Me.gbCalcBPType.TabIndex = 5
        Me.gbCalcBPType.TabStop = false
        Me.gbCalcBPType.Text = "Blueprint Type:"
        '
        'chkCalcCelestials
        '
        Me.chkCalcCelestials.AutoSize = true
        Me.chkCalcCelestials.Location = New System.Drawing.Point(9, 95)
        Me.chkCalcCelestials.Name = "chkCalcCelestials"
        Me.chkCalcCelestials.Size = New System.Drawing.Size(70, 17)
        Me.chkCalcCelestials.TabIndex = 10
        Me.chkCalcCelestials.Text = "Celestials"
        Me.chkCalcCelestials.UseVisualStyleBackColor = true
        '
        'chkCalcMisc
        '
        Me.chkCalcMisc.AutoSize = true
        Me.chkCalcMisc.Location = New System.Drawing.Point(9, 111)
        Me.chkCalcMisc.Name = "chkCalcMisc"
        Me.chkCalcMisc.Size = New System.Drawing.Size(51, 17)
        Me.chkCalcMisc.TabIndex = 12
        Me.chkCalcMisc.Text = "Misc."
        Me.chkCalcMisc.UseVisualStyleBackColor = true
        '
        'chkCalcSubsystems
        '
        Me.chkCalcSubsystems.AutoSize = true
        Me.chkCalcSubsystems.Location = New System.Drawing.Point(88, 63)
        Me.chkCalcSubsystems.Name = "chkCalcSubsystems"
        Me.chkCalcSubsystems.Size = New System.Drawing.Size(82, 17)
        Me.chkCalcSubsystems.TabIndex = 7
        Me.chkCalcSubsystems.Text = "Subsystems"
        Me.chkCalcSubsystems.UseVisualStyleBackColor = true
        '
        'chkCalcDeployables
        '
        Me.chkCalcDeployables.AutoSize = true
        Me.chkCalcDeployables.Location = New System.Drawing.Point(9, 63)
        Me.chkCalcDeployables.Name = "chkCalcDeployables"
        Me.chkCalcDeployables.Size = New System.Drawing.Size(84, 17)
        Me.chkCalcDeployables.TabIndex = 6
        Me.chkCalcDeployables.Text = "Deployables"
        Me.chkCalcDeployables.UseVisualStyleBackColor = true
        '
        'chkCalcStructures
        '
        Me.chkCalcStructures.AutoSize = true
        Me.chkCalcStructures.Location = New System.Drawing.Point(9, 79)
        Me.chkCalcStructures.Name = "chkCalcStructures"
        Me.chkCalcStructures.Size = New System.Drawing.Size(74, 17)
        Me.chkCalcStructures.TabIndex = 8
        Me.chkCalcStructures.Text = "Structures"
        Me.chkCalcStructures.UseVisualStyleBackColor = true
        '
        'chkCalcStationParts
        '
        Me.chkCalcStationParts.AutoSize = true
        Me.chkCalcStationParts.Location = New System.Drawing.Point(88, 95)
        Me.chkCalcStationParts.Name = "chkCalcStationParts"
        Me.chkCalcStationParts.Size = New System.Drawing.Size(86, 17)
        Me.chkCalcStationParts.TabIndex = 11
        Me.chkCalcStationParts.Text = "Station Parts"
        Me.chkCalcStationParts.UseVisualStyleBackColor = true
        '
        'chkCalcBoosters
        '
        Me.chkCalcBoosters.AutoSize = true
        Me.chkCalcBoosters.Location = New System.Drawing.Point(88, 79)
        Me.chkCalcBoosters.Name = "chkCalcBoosters"
        Me.chkCalcBoosters.Size = New System.Drawing.Size(67, 17)
        Me.chkCalcBoosters.TabIndex = 9
        Me.chkCalcBoosters.Text = "Boosters"
        Me.chkCalcBoosters.UseVisualStyleBackColor = true
        '
        'chkCalcRigs
        '
        Me.chkCalcRigs.AutoSize = true
        Me.chkCalcRigs.Location = New System.Drawing.Point(88, 47)
        Me.chkCalcRigs.Name = "chkCalcRigs"
        Me.chkCalcRigs.Size = New System.Drawing.Size(47, 17)
        Me.chkCalcRigs.TabIndex = 5
        Me.chkCalcRigs.Text = "Rigs"
        Me.chkCalcRigs.UseVisualStyleBackColor = true
        '
        'chkCalcComponents
        '
        Me.chkCalcComponents.AutoSize = true
        Me.chkCalcComponents.Location = New System.Drawing.Point(9, 47)
        Me.chkCalcComponents.Name = "chkCalcComponents"
        Me.chkCalcComponents.Size = New System.Drawing.Size(85, 17)
        Me.chkCalcComponents.TabIndex = 4
        Me.chkCalcComponents.Text = "Components"
        Me.chkCalcComponents.UseVisualStyleBackColor = true
        '
        'chkCalcAmmo
        '
        Me.chkCalcAmmo.AutoSize = true
        Me.chkCalcAmmo.Location = New System.Drawing.Point(88, 31)
        Me.chkCalcAmmo.Name = "chkCalcAmmo"
        Me.chkCalcAmmo.Size = New System.Drawing.Size(99, 17)
        Me.chkCalcAmmo.TabIndex = 3
        Me.chkCalcAmmo.Text = "Ammo/Charges"
        Me.chkCalcAmmo.UseVisualStyleBackColor = true
        '
        'chkCalcDrones
        '
        Me.chkCalcDrones.AutoSize = true
        Me.chkCalcDrones.Location = New System.Drawing.Point(9, 31)
        Me.chkCalcDrones.Name = "chkCalcDrones"
        Me.chkCalcDrones.Size = New System.Drawing.Size(60, 17)
        Me.chkCalcDrones.TabIndex = 2
        Me.chkCalcDrones.Text = "Drones"
        Me.chkCalcDrones.UseVisualStyleBackColor = true
        '
        'chkCalcModules
        '
        Me.chkCalcModules.AutoSize = true
        Me.chkCalcModules.Location = New System.Drawing.Point(88, 15)
        Me.chkCalcModules.Name = "chkCalcModules"
        Me.chkCalcModules.Size = New System.Drawing.Size(66, 17)
        Me.chkCalcModules.TabIndex = 1
        Me.chkCalcModules.Text = "Modules"
        Me.chkCalcModules.UseVisualStyleBackColor = true
        '
        'chkCalcShips
        '
        Me.chkCalcShips.AutoSize = true
        Me.chkCalcShips.Location = New System.Drawing.Point(9, 15)
        Me.chkCalcShips.Name = "chkCalcShips"
        Me.chkCalcShips.Size = New System.Drawing.Size(52, 17)
        Me.chkCalcShips.TabIndex = 0
        Me.chkCalcShips.Text = "Ships"
        Me.chkCalcShips.UseVisualStyleBackColor = true
        '
        'gbCalcBPSelect
        '
        Me.gbCalcBPSelect.Controls.Add(Me.rbtnCalcBPFavorites)
        Me.gbCalcBPSelect.Controls.Add(Me.rbtnCalcAllBPs)
        Me.gbCalcBPSelect.Controls.Add(Me.rbtnCalcBPOwned)
        Me.gbCalcBPSelect.Location = New System.Drawing.Point(6, 15)
        Me.gbCalcBPSelect.Name = "gbCalcBPSelect"
        Me.gbCalcBPSelect.Size = New System.Drawing.Size(100, 65)
        Me.gbCalcBPSelect.TabIndex = 0
        Me.gbCalcBPSelect.TabStop = false
        Me.gbCalcBPSelect.Text = "Load:"
        '
        'rbtnCalcBPFavorites
        '
        Me.rbtnCalcBPFavorites.AutoSize = true
        Me.rbtnCalcBPFavorites.Location = New System.Drawing.Point(8, 44)
        Me.rbtnCalcBPFavorites.Name = "rbtnCalcBPFavorites"
        Me.rbtnCalcBPFavorites.Size = New System.Drawing.Size(68, 17)
        Me.rbtnCalcBPFavorites.TabIndex = 2
        Me.rbtnCalcBPFavorites.Text = "Favorites"
        Me.rbtnCalcBPFavorites.UseVisualStyleBackColor = true
        '
        'rbtnCalcAllBPs
        '
        Me.rbtnCalcAllBPs.AutoSize = true
        Me.rbtnCalcAllBPs.Location = New System.Drawing.Point(8, 14)
        Me.rbtnCalcAllBPs.Name = "rbtnCalcAllBPs"
        Me.rbtnCalcAllBPs.Size = New System.Drawing.Size(85, 17)
        Me.rbtnCalcAllBPs.TabIndex = 0
        Me.rbtnCalcAllBPs.Text = "All Blueprints"
        Me.rbtnCalcAllBPs.UseVisualStyleBackColor = true
        '
        'rbtnCalcBPOwned
        '
        Me.rbtnCalcBPOwned.AutoSize = true
        Me.rbtnCalcBPOwned.Location = New System.Drawing.Point(8, 29)
        Me.rbtnCalcBPOwned.Name = "rbtnCalcBPOwned"
        Me.rbtnCalcBPOwned.Size = New System.Drawing.Size(81, 17)
        Me.rbtnCalcBPOwned.TabIndex = 1
        Me.rbtnCalcBPOwned.Text = "Owned BPs"
        Me.rbtnCalcBPOwned.UseVisualStyleBackColor = true
        '
        'gbCalcRelics
        '
        Me.gbCalcRelics.Controls.Add(Me.chkCalcRERelic2)
        Me.gbCalcRelics.Controls.Add(Me.chkCalcRERelic3)
        Me.gbCalcRelics.Controls.Add(Me.chkCalcRERelic1)
        Me.gbCalcRelics.Location = New System.Drawing.Point(409, 147)
        Me.gbCalcRelics.Name = "gbCalcRelics"
        Me.gbCalcRelics.Size = New System.Drawing.Size(133, 52)
        Me.gbCalcRelics.TabIndex = 7
        Me.gbCalcRelics.TabStop = false
        Me.gbCalcRelics.Text = "RE Relics:"
        '
        'chkCalcRERelic2
        '
        Me.chkCalcRERelic2.Location = New System.Drawing.Point(9, 30)
        Me.chkCalcRERelic2.Name = "chkCalcRERelic2"
        Me.chkCalcRERelic2.Size = New System.Drawing.Size(95, 17)
        Me.chkCalcRERelic2.TabIndex = 1
        Me.chkCalcRERelic2.Text = "Malfunctioning"
        Me.chkCalcRERelic2.UseVisualStyleBackColor = true
        '
        'chkCalcRERelic3
        '
        Me.chkCalcRERelic3.AutoSize = true
        Me.chkCalcRERelic3.Location = New System.Drawing.Point(78, 14)
        Me.chkCalcRERelic3.Name = "chkCalcRERelic3"
        Me.chkCalcRERelic3.Size = New System.Drawing.Size(53, 17)
        Me.chkCalcRERelic3.TabIndex = 2
        Me.chkCalcRERelic3.Text = "Intact"
        Me.chkCalcRERelic3.UseVisualStyleBackColor = true
        '
        'chkCalcRERelic1
        '
        Me.chkCalcRERelic1.AutoSize = true
        Me.chkCalcRERelic1.Location = New System.Drawing.Point(9, 14)
        Me.chkCalcRERelic1.Name = "chkCalcRERelic1"
        Me.chkCalcRERelic1.Size = New System.Drawing.Size(70, 17)
        Me.chkCalcRERelic1.TabIndex = 0
        Me.chkCalcRERelic1.Text = "Wrecked"
        Me.chkCalcRERelic1.UseVisualStyleBackColor = true
        '
        'tabCalcTeams
        '
        Me.tabCalcTeams.Controls.Add(Me.tabCalcTeamManufacturing)
        Me.tabCalcTeams.Controls.Add(Me.tabCalcTeamComponents)
        Me.tabCalcTeams.Controls.Add(Me.tabCalcTeamInvention)
        Me.tabCalcTeams.Controls.Add(Me.tabCalcTeamCopy)
        Me.tabCalcTeams.Enabled = false
        Me.tabCalcTeams.ItemSize = New System.Drawing.Size(49, 20)
        Me.tabCalcTeams.Location = New System.Drawing.Point(546, 176)
        Me.tabCalcTeams.Multiline = true
        Me.tabCalcTeams.Name = "tabCalcTeams"
        Me.tabCalcTeams.Padding = New System.Drawing.Point(0, 0)
        Me.tabCalcTeams.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabCalcTeams.SelectedIndex = 0
        Me.tabCalcTeams.Size = New System.Drawing.Size(302, 118)
        Me.tabCalcTeams.TabIndex = 14
        '
        'tabCalcTeamManufacturing
        '
        Me.tabCalcTeamManufacturing.Controls.Add(Me.txtCalcManufacturingTeamBonus)
        Me.tabCalcTeamManufacturing.Controls.Add(Me.btnCalcSaveManufacturingTeam)
        Me.tabCalcTeamManufacturing.Controls.Add(Me.cmbCalcManufacturingTeam)
        Me.tabCalcTeamManufacturing.Controls.Add(Me.lblCalcManufacturingTeamDefault)
        Me.tabCalcTeamManufacturing.Location = New System.Drawing.Point(4, 24)
        Me.tabCalcTeamManufacturing.Margin = New System.Windows.Forms.Padding(0)
        Me.tabCalcTeamManufacturing.Name = "tabCalcTeamManufacturing"
        Me.tabCalcTeamManufacturing.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalcTeamManufacturing.Size = New System.Drawing.Size(294, 90)
        Me.tabCalcTeamManufacturing.TabIndex = 1
        Me.tabCalcTeamManufacturing.Text = "Manufacturing"
        Me.tabCalcTeamManufacturing.UseVisualStyleBackColor = true
        '
        'txtCalcManufacturingTeamBonus
        '
        Me.txtCalcManufacturingTeamBonus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalcManufacturingTeamBonus.Location = New System.Drawing.Point(8, 32)
        Me.txtCalcManufacturingTeamBonus.Multiline = true
        Me.txtCalcManufacturingTeamBonus.Name = "txtCalcManufacturingTeamBonus"
        Me.txtCalcManufacturingTeamBonus.Size = New System.Drawing.Size(225, 53)
        Me.txtCalcManufacturingTeamBonus.TabIndex = 1
        Me.txtCalcManufacturingTeamBonus.Text = "Team Bonus"
        '
        'btnCalcSaveManufacturingTeam
        '
        Me.btnCalcSaveManufacturingTeam.Enabled = false
        Me.btnCalcSaveManufacturingTeam.Location = New System.Drawing.Point(234, 64)
        Me.btnCalcSaveManufacturingTeam.Name = "btnCalcSaveManufacturingTeam"
        Me.btnCalcSaveManufacturingTeam.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcSaveManufacturingTeam.TabIndex = 3
        Me.btnCalcSaveManufacturingTeam.Text = "Save"
        Me.btnCalcSaveManufacturingTeam.UseVisualStyleBackColor = true
        '
        'cmbCalcManufacturingTeam
        '
        Me.cmbCalcManufacturingTeam.Location = New System.Drawing.Point(6, 7)
        Me.cmbCalcManufacturingTeam.Name = "cmbCalcManufacturingTeam"
        Me.cmbCalcManufacturingTeam.Size = New System.Drawing.Size(284, 21)
        Me.cmbCalcManufacturingTeam.TabIndex = 0
        Me.cmbCalcManufacturingTeam.Text = "Select Team"
        '
        'lblCalcManufacturingTeamDefault
        '
        Me.lblCalcManufacturingTeamDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcManufacturingTeamDefault.Location = New System.Drawing.Point(240, 32)
        Me.lblCalcManufacturingTeamDefault.Name = "lblCalcManufacturingTeamDefault"
        Me.lblCalcManufacturingTeamDefault.Size = New System.Drawing.Size(44, 30)
        Me.lblCalcManufacturingTeamDefault.TabIndex = 2
        Me.lblCalcManufacturingTeamDefault.Text = "Default Team"
        Me.lblCalcManufacturingTeamDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabCalcTeamComponents
        '
        Me.tabCalcTeamComponents.Controls.Add(Me.txtCalcComponentManufacturingTeamBonus)
        Me.tabCalcTeamComponents.Controls.Add(Me.btnCalcSaveComponentManufacturingTeam)
        Me.tabCalcTeamComponents.Controls.Add(Me.cmbCalcComponentManufacturingTeam)
        Me.tabCalcTeamComponents.Controls.Add(Me.lblCalcComponentManufacturingTeamDefault)
        Me.tabCalcTeamComponents.Location = New System.Drawing.Point(4, 24)
        Me.tabCalcTeamComponents.Name = "tabCalcTeamComponents"
        Me.tabCalcTeamComponents.Size = New System.Drawing.Size(294, 90)
        Me.tabCalcTeamComponents.TabIndex = 4
        Me.tabCalcTeamComponents.Text = "Components"
        Me.tabCalcTeamComponents.UseVisualStyleBackColor = true
        '
        'txtCalcComponentManufacturingTeamBonus
        '
        Me.txtCalcComponentManufacturingTeamBonus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalcComponentManufacturingTeamBonus.Location = New System.Drawing.Point(8, 32)
        Me.txtCalcComponentManufacturingTeamBonus.Multiline = true
        Me.txtCalcComponentManufacturingTeamBonus.Name = "txtCalcComponentManufacturingTeamBonus"
        Me.txtCalcComponentManufacturingTeamBonus.Size = New System.Drawing.Size(225, 53)
        Me.txtCalcComponentManufacturingTeamBonus.TabIndex = 20
        Me.txtCalcComponentManufacturingTeamBonus.Text = "Team Bonus"
        '
        'btnCalcSaveComponentManufacturingTeam
        '
        Me.btnCalcSaveComponentManufacturingTeam.Enabled = false
        Me.btnCalcSaveComponentManufacturingTeam.Location = New System.Drawing.Point(234, 64)
        Me.btnCalcSaveComponentManufacturingTeam.Name = "btnCalcSaveComponentManufacturingTeam"
        Me.btnCalcSaveComponentManufacturingTeam.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcSaveComponentManufacturingTeam.TabIndex = 18
        Me.btnCalcSaveComponentManufacturingTeam.Text = "Save"
        Me.btnCalcSaveComponentManufacturingTeam.UseVisualStyleBackColor = true
        '
        'cmbCalcComponentManufacturingTeam
        '
        Me.cmbCalcComponentManufacturingTeam.Location = New System.Drawing.Point(6, 7)
        Me.cmbCalcComponentManufacturingTeam.Name = "cmbCalcComponentManufacturingTeam"
        Me.cmbCalcComponentManufacturingTeam.Size = New System.Drawing.Size(284, 21)
        Me.cmbCalcComponentManufacturingTeam.TabIndex = 17
        Me.cmbCalcComponentManufacturingTeam.Text = "Select Team"
        '
        'lblCalcComponentManufacturingTeamDefault
        '
        Me.lblCalcComponentManufacturingTeamDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcComponentManufacturingTeamDefault.Location = New System.Drawing.Point(240, 32)
        Me.lblCalcComponentManufacturingTeamDefault.Name = "lblCalcComponentManufacturingTeamDefault"
        Me.lblCalcComponentManufacturingTeamDefault.Size = New System.Drawing.Size(44, 30)
        Me.lblCalcComponentManufacturingTeamDefault.TabIndex = 19
        Me.lblCalcComponentManufacturingTeamDefault.Text = "Default Team"
        Me.lblCalcComponentManufacturingTeamDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabCalcTeamInvention
        '
        Me.tabCalcTeamInvention.Controls.Add(Me.txtCalcInventionTeamBonus)
        Me.tabCalcTeamInvention.Controls.Add(Me.btnCalcSaveInventionTeam)
        Me.tabCalcTeamInvention.Controls.Add(Me.cmbCalcInventionTeam)
        Me.tabCalcTeamInvention.Controls.Add(Me.lblCalcInventionTeamDefault)
        Me.tabCalcTeamInvention.Location = New System.Drawing.Point(4, 24)
        Me.tabCalcTeamInvention.Name = "tabCalcTeamInvention"
        Me.tabCalcTeamInvention.Size = New System.Drawing.Size(294, 90)
        Me.tabCalcTeamInvention.TabIndex = 2
        Me.tabCalcTeamInvention.Text = "Invention"
        Me.tabCalcTeamInvention.UseVisualStyleBackColor = true
        '
        'txtCalcInventionTeamBonus
        '
        Me.txtCalcInventionTeamBonus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalcInventionTeamBonus.Location = New System.Drawing.Point(8, 32)
        Me.txtCalcInventionTeamBonus.Multiline = true
        Me.txtCalcInventionTeamBonus.Name = "txtCalcInventionTeamBonus"
        Me.txtCalcInventionTeamBonus.Size = New System.Drawing.Size(225, 53)
        Me.txtCalcInventionTeamBonus.TabIndex = 17
        Me.txtCalcInventionTeamBonus.Text = "Team Bonus"
        '
        'btnCalcSaveInventionTeam
        '
        Me.btnCalcSaveInventionTeam.Enabled = false
        Me.btnCalcSaveInventionTeam.Location = New System.Drawing.Point(234, 64)
        Me.btnCalcSaveInventionTeam.Name = "btnCalcSaveInventionTeam"
        Me.btnCalcSaveInventionTeam.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcSaveInventionTeam.TabIndex = 3
        Me.btnCalcSaveInventionTeam.Text = "Save"
        Me.btnCalcSaveInventionTeam.UseVisualStyleBackColor = true
        '
        'cmbCalcInventionTeam
        '
        Me.cmbCalcInventionTeam.Location = New System.Drawing.Point(6, 7)
        Me.cmbCalcInventionTeam.Name = "cmbCalcInventionTeam"
        Me.cmbCalcInventionTeam.Size = New System.Drawing.Size(284, 21)
        Me.cmbCalcInventionTeam.TabIndex = 0
        Me.cmbCalcInventionTeam.Text = "Select Team"
        '
        'lblCalcInventionTeamDefault
        '
        Me.lblCalcInventionTeamDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcInventionTeamDefault.Location = New System.Drawing.Point(240, 32)
        Me.lblCalcInventionTeamDefault.Name = "lblCalcInventionTeamDefault"
        Me.lblCalcInventionTeamDefault.Size = New System.Drawing.Size(44, 30)
        Me.lblCalcInventionTeamDefault.TabIndex = 4
        Me.lblCalcInventionTeamDefault.Text = "Default Team"
        Me.lblCalcInventionTeamDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabCalcTeamCopy
        '
        Me.tabCalcTeamCopy.Controls.Add(Me.btnCalcSaveCopyTeam)
        Me.tabCalcTeamCopy.Controls.Add(Me.cmbCalcCopyTeam)
        Me.tabCalcTeamCopy.Controls.Add(Me.lblCalcCopyTeamDefault)
        Me.tabCalcTeamCopy.Controls.Add(Me.txtCalcCopyTeamBonus)
        Me.tabCalcTeamCopy.Location = New System.Drawing.Point(4, 24)
        Me.tabCalcTeamCopy.Name = "tabCalcTeamCopy"
        Me.tabCalcTeamCopy.Size = New System.Drawing.Size(294, 90)
        Me.tabCalcTeamCopy.TabIndex = 3
        Me.tabCalcTeamCopy.Text = "Copy"
        Me.tabCalcTeamCopy.UseVisualStyleBackColor = true
        '
        'btnCalcSaveCopyTeam
        '
        Me.btnCalcSaveCopyTeam.Enabled = false
        Me.btnCalcSaveCopyTeam.Location = New System.Drawing.Point(234, 64)
        Me.btnCalcSaveCopyTeam.Name = "btnCalcSaveCopyTeam"
        Me.btnCalcSaveCopyTeam.Size = New System.Drawing.Size(56, 22)
        Me.btnCalcSaveCopyTeam.TabIndex = 3
        Me.btnCalcSaveCopyTeam.Text = "Save"
        Me.btnCalcSaveCopyTeam.UseVisualStyleBackColor = true
        '
        'cmbCalcCopyTeam
        '
        Me.cmbCalcCopyTeam.Location = New System.Drawing.Point(6, 7)
        Me.cmbCalcCopyTeam.Name = "cmbCalcCopyTeam"
        Me.cmbCalcCopyTeam.Size = New System.Drawing.Size(284, 21)
        Me.cmbCalcCopyTeam.TabIndex = 0
        Me.cmbCalcCopyTeam.Text = "Select Team"
        '
        'lblCalcCopyTeamDefault
        '
        Me.lblCalcCopyTeamDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCalcCopyTeamDefault.Location = New System.Drawing.Point(240, 32)
        Me.lblCalcCopyTeamDefault.Name = "lblCalcCopyTeamDefault"
        Me.lblCalcCopyTeamDefault.Size = New System.Drawing.Size(44, 30)
        Me.lblCalcCopyTeamDefault.TabIndex = 4
        Me.lblCalcCopyTeamDefault.Text = "Default Team"
        Me.lblCalcCopyTeamDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCalcCopyTeamBonus
        '
        Me.txtCalcCopyTeamBonus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCalcCopyTeamBonus.Location = New System.Drawing.Point(8, 32)
        Me.txtCalcCopyTeamBonus.Multiline = true
        Me.txtCalcCopyTeamBonus.Name = "txtCalcCopyTeamBonus"
        Me.txtCalcCopyTeamBonus.Size = New System.Drawing.Size(225, 53)
        Me.txtCalcCopyTeamBonus.TabIndex = 18
        Me.txtCalcCopyTeamBonus.Text = "Team Bonus"
        '
        'gbTempMEPE
        '
        Me.gbTempMEPE.Controls.Add(Me.txtCalcTempTE)
        Me.gbTempMEPE.Controls.Add(Me.lblTempPE)
        Me.gbTempMEPE.Controls.Add(Me.txtCalcTempME)
        Me.gbTempMEPE.Controls.Add(Me.lblTempME)
        Me.gbTempMEPE.Location = New System.Drawing.Point(409, 201)
        Me.gbTempMEPE.Name = "gbTempMEPE"
        Me.gbTempMEPE.Size = New System.Drawing.Size(133, 40)
        Me.gbTempMEPE.TabIndex = 11
        Me.gbTempMEPE.TabStop = false
        Me.gbTempMEPE.Text = "Unowned BPs:"
        '
        'txtCalcTempTE
        '
        Me.txtCalcTempTE.Location = New System.Drawing.Point(91, 15)
        Me.txtCalcTempTE.Name = "txtCalcTempTE"
        Me.txtCalcTempTE.Size = New System.Drawing.Size(29, 20)
        Me.txtCalcTempTE.TabIndex = 3
        '
        'lblTempPE
        '
        Me.lblTempPE.AutoSize = true
        Me.lblTempPE.Location = New System.Drawing.Point(70, 19)
        Me.lblTempPE.Name = "lblTempPE"
        Me.lblTempPE.Size = New System.Drawing.Size(24, 13)
        Me.lblTempPE.TabIndex = 2
        Me.lblTempPE.Text = "TE:"
        '
        'txtCalcTempME
        '
        Me.txtCalcTempME.Location = New System.Drawing.Point(37, 15)
        Me.txtCalcTempME.Name = "txtCalcTempME"
        Me.txtCalcTempME.Size = New System.Drawing.Size(29, 20)
        Me.txtCalcTempME.TabIndex = 1
        '
        'lblTempME
        '
        Me.lblTempME.AutoSize = true
        Me.lblTempME.Location = New System.Drawing.Point(13, 19)
        Me.lblTempME.Name = "lblTempME"
        Me.lblTempME.Size = New System.Drawing.Size(26, 13)
        Me.lblTempME.TabIndex = 0
        Me.lblTempME.Text = "ME:"
        '
        'lstManufacturing
        '
        Me.lstManufacturing.AllowColumnReorder = true
        Me.lstManufacturing.FullRowSelect = true
        Me.lstManufacturing.GridLines = true
        Me.lstManufacturing.HideSelection = false
        Me.lstManufacturing.Location = New System.Drawing.Point(8, 7)
        Me.lstManufacturing.Name = "lstManufacturing"
        Me.lstManufacturing.Size = New System.Drawing.Size(1121, 300)
        Me.lstManufacturing.TabIndex = 0
        Me.lstManufacturing.TabStop = false
        Me.lstManufacturing.UseCompatibleStateImageBehavior = false
        Me.lstManufacturing.View = System.Windows.Forms.View.Details
        '
        'tabUpdatePrices
        '
        Me.tabUpdatePrices.Controls.Add(Me.chkUpdatePricesCRESTHistory)
        Me.tabUpdatePrices.Controls.Add(Me.chkUpdatePricesNoPrice)
        Me.tabUpdatePrices.Controls.Add(Me.gbTradeHubSystems)
        Me.tabUpdatePrices.Controls.Add(Me.lstPricesView)
        Me.tabUpdatePrices.Controls.Add(Me.txtPriceItemFilter)
        Me.tabUpdatePrices.Controls.Add(Me.chkSplitPrices)
        Me.tabUpdatePrices.Controls.Add(Me.gbSplitPrices)
        Me.tabUpdatePrices.Controls.Add(Me.btnSaveUpdatePrices)
        Me.tabUpdatePrices.Controls.Add(Me.btnEnterPrices)
        Me.tabUpdatePrices.Controls.Add(Me.btnClearItemFilter)
        Me.tabUpdatePrices.Controls.Add(Me.btnToggleAllPriceItems)
        Me.tabUpdatePrices.Controls.Add(Me.btnImportPrices)
        Me.tabUpdatePrices.Controls.Add(Me.lblItemFilter)
        Me.tabUpdatePrices.Controls.Add(Me.gbManufacturedItems)
        Me.tabUpdatePrices.Controls.Add(Me.gbPrice)
        Me.tabUpdatePrices.Controls.Add(Me.gbRawMaterials)
        Me.tabUpdatePrices.Controls.Add(Me.gbRegions)
        Me.tabUpdatePrices.Location = New System.Drawing.Point(4, 22)
        Me.tabUpdatePrices.Name = "tabUpdatePrices"
        Me.tabUpdatePrices.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUpdatePrices.Size = New System.Drawing.Size(1137, 615)
        Me.tabUpdatePrices.TabIndex = 1
        Me.tabUpdatePrices.Text = "Update Prices"
        Me.tabUpdatePrices.UseVisualStyleBackColor = true
        '
        'chkUpdatePricesCRESTHistory
        '
        Me.chkUpdatePricesCRESTHistory.AutoSize = true
        Me.chkUpdatePricesCRESTHistory.Location = New System.Drawing.Point(568, 583)
        Me.chkUpdatePricesCRESTHistory.Name = "chkUpdatePricesCRESTHistory"
        Me.chkUpdatePricesCRESTHistory.Size = New System.Drawing.Size(123, 17)
        Me.chkUpdatePricesCRESTHistory.TabIndex = 15
        Me.chkUpdatePricesCRESTHistory.Text = "Update Price History"
        Me.chkUpdatePricesCRESTHistory.UseVisualStyleBackColor = true
        Me.chkUpdatePricesCRESTHistory.Visible = false
        '
        'chkUpdatePricesNoPrice
        '
        Me.chkUpdatePricesNoPrice.AutoSize = true
        Me.chkUpdatePricesNoPrice.Location = New System.Drawing.Point(448, 583)
        Me.chkUpdatePricesNoPrice.Name = "chkUpdatePricesNoPrice"
        Me.chkUpdatePricesNoPrice.Size = New System.Drawing.Size(108, 17)
        Me.chkUpdatePricesNoPrice.TabIndex = 6
        Me.chkUpdatePricesNoPrice.Text = "Items w/No Price"
        Me.chkUpdatePricesNoPrice.UseVisualStyleBackColor = true
        '
        'gbTradeHubSystems
        '
        Me.gbTradeHubSystems.Controls.Add(Me.cmbPriceSystems)
        Me.gbTradeHubSystems.Controls.Add(Me.chkSystems2)
        Me.gbTradeHubSystems.Controls.Add(Me.chkSystems4)
        Me.gbTradeHubSystems.Controls.Add(Me.chkSystems5)
        Me.gbTradeHubSystems.Controls.Add(Me.chkSystems3)
        Me.gbTradeHubSystems.Controls.Add(Me.chkSystems1)
        Me.gbTradeHubSystems.Location = New System.Drawing.Point(704, 428)
        Me.gbTradeHubSystems.Name = "gbTradeHubSystems"
        Me.gbTradeHubSystems.Size = New System.Drawing.Size(425, 45)
        Me.gbTradeHubSystems.TabIndex = 8
        Me.gbTradeHubSystems.TabStop = false
        Me.gbTradeHubSystems.Text = "Trade Hub Systems"
        '
        'cmbPriceSystems
        '
        Me.cmbPriceSystems.FormattingEnabled = true
        Me.cmbPriceSystems.Location = New System.Drawing.Point(293, 16)
        Me.cmbPriceSystems.Name = "cmbPriceSystems"
        Me.cmbPriceSystems.Size = New System.Drawing.Size(126, 21)
        Me.cmbPriceSystems.TabIndex = 5
        Me.cmbPriceSystems.Text = "Select System"
        '
        'chkSystems2
        '
        Me.chkSystems2.AutoSize = true
        Me.chkSystems2.Location = New System.Drawing.Point(62, 19)
        Me.chkSystems2.Name = "chkSystems2"
        Me.chkSystems2.Size = New System.Drawing.Size(53, 17)
        Me.chkSystems2.TabIndex = 1
        Me.chkSystems2.Text = "Amarr"
        Me.chkSystems2.UseVisualStyleBackColor = true
        '
        'chkSystems4
        '
        Me.chkSystems4.AutoSize = true
        Me.chkSystems4.Location = New System.Drawing.Point(188, 19)
        Me.chkSystems4.Name = "chkSystems4"
        Me.chkSystems4.Size = New System.Drawing.Size(51, 17)
        Me.chkSystems4.TabIndex = 3
        Me.chkSystems4.Text = "Rens"
        Me.chkSystems4.UseVisualStyleBackColor = true
        '
        'chkSystems5
        '
        Me.chkSystems5.AutoSize = true
        Me.chkSystems5.Location = New System.Drawing.Point(245, 19)
        Me.chkSystems5.Name = "chkSystems5"
        Me.chkSystems5.Size = New System.Drawing.Size(46, 17)
        Me.chkSystems5.TabIndex = 4
        Me.chkSystems5.Text = "Hek"
        Me.chkSystems5.UseVisualStyleBackColor = true
        '
        'chkSystems3
        '
        Me.chkSystems3.AutoSize = true
        Me.chkSystems3.Location = New System.Drawing.Point(121, 19)
        Me.chkSystems3.Name = "chkSystems3"
        Me.chkSystems3.Size = New System.Drawing.Size(61, 17)
        Me.chkSystems3.TabIndex = 2
        Me.chkSystems3.Text = "Dodixie"
        Me.chkSystems3.UseVisualStyleBackColor = true
        '
        'chkSystems1
        '
        Me.chkSystems1.AutoSize = true
        Me.chkSystems1.Checked = true
        Me.chkSystems1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSystems1.Location = New System.Drawing.Point(14, 19)
        Me.chkSystems1.Name = "chkSystems1"
        Me.chkSystems1.Size = New System.Drawing.Size(42, 17)
        Me.chkSystems1.TabIndex = 0
        Me.chkSystems1.Text = "Jita"
        Me.chkSystems1.UseVisualStyleBackColor = true
        '
        'txtPriceItemFilter
        '
        Me.txtPriceItemFilter.Location = New System.Drawing.Point(80, 581)
        Me.txtPriceItemFilter.Name = "txtPriceItemFilter"
        Me.txtPriceItemFilter.Size = New System.Drawing.Size(290, 20)
        Me.txtPriceItemFilter.TabIndex = 3
        '
        'chkSplitPrices
        '
        Me.chkSplitPrices.AutoSize = true
        Me.chkSplitPrices.BackColor = System.Drawing.Color.White
        Me.chkSplitPrices.Location = New System.Drawing.Point(1043, 479)
        Me.chkSplitPrices.Name = "chkSplitPrices"
        Me.chkSplitPrices.Size = New System.Drawing.Size(78, 17)
        Me.chkSplitPrices.TabIndex = 0
        Me.chkSplitPrices.Text = "Split Prices"
        Me.chkSplitPrices.UseVisualStyleBackColor = false
        '
        'gbSplitPrices
        '
        Me.gbSplitPrices.Controls.Add(Me.cmbItemsSplitPrices)
        Me.gbSplitPrices.Controls.Add(Me.cmbRawMatsSplitPrices)
        Me.gbSplitPrices.Controls.Add(Me.lblItemsSplitPrices)
        Me.gbSplitPrices.Controls.Add(Me.lblRawMatsSplitPrices)
        Me.gbSplitPrices.Location = New System.Drawing.Point(1038, 480)
        Me.gbSplitPrices.Name = "gbSplitPrices"
        Me.gbSplitPrices.Size = New System.Drawing.Size(91, 95)
        Me.gbSplitPrices.TabIndex = 10
        Me.gbSplitPrices.TabStop = false
        '
        'cmbItemsSplitPrices
        '
        Me.cmbItemsSplitPrices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemsSplitPrices.FormattingEnabled = true
        Me.cmbItemsSplitPrices.Items.AddRange(New Object() {"Min Sell", "Max Sell", "Avg Sell", "Median Sell", "Percentile Sell", "Min Buy", "Max Buy", "Avg Buy", "Median Buy", "Percentile Buy", "Min Buy & Sell", "Max Buy & Sell", "Avg Buy & Sell", "Median Buy & Sell", "Percentile Buy & Sell"})
        Me.cmbItemsSplitPrices.Location = New System.Drawing.Point(6, 68)
        Me.cmbItemsSplitPrices.Name = "cmbItemsSplitPrices"
        Me.cmbItemsSplitPrices.Size = New System.Drawing.Size(78, 21)
        Me.cmbItemsSplitPrices.TabIndex = 2
        '
        'cmbRawMatsSplitPrices
        '
        Me.cmbRawMatsSplitPrices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRawMatsSplitPrices.FormattingEnabled = true
        Me.cmbRawMatsSplitPrices.Items.AddRange(New Object() {"Min Sell", "Max Sell", "Avg Sell", "Median Sell", "Percentile Sell", "Min Buy", "Max Buy", "Avg Buy", "Median Buy", "Percentile Buy", "Min Buy & Sell", "Max Buy & Sell", "Avg Buy & Sell", "Median Buy & Sell", "Percentile Buy & Sell"})
        Me.cmbRawMatsSplitPrices.Location = New System.Drawing.Point(6, 31)
        Me.cmbRawMatsSplitPrices.Name = "cmbRawMatsSplitPrices"
        Me.cmbRawMatsSplitPrices.Size = New System.Drawing.Size(78, 21)
        Me.cmbRawMatsSplitPrices.TabIndex = 1
        '
        'lblItemsSplitPrices
        '
        Me.lblItemsSplitPrices.AutoSize = true
        Me.lblItemsSplitPrices.Location = New System.Drawing.Point(3, 54)
        Me.lblItemsSplitPrices.Name = "lblItemsSplitPrices"
        Me.lblItemsSplitPrices.Size = New System.Drawing.Size(35, 13)
        Me.lblItemsSplitPrices.TabIndex = 6
        Me.lblItemsSplitPrices.Text = "Items:"
        '
        'lblRawMatsSplitPrices
        '
        Me.lblRawMatsSplitPrices.AutoSize = true
        Me.lblRawMatsSplitPrices.Location = New System.Drawing.Point(3, 17)
        Me.lblRawMatsSplitPrices.Name = "lblRawMatsSplitPrices"
        Me.lblRawMatsSplitPrices.Size = New System.Drawing.Size(58, 13)
        Me.lblRawMatsSplitPrices.TabIndex = 7
        Me.lblRawMatsSplitPrices.Text = "Raw Mats:"
        '
        'btnSaveUpdatePrices
        '
        Me.btnSaveUpdatePrices.Location = New System.Drawing.Point(1026, 577)
        Me.btnSaveUpdatePrices.Name = "btnSaveUpdatePrices"
        Me.btnSaveUpdatePrices.Size = New System.Drawing.Size(103, 28)
        Me.btnSaveUpdatePrices.TabIndex = 14
        Me.btnSaveUpdatePrices.Text = "Save Settings"
        Me.btnSaveUpdatePrices.UseVisualStyleBackColor = true
        '
        'btnEnterPrices
        '
        Me.btnEnterPrices.Location = New System.Drawing.Point(918, 577)
        Me.btnEnterPrices.Name = "btnEnterPrices"
        Me.btnEnterPrices.Size = New System.Drawing.Size(103, 28)
        Me.btnEnterPrices.TabIndex = 13
        Me.btnEnterPrices.Text = "Enter Prices"
        Me.btnEnterPrices.UseVisualStyleBackColor = true
        '
        'btnClearItemFilter
        '
        Me.btnClearItemFilter.Location = New System.Drawing.Point(376, 581)
        Me.btnClearItemFilter.Name = "btnClearItemFilter"
        Me.btnClearItemFilter.Size = New System.Drawing.Size(59, 21)
        Me.btnClearItemFilter.TabIndex = 4
        Me.btnClearItemFilter.Text = "Clear"
        Me.btnClearItemFilter.UseVisualStyleBackColor = true
        '
        'btnToggleAllPriceItems
        '
        Me.btnToggleAllPriceItems.Location = New System.Drawing.Point(704, 577)
        Me.btnToggleAllPriceItems.Name = "btnToggleAllPriceItems"
        Me.btnToggleAllPriceItems.Size = New System.Drawing.Size(103, 28)
        Me.btnToggleAllPriceItems.TabIndex = 11
        Me.btnToggleAllPriceItems.Text = "Select All Items"
        Me.btnToggleAllPriceItems.UseVisualStyleBackColor = true
        '
        'btnImportPrices
        '
        Me.btnImportPrices.Location = New System.Drawing.Point(811, 577)
        Me.btnImportPrices.Name = "btnImportPrices"
        Me.btnImportPrices.Size = New System.Drawing.Size(103, 28)
        Me.btnImportPrices.TabIndex = 12
        Me.btnImportPrices.Text = "Import Prices"
        Me.btnImportPrices.UseVisualStyleBackColor = true
        '
        'lblItemFilter
        '
        Me.lblItemFilter.AutoSize = true
        Me.lblItemFilter.Location = New System.Drawing.Point(15, 585)
        Me.lblItemFilter.Name = "lblItemFilter"
        Me.lblItemFilter.Size = New System.Drawing.Size(55, 13)
        Me.lblItemFilter.TabIndex = 5
        Me.lblItemFilter.Text = "Item Filter:"
        '
        'gbManufacturedItems
        '
        Me.gbManufacturedItems.Controls.Add(Me.chkPriceManufacturedPrices)
        Me.gbManufacturedItems.Controls.Add(Me.gbPriceTools)
        Me.gbManufacturedItems.Controls.Add(Me.gbComponents)
        Me.gbManufacturedItems.Controls.Add(Me.gbItems)
        Me.gbManufacturedItems.Location = New System.Drawing.Point(269, 334)
        Me.gbManufacturedItems.Name = "gbManufacturedItems"
        Me.gbManufacturedItems.Size = New System.Drawing.Size(430, 238)
        Me.gbManufacturedItems.TabIndex = 2
        Me.gbManufacturedItems.TabStop = false
        '
        'chkPriceManufacturedPrices
        '
        Me.chkPriceManufacturedPrices.AutoSize = true
        Me.chkPriceManufacturedPrices.BackColor = System.Drawing.Color.White
        Me.chkPriceManufacturedPrices.Location = New System.Drawing.Point(6, 1)
        Me.chkPriceManufacturedPrices.Name = "chkPriceManufacturedPrices"
        Me.chkPriceManufacturedPrices.Size = New System.Drawing.Size(120, 17)
        Me.chkPriceManufacturedPrices.TabIndex = 0
        Me.chkPriceManufacturedPrices.Text = "Manufactured Items"
        Me.chkPriceManufacturedPrices.UseVisualStyleBackColor = false
        '
        'gbPriceTools
        '
        Me.gbPriceTools.Controls.Add(Me.chkImplants)
        Me.gbPriceTools.Controls.Add(Me.chkFuelBlocks)
        Me.gbPriceTools.Controls.Add(Me.chkDataInterfaces)
        Me.gbPriceTools.Controls.Add(Me.chkTools)
        Me.gbPriceTools.Location = New System.Drawing.Point(293, 145)
        Me.gbPriceTools.Name = "gbPriceTools"
        Me.gbPriceTools.Size = New System.Drawing.Size(131, 88)
        Me.gbPriceTools.TabIndex = 3
        Me.gbPriceTools.TabStop = false
        Me.gbPriceTools.Text = "Misc Items"
        '
        'chkImplants
        '
        Me.chkImplants.AutoSize = true
        Me.chkImplants.Location = New System.Drawing.Point(6, 66)
        Me.chkImplants.Name = "chkImplants"
        Me.chkImplants.Size = New System.Drawing.Size(65, 17)
        Me.chkImplants.TabIndex = 4
        Me.chkImplants.Text = "Implants"
        Me.chkImplants.UseVisualStyleBackColor = true
        '
        'chkFuelBlocks
        '
        Me.chkFuelBlocks.AutoSize = true
        Me.chkFuelBlocks.Location = New System.Drawing.Point(6, 49)
        Me.chkFuelBlocks.Name = "chkFuelBlocks"
        Me.chkFuelBlocks.Size = New System.Drawing.Size(81, 17)
        Me.chkFuelBlocks.TabIndex = 3
        Me.chkFuelBlocks.Text = "Fuel Blocks"
        Me.chkFuelBlocks.UseVisualStyleBackColor = true
        '
        'chkDataInterfaces
        '
        Me.chkDataInterfaces.AutoSize = true
        Me.chkDataInterfaces.Location = New System.Drawing.Point(6, 32)
        Me.chkDataInterfaces.Name = "chkDataInterfaces"
        Me.chkDataInterfaces.Size = New System.Drawing.Size(99, 17)
        Me.chkDataInterfaces.TabIndex = 2
        Me.chkDataInterfaces.Text = "Data Interfaces"
        Me.chkDataInterfaces.UseVisualStyleBackColor = true
        '
        'chkTools
        '
        Me.chkTools.AutoSize = true
        Me.chkTools.Location = New System.Drawing.Point(6, 15)
        Me.chkTools.Name = "chkTools"
        Me.chkTools.Size = New System.Drawing.Size(52, 17)
        Me.chkTools.TabIndex = 1
        Me.chkTools.Text = "Tools"
        Me.chkTools.UseVisualStyleBackColor = true
        '
        'gbComponents
        '
        Me.gbComponents.Controls.Add(Me.chkHybrid)
        Me.gbComponents.Controls.Add(Me.chkComponents)
        Me.gbComponents.Controls.Add(Me.chkCapitalComponents)
        Me.gbComponents.Controls.Add(Me.chkCapT2Components)
        Me.gbComponents.Location = New System.Drawing.Point(5, 145)
        Me.gbComponents.Name = "gbComponents"
        Me.gbComponents.Size = New System.Drawing.Size(282, 88)
        Me.gbComponents.TabIndex = 2
        Me.gbComponents.TabStop = false
        Me.gbComponents.Text = "Components"
        '
        'chkHybrid
        '
        Me.chkHybrid.AutoSize = true
        Me.chkHybrid.Location = New System.Drawing.Point(9, 66)
        Me.chkHybrid.Name = "chkHybrid"
        Me.chkHybrid.Size = New System.Drawing.Size(146, 17)
        Me.chkHybrid.TabIndex = 5
        Me.chkHybrid.Text = "Hybrid Tech Components"
        Me.chkHybrid.UseVisualStyleBackColor = true
        '
        'chkComponents
        '
        Me.chkComponents.AutoSize = true
        Me.chkComponents.Location = New System.Drawing.Point(9, 49)
        Me.chkComponents.Name = "chkComponents"
        Me.chkComponents.Size = New System.Drawing.Size(147, 17)
        Me.chkComponents.TabIndex = 4
        Me.chkComponents.Text = "Construction Components"
        Me.chkComponents.UseVisualStyleBackColor = true
        '
        'chkCapitalComponents
        '
        Me.chkCapitalComponents.AutoSize = true
        Me.chkCapitalComponents.Location = New System.Drawing.Point(9, 32)
        Me.chkCapitalComponents.Name = "chkCapitalComponents"
        Me.chkCapitalComponents.Size = New System.Drawing.Size(182, 17)
        Me.chkCapitalComponents.TabIndex = 3
        Me.chkCapitalComponents.Text = "Capital Construction Components"
        Me.chkCapitalComponents.UseVisualStyleBackColor = true
        '
        'chkCapT2Components
        '
        Me.chkCapT2Components.AutoSize = true
        Me.chkCapT2Components.Location = New System.Drawing.Point(9, 15)
        Me.chkCapT2Components.Name = "chkCapT2Components"
        Me.chkCapT2Components.Size = New System.Drawing.Size(207, 17)
        Me.chkCapT2Components.TabIndex = 2
        Me.chkCapT2Components.Text = "Adv. Capital Construction Components"
        Me.chkCapT2Components.UseVisualStyleBackColor = true
        '
        'gbItems
        '
        Me.gbItems.Controls.Add(Me.chkCelestials)
        Me.gbItems.Controls.Add(Me.chkDeployables)
        Me.gbItems.Controls.Add(Me.cmbPriceChargeTypes)
        Me.gbItems.Controls.Add(Me.chkStructures)
        Me.gbItems.Controls.Add(Me.chkStationComponents)
        Me.gbItems.Controls.Add(Me.chkCharges)
        Me.gbItems.Controls.Add(Me.chkBoosters)
        Me.gbItems.Controls.Add(Me.cmbPriceShipTypes)
        Me.gbItems.Controls.Add(Me.gbPricesTech)
        Me.gbItems.Controls.Add(Me.chkSubsystems)
        Me.gbItems.Controls.Add(Me.chkShips)
        Me.gbItems.Controls.Add(Me.chkModules)
        Me.gbItems.Controls.Add(Me.chkRigs)
        Me.gbItems.Controls.Add(Me.chkDrones)
        Me.gbItems.Location = New System.Drawing.Point(5, 16)
        Me.gbItems.Name = "gbItems"
        Me.gbItems.Size = New System.Drawing.Size(419, 128)
        Me.gbItems.TabIndex = 1
        Me.gbItems.TabStop = false
        Me.gbItems.Text = "Items"
        '
        'chkCelestials
        '
        Me.chkCelestials.AutoSize = true
        Me.chkCelestials.Location = New System.Drawing.Point(196, 84)
        Me.chkCelestials.Name = "chkCelestials"
        Me.chkCelestials.Size = New System.Drawing.Size(70, 17)
        Me.chkCelestials.TabIndex = 13
        Me.chkCelestials.Text = "Celestials"
        Me.chkCelestials.UseVisualStyleBackColor = true
        '
        'chkDeployables
        '
        Me.chkDeployables.AutoSize = true
        Me.chkDeployables.Location = New System.Drawing.Point(94, 67)
        Me.chkDeployables.Name = "chkDeployables"
        Me.chkDeployables.Size = New System.Drawing.Size(84, 17)
        Me.chkDeployables.TabIndex = 9
        Me.chkDeployables.Text = "Deployables"
        Me.chkDeployables.UseVisualStyleBackColor = true
        '
        'cmbPriceChargeTypes
        '
        Me.cmbPriceChargeTypes.FormattingEnabled = true
        Me.cmbPriceChargeTypes.Location = New System.Drawing.Point(71, 40)
        Me.cmbPriceChargeTypes.Name = "cmbPriceChargeTypes"
        Me.cmbPriceChargeTypes.Size = New System.Drawing.Size(211, 21)
        Me.cmbPriceChargeTypes.TabIndex = 5
        Me.cmbPriceChargeTypes.Text = "All Charge Types"
        '
        'chkStructures
        '
        Me.chkStructures.AutoSize = true
        Me.chkStructures.Location = New System.Drawing.Point(196, 67)
        Me.chkStructures.Name = "chkStructures"
        Me.chkStructures.Size = New System.Drawing.Size(74, 17)
        Me.chkStructures.TabIndex = 12
        Me.chkStructures.Text = "Structures"
        Me.chkStructures.UseVisualStyleBackColor = true
        '
        'chkStationComponents
        '
        Me.chkStationComponents.AutoSize = true
        Me.chkStationComponents.Location = New System.Drawing.Point(196, 101)
        Me.chkStationComponents.Name = "chkStationComponents"
        Me.chkStationComponents.Size = New System.Drawing.Size(86, 17)
        Me.chkStationComponents.TabIndex = 14
        Me.chkStationComponents.Text = "Station Parts"
        Me.chkStationComponents.UseVisualStyleBackColor = true
        '
        'chkCharges
        '
        Me.chkCharges.AutoSize = true
        Me.chkCharges.Location = New System.Drawing.Point(10, 42)
        Me.chkCharges.Name = "chkCharges"
        Me.chkCharges.Size = New System.Drawing.Size(65, 17)
        Me.chkCharges.TabIndex = 4
        Me.chkCharges.Text = "Charges"
        Me.chkCharges.UseVisualStyleBackColor = true
        '
        'chkBoosters
        '
        Me.chkBoosters.AutoSize = true
        Me.chkBoosters.Location = New System.Drawing.Point(94, 101)
        Me.chkBoosters.Name = "chkBoosters"
        Me.chkBoosters.Size = New System.Drawing.Size(67, 17)
        Me.chkBoosters.TabIndex = 11
        Me.chkBoosters.Text = "Boosters"
        Me.chkBoosters.UseVisualStyleBackColor = true
        '
        'cmbPriceShipTypes
        '
        Me.cmbPriceShipTypes.FormattingEnabled = true
        Me.cmbPriceShipTypes.Location = New System.Drawing.Point(71, 17)
        Me.cmbPriceShipTypes.Name = "cmbPriceShipTypes"
        Me.cmbPriceShipTypes.Size = New System.Drawing.Size(211, 21)
        Me.cmbPriceShipTypes.TabIndex = 3
        Me.cmbPriceShipTypes.Text = "All Ship Types"
        '
        'gbPricesTech
        '
        Me.gbPricesTech.Controls.Add(Me.chkPricesT4)
        Me.gbPricesTech.Controls.Add(Me.chkPricesT6)
        Me.gbPricesTech.Controls.Add(Me.chkPricesT5)
        Me.gbPricesTech.Controls.Add(Me.chkPricesT3)
        Me.gbPricesTech.Controls.Add(Me.chkPricesT2)
        Me.gbPricesTech.Controls.Add(Me.chkPricesT1)
        Me.gbPricesTech.Location = New System.Drawing.Point(288, 4)
        Me.gbPricesTech.Name = "gbPricesTech"
        Me.gbPricesTech.Size = New System.Drawing.Size(125, 114)
        Me.gbPricesTech.TabIndex = 15
        Me.gbPricesTech.TabStop = false
        '
        'chkPricesT4
        '
        Me.chkPricesT4.AutoSize = true
        Me.chkPricesT4.Enabled = false
        Me.chkPricesT4.Location = New System.Drawing.Point(6, 60)
        Me.chkPricesT4.Name = "chkPricesT4"
        Me.chkPricesT4.Size = New System.Drawing.Size(66, 17)
        Me.chkPricesT4.TabIndex = 3
        Me.chkPricesT4.Text = "Storyline"
        Me.chkPricesT4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkPricesT4.UseVisualStyleBackColor = true
        '
        'chkPricesT6
        '
        Me.chkPricesT6.AutoSize = true
        Me.chkPricesT6.Enabled = false
        Me.chkPricesT6.Location = New System.Drawing.Point(6, 94)
        Me.chkPricesT6.Name = "chkPricesT6"
        Me.chkPricesT6.Size = New System.Drawing.Size(91, 17)
        Me.chkPricesT6.TabIndex = 9
        Me.chkPricesT6.Text = "Pirate Faction"
        Me.chkPricesT6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkPricesT6.UseVisualStyleBackColor = true
        '
        'chkPricesT5
        '
        Me.chkPricesT5.AutoSize = true
        Me.chkPricesT5.Enabled = false
        Me.chkPricesT5.Location = New System.Drawing.Point(6, 77)
        Me.chkPricesT5.Name = "chkPricesT5"
        Me.chkPricesT5.Size = New System.Drawing.Size(89, 17)
        Me.chkPricesT5.TabIndex = 8
        Me.chkPricesT5.Text = "Navy Faction"
        Me.chkPricesT5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkPricesT5.UseVisualStyleBackColor = true
        '
        'chkPricesT3
        '
        Me.chkPricesT3.AutoSize = true
        Me.chkPricesT3.Enabled = false
        Me.chkPricesT3.Location = New System.Drawing.Point(6, 43)
        Me.chkPricesT3.Name = "chkPricesT3"
        Me.chkPricesT3.Size = New System.Drawing.Size(60, 17)
        Me.chkPricesT3.TabIndex = 2
        Me.chkPricesT3.Text = "Tech 3"
        Me.chkPricesT3.UseVisualStyleBackColor = true
        '
        'chkPricesT2
        '
        Me.chkPricesT2.AutoSize = true
        Me.chkPricesT2.Enabled = false
        Me.chkPricesT2.Location = New System.Drawing.Point(6, 26)
        Me.chkPricesT2.Name = "chkPricesT2"
        Me.chkPricesT2.Size = New System.Drawing.Size(60, 17)
        Me.chkPricesT2.TabIndex = 1
        Me.chkPricesT2.Text = "Tech 2"
        Me.chkPricesT2.UseVisualStyleBackColor = true
        '
        'chkPricesT1
        '
        Me.chkPricesT1.AutoSize = true
        Me.chkPricesT1.Enabled = false
        Me.chkPricesT1.Location = New System.Drawing.Point(6, 9)
        Me.chkPricesT1.Name = "chkPricesT1"
        Me.chkPricesT1.Size = New System.Drawing.Size(60, 17)
        Me.chkPricesT1.TabIndex = 0
        Me.chkPricesT1.Text = "Tech 1"
        Me.chkPricesT1.UseVisualStyleBackColor = true
        '
        'chkSubsystems
        '
        Me.chkSubsystems.AutoSize = true
        Me.chkSubsystems.Location = New System.Drawing.Point(94, 84)
        Me.chkSubsystems.Name = "chkSubsystems"
        Me.chkSubsystems.Size = New System.Drawing.Size(82, 17)
        Me.chkSubsystems.TabIndex = 10
        Me.chkSubsystems.Text = "Subsystems"
        Me.chkSubsystems.UseVisualStyleBackColor = true
        '
        'chkShips
        '
        Me.chkShips.AutoSize = true
        Me.chkShips.Location = New System.Drawing.Point(10, 19)
        Me.chkShips.Name = "chkShips"
        Me.chkShips.Size = New System.Drawing.Size(52, 17)
        Me.chkShips.TabIndex = 2
        Me.chkShips.Text = "Ships"
        Me.chkShips.UseVisualStyleBackColor = true
        '
        'chkModules
        '
        Me.chkModules.AutoSize = true
        Me.chkModules.Location = New System.Drawing.Point(10, 67)
        Me.chkModules.Name = "chkModules"
        Me.chkModules.Size = New System.Drawing.Size(66, 17)
        Me.chkModules.TabIndex = 6
        Me.chkModules.Text = "Modules"
        Me.chkModules.UseVisualStyleBackColor = true
        '
        'chkRigs
        '
        Me.chkRigs.AutoSize = true
        Me.chkRigs.Location = New System.Drawing.Point(10, 101)
        Me.chkRigs.Name = "chkRigs"
        Me.chkRigs.Size = New System.Drawing.Size(47, 17)
        Me.chkRigs.TabIndex = 8
        Me.chkRigs.Text = "Rigs"
        Me.chkRigs.UseVisualStyleBackColor = true
        '
        'chkDrones
        '
        Me.chkDrones.AutoSize = true
        Me.chkDrones.Location = New System.Drawing.Point(10, 84)
        Me.chkDrones.Name = "chkDrones"
        Me.chkDrones.Size = New System.Drawing.Size(60, 17)
        Me.chkDrones.TabIndex = 7
        Me.chkDrones.Text = "Drones"
        Me.chkDrones.UseVisualStyleBackColor = true
        '
        'gbPrice
        '
        Me.gbPrice.Controls.Add(Me.rbtnPercentileBuySell)
        Me.gbPrice.Controls.Add(Me.rbtnPercentileBuy)
        Me.gbPrice.Controls.Add(Me.rbtnPercentileSell)
        Me.gbPrice.Controls.Add(Me.rbtnMedBuySell)
        Me.gbPrice.Controls.Add(Me.rbtnAvgBuySell)
        Me.gbPrice.Controls.Add(Me.rbtnMaxBuySell)
        Me.gbPrice.Controls.Add(Me.rbtnMinBuySell)
        Me.gbPrice.Controls.Add(Me.rbtnMedBuy)
        Me.gbPrice.Controls.Add(Me.rbtnAvgBuy)
        Me.gbPrice.Controls.Add(Me.rbtnMaxBuy)
        Me.gbPrice.Controls.Add(Me.rbtnMinBuy)
        Me.gbPrice.Controls.Add(Me.rbtnMedSell)
        Me.gbPrice.Controls.Add(Me.rbtnAvgSell)
        Me.gbPrice.Controls.Add(Me.rbtnMaxSell)
        Me.gbPrice.Controls.Add(Me.rbtnMinSell)
        Me.gbPrice.Location = New System.Drawing.Point(704, 480)
        Me.gbPrice.Name = "gbPrice"
        Me.gbPrice.Size = New System.Drawing.Size(329, 95)
        Me.gbPrice.TabIndex = 9
        Me.gbPrice.TabStop = false
        Me.gbPrice.Text = "Price Import Types"
        '
        'rbtnPercentileBuySell
        '
        Me.rbtnPercentileBuySell.AutoSize = true
        Me.rbtnPercentileBuySell.Location = New System.Drawing.Point(207, 75)
        Me.rbtnPercentileBuySell.Name = "rbtnPercentileBuySell"
        Me.rbtnPercentileBuySell.Size = New System.Drawing.Size(122, 17)
        Me.rbtnPercentileBuySell.TabIndex = 14
        Me.rbtnPercentileBuySell.Text = "Percentile Buy && Sell"
        Me.rbtnPercentileBuySell.UseVisualStyleBackColor = true
        '
        'rbtnPercentileBuy
        '
        Me.rbtnPercentileBuy.AutoSize = true
        Me.rbtnPercentileBuy.Location = New System.Drawing.Point(111, 75)
        Me.rbtnPercentileBuy.Name = "rbtnPercentileBuy"
        Me.rbtnPercentileBuy.Size = New System.Drawing.Size(93, 17)
        Me.rbtnPercentileBuy.TabIndex = 9
        Me.rbtnPercentileBuy.Text = "Percentile Buy"
        Me.rbtnPercentileBuy.UseVisualStyleBackColor = true
        '
        'rbtnPercentileSell
        '
        Me.rbtnPercentileSell.AutoSize = true
        Me.rbtnPercentileSell.Location = New System.Drawing.Point(14, 75)
        Me.rbtnPercentileSell.Name = "rbtnPercentileSell"
        Me.rbtnPercentileSell.Size = New System.Drawing.Size(92, 17)
        Me.rbtnPercentileSell.TabIndex = 4
        Me.rbtnPercentileSell.Text = "Percentile Sell"
        Me.rbtnPercentileSell.UseVisualStyleBackColor = true
        '
        'rbtnMedBuySell
        '
        Me.rbtnMedBuySell.AutoSize = true
        Me.rbtnMedBuySell.Location = New System.Drawing.Point(207, 60)
        Me.rbtnMedBuySell.Name = "rbtnMedBuySell"
        Me.rbtnMedBuySell.Size = New System.Drawing.Size(110, 17)
        Me.rbtnMedBuySell.TabIndex = 13
        Me.rbtnMedBuySell.Text = "Median Buy && Sell"
        Me.rbtnMedBuySell.UseVisualStyleBackColor = true
        '
        'rbtnAvgBuySell
        '
        Me.rbtnAvgBuySell.AutoSize = true
        Me.rbtnAvgBuySell.Location = New System.Drawing.Point(207, 45)
        Me.rbtnAvgBuySell.Name = "rbtnAvgBuySell"
        Me.rbtnAvgBuySell.Size = New System.Drawing.Size(115, 17)
        Me.rbtnAvgBuySell.TabIndex = 12
        Me.rbtnAvgBuySell.Text = "Average Buy && Sell"
        Me.rbtnAvgBuySell.UseVisualStyleBackColor = true
        '
        'rbtnMaxBuySell
        '
        Me.rbtnMaxBuySell.AutoSize = true
        Me.rbtnMaxBuySell.Location = New System.Drawing.Point(207, 30)
        Me.rbtnMaxBuySell.Name = "rbtnMaxBuySell"
        Me.rbtnMaxBuySell.Size = New System.Drawing.Size(119, 17)
        Me.rbtnMaxBuySell.TabIndex = 11
        Me.rbtnMaxBuySell.Text = "Maximum Buy && Sell"
        Me.rbtnMaxBuySell.UseVisualStyleBackColor = true
        '
        'rbtnMinBuySell
        '
        Me.rbtnMinBuySell.AutoSize = true
        Me.rbtnMinBuySell.Location = New System.Drawing.Point(207, 15)
        Me.rbtnMinBuySell.Name = "rbtnMinBuySell"
        Me.rbtnMinBuySell.Size = New System.Drawing.Size(116, 17)
        Me.rbtnMinBuySell.TabIndex = 10
        Me.rbtnMinBuySell.Text = "Minimum Buy && Sell"
        Me.rbtnMinBuySell.UseVisualStyleBackColor = true
        '
        'rbtnMedBuy
        '
        Me.rbtnMedBuy.AutoSize = true
        Me.rbtnMedBuy.Location = New System.Drawing.Point(111, 60)
        Me.rbtnMedBuy.Name = "rbtnMedBuy"
        Me.rbtnMedBuy.Size = New System.Drawing.Size(81, 17)
        Me.rbtnMedBuy.TabIndex = 8
        Me.rbtnMedBuy.Text = "Median Buy"
        Me.rbtnMedBuy.UseVisualStyleBackColor = true
        '
        'rbtnAvgBuy
        '
        Me.rbtnAvgBuy.AutoSize = true
        Me.rbtnAvgBuy.Location = New System.Drawing.Point(111, 45)
        Me.rbtnAvgBuy.Name = "rbtnAvgBuy"
        Me.rbtnAvgBuy.Size = New System.Drawing.Size(86, 17)
        Me.rbtnAvgBuy.TabIndex = 7
        Me.rbtnAvgBuy.Text = "Average Buy"
        Me.rbtnAvgBuy.UseVisualStyleBackColor = true
        '
        'rbtnMaxBuy
        '
        Me.rbtnMaxBuy.AutoSize = true
        Me.rbtnMaxBuy.Location = New System.Drawing.Point(111, 30)
        Me.rbtnMaxBuy.Name = "rbtnMaxBuy"
        Me.rbtnMaxBuy.Size = New System.Drawing.Size(90, 17)
        Me.rbtnMaxBuy.TabIndex = 6
        Me.rbtnMaxBuy.Text = "Maximum Buy"
        Me.rbtnMaxBuy.UseVisualStyleBackColor = true
        '
        'rbtnMinBuy
        '
        Me.rbtnMinBuy.AutoSize = true
        Me.rbtnMinBuy.Location = New System.Drawing.Point(111, 15)
        Me.rbtnMinBuy.Name = "rbtnMinBuy"
        Me.rbtnMinBuy.Size = New System.Drawing.Size(87, 17)
        Me.rbtnMinBuy.TabIndex = 5
        Me.rbtnMinBuy.Text = "Minimum Buy"
        Me.rbtnMinBuy.UseVisualStyleBackColor = true
        '
        'rbtnMedSell
        '
        Me.rbtnMedSell.AutoSize = true
        Me.rbtnMedSell.Location = New System.Drawing.Point(14, 60)
        Me.rbtnMedSell.Name = "rbtnMedSell"
        Me.rbtnMedSell.Size = New System.Drawing.Size(80, 17)
        Me.rbtnMedSell.TabIndex = 3
        Me.rbtnMedSell.Text = "Median Sell"
        Me.rbtnMedSell.UseVisualStyleBackColor = true
        '
        'rbtnAvgSell
        '
        Me.rbtnAvgSell.AutoSize = true
        Me.rbtnAvgSell.Location = New System.Drawing.Point(14, 45)
        Me.rbtnAvgSell.Name = "rbtnAvgSell"
        Me.rbtnAvgSell.Size = New System.Drawing.Size(85, 17)
        Me.rbtnAvgSell.TabIndex = 2
        Me.rbtnAvgSell.Text = "Average Sell"
        Me.rbtnAvgSell.UseVisualStyleBackColor = true
        '
        'rbtnMaxSell
        '
        Me.rbtnMaxSell.AutoSize = true
        Me.rbtnMaxSell.Location = New System.Drawing.Point(14, 30)
        Me.rbtnMaxSell.Name = "rbtnMaxSell"
        Me.rbtnMaxSell.Size = New System.Drawing.Size(89, 17)
        Me.rbtnMaxSell.TabIndex = 1
        Me.rbtnMaxSell.Text = "Maximum Sell"
        Me.rbtnMaxSell.UseVisualStyleBackColor = true
        '
        'rbtnMinSell
        '
        Me.rbtnMinSell.AutoSize = true
        Me.rbtnMinSell.Checked = true
        Me.rbtnMinSell.Location = New System.Drawing.Point(14, 15)
        Me.rbtnMinSell.Name = "rbtnMinSell"
        Me.rbtnMinSell.Size = New System.Drawing.Size(86, 17)
        Me.rbtnMinSell.TabIndex = 0
        Me.rbtnMinSell.TabStop = true
        Me.rbtnMinSell.Text = "Minimum Sell"
        Me.rbtnMinSell.UseVisualStyleBackColor = true
        '
        'gbRawMaterials
        '
        Me.gbRawMaterials.Controls.Add(Me.chkMisc)
        Me.gbRawMaterials.Controls.Add(Me.chkAsteroids)
        Me.gbRawMaterials.Controls.Add(Me.chkPriceRawMaterialPrices)
        Me.gbRawMaterials.Controls.Add(Me.chkPlanetary)
        Me.gbRawMaterials.Controls.Add(Me.chkBoosterMats)
        Me.gbRawMaterials.Controls.Add(Me.chkDroneComponents)
        Me.gbRawMaterials.Controls.Add(Me.chkMatsandCompounds)
        Me.gbRawMaterials.Controls.Add(Me.chkAdvancedMats)
        Me.gbRawMaterials.Controls.Add(Me.chkProcessedMats)
        Me.gbRawMaterials.Controls.Add(Me.chkRawMats)
        Me.gbRawMaterials.Controls.Add(Me.chkGas)
        Me.gbRawMaterials.Controls.Add(Me.chkPolymers)
        Me.gbRawMaterials.Controls.Add(Me.chkAncientRelics)
        Me.gbRawMaterials.Controls.Add(Me.chkAncientSalvage)
        Me.gbRawMaterials.Controls.Add(Me.chkSalvage)
        Me.gbRawMaterials.Controls.Add(Me.chkDecryptors)
        Me.gbRawMaterials.Controls.Add(Me.chkDatacores)
        Me.gbRawMaterials.Controls.Add(Me.chkIceProducts)
        Me.gbRawMaterials.Controls.Add(Me.chkMinerals)
        Me.gbRawMaterials.Location = New System.Drawing.Point(8, 337)
        Me.gbRawMaterials.Name = "gbRawMaterials"
        Me.gbRawMaterials.Size = New System.Drawing.Size(257, 238)
        Me.gbRawMaterials.TabIndex = 1
        Me.gbRawMaterials.TabStop = false
        '
        'chkMisc
        '
        Me.chkMisc.AutoSize = true
        Me.chkMisc.Location = New System.Drawing.Point(133, 108)
        Me.chkMisc.Name = "chkMisc"
        Me.chkMisc.Size = New System.Drawing.Size(51, 17)
        Me.chkMisc.TabIndex = 12
        Me.chkMisc.Text = "Misc."
        Me.chkMisc.UseVisualStyleBackColor = true
        '
        'chkAsteroids
        '
        Me.chkAsteroids.AutoSize = true
        Me.chkAsteroids.Location = New System.Drawing.Point(8, 108)
        Me.chkAsteroids.Name = "chkAsteroids"
        Me.chkAsteroids.Size = New System.Drawing.Size(69, 17)
        Me.chkAsteroids.TabIndex = 6
        Me.chkAsteroids.Text = "Asteroids"
        Me.chkAsteroids.UseVisualStyleBackColor = true
        '
        'chkPriceRawMaterialPrices
        '
        Me.chkPriceRawMaterialPrices.AutoSize = true
        Me.chkPriceRawMaterialPrices.BackColor = System.Drawing.Color.White
        Me.chkPriceRawMaterialPrices.Location = New System.Drawing.Point(6, 1)
        Me.chkPriceRawMaterialPrices.Name = "chkPriceRawMaterialPrices"
        Me.chkPriceRawMaterialPrices.Size = New System.Drawing.Size(93, 17)
        Me.chkPriceRawMaterialPrices.TabIndex = 0
        Me.chkPriceRawMaterialPrices.Text = "Raw Materials"
        Me.chkPriceRawMaterialPrices.UseVisualStyleBackColor = false
        '
        'chkPlanetary
        '
        Me.chkPlanetary.AutoSize = true
        Me.chkPlanetary.Location = New System.Drawing.Point(8, 91)
        Me.chkPlanetary.Name = "chkPlanetary"
        Me.chkPlanetary.Size = New System.Drawing.Size(70, 17)
        Me.chkPlanetary.TabIndex = 5
        Me.chkPlanetary.Text = "Planetary"
        Me.chkPlanetary.UseVisualStyleBackColor = true
        '
        'chkBoosterMats
        '
        Me.chkBoosterMats.AutoSize = true
        Me.chkBoosterMats.Location = New System.Drawing.Point(8, 218)
        Me.chkBoosterMats.Name = "chkBoosterMats"
        Me.chkBoosterMats.Size = New System.Drawing.Size(107, 17)
        Me.chkBoosterMats.TabIndex = 18
        Me.chkBoosterMats.Text = "Booster Materials"
        Me.chkBoosterMats.UseVisualStyleBackColor = true
        '
        'chkDroneComponents
        '
        Me.chkDroneComponents.AutoSize = true
        Me.chkDroneComponents.Location = New System.Drawing.Point(8, 201)
        Me.chkDroneComponents.Name = "chkDroneComponents"
        Me.chkDroneComponents.Size = New System.Drawing.Size(152, 17)
        Me.chkDroneComponents.TabIndex = 17
        Me.chkDroneComponents.Text = "Rogue Drone Components"
        Me.chkDroneComponents.UseVisualStyleBackColor = true
        '
        'chkMatsandCompounds
        '
        Me.chkMatsandCompounds.AutoSize = true
        Me.chkMatsandCompounds.Location = New System.Drawing.Point(8, 184)
        Me.chkMatsandCompounds.Name = "chkMatsandCompounds"
        Me.chkMatsandCompounds.Size = New System.Drawing.Size(136, 17)
        Me.chkMatsandCompounds.TabIndex = 16
        Me.chkMatsandCompounds.Text = "Materials && Compounds"
        Me.chkMatsandCompounds.UseVisualStyleBackColor = true
        '
        'chkAdvancedMats
        '
        Me.chkAdvancedMats.AutoSize = true
        Me.chkAdvancedMats.Location = New System.Drawing.Point(8, 162)
        Me.chkAdvancedMats.Name = "chkAdvancedMats"
        Me.chkAdvancedMats.Size = New System.Drawing.Size(150, 17)
        Me.chkAdvancedMats.TabIndex = 15
        Me.chkAdvancedMats.Text = "Advanced Moon Materials"
        Me.chkAdvancedMats.UseVisualStyleBackColor = true
        '
        'chkProcessedMats
        '
        Me.chkProcessedMats.AutoSize = true
        Me.chkProcessedMats.Location = New System.Drawing.Point(8, 145)
        Me.chkProcessedMats.Name = "chkProcessedMats"
        Me.chkProcessedMats.Size = New System.Drawing.Size(151, 17)
        Me.chkProcessedMats.TabIndex = 14
        Me.chkProcessedMats.Text = "Processed Moon Materials"
        Me.chkProcessedMats.UseVisualStyleBackColor = true
        '
        'chkRawMats
        '
        Me.chkRawMats.AutoSize = true
        Me.chkRawMats.Location = New System.Drawing.Point(8, 128)
        Me.chkRawMats.Name = "chkRawMats"
        Me.chkRawMats.Size = New System.Drawing.Size(123, 17)
        Me.chkRawMats.TabIndex = 13
        Me.chkRawMats.Text = "Raw Moon Materials"
        Me.chkRawMats.UseVisualStyleBackColor = true
        '
        'chkGas
        '
        Me.chkGas.AutoSize = true
        Me.chkGas.Location = New System.Drawing.Point(133, 91)
        Me.chkGas.Name = "chkGas"
        Me.chkGas.Size = New System.Drawing.Size(45, 17)
        Me.chkGas.TabIndex = 11
        Me.chkGas.Text = "Gas"
        Me.chkGas.UseVisualStyleBackColor = true
        '
        'chkPolymers
        '
        Me.chkPolymers.AutoSize = true
        Me.chkPolymers.Location = New System.Drawing.Point(133, 74)
        Me.chkPolymers.Name = "chkPolymers"
        Me.chkPolymers.Size = New System.Drawing.Size(101, 17)
        Me.chkPolymers.TabIndex = 10
        Me.chkPolymers.Text = "Hybrid Polymers"
        Me.chkPolymers.UseVisualStyleBackColor = true
        '
        'chkAncientRelics
        '
        Me.chkAncientRelics.AutoSize = true
        Me.chkAncientRelics.Location = New System.Drawing.Point(133, 57)
        Me.chkAncientRelics.Name = "chkAncientRelics"
        Me.chkAncientRelics.Size = New System.Drawing.Size(94, 17)
        Me.chkAncientRelics.TabIndex = 9
        Me.chkAncientRelics.Text = "Ancient Relics"
        Me.chkAncientRelics.UseVisualStyleBackColor = true
        '
        'chkAncientSalvage
        '
        Me.chkAncientSalvage.AutoSize = true
        Me.chkAncientSalvage.Location = New System.Drawing.Point(133, 40)
        Me.chkAncientSalvage.Name = "chkAncientSalvage"
        Me.chkAncientSalvage.Size = New System.Drawing.Size(104, 17)
        Me.chkAncientSalvage.TabIndex = 8
        Me.chkAncientSalvage.Text = "Ancient Salvage"
        Me.chkAncientSalvage.UseVisualStyleBackColor = true
        '
        'chkSalvage
        '
        Me.chkSalvage.AutoSize = true
        Me.chkSalvage.Location = New System.Drawing.Point(133, 23)
        Me.chkSalvage.Name = "chkSalvage"
        Me.chkSalvage.Size = New System.Drawing.Size(65, 17)
        Me.chkSalvage.TabIndex = 7
        Me.chkSalvage.Text = "Salvage"
        Me.chkSalvage.UseVisualStyleBackColor = true
        '
        'chkDecryptors
        '
        Me.chkDecryptors.AutoSize = true
        Me.chkDecryptors.Location = New System.Drawing.Point(8, 74)
        Me.chkDecryptors.Name = "chkDecryptors"
        Me.chkDecryptors.Size = New System.Drawing.Size(77, 17)
        Me.chkDecryptors.TabIndex = 4
        Me.chkDecryptors.Text = "Decryptors"
        Me.chkDecryptors.UseVisualStyleBackColor = true
        '
        'chkDatacores
        '
        Me.chkDatacores.AutoSize = true
        Me.chkDatacores.Location = New System.Drawing.Point(8, 57)
        Me.chkDatacores.Name = "chkDatacores"
        Me.chkDatacores.Size = New System.Drawing.Size(75, 17)
        Me.chkDatacores.TabIndex = 2
        Me.chkDatacores.Text = "Datacores"
        Me.chkDatacores.UseVisualStyleBackColor = true
        '
        'chkIceProducts
        '
        Me.chkIceProducts.AutoSize = true
        Me.chkIceProducts.Location = New System.Drawing.Point(8, 40)
        Me.chkIceProducts.Name = "chkIceProducts"
        Me.chkIceProducts.Size = New System.Drawing.Size(86, 17)
        Me.chkIceProducts.TabIndex = 1
        Me.chkIceProducts.Text = "Ice Products"
        Me.chkIceProducts.UseVisualStyleBackColor = true
        '
        'chkMinerals
        '
        Me.chkMinerals.AutoSize = true
        Me.chkMinerals.Location = New System.Drawing.Point(8, 23)
        Me.chkMinerals.Name = "chkMinerals"
        Me.chkMinerals.Size = New System.Drawing.Size(65, 17)
        Me.chkMinerals.TabIndex = 0
        Me.chkMinerals.Text = "Minerals"
        Me.chkMinerals.UseVisualStyleBackColor = true
        '
        'gbRegions
        '
        Me.gbRegions.Controls.Add(Me.chkRegion67)
        Me.gbRegions.Controls.Add(Me.chkRegion45)
        Me.gbRegions.Controls.Add(Me.chkRegion46)
        Me.gbRegions.Controls.Add(Me.chkRegion47)
        Me.gbRegions.Controls.Add(Me.chkRegion48)
        Me.gbRegions.Controls.Add(Me.chkRegion49)
        Me.gbRegions.Controls.Add(Me.chkRegion50)
        Me.gbRegions.Controls.Add(Me.chkRegion51)
        Me.gbRegions.Controls.Add(Me.chkRegion52)
        Me.gbRegions.Controls.Add(Me.chkRegion53)
        Me.gbRegions.Controls.Add(Me.chkRegion54)
        Me.gbRegions.Controls.Add(Me.chkRegion55)
        Me.gbRegions.Controls.Add(Me.chkRegion56)
        Me.gbRegions.Controls.Add(Me.chkRegion57)
        Me.gbRegions.Controls.Add(Me.chkRegion58)
        Me.gbRegions.Controls.Add(Me.chkRegion59)
        Me.gbRegions.Controls.Add(Me.chkRegion60)
        Me.gbRegions.Controls.Add(Me.chkRegion61)
        Me.gbRegions.Controls.Add(Me.chkRegion62)
        Me.gbRegions.Controls.Add(Me.chkRegion63)
        Me.gbRegions.Controls.Add(Me.chkRegion64)
        Me.gbRegions.Controls.Add(Me.chkRegion65)
        Me.gbRegions.Controls.Add(Me.chkRegion66)
        Me.gbRegions.Controls.Add(Me.chkRegion23)
        Me.gbRegions.Controls.Add(Me.chkRegion24)
        Me.gbRegions.Controls.Add(Me.chkRegion25)
        Me.gbRegions.Controls.Add(Me.chkRegion26)
        Me.gbRegions.Controls.Add(Me.chkRegion27)
        Me.gbRegions.Controls.Add(Me.chkRegion28)
        Me.gbRegions.Controls.Add(Me.chkRegion29)
        Me.gbRegions.Controls.Add(Me.chkRegion30)
        Me.gbRegions.Controls.Add(Me.chkRegion31)
        Me.gbRegions.Controls.Add(Me.chkRegion32)
        Me.gbRegions.Controls.Add(Me.chkRegion33)
        Me.gbRegions.Controls.Add(Me.chkRegion34)
        Me.gbRegions.Controls.Add(Me.chkRegion35)
        Me.gbRegions.Controls.Add(Me.chkRegion36)
        Me.gbRegions.Controls.Add(Me.chkRegion37)
        Me.gbRegions.Controls.Add(Me.chkRegion38)
        Me.gbRegions.Controls.Add(Me.chkRegion39)
        Me.gbRegions.Controls.Add(Me.chkRegion40)
        Me.gbRegions.Controls.Add(Me.chkRegion41)
        Me.gbRegions.Controls.Add(Me.chkRegion42)
        Me.gbRegions.Controls.Add(Me.chkRegion43)
        Me.gbRegions.Controls.Add(Me.chkRegion44)
        Me.gbRegions.Controls.Add(Me.chkRegion12)
        Me.gbRegions.Controls.Add(Me.chkRegion13)
        Me.gbRegions.Controls.Add(Me.chkRegion14)
        Me.gbRegions.Controls.Add(Me.chkRegion15)
        Me.gbRegions.Controls.Add(Me.chkRegion16)
        Me.gbRegions.Controls.Add(Me.chkRegion17)
        Me.gbRegions.Controls.Add(Me.chkRegion18)
        Me.gbRegions.Controls.Add(Me.chkRegion19)
        Me.gbRegions.Controls.Add(Me.chkRegion20)
        Me.gbRegions.Controls.Add(Me.chkRegion21)
        Me.gbRegions.Controls.Add(Me.chkRegion22)
        Me.gbRegions.Controls.Add(Me.chkRegion11)
        Me.gbRegions.Controls.Add(Me.chkRegion10)
        Me.gbRegions.Controls.Add(Me.chkRegion9)
        Me.gbRegions.Controls.Add(Me.chkRegion8)
        Me.gbRegions.Controls.Add(Me.chkRegion7)
        Me.gbRegions.Controls.Add(Me.chkRegion6)
        Me.gbRegions.Controls.Add(Me.chkRegion5)
        Me.gbRegions.Controls.Add(Me.chkRegion4)
        Me.gbRegions.Controls.Add(Me.chkRegion3)
        Me.gbRegions.Controls.Add(Me.chkRegion2)
        Me.gbRegions.Controls.Add(Me.chkRegion1)
        Me.gbRegions.Controls.Add(Me.btnCheckNullLowRegions)
        Me.gbRegions.Controls.Add(Me.btnCheckEmpireRegions)
        Me.gbRegions.Controls.Add(Me.btnCheckNoRegions)
        Me.gbRegions.Controls.Add(Me.btnCheckAllRegions)
        Me.gbRegions.Location = New System.Drawing.Point(704, 3)
        Me.gbRegions.Name = "gbRegions"
        Me.gbRegions.Size = New System.Drawing.Size(425, 420)
        Me.gbRegions.TabIndex = 7
        Me.gbRegions.TabStop = false
        Me.gbRegions.Text = "Regions"
        '
        'chkRegion67
        '
        Me.chkRegion67.AutoSize = true
        Me.chkRegion67.Location = New System.Drawing.Point(294, 396)
        Me.chkRegion67.Name = "chkRegion67"
        Me.chkRegion67.Size = New System.Drawing.Size(94, 17)
        Me.chkRegion67.TabIndex = 70
        Me.chkRegion67.Text = "Wicked Creek"
        Me.chkRegion67.UseVisualStyleBackColor = true
        '
        'chkRegion45
        '
        Me.chkRegion45.AutoSize = true
        Me.chkRegion45.Location = New System.Drawing.Point(294, 22)
        Me.chkRegion45.Name = "chkRegion45"
        Me.chkRegion45.Size = New System.Drawing.Size(55, 17)
        Me.chkRegion45.TabIndex = 48
        Me.chkRegion45.Text = "Placid"
        Me.chkRegion45.UseVisualStyleBackColor = true
        '
        'chkRegion46
        '
        Me.chkRegion46.AutoSize = true
        Me.chkRegion46.Location = New System.Drawing.Point(294, 39)
        Me.chkRegion46.Name = "chkRegion46"
        Me.chkRegion46.Size = New System.Drawing.Size(80, 17)
        Me.chkRegion46.TabIndex = 49
        Me.chkRegion46.Text = "Providence"
        Me.chkRegion46.UseVisualStyleBackColor = true
        '
        'chkRegion47
        '
        Me.chkRegion47.AutoSize = true
        Me.chkRegion47.Location = New System.Drawing.Point(294, 56)
        Me.chkRegion47.Name = "chkRegion47"
        Me.chkRegion47.Size = New System.Drawing.Size(74, 17)
        Me.chkRegion47.TabIndex = 50
        Me.chkRegion47.Text = "Pure Blind"
        Me.chkRegion47.UseVisualStyleBackColor = true
        '
        'chkRegion48
        '
        Me.chkRegion48.AutoSize = true
        Me.chkRegion48.Location = New System.Drawing.Point(294, 73)
        Me.chkRegion48.Name = "chkRegion48"
        Me.chkRegion48.Size = New System.Drawing.Size(68, 17)
        Me.chkRegion48.TabIndex = 51
        Me.chkRegion48.Text = "Querious"
        Me.chkRegion48.UseVisualStyleBackColor = true
        '
        'chkRegion49
        '
        Me.chkRegion49.AutoSize = true
        Me.chkRegion49.Location = New System.Drawing.Point(294, 90)
        Me.chkRegion49.Name = "chkRegion49"
        Me.chkRegion49.Size = New System.Drawing.Size(93, 17)
        Me.chkRegion49.TabIndex = 52
        Me.chkRegion49.Text = "Scalding Pass"
        Me.chkRegion49.UseVisualStyleBackColor = true
        '
        'chkRegion50
        '
        Me.chkRegion50.AutoSize = true
        Me.chkRegion50.Location = New System.Drawing.Point(294, 107)
        Me.chkRegion50.Name = "chkRegion50"
        Me.chkRegion50.Size = New System.Drawing.Size(125, 17)
        Me.chkRegion50.TabIndex = 53
        Me.chkRegion50.Text = "Sinq Laison (Dodixie)"
        Me.chkRegion50.UseVisualStyleBackColor = true
        '
        'chkRegion51
        '
        Me.chkRegion51.AutoSize = true
        Me.chkRegion51.Location = New System.Drawing.Point(294, 124)
        Me.chkRegion51.Name = "chkRegion51"
        Me.chkRegion51.Size = New System.Drawing.Size(64, 17)
        Me.chkRegion51.TabIndex = 54
        Me.chkRegion51.Text = "Solitude"
        Me.chkRegion51.UseVisualStyleBackColor = true
        '
        'chkRegion52
        '
        Me.chkRegion52.AutoSize = true
        Me.chkRegion52.Location = New System.Drawing.Point(294, 141)
        Me.chkRegion52.Name = "chkRegion52"
        Me.chkRegion52.Size = New System.Drawing.Size(50, 17)
        Me.chkRegion52.TabIndex = 55
        Me.chkRegion52.Text = "Stain"
        Me.chkRegion52.UseVisualStyleBackColor = true
        '
        'chkRegion53
        '
        Me.chkRegion53.AutoSize = true
        Me.chkRegion53.Location = New System.Drawing.Point(294, 158)
        Me.chkRegion53.Name = "chkRegion53"
        Me.chkRegion53.Size = New System.Drawing.Size(73, 17)
        Me.chkRegion53.TabIndex = 56
        Me.chkRegion53.Text = "Syndicate"
        Me.chkRegion53.UseVisualStyleBackColor = true
        '
        'chkRegion54
        '
        Me.chkRegion54.AutoSize = true
        Me.chkRegion54.Location = New System.Drawing.Point(294, 175)
        Me.chkRegion54.Name = "chkRegion54"
        Me.chkRegion54.Size = New System.Drawing.Size(89, 17)
        Me.chkRegion54.TabIndex = 57
        Me.chkRegion54.Text = "Tash-Murkon"
        Me.chkRegion54.UseVisualStyleBackColor = true
        '
        'chkRegion55
        '
        Me.chkRegion55.AutoSize = true
        Me.chkRegion55.Location = New System.Drawing.Point(294, 192)
        Me.chkRegion55.Name = "chkRegion55"
        Me.chkRegion55.Size = New System.Drawing.Size(53, 17)
        Me.chkRegion55.TabIndex = 58
        Me.chkRegion55.Text = "Tenal"
        Me.chkRegion55.UseVisualStyleBackColor = true
        '
        'chkRegion56
        '
        Me.chkRegion56.AutoSize = true
        Me.chkRegion56.Location = New System.Drawing.Point(294, 209)
        Me.chkRegion56.Name = "chkRegion56"
        Me.chkRegion56.Size = New System.Drawing.Size(66, 17)
        Me.chkRegion56.TabIndex = 59
        Me.chkRegion56.Text = "Tenerifis"
        Me.chkRegion56.UseVisualStyleBackColor = true
        '
        'chkRegion57
        '
        Me.chkRegion57.AutoSize = true
        Me.chkRegion57.Location = New System.Drawing.Point(294, 226)
        Me.chkRegion57.Name = "chkRegion57"
        Me.chkRegion57.Size = New System.Drawing.Size(107, 17)
        Me.chkRegion57.TabIndex = 60
        Me.chkRegion57.Text = "The Bleak Lands"
        Me.chkRegion57.UseVisualStyleBackColor = true
        '
        'chkRegion58
        '
        Me.chkRegion58.AutoSize = true
        Me.chkRegion58.Location = New System.Drawing.Point(294, 243)
        Me.chkRegion58.Name = "chkRegion58"
        Me.chkRegion58.Size = New System.Drawing.Size(80, 17)
        Me.chkRegion58.TabIndex = 61
        Me.chkRegion58.Text = "The Citadel"
        Me.chkRegion58.UseVisualStyleBackColor = true
        '
        'chkRegion59
        '
        Me.chkRegion59.AutoSize = true
        Me.chkRegion59.Location = New System.Drawing.Point(294, 260)
        Me.chkRegion59.Name = "chkRegion59"
        Me.chkRegion59.Size = New System.Drawing.Size(100, 17)
        Me.chkRegion59.TabIndex = 62
        Me.chkRegion59.Text = "The Forge (Jita)"
        Me.chkRegion59.UseVisualStyleBackColor = true
        '
        'chkRegion60
        '
        Me.chkRegion60.AutoSize = true
        Me.chkRegion60.Location = New System.Drawing.Point(294, 277)
        Me.chkRegion60.Name = "chkRegion60"
        Me.chkRegion60.Size = New System.Drawing.Size(133, 17)
        Me.chkRegion60.TabIndex = 63
        Me.chkRegion60.Text = "The Kalevala Expanse"
        Me.chkRegion60.UseVisualStyleBackColor = true
        '
        'chkRegion61
        '
        Me.chkRegion61.AutoSize = true
        Me.chkRegion61.Location = New System.Drawing.Point(294, 294)
        Me.chkRegion61.Name = "chkRegion61"
        Me.chkRegion61.Size = New System.Drawing.Size(72, 17)
        Me.chkRegion61.TabIndex = 64
        Me.chkRegion61.Text = "The Spire"
        Me.chkRegion61.UseVisualStyleBackColor = true
        '
        'chkRegion62
        '
        Me.chkRegion62.AutoSize = true
        Me.chkRegion62.Location = New System.Drawing.Point(294, 311)
        Me.chkRegion62.Name = "chkRegion62"
        Me.chkRegion62.Size = New System.Drawing.Size(59, 17)
        Me.chkRegion62.TabIndex = 65
        Me.chkRegion62.Text = "Tribute"
        Me.chkRegion62.UseVisualStyleBackColor = true
        '
        'chkRegion63
        '
        Me.chkRegion63.AutoSize = true
        Me.chkRegion63.Location = New System.Drawing.Point(294, 328)
        Me.chkRegion63.Name = "chkRegion63"
        Me.chkRegion63.Size = New System.Drawing.Size(64, 17)
        Me.chkRegion63.TabIndex = 66
        Me.chkRegion63.Text = "UUA-F4"
        Me.chkRegion63.UseVisualStyleBackColor = true
        '
        'chkRegion64
        '
        Me.chkRegion64.AutoSize = true
        Me.chkRegion64.Location = New System.Drawing.Point(294, 345)
        Me.chkRegion64.Name = "chkRegion64"
        Me.chkRegion64.Size = New System.Drawing.Size(106, 17)
        Me.chkRegion64.TabIndex = 67
        Me.chkRegion64.Text = "Vale of the Silent"
        Me.chkRegion64.UseVisualStyleBackColor = true
        '
        'chkRegion65
        '
        Me.chkRegion65.AutoSize = true
        Me.chkRegion65.Location = New System.Drawing.Point(294, 362)
        Me.chkRegion65.Name = "chkRegion65"
        Me.chkRegion65.Size = New System.Drawing.Size(53, 17)
        Me.chkRegion65.TabIndex = 68
        Me.chkRegion65.Text = "Venal"
        Me.chkRegion65.UseVisualStyleBackColor = true
        '
        'chkRegion66
        '
        Me.chkRegion66.AutoSize = true
        Me.chkRegion66.Location = New System.Drawing.Point(294, 379)
        Me.chkRegion66.Name = "chkRegion66"
        Me.chkRegion66.Size = New System.Drawing.Size(91, 17)
        Me.chkRegion66.TabIndex = 69
        Me.chkRegion66.Text = "Verge Vendor"
        Me.chkRegion66.UseVisualStyleBackColor = true
        '
        'chkRegion23
        '
        Me.chkRegion23.AutoSize = true
        Me.chkRegion23.Location = New System.Drawing.Point(159, 39)
        Me.chkRegion23.Name = "chkRegion23"
        Me.chkRegion23.Size = New System.Drawing.Size(71, 17)
        Me.chkRegion23.TabIndex = 26
        Me.chkRegion23.Text = "Geminate"
        Me.chkRegion23.UseVisualStyleBackColor = true
        '
        'chkRegion24
        '
        Me.chkRegion24.AutoSize = true
        Me.chkRegion24.Location = New System.Drawing.Point(159, 56)
        Me.chkRegion24.Name = "chkRegion24"
        Me.chkRegion24.Size = New System.Drawing.Size(64, 17)
        Me.chkRegion24.TabIndex = 27
        Me.chkRegion24.Text = "Genesis"
        Me.chkRegion24.UseVisualStyleBackColor = true
        '
        'chkRegion25
        '
        Me.chkRegion25.AutoSize = true
        Me.chkRegion25.Location = New System.Drawing.Point(159, 73)
        Me.chkRegion25.Name = "chkRegion25"
        Me.chkRegion25.Size = New System.Drawing.Size(101, 17)
        Me.chkRegion25.TabIndex = 28
        Me.chkRegion25.Text = "Great Wildlands"
        Me.chkRegion25.UseVisualStyleBackColor = true
        '
        'chkRegion26
        '
        Me.chkRegion26.AutoSize = true
        Me.chkRegion26.Location = New System.Drawing.Point(159, 90)
        Me.chkRegion26.Name = "chkRegion26"
        Me.chkRegion26.Size = New System.Drawing.Size(102, 17)
        Me.chkRegion26.TabIndex = 29
        Me.chkRegion26.Text = "Heimatar (Rens)"
        Me.chkRegion26.UseVisualStyleBackColor = true
        '
        'chkRegion27
        '
        Me.chkRegion27.AutoSize = true
        Me.chkRegion27.Location = New System.Drawing.Point(159, 107)
        Me.chkRegion27.Name = "chkRegion27"
        Me.chkRegion27.Size = New System.Drawing.Size(74, 17)
        Me.chkRegion27.TabIndex = 30
        Me.chkRegion27.Text = "Immensea"
        Me.chkRegion27.UseVisualStyleBackColor = true
        '
        'chkRegion28
        '
        Me.chkRegion28.AutoSize = true
        Me.chkRegion28.Location = New System.Drawing.Point(159, 124)
        Me.chkRegion28.Name = "chkRegion28"
        Me.chkRegion28.Size = New System.Drawing.Size(59, 17)
        Me.chkRegion28.TabIndex = 31
        Me.chkRegion28.Text = "Impass"
        Me.chkRegion28.UseVisualStyleBackColor = true
        '
        'chkRegion29
        '
        Me.chkRegion29.AutoSize = true
        Me.chkRegion29.Location = New System.Drawing.Point(159, 141)
        Me.chkRegion29.Name = "chkRegion29"
        Me.chkRegion29.Size = New System.Drawing.Size(72, 17)
        Me.chkRegion29.TabIndex = 32
        Me.chkRegion29.Text = "Insmother"
        Me.chkRegion29.UseVisualStyleBackColor = true
        '
        'chkRegion30
        '
        Me.chkRegion30.AutoSize = true
        Me.chkRegion30.Location = New System.Drawing.Point(159, 158)
        Me.chkRegion30.Name = "chkRegion30"
        Me.chkRegion30.Size = New System.Drawing.Size(61, 17)
        Me.chkRegion30.TabIndex = 33
        Me.chkRegion30.Text = "J7HZ-F"
        Me.chkRegion30.UseVisualStyleBackColor = true
        '
        'chkRegion31
        '
        Me.chkRegion31.AutoSize = true
        Me.chkRegion31.Location = New System.Drawing.Point(159, 175)
        Me.chkRegion31.Name = "chkRegion31"
        Me.chkRegion31.Size = New System.Drawing.Size(54, 17)
        Me.chkRegion31.TabIndex = 34
        Me.chkRegion31.Text = "Kador"
        Me.chkRegion31.UseVisualStyleBackColor = true
        '
        'chkRegion32
        '
        Me.chkRegion32.AutoSize = true
        Me.chkRegion32.Location = New System.Drawing.Point(159, 192)
        Me.chkRegion32.Name = "chkRegion32"
        Me.chkRegion32.Size = New System.Drawing.Size(59, 17)
        Me.chkRegion32.TabIndex = 35
        Me.chkRegion32.Text = "Khanid"
        Me.chkRegion32.UseVisualStyleBackColor = true
        '
        'chkRegion33
        '
        Me.chkRegion33.AutoSize = true
        Me.chkRegion33.Location = New System.Drawing.Point(159, 209)
        Me.chkRegion33.Name = "chkRegion33"
        Me.chkRegion33.Size = New System.Drawing.Size(66, 17)
        Me.chkRegion33.TabIndex = 36
        Me.chkRegion33.Text = "Kor-Azor"
        Me.chkRegion33.UseVisualStyleBackColor = true
        '
        'chkRegion34
        '
        Me.chkRegion34.AutoSize = true
        Me.chkRegion34.Location = New System.Drawing.Point(159, 226)
        Me.chkRegion34.Name = "chkRegion34"
        Me.chkRegion34.Size = New System.Drawing.Size(68, 17)
        Me.chkRegion34.TabIndex = 37
        Me.chkRegion34.Text = "Lonetrek"
        Me.chkRegion34.UseVisualStyleBackColor = true
        '
        'chkRegion35
        '
        Me.chkRegion35.AutoSize = true
        Me.chkRegion35.Location = New System.Drawing.Point(159, 243)
        Me.chkRegion35.Name = "chkRegion35"
        Me.chkRegion35.Size = New System.Drawing.Size(62, 17)
        Me.chkRegion35.TabIndex = 38
        Me.chkRegion35.Text = "Malpais"
        Me.chkRegion35.UseVisualStyleBackColor = true
        '
        'chkRegion36
        '
        Me.chkRegion36.AutoSize = true
        Me.chkRegion36.Location = New System.Drawing.Point(159, 260)
        Me.chkRegion36.Name = "chkRegion36"
        Me.chkRegion36.Size = New System.Drawing.Size(103, 17)
        Me.chkRegion36.TabIndex = 39
        Me.chkRegion36.Text = "Metropolis (Hek)"
        Me.chkRegion36.UseVisualStyleBackColor = true
        '
        'chkRegion37
        '
        Me.chkRegion37.AutoSize = true
        Me.chkRegion37.Location = New System.Drawing.Point(159, 277)
        Me.chkRegion37.Name = "chkRegion37"
        Me.chkRegion37.Size = New System.Drawing.Size(93, 17)
        Me.chkRegion37.TabIndex = 40
        Me.chkRegion37.Text = "Molden Heath"
        Me.chkRegion37.UseVisualStyleBackColor = true
        '
        'chkRegion38
        '
        Me.chkRegion38.AutoSize = true
        Me.chkRegion38.Location = New System.Drawing.Point(159, 294)
        Me.chkRegion38.Name = "chkRegion38"
        Me.chkRegion38.Size = New System.Drawing.Size(51, 17)
        Me.chkRegion38.TabIndex = 41
        Me.chkRegion38.Text = "Oasa"
        Me.chkRegion38.UseVisualStyleBackColor = true
        '
        'chkRegion39
        '
        Me.chkRegion39.AutoSize = true
        Me.chkRegion39.Location = New System.Drawing.Point(159, 311)
        Me.chkRegion39.Name = "chkRegion39"
        Me.chkRegion39.Size = New System.Drawing.Size(52, 17)
        Me.chkRegion39.TabIndex = 42
        Me.chkRegion39.Text = "Omist"
        Me.chkRegion39.UseVisualStyleBackColor = true
        '
        'chkRegion40
        '
        Me.chkRegion40.AutoSize = true
        Me.chkRegion40.Location = New System.Drawing.Point(159, 328)
        Me.chkRegion40.Name = "chkRegion40"
        Me.chkRegion40.Size = New System.Drawing.Size(96, 17)
        Me.chkRegion40.TabIndex = 43
        Me.chkRegion40.Text = "Outer Passage"
        Me.chkRegion40.UseVisualStyleBackColor = true
        '
        'chkRegion41
        '
        Me.chkRegion41.AutoSize = true
        Me.chkRegion41.Location = New System.Drawing.Point(159, 345)
        Me.chkRegion41.Name = "chkRegion41"
        Me.chkRegion41.Size = New System.Drawing.Size(77, 17)
        Me.chkRegion41.TabIndex = 44
        Me.chkRegion41.Text = "Outer Ring"
        Me.chkRegion41.UseVisualStyleBackColor = true
        '
        'chkRegion42
        '
        Me.chkRegion42.AutoSize = true
        Me.chkRegion42.Location = New System.Drawing.Point(159, 362)
        Me.chkRegion42.Name = "chkRegion42"
        Me.chkRegion42.Size = New System.Drawing.Size(90, 17)
        Me.chkRegion42.TabIndex = 45
        Me.chkRegion42.Text = "Paragon Soul"
        Me.chkRegion42.UseVisualStyleBackColor = true
        '
        'chkRegion43
        '
        Me.chkRegion43.AutoSize = true
        Me.chkRegion43.Location = New System.Drawing.Point(159, 379)
        Me.chkRegion43.Name = "chkRegion43"
        Me.chkRegion43.Size = New System.Drawing.Size(84, 17)
        Me.chkRegion43.TabIndex = 46
        Me.chkRegion43.Text = "Period Basis"
        Me.chkRegion43.UseVisualStyleBackColor = true
        '
        'chkRegion44
        '
        Me.chkRegion44.AutoSize = true
        Me.chkRegion44.Location = New System.Drawing.Point(159, 396)
        Me.chkRegion44.Name = "chkRegion44"
        Me.chkRegion44.Size = New System.Drawing.Size(89, 17)
        Me.chkRegion44.TabIndex = 47
        Me.chkRegion44.Text = "Perrigen Falls"
        Me.chkRegion44.UseVisualStyleBackColor = true
        '
        'chkRegion12
        '
        Me.chkRegion12.AutoSize = true
        Me.chkRegion12.Location = New System.Drawing.Point(14, 226)
        Me.chkRegion12.Name = "chkRegion12"
        Me.chkRegion12.Size = New System.Drawing.Size(59, 17)
        Me.chkRegion12.TabIndex = 15
        Me.chkRegion12.Text = "Derelik"
        Me.chkRegion12.UseVisualStyleBackColor = true
        '
        'chkRegion13
        '
        Me.chkRegion13.AutoSize = true
        Me.chkRegion13.Location = New System.Drawing.Point(14, 243)
        Me.chkRegion13.Name = "chkRegion13"
        Me.chkRegion13.Size = New System.Drawing.Size(60, 17)
        Me.chkRegion13.TabIndex = 16
        Me.chkRegion13.Text = "Detorid"
        Me.chkRegion13.UseVisualStyleBackColor = true
        '
        'chkRegion14
        '
        Me.chkRegion14.AutoSize = true
        Me.chkRegion14.Location = New System.Drawing.Point(14, 260)
        Me.chkRegion14.Name = "chkRegion14"
        Me.chkRegion14.Size = New System.Drawing.Size(60, 17)
        Me.chkRegion14.TabIndex = 17
        Me.chkRegion14.Text = "Devoid"
        Me.chkRegion14.UseVisualStyleBackColor = true
        '
        'chkRegion15
        '
        Me.chkRegion15.AutoSize = true
        Me.chkRegion15.Location = New System.Drawing.Point(14, 277)
        Me.chkRegion15.Name = "chkRegion15"
        Me.chkRegion15.Size = New System.Drawing.Size(98, 17)
        Me.chkRegion15.TabIndex = 18
        Me.chkRegion15.Text = "Domain (Amarr)"
        Me.chkRegion15.UseVisualStyleBackColor = true
        '
        'chkRegion16
        '
        Me.chkRegion16.AutoSize = true
        Me.chkRegion16.Location = New System.Drawing.Point(14, 294)
        Me.chkRegion16.Name = "chkRegion16"
        Me.chkRegion16.Size = New System.Drawing.Size(64, 17)
        Me.chkRegion16.TabIndex = 19
        Me.chkRegion16.Text = "Esoteria"
        Me.chkRegion16.UseVisualStyleBackColor = true
        '
        'chkRegion17
        '
        Me.chkRegion17.AutoSize = true
        Me.chkRegion17.Location = New System.Drawing.Point(14, 311)
        Me.chkRegion17.Name = "chkRegion17"
        Me.chkRegion17.Size = New System.Drawing.Size(67, 17)
        Me.chkRegion17.TabIndex = 20
        Me.chkRegion17.Text = "Essence"
        Me.chkRegion17.UseVisualStyleBackColor = true
        '
        'chkRegion18
        '
        Me.chkRegion18.AutoSize = true
        Me.chkRegion18.Location = New System.Drawing.Point(14, 328)
        Me.chkRegion18.Name = "chkRegion18"
        Me.chkRegion18.Size = New System.Drawing.Size(102, 17)
        Me.chkRegion18.TabIndex = 21
        Me.chkRegion18.Text = "Etherium Reach"
        Me.chkRegion18.UseVisualStyleBackColor = true
        '
        'chkRegion19
        '
        Me.chkRegion19.AutoSize = true
        Me.chkRegion19.Location = New System.Drawing.Point(14, 345)
        Me.chkRegion19.Name = "chkRegion19"
        Me.chkRegion19.Size = New System.Drawing.Size(79, 17)
        Me.chkRegion19.TabIndex = 22
        Me.chkRegion19.Text = "Everyshore"
        Me.chkRegion19.UseVisualStyleBackColor = true
        '
        'chkRegion20
        '
        Me.chkRegion20.AutoSize = true
        Me.chkRegion20.Location = New System.Drawing.Point(14, 362)
        Me.chkRegion20.Name = "chkRegion20"
        Me.chkRegion20.Size = New System.Drawing.Size(50, 17)
        Me.chkRegion20.TabIndex = 23
        Me.chkRegion20.Text = "Fade"
        Me.chkRegion20.UseVisualStyleBackColor = true
        '
        'chkRegion21
        '
        Me.chkRegion21.AutoSize = true
        Me.chkRegion21.Location = New System.Drawing.Point(14, 379)
        Me.chkRegion21.Name = "chkRegion21"
        Me.chkRegion21.Size = New System.Drawing.Size(79, 17)
        Me.chkRegion21.TabIndex = 24
        Me.chkRegion21.Text = "Feythabolis"
        Me.chkRegion21.UseVisualStyleBackColor = true
        '
        'chkRegion22
        '
        Me.chkRegion22.AutoSize = true
        Me.chkRegion22.Location = New System.Drawing.Point(14, 396)
        Me.chkRegion22.Name = "chkRegion22"
        Me.chkRegion22.Size = New System.Drawing.Size(67, 17)
        Me.chkRegion22.TabIndex = 25
        Me.chkRegion22.Text = "Fountain"
        Me.chkRegion22.UseVisualStyleBackColor = true
        '
        'chkRegion11
        '
        Me.chkRegion11.AutoSize = true
        Me.chkRegion11.Location = New System.Drawing.Point(14, 209)
        Me.chkRegion11.Name = "chkRegion11"
        Me.chkRegion11.Size = New System.Drawing.Size(54, 17)
        Me.chkRegion11.TabIndex = 14
        Me.chkRegion11.Text = "Delve"
        Me.chkRegion11.UseVisualStyleBackColor = true
        '
        'chkRegion10
        '
        Me.chkRegion10.AutoSize = true
        Me.chkRegion10.Location = New System.Drawing.Point(14, 192)
        Me.chkRegion10.Name = "chkRegion10"
        Me.chkRegion10.Size = New System.Drawing.Size(62, 17)
        Me.chkRegion10.TabIndex = 13
        Me.chkRegion10.Text = "Deklein"
        Me.chkRegion10.UseVisualStyleBackColor = true
        '
        'chkRegion9
        '
        Me.chkRegion9.AutoSize = true
        Me.chkRegion9.Location = New System.Drawing.Point(14, 175)
        Me.chkRegion9.Name = "chkRegion9"
        Me.chkRegion9.Size = New System.Drawing.Size(53, 17)
        Me.chkRegion9.TabIndex = 12
        Me.chkRegion9.Text = "Curse"
        Me.chkRegion9.UseVisualStyleBackColor = true
        '
        'chkRegion8
        '
        Me.chkRegion8.AutoSize = true
        Me.chkRegion8.Location = New System.Drawing.Point(14, 158)
        Me.chkRegion8.Name = "chkRegion8"
        Me.chkRegion8.Size = New System.Drawing.Size(84, 17)
        Me.chkRegion8.TabIndex = 11
        Me.chkRegion8.Text = "Cobalt Edge"
        Me.chkRegion8.UseVisualStyleBackColor = true
        '
        'chkRegion7
        '
        Me.chkRegion7.AutoSize = true
        Me.chkRegion7.Location = New System.Drawing.Point(14, 141)
        Me.chkRegion7.Name = "chkRegion7"
        Me.chkRegion7.Size = New System.Drawing.Size(78, 17)
        Me.chkRegion7.TabIndex = 10
        Me.chkRegion7.Text = "Cloud Ring"
        Me.chkRegion7.UseVisualStyleBackColor = true
        '
        'chkRegion6
        '
        Me.chkRegion6.AutoSize = true
        Me.chkRegion6.Location = New System.Drawing.Point(14, 124)
        Me.chkRegion6.Name = "chkRegion6"
        Me.chkRegion6.Size = New System.Drawing.Size(54, 17)
        Me.chkRegion6.TabIndex = 9
        Me.chkRegion6.Text = "Catch"
        Me.chkRegion6.UseVisualStyleBackColor = true
        '
        'chkRegion5
        '
        Me.chkRegion5.AutoSize = true
        Me.chkRegion5.Location = New System.Drawing.Point(14, 107)
        Me.chkRegion5.Name = "chkRegion5"
        Me.chkRegion5.Size = New System.Drawing.Size(57, 17)
        Me.chkRegion5.TabIndex = 8
        Me.chkRegion5.Text = "Cache"
        Me.chkRegion5.UseVisualStyleBackColor = true
        '
        'chkRegion4
        '
        Me.chkRegion4.AutoSize = true
        Me.chkRegion4.Location = New System.Drawing.Point(14, 90)
        Me.chkRegion4.Name = "chkRegion4"
        Me.chkRegion4.Size = New System.Drawing.Size(60, 17)
        Me.chkRegion4.TabIndex = 7
        Me.chkRegion4.Text = "Branch"
        Me.chkRegion4.UseVisualStyleBackColor = true
        '
        'chkRegion3
        '
        Me.chkRegion3.AutoSize = true
        Me.chkRegion3.Location = New System.Drawing.Point(14, 73)
        Me.chkRegion3.Name = "chkRegion3"
        Me.chkRegion3.Size = New System.Drawing.Size(77, 17)
        Me.chkRegion3.TabIndex = 6
        Me.chkRegion3.Text = "Black Rise"
        Me.chkRegion3.UseVisualStyleBackColor = true
        '
        'chkRegion2
        '
        Me.chkRegion2.AutoSize = true
        Me.chkRegion2.Location = New System.Drawing.Point(14, 56)
        Me.chkRegion2.Name = "chkRegion2"
        Me.chkRegion2.Size = New System.Drawing.Size(52, 17)
        Me.chkRegion2.TabIndex = 5
        Me.chkRegion2.Text = "Aridia"
        Me.chkRegion2.UseVisualStyleBackColor = true
        '
        'chkRegion1
        '
        Me.chkRegion1.AutoSize = true
        Me.chkRegion1.Location = New System.Drawing.Point(14, 39)
        Me.chkRegion1.Name = "chkRegion1"
        Me.chkRegion1.Size = New System.Drawing.Size(61, 17)
        Me.chkRegion1.TabIndex = 4
        Me.chkRegion1.Text = "A821-A"
        Me.chkRegion1.UseVisualStyleBackColor = true
        '
        'btnCheckNullLowRegions
        '
        Me.btnCheckNullLowRegions.Location = New System.Drawing.Point(218, 15)
        Me.btnCheckNullLowRegions.Name = "btnCheckNullLowRegions"
        Me.btnCheckNullLowRegions.Size = New System.Drawing.Size(62, 20)
        Me.btnCheckNullLowRegions.TabIndex = 3
        Me.btnCheckNullLowRegions.Text = "Null"
        Me.btnCheckNullLowRegions.UseVisualStyleBackColor = true
        '
        'btnCheckEmpireRegions
        '
        Me.btnCheckEmpireRegions.Location = New System.Drawing.Point(150, 15)
        Me.btnCheckEmpireRegions.Name = "btnCheckEmpireRegions"
        Me.btnCheckEmpireRegions.Size = New System.Drawing.Size(62, 20)
        Me.btnCheckEmpireRegions.TabIndex = 2
        Me.btnCheckEmpireRegions.Text = "Empire"
        Me.btnCheckEmpireRegions.UseVisualStyleBackColor = true
        '
        'btnCheckNoRegions
        '
        Me.btnCheckNoRegions.Location = New System.Drawing.Point(82, 15)
        Me.btnCheckNoRegions.Name = "btnCheckNoRegions"
        Me.btnCheckNoRegions.Size = New System.Drawing.Size(62, 20)
        Me.btnCheckNoRegions.TabIndex = 1
        Me.btnCheckNoRegions.Text = "None"
        Me.btnCheckNoRegions.UseVisualStyleBackColor = true
        '
        'btnCheckAllRegions
        '
        Me.btnCheckAllRegions.Location = New System.Drawing.Point(14, 15)
        Me.btnCheckAllRegions.Name = "btnCheckAllRegions"
        Me.btnCheckAllRegions.Size = New System.Drawing.Size(62, 20)
        Me.btnCheckAllRegions.TabIndex = 0
        Me.btnCheckAllRegions.Text = "All"
        Me.btnCheckAllRegions.UseVisualStyleBackColor = true
        '
        'tabBlueprints
        '
        Me.tabBlueprints.Controls.Add(Me.btnBPForward)
        Me.tabBlueprints.Controls.Add(Me.btnBPBack)
        Me.tabBlueprints.Controls.Add(Me.gbFilters)
        Me.tabBlueprints.Controls.Add(Me.gbBPBlueprintType)
        Me.tabBlueprints.Controls.Add(Me.lblBPSelectBlueprint)
        Me.tabBlueprints.Controls.Add(Me.lstBPComponentMats)
        Me.tabBlueprints.Controls.Add(Me.lstBPRawMats)
        Me.tabBlueprints.Controls.Add(Me.gbBPInventionStats)
        Me.tabBlueprints.Controls.Add(Me.lblBPBuyColor)
        Me.tabBlueprints.Controls.Add(Me.lblBPBuildColor)
        Me.tabBlueprints.Controls.Add(Me.gbBPMEPEImage)
        Me.tabBlueprints.Controls.Add(Me.gbBPShopandCopy)
        Me.tabBlueprints.Controls.Add(Me.lblBPCanMakeBPAll)
        Me.tabBlueprints.Controls.Add(Me.lblBPRawMatCost)
        Me.tabBlueprints.Controls.Add(Me.lblBPRawMatCost1)
        Me.tabBlueprints.Controls.Add(Me.lblBPCanMakeBP)
        Me.tabBlueprints.Controls.Add(Me.lblBPRawMats)
        Me.tabBlueprints.Controls.Add(Me.lblBPComponentMatCost)
        Me.tabBlueprints.Controls.Add(Me.lblBPComponentMats)
        Me.tabBlueprints.Controls.Add(Me.lblBPComponentMatCost1)
        Me.tabBlueprints.Controls.Add(Me.gbBPBlueprintTech)
        Me.tabBlueprints.Controls.Add(Me.cmbBPBlueprintSelection)
        Me.tabBlueprints.Location = New System.Drawing.Point(4, 22)
        Me.tabBlueprints.Name = "tabBlueprints"
        Me.tabBlueprints.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBlueprints.Size = New System.Drawing.Size(1137, 615)
        Me.tabBlueprints.TabIndex = 0
        Me.tabBlueprints.Text = "Blueprints"
        Me.tabBlueprints.UseVisualStyleBackColor = true
        '
        'btnBPForward
        '
        Me.btnBPForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnBPForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnBPForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBPForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPForward.Image = CType(resources.GetObject("btnBPForward.Image"),System.Drawing.Image)
        Me.btnBPForward.Location = New System.Drawing.Point(1114, 236)
        Me.btnBPForward.Name = "btnBPForward"
        Me.btnBPForward.Size = New System.Drawing.Size(17, 19)
        Me.btnBPForward.TabIndex = 37
        Me.btnBPForward.UseVisualStyleBackColor = true
        Me.btnBPForward.Visible = false
        '
        'btnBPBack
        '
        Me.btnBPBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnBPBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnBPBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBPBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPBack.Image = CType(resources.GetObject("btnBPBack.Image"),System.Drawing.Image)
        Me.btnBPBack.Location = New System.Drawing.Point(1091, 236)
        Me.btnBPBack.Name = "btnBPBack"
        Me.btnBPBack.Size = New System.Drawing.Size(17, 19)
        Me.btnBPBack.TabIndex = 36
        Me.btnBPBack.UseVisualStyleBackColor = true
        Me.btnBPBack.Visible = false
        '
        'gbFilters
        '
        Me.gbFilters.Controls.Add(Me.chkBPXL)
        Me.gbFilters.Controls.Add(Me.chkBPLarge)
        Me.gbFilters.Controls.Add(Me.chkBPMedium)
        Me.gbFilters.Controls.Add(Me.chkBPSmall)
        Me.gbFilters.Location = New System.Drawing.Point(302, 51)
        Me.gbFilters.Name = "gbFilters"
        Me.gbFilters.Size = New System.Drawing.Size(84, 55)
        Me.gbFilters.TabIndex = 4
        Me.gbFilters.TabStop = false
        Me.gbFilters.Text = "Size Limit"
        '
        'chkBPXL
        '
        Me.chkBPXL.AutoSize = true
        Me.chkBPXL.Location = New System.Drawing.Point(43, 33)
        Me.chkBPXL.Name = "chkBPXL"
        Me.chkBPXL.Size = New System.Drawing.Size(39, 17)
        Me.chkBPXL.TabIndex = 4
        Me.chkBPXL.Text = "XL"
        Me.chkBPXL.UseVisualStyleBackColor = true
        '
        'chkBPLarge
        '
        Me.chkBPLarge.AutoSize = true
        Me.chkBPLarge.Location = New System.Drawing.Point(8, 33)
        Me.chkBPLarge.Name = "chkBPLarge"
        Me.chkBPLarge.Size = New System.Drawing.Size(32, 17)
        Me.chkBPLarge.TabIndex = 3
        Me.chkBPLarge.Text = "L"
        Me.chkBPLarge.UseVisualStyleBackColor = true
        '
        'chkBPMedium
        '
        Me.chkBPMedium.AutoSize = true
        Me.chkBPMedium.Location = New System.Drawing.Point(43, 15)
        Me.chkBPMedium.Name = "chkBPMedium"
        Me.chkBPMedium.Size = New System.Drawing.Size(35, 17)
        Me.chkBPMedium.TabIndex = 2
        Me.chkBPMedium.Text = "M"
        Me.chkBPMedium.UseVisualStyleBackColor = true
        '
        'chkBPSmall
        '
        Me.chkBPSmall.AutoSize = true
        Me.chkBPSmall.Location = New System.Drawing.Point(8, 15)
        Me.chkBPSmall.Name = "chkBPSmall"
        Me.chkBPSmall.Size = New System.Drawing.Size(33, 17)
        Me.chkBPSmall.TabIndex = 1
        Me.chkBPSmall.Text = "S"
        Me.chkBPSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkBPSmall.UseVisualStyleBackColor = true
        '
        'gbBPBlueprintType
        '
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPCelestialsBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPMiscBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPStructureBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPFavoriteBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPStationPartsBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPOwnedBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPRigBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPBoosterBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPSubsystemBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPModuleBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPAmmoChargeBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPDroneBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPComponentBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPAllBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPShipBlueprints)
        Me.gbBPBlueprintType.Controls.Add(Me.rbtnBPDeployableBlueprints)
        Me.gbBPBlueprintType.Location = New System.Drawing.Point(5, 51)
        Me.gbBPBlueprintType.Name = "gbBPBlueprintType"
        Me.gbBPBlueprintType.Size = New System.Drawing.Size(292, 125)
        Me.gbBPBlueprintType.TabIndex = 2
        Me.gbBPBlueprintType.TabStop = false
        Me.gbBPBlueprintType.Text = "Blueprint Type"
        '
        'rbtnBPCelestialsBlueprints
        '
        Me.rbtnBPCelestialsBlueprints.AutoSize = true
        Me.rbtnBPCelestialsBlueprints.Location = New System.Drawing.Point(188, 85)
        Me.rbtnBPCelestialsBlueprints.Name = "rbtnBPCelestialsBlueprints"
        Me.rbtnBPCelestialsBlueprints.Size = New System.Drawing.Size(69, 17)
        Me.rbtnBPCelestialsBlueprints.TabIndex = 14
        Me.rbtnBPCelestialsBlueprints.TabStop = true
        Me.rbtnBPCelestialsBlueprints.Text = "Celestials"
        Me.rbtnBPCelestialsBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPMiscBlueprints
        '
        Me.rbtnBPMiscBlueprints.AutoSize = true
        Me.rbtnBPMiscBlueprints.Location = New System.Drawing.Point(9, 102)
        Me.rbtnBPMiscBlueprints.Name = "rbtnBPMiscBlueprints"
        Me.rbtnBPMiscBlueprints.Size = New System.Drawing.Size(50, 17)
        Me.rbtnBPMiscBlueprints.TabIndex = 15
        Me.rbtnBPMiscBlueprints.TabStop = true
        Me.rbtnBPMiscBlueprints.Text = "Misc."
        Me.rbtnBPMiscBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPStructureBlueprints
        '
        Me.rbtnBPStructureBlueprints.AutoSize = true
        Me.rbtnBPStructureBlueprints.Location = New System.Drawing.Point(9, 85)
        Me.rbtnBPStructureBlueprints.Name = "rbtnBPStructureBlueprints"
        Me.rbtnBPStructureBlueprints.Size = New System.Drawing.Size(73, 17)
        Me.rbtnBPStructureBlueprints.TabIndex = 12
        Me.rbtnBPStructureBlueprints.TabStop = true
        Me.rbtnBPStructureBlueprints.Text = "Structures"
        Me.rbtnBPStructureBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPFavoriteBlueprints
        '
        Me.rbtnBPFavoriteBlueprints.AutoSize = true
        Me.rbtnBPFavoriteBlueprints.Location = New System.Drawing.Point(188, 15)
        Me.rbtnBPFavoriteBlueprints.Name = "rbtnBPFavoriteBlueprints"
        Me.rbtnBPFavoriteBlueprints.Size = New System.Drawing.Size(68, 17)
        Me.rbtnBPFavoriteBlueprints.TabIndex = 2
        Me.rbtnBPFavoriteBlueprints.TabStop = true
        Me.rbtnBPFavoriteBlueprints.Text = "Favorites"
        Me.rbtnBPFavoriteBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPStationPartsBlueprints
        '
        Me.rbtnBPStationPartsBlueprints.AutoSize = true
        Me.rbtnBPStationPartsBlueprints.Location = New System.Drawing.Point(98, 85)
        Me.rbtnBPStationPartsBlueprints.Name = "rbtnBPStationPartsBlueprints"
        Me.rbtnBPStationPartsBlueprints.Size = New System.Drawing.Size(85, 17)
        Me.rbtnBPStationPartsBlueprints.TabIndex = 13
        Me.rbtnBPStationPartsBlueprints.TabStop = true
        Me.rbtnBPStationPartsBlueprints.Text = "Station Parts"
        Me.rbtnBPStationPartsBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPOwnedBlueprints
        '
        Me.rbtnBPOwnedBlueprints.AutoSize = true
        Me.rbtnBPOwnedBlueprints.Location = New System.Drawing.Point(98, 15)
        Me.rbtnBPOwnedBlueprints.Name = "rbtnBPOwnedBlueprints"
        Me.rbtnBPOwnedBlueprints.Size = New System.Drawing.Size(59, 17)
        Me.rbtnBPOwnedBlueprints.TabIndex = 1
        Me.rbtnBPOwnedBlueprints.TabStop = true
        Me.rbtnBPOwnedBlueprints.Text = "Owned"
        Me.rbtnBPOwnedBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPRigBlueprints
        '
        Me.rbtnBPRigBlueprints.AutoSize = true
        Me.rbtnBPRigBlueprints.Location = New System.Drawing.Point(98, 51)
        Me.rbtnBPRigBlueprints.Name = "rbtnBPRigBlueprints"
        Me.rbtnBPRigBlueprints.Size = New System.Drawing.Size(46, 17)
        Me.rbtnBPRigBlueprints.TabIndex = 7
        Me.rbtnBPRigBlueprints.TabStop = true
        Me.rbtnBPRigBlueprints.Text = "Rigs"
        Me.rbtnBPRigBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPBoosterBlueprints
        '
        Me.rbtnBPBoosterBlueprints.AutoSize = true
        Me.rbtnBPBoosterBlueprints.Location = New System.Drawing.Point(188, 68)
        Me.rbtnBPBoosterBlueprints.Name = "rbtnBPBoosterBlueprints"
        Me.rbtnBPBoosterBlueprints.Size = New System.Drawing.Size(66, 17)
        Me.rbtnBPBoosterBlueprints.TabIndex = 11
        Me.rbtnBPBoosterBlueprints.TabStop = true
        Me.rbtnBPBoosterBlueprints.Text = "Boosters"
        Me.rbtnBPBoosterBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPSubsystemBlueprints
        '
        Me.rbtnBPSubsystemBlueprints.AutoSize = true
        Me.rbtnBPSubsystemBlueprints.Location = New System.Drawing.Point(188, 51)
        Me.rbtnBPSubsystemBlueprints.Name = "rbtnBPSubsystemBlueprints"
        Me.rbtnBPSubsystemBlueprints.Size = New System.Drawing.Size(81, 17)
        Me.rbtnBPSubsystemBlueprints.TabIndex = 8
        Me.rbtnBPSubsystemBlueprints.TabStop = true
        Me.rbtnBPSubsystemBlueprints.Text = "Subsystems"
        Me.rbtnBPSubsystemBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPModuleBlueprints
        '
        Me.rbtnBPModuleBlueprints.AutoSize = true
        Me.rbtnBPModuleBlueprints.Location = New System.Drawing.Point(98, 34)
        Me.rbtnBPModuleBlueprints.Name = "rbtnBPModuleBlueprints"
        Me.rbtnBPModuleBlueprints.Size = New System.Drawing.Size(65, 17)
        Me.rbtnBPModuleBlueprints.TabIndex = 4
        Me.rbtnBPModuleBlueprints.TabStop = true
        Me.rbtnBPModuleBlueprints.Text = "Modules"
        Me.rbtnBPModuleBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPAmmoChargeBlueprints
        '
        Me.rbtnBPAmmoChargeBlueprints.AutoSize = true
        Me.rbtnBPAmmoChargeBlueprints.Location = New System.Drawing.Point(188, 34)
        Me.rbtnBPAmmoChargeBlueprints.Name = "rbtnBPAmmoChargeBlueprints"
        Me.rbtnBPAmmoChargeBlueprints.Size = New System.Drawing.Size(98, 17)
        Me.rbtnBPAmmoChargeBlueprints.TabIndex = 5
        Me.rbtnBPAmmoChargeBlueprints.TabStop = true
        Me.rbtnBPAmmoChargeBlueprints.Text = "Ammo/Charges"
        Me.rbtnBPAmmoChargeBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPDroneBlueprints
        '
        Me.rbtnBPDroneBlueprints.AutoSize = true
        Me.rbtnBPDroneBlueprints.Location = New System.Drawing.Point(9, 51)
        Me.rbtnBPDroneBlueprints.Name = "rbtnBPDroneBlueprints"
        Me.rbtnBPDroneBlueprints.Size = New System.Drawing.Size(59, 17)
        Me.rbtnBPDroneBlueprints.TabIndex = 6
        Me.rbtnBPDroneBlueprints.TabStop = true
        Me.rbtnBPDroneBlueprints.Text = "Drones"
        Me.rbtnBPDroneBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPComponentBlueprints
        '
        Me.rbtnBPComponentBlueprints.AutoSize = true
        Me.rbtnBPComponentBlueprints.Location = New System.Drawing.Point(98, 68)
        Me.rbtnBPComponentBlueprints.Name = "rbtnBPComponentBlueprints"
        Me.rbtnBPComponentBlueprints.Size = New System.Drawing.Size(84, 17)
        Me.rbtnBPComponentBlueprints.TabIndex = 10
        Me.rbtnBPComponentBlueprints.TabStop = true
        Me.rbtnBPComponentBlueprints.Text = "Components"
        Me.rbtnBPComponentBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPAllBlueprints
        '
        Me.rbtnBPAllBlueprints.AutoSize = true
        Me.rbtnBPAllBlueprints.Location = New System.Drawing.Point(9, 17)
        Me.rbtnBPAllBlueprints.Name = "rbtnBPAllBlueprints"
        Me.rbtnBPAllBlueprints.Size = New System.Drawing.Size(36, 17)
        Me.rbtnBPAllBlueprints.TabIndex = 0
        Me.rbtnBPAllBlueprints.TabStop = true
        Me.rbtnBPAllBlueprints.Text = "All"
        Me.rbtnBPAllBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPShipBlueprints
        '
        Me.rbtnBPShipBlueprints.AutoSize = true
        Me.rbtnBPShipBlueprints.Location = New System.Drawing.Point(9, 34)
        Me.rbtnBPShipBlueprints.Name = "rbtnBPShipBlueprints"
        Me.rbtnBPShipBlueprints.Size = New System.Drawing.Size(51, 17)
        Me.rbtnBPShipBlueprints.TabIndex = 3
        Me.rbtnBPShipBlueprints.TabStop = true
        Me.rbtnBPShipBlueprints.Text = "Ships"
        Me.rbtnBPShipBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPDeployableBlueprints
        '
        Me.rbtnBPDeployableBlueprints.AutoSize = true
        Me.rbtnBPDeployableBlueprints.Location = New System.Drawing.Point(9, 68)
        Me.rbtnBPDeployableBlueprints.Name = "rbtnBPDeployableBlueprints"
        Me.rbtnBPDeployableBlueprints.Size = New System.Drawing.Size(78, 17)
        Me.rbtnBPDeployableBlueprints.TabIndex = 9
        Me.rbtnBPDeployableBlueprints.TabStop = true
        Me.rbtnBPDeployableBlueprints.Text = "Deployable"
        Me.rbtnBPDeployableBlueprints.UseVisualStyleBackColor = true
        '
        'lblBPSelectBlueprint
        '
        Me.lblBPSelectBlueprint.AutoSize = true
        Me.lblBPSelectBlueprint.Location = New System.Drawing.Point(3, 13)
        Me.lblBPSelectBlueprint.Name = "lblBPSelectBlueprint"
        Me.lblBPSelectBlueprint.Size = New System.Drawing.Size(93, 13)
        Me.lblBPSelectBlueprint.TabIndex = 0
        Me.lblBPSelectBlueprint.Text = "Selected Blueprint"
        '
        'gbBPInventionStats
        '
        Me.gbBPInventionStats.BackColor = System.Drawing.Color.Transparent
        Me.gbBPInventionStats.Controls.Add(Me.lblBPTotalUnits)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPTaxes)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPTotalUnits1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPBrokerFees)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPPT)
        Me.gbBPInventionStats.Controls.Add(Me.chkBPTaxes)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPMarketCost)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPMarketCost1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawTotalCost)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPCompProfit)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawTotalCost1)
        Me.gbBPInventionStats.Controls.Add(Me.chkBPBrokerFees)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPCompIPH)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawIPH)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPTotalCompCost1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPCompIPH1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPTotalItemPT)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPTotalCompCost)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPCPTPT)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawSVR)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawIPH1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawProfit)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPBPSVR)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPCompProfit1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawProfit1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPProductionTime)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPBPSVR1)
        Me.gbBPInventionStats.Controls.Add(Me.lblBPRawSVR1)
        Me.gbBPInventionStats.Controls.Add(Me.chkBPPricePerUnit)
        Me.gbBPInventionStats.Location = New System.Drawing.Point(853, 8)
        Me.gbBPInventionStats.Name = "gbBPInventionStats"
        Me.gbBPInventionStats.Size = New System.Drawing.Size(278, 224)
        Me.gbBPInventionStats.TabIndex = 17
        Me.gbBPInventionStats.TabStop = false
        '
        'lblBPTotalUnits
        '
        Me.lblBPTotalUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPTotalUnits.Location = New System.Drawing.Point(141, 63)
        Me.lblBPTotalUnits.Name = "lblBPTotalUnits"
        Me.lblBPTotalUnits.Size = New System.Drawing.Size(132, 16)
        Me.lblBPTotalUnits.TabIndex = 7
        Me.lblBPTotalUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPTaxes
        '
        Me.lblBPTaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPTaxes.Location = New System.Drawing.Point(6, 98)
        Me.lblBPTaxes.Name = "lblBPTaxes"
        Me.lblBPTaxes.Size = New System.Drawing.Size(131, 17)
        Me.lblBPTaxes.TabIndex = 10
        Me.lblBPTaxes.Text = "0.00"
        Me.lblBPTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPTotalUnits1
        '
        Me.lblBPTotalUnits1.AutoSize = true
        Me.lblBPTotalUnits1.Location = New System.Drawing.Point(138, 48)
        Me.lblBPTotalUnits1.Name = "lblBPTotalUnits1"
        Me.lblBPTotalUnits1.Size = New System.Drawing.Size(34, 13)
        Me.lblBPTotalUnits1.TabIndex = 6
        Me.lblBPTotalUnits1.Text = "Units:"
        '
        'lblBPBrokerFees
        '
        Me.lblBPBrokerFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPBrokerFees.Location = New System.Drawing.Point(141, 98)
        Me.lblBPBrokerFees.Name = "lblBPBrokerFees"
        Me.lblBPBrokerFees.Size = New System.Drawing.Size(132, 17)
        Me.lblBPBrokerFees.TabIndex = 12
        Me.lblBPBrokerFees.Text = "0.00"
        Me.lblBPBrokerFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPPT
        '
        Me.lblBPPT.AutoSize = true
        Me.lblBPPT.Location = New System.Drawing.Point(3, 13)
        Me.lblBPPT.Name = "lblBPPT"
        Me.lblBPPT.Size = New System.Drawing.Size(104, 13)
        Me.lblBPPT.TabIndex = 0
        Me.lblBPPT.Text = "BP Production Time:"
        '
        'chkBPTaxes
        '
        Me.chkBPTaxes.AutoSize = true
        Me.chkBPTaxes.Checked = true
        Me.chkBPTaxes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPTaxes.Location = New System.Drawing.Point(6, 81)
        Me.chkBPTaxes.Name = "chkBPTaxes"
        Me.chkBPTaxes.Size = New System.Drawing.Size(58, 17)
        Me.chkBPTaxes.TabIndex = 9
        Me.chkBPTaxes.Text = "Taxes:"
        Me.chkBPTaxes.UseVisualStyleBackColor = true
        '
        'lblBPMarketCost
        '
        Me.lblBPMarketCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPMarketCost.Location = New System.Drawing.Point(5, 62)
        Me.lblBPMarketCost.Name = "lblBPMarketCost"
        Me.lblBPMarketCost.Size = New System.Drawing.Size(132, 17)
        Me.lblBPMarketCost.TabIndex = 5
        Me.lblBPMarketCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPMarketCost1
        '
        Me.lblBPMarketCost1.AutoSize = true
        Me.lblBPMarketCost1.Location = New System.Drawing.Point(3, 48)
        Me.lblBPMarketCost1.Name = "lblBPMarketCost1"
        Me.lblBPMarketCost1.Size = New System.Drawing.Size(70, 13)
        Me.lblBPMarketCost1.TabIndex = 4
        Me.lblBPMarketCost1.Text = "Market Price:"
        '
        'lblBPRawTotalCost
        '
        Me.lblBPRawTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPRawTotalCost.Location = New System.Drawing.Point(141, 132)
        Me.lblBPRawTotalCost.Name = "lblBPRawTotalCost"
        Me.lblBPRawTotalCost.Size = New System.Drawing.Size(132, 17)
        Me.lblBPRawTotalCost.TabIndex = 16
        Me.lblBPRawTotalCost.Text = "0.00"
        Me.lblBPRawTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPCompProfit
        '
        Me.lblBPCompProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPCompProfit.Location = New System.Drawing.Point(5, 166)
        Me.lblBPCompProfit.Name = "lblBPCompProfit"
        Me.lblBPCompProfit.Size = New System.Drawing.Size(132, 17)
        Me.lblBPCompProfit.TabIndex = 18
        Me.lblBPCompProfit.Text = "0.00"
        Me.lblBPCompProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPRawTotalCost1
        '
        Me.lblBPRawTotalCost1.AutoSize = true
        Me.lblBPRawTotalCost1.Location = New System.Drawing.Point(138, 118)
        Me.lblBPRawTotalCost1.Name = "lblBPRawTotalCost1"
        Me.lblBPRawTotalCost1.Size = New System.Drawing.Size(104, 13)
        Me.lblBPRawTotalCost1.TabIndex = 15
        Me.lblBPRawTotalCost1.Text = "Total Raw Mat Cost:"
        '
        'chkBPBrokerFees
        '
        Me.chkBPBrokerFees.AutoSize = true
        Me.chkBPBrokerFees.Checked = true
        Me.chkBPBrokerFees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPBrokerFees.Location = New System.Drawing.Point(141, 81)
        Me.chkBPBrokerFees.Name = "chkBPBrokerFees"
        Me.chkBPBrokerFees.Size = New System.Drawing.Size(52, 17)
        Me.chkBPBrokerFees.TabIndex = 11
        Me.chkBPBrokerFees.Text = "Fees:"
        Me.chkBPBrokerFees.UseVisualStyleBackColor = true
        '
        'lblBPCompIPH
        '
        Me.lblBPCompIPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPCompIPH.Location = New System.Drawing.Point(5, 200)
        Me.lblBPCompIPH.Name = "lblBPCompIPH"
        Me.lblBPCompIPH.Size = New System.Drawing.Size(132, 17)
        Me.lblBPCompIPH.TabIndex = 22
        Me.lblBPCompIPH.Text = "0.00"
        Me.lblBPCompIPH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPRawIPH
        '
        Me.lblBPRawIPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPRawIPH.Location = New System.Drawing.Point(141, 200)
        Me.lblBPRawIPH.Name = "lblBPRawIPH"
        Me.lblBPRawIPH.Size = New System.Drawing.Size(132, 17)
        Me.lblBPRawIPH.TabIndex = 26
        Me.lblBPRawIPH.Text = "0.00"
        Me.lblBPRawIPH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPTotalCompCost1
        '
        Me.lblBPTotalCompCost1.AutoSize = true
        Me.lblBPTotalCompCost1.Location = New System.Drawing.Point(3, 118)
        Me.lblBPTotalCompCost1.Name = "lblBPTotalCompCost1"
        Me.lblBPTotalCompCost1.Size = New System.Drawing.Size(115, 13)
        Me.lblBPTotalCompCost1.TabIndex = 13
        Me.lblBPTotalCompCost1.Text = "Total Component Cost:"
        '
        'lblBPCompIPH1
        '
        Me.lblBPCompIPH1.AutoSize = true
        Me.lblBPCompIPH1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblBPCompIPH1.Location = New System.Drawing.Point(3, 186)
        Me.lblBPCompIPH1.Name = "lblBPCompIPH1"
        Me.lblBPCompIPH1.Size = New System.Drawing.Size(88, 13)
        Me.lblBPCompIPH1.TabIndex = 21
        Me.lblBPCompIPH1.Text = "BP ISK per Hour:"
        '
        'lblBPTotalItemPT
        '
        Me.lblBPTotalItemPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPTotalItemPT.Location = New System.Drawing.Point(141, 28)
        Me.lblBPTotalItemPT.Name = "lblBPTotalItemPT"
        Me.lblBPTotalItemPT.Size = New System.Drawing.Size(132, 17)
        Me.lblBPTotalItemPT.TabIndex = 3
        Me.lblBPTotalItemPT.Text = "00:00:00"
        Me.lblBPTotalItemPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPTotalCompCost
        '
        Me.lblBPTotalCompCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPTotalCompCost.Location = New System.Drawing.Point(5, 132)
        Me.lblBPTotalCompCost.Name = "lblBPTotalCompCost"
        Me.lblBPTotalCompCost.Size = New System.Drawing.Size(132, 17)
        Me.lblBPTotalCompCost.TabIndex = 14
        Me.lblBPTotalCompCost.Text = "0.00"
        Me.lblBPTotalCompCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPCPTPT
        '
        Me.lblBPCPTPT.AutoSize = true
        Me.lblBPCPTPT.Location = New System.Drawing.Point(138, 13)
        Me.lblBPCPTPT.Name = "lblBPCPTPT"
        Me.lblBPCPTPT.Size = New System.Drawing.Size(114, 13)
        Me.lblBPCPTPT.TabIndex = 2
        Me.lblBPCPTPT.Text = "Total Production Time:"
        '
        'lblBPRawSVR
        '
        Me.lblBPRawSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPRawSVR.Location = New System.Drawing.Point(232, 200)
        Me.lblBPRawSVR.Name = "lblBPRawSVR"
        Me.lblBPRawSVR.Size = New System.Drawing.Size(41, 17)
        Me.lblBPRawSVR.TabIndex = 28
        Me.lblBPRawSVR.Text = "0.00"
        Me.lblBPRawSVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPRawIPH1
        '
        Me.lblBPRawIPH1.AutoSize = true
        Me.lblBPRawIPH1.Location = New System.Drawing.Point(138, 186)
        Me.lblBPRawIPH1.Name = "lblBPRawIPH1"
        Me.lblBPRawIPH1.Size = New System.Drawing.Size(96, 13)
        Me.lblBPRawIPH1.TabIndex = 25
        Me.lblBPRawIPH1.Text = "Raw ISK per Hour:"
        '
        'lblBPRawProfit
        '
        Me.lblBPRawProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPRawProfit.Location = New System.Drawing.Point(141, 166)
        Me.lblBPRawProfit.Name = "lblBPRawProfit"
        Me.lblBPRawProfit.Size = New System.Drawing.Size(132, 17)
        Me.lblBPRawProfit.TabIndex = 20
        Me.lblBPRawProfit.Text = "0.00"
        Me.lblBPRawProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPBPSVR
        '
        Me.lblBPBPSVR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPBPSVR.Location = New System.Drawing.Point(97, 200)
        Me.lblBPBPSVR.Name = "lblBPBPSVR"
        Me.lblBPBPSVR.Size = New System.Drawing.Size(40, 17)
        Me.lblBPBPSVR.TabIndex = 24
        Me.lblBPBPSVR.Text = "0.00"
        Me.lblBPBPSVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPCompProfit1
        '
        Me.lblBPCompProfit1.AutoSize = true
        Me.lblBPCompProfit1.Location = New System.Drawing.Point(3, 152)
        Me.lblBPCompProfit1.Name = "lblBPCompProfit1"
        Me.lblBPCompProfit1.Size = New System.Drawing.Size(91, 13)
        Me.lblBPCompProfit1.TabIndex = 17
        Me.lblBPCompProfit1.Text = "Component Profit:"
        '
        'lblBPRawProfit1
        '
        Me.lblBPRawProfit1.AutoSize = true
        Me.lblBPRawProfit1.Location = New System.Drawing.Point(138, 152)
        Me.lblBPRawProfit1.Name = "lblBPRawProfit1"
        Me.lblBPRawProfit1.Size = New System.Drawing.Size(59, 13)
        Me.lblBPRawProfit1.TabIndex = 19
        Me.lblBPRawProfit1.Text = "Raw Profit:"
        '
        'lblBPProductionTime
        '
        Me.lblBPProductionTime.BackColor = System.Drawing.Color.Transparent
        Me.lblBPProductionTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPProductionTime.Location = New System.Drawing.Point(5, 28)
        Me.lblBPProductionTime.Name = "lblBPProductionTime"
        Me.lblBPProductionTime.Size = New System.Drawing.Size(132, 17)
        Me.lblBPProductionTime.TabIndex = 1
        Me.lblBPProductionTime.Text = "00:00:00"
        Me.lblBPProductionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPBPSVR1
        '
        Me.lblBPBPSVR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblBPBPSVR1.Location = New System.Drawing.Point(101, 186)
        Me.lblBPBPSVR1.Name = "lblBPBPSVR1"
        Me.lblBPBPSVR1.Size = New System.Drawing.Size(32, 13)
        Me.lblBPBPSVR1.TabIndex = 23
        Me.lblBPBPSVR1.Text = "SVR"
        Me.lblBPBPSVR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBPBPSVR1.Visible = false
        '
        'lblBPRawSVR1
        '
        Me.lblBPRawSVR1.Location = New System.Drawing.Point(236, 186)
        Me.lblBPRawSVR1.Name = "lblBPRawSVR1"
        Me.lblBPRawSVR1.Size = New System.Drawing.Size(32, 13)
        Me.lblBPRawSVR1.TabIndex = 27
        Me.lblBPRawSVR1.Text = "SVR"
        Me.lblBPRawSVR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBPRawSVR1.Visible = false
        '
        'chkBPPricePerUnit
        '
        Me.chkBPPricePerUnit.AutoSize = true
        Me.chkBPPricePerUnit.Location = New System.Drawing.Point(225, 47)
        Me.chkBPPricePerUnit.Name = "chkBPPricePerUnit"
        Me.chkBPPricePerUnit.Size = New System.Drawing.Size(48, 17)
        Me.chkBPPricePerUnit.TabIndex = 8
        Me.chkBPPricePerUnit.Text = "PPU"
        Me.chkBPPricePerUnit.UseVisualStyleBackColor = true
        '
        'lblBPBuyColor
        '
        Me.lblBPBuyColor.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblBPBuyColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPBuyColor.Location = New System.Drawing.Point(507, 238)
        Me.lblBPBuyColor.Name = "lblBPBuyColor"
        Me.lblBPBuyColor.Size = New System.Drawing.Size(59, 16)
        Me.lblBPBuyColor.TabIndex = 31
        Me.lblBPBuyColor.Text = "Buy Item"
        Me.lblBPBuyColor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBPBuildColor
        '
        Me.lblBPBuildColor.BackColor = System.Drawing.Color.Gold
        Me.lblBPBuildColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPBuildColor.Location = New System.Drawing.Point(447, 238)
        Me.lblBPBuildColor.Name = "lblBPBuildColor"
        Me.lblBPBuildColor.Size = New System.Drawing.Size(59, 16)
        Me.lblBPBuildColor.TabIndex = 30
        Me.lblBPBuildColor.Text = "Build Item"
        Me.lblBPBuildColor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbBPMEPEImage
        '
        Me.gbBPMEPEImage.Controls.Add(Me.btnBPSaveBP)
        Me.gbBPMEPEImage.Controls.Add(Me.tabBPInventionEquip)
        Me.gbBPMEPEImage.Controls.Add(Me.btnBPSaveSettings)
        Me.gbBPMEPEImage.Controls.Add(Me.txtBPLines)
        Me.gbBPMEPEImage.Controls.Add(Me.pictBP)
        Me.gbBPMEPEImage.Controls.Add(Me.txtBPNumBPs)
        Me.gbBPMEPEImage.Controls.Add(Me.btnBPRefreshBP)
        Me.gbBPMEPEImage.Controls.Add(Me.lblBPLines)
        Me.gbBPMEPEImage.Controls.Add(Me.txtBPME)
        Me.gbBPMEPEImage.Controls.Add(Me.lblBPRuns)
        Me.gbBPMEPEImage.Controls.Add(Me.gbBPTeam)
        Me.gbBPMEPEImage.Controls.Add(Me.chkBPBuildBuy)
        Me.gbBPMEPEImage.Controls.Add(Me.txtBPRuns)
        Me.gbBPMEPEImage.Controls.Add(Me.txtBPAddlCosts)
        Me.gbBPMEPEImage.Controls.Add(Me.lblBPAddlCosts)
        Me.gbBPMEPEImage.Controls.Add(Me.lblBPME)
        Me.gbBPMEPEImage.Controls.Add(Me.txtBPTE)
        Me.gbBPMEPEImage.Controls.Add(Me.lblBPPE)
        Me.gbBPMEPEImage.Controls.Add(Me.lblBPNumBPs)
        Me.gbBPMEPEImage.Location = New System.Drawing.Point(392, 8)
        Me.gbBPMEPEImage.Name = "gbBPMEPEImage"
        Me.gbBPMEPEImage.Size = New System.Drawing.Size(455, 224)
        Me.gbBPMEPEImage.TabIndex = 6
        Me.gbBPMEPEImage.TabStop = false
        '
        'btnBPSaveBP
        '
        Me.btnBPSaveBP.Location = New System.Drawing.Point(6, 153)
        Me.btnBPSaveBP.Name = "btnBPSaveBP"
        Me.btnBPSaveBP.Size = New System.Drawing.Size(45, 34)
        Me.btnBPSaveBP.TabIndex = 17
        Me.btnBPSaveBP.Text = "Save BP"
        Me.btnBPSaveBP.UseVisualStyleBackColor = true
        '
        'tabBPInventionEquip
        '
        Me.tabBPInventionEquip.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.tabBPInventionEquip.Controls.Add(Me.tabFacility)
        Me.tabBPInventionEquip.Controls.Add(Me.tabInventionCalcs)
        Me.tabBPInventionEquip.Controls.Add(Me.tabT3Calcs)
        Me.tabBPInventionEquip.ItemSize = New System.Drawing.Size(49, 20)
        Me.tabBPInventionEquip.Location = New System.Drawing.Point(140, 78)
        Me.tabBPInventionEquip.Multiline = true
        Me.tabBPInventionEquip.Name = "tabBPInventionEquip"
        Me.tabBPInventionEquip.Padding = New System.Drawing.Point(0, 0)
        Me.tabBPInventionEquip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabBPInventionEquip.SelectedIndex = 0
        Me.tabBPInventionEquip.Size = New System.Drawing.Size(309, 140)
        Me.tabBPInventionEquip.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabBPInventionEquip.TabIndex = 16
        '
        'tabFacility
        '
        Me.tabFacility.Controls.Add(Me.txtBPFacilityManualTax)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityManualTax)
        Me.tabFacility.Controls.Add(Me.cmbBPFacilityType)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityDefault)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityActivity)
        Me.tabFacility.Controls.Add(Me.cmbBPFacilityActivities)
        Me.tabFacility.Controls.Add(Me.btnBPFacilitySave)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityTaxRate)
        Me.tabFacility.Controls.Add(Me.txtBPFacilityManualTE)
        Me.tabFacility.Controls.Add(Me.txtBPFacilityManualME)
        Me.tabFacility.Controls.Add(Me.cmbBPFacilityorArray)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityUsage)
        Me.tabFacility.Controls.Add(Me.cmbBPFacilitySystem)
        Me.tabFacility.Controls.Add(Me.cmbBPFacilityRegion)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityManualTE)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityLocation)
        Me.tabFacility.Controls.Add(Me.lblBPFacility)
        Me.tabFacility.Controls.Add(Me.chkBPFacilityIncludeUsage)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityManualME)
        Me.tabFacility.Controls.Add(Me.lblBPFacilityBonus)
        Me.tabFacility.Location = New System.Drawing.Point(4, 4)
        Me.tabFacility.Margin = New System.Windows.Forms.Padding(0)
        Me.tabFacility.Name = "tabFacility"
        Me.tabFacility.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFacility.Size = New System.Drawing.Size(281, 132)
        Me.tabFacility.TabIndex = 1
        Me.tabFacility.Text = "Facility"
        Me.tabFacility.UseVisualStyleBackColor = true
        '
        'txtBPFacilityManualTax
        '
        Me.txtBPFacilityManualTax.Location = New System.Drawing.Point(185, 108)
        Me.txtBPFacilityManualTax.MaxLength = 5
        Me.txtBPFacilityManualTax.Name = "txtBPFacilityManualTax"
        Me.txtBPFacilityManualTax.Size = New System.Drawing.Size(35, 20)
        Me.txtBPFacilityManualTax.TabIndex = 19
        Me.txtBPFacilityManualTax.Text = "0%"
        Me.txtBPFacilityManualTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBPFacilityManualTax.Visible = false
        '
        'lblBPFacilityManualTax
        '
        Me.lblBPFacilityManualTax.AutoSize = true
        Me.lblBPFacilityManualTax.Location = New System.Drawing.Point(159, 111)
        Me.lblBPFacilityManualTax.Name = "lblBPFacilityManualTax"
        Me.lblBPFacilityManualTax.Size = New System.Drawing.Size(28, 13)
        Me.lblBPFacilityManualTax.TabIndex = 18
        Me.lblBPFacilityManualTax.Text = "Tax:"
        Me.lblBPFacilityManualTax.Visible = false
        '
        'cmbBPFacilityType
        '
        Me.cmbBPFacilityType.Enabled = false
        Me.cmbBPFacilityType.FormattingEnabled = true
        Me.cmbBPFacilityType.ItemHeight = 13
        Me.cmbBPFacilityType.Items.AddRange(New Object() {"NPC Station", "Outpost", "POS"})
        Me.cmbBPFacilityType.Location = New System.Drawing.Point(177, 19)
        Me.cmbBPFacilityType.Name = "cmbBPFacilityType"
        Me.cmbBPFacilityType.Size = New System.Drawing.Size(62, 21)
        Me.cmbBPFacilityType.TabIndex = 4
        Me.cmbBPFacilityType.Text = "Type"
        '
        'lblBPFacilityDefault
        '
        Me.lblBPFacilityDefault.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblBPFacilityDefault.Location = New System.Drawing.Point(237, 6)
        Me.lblBPFacilityDefault.Name = "lblBPFacilityDefault"
        Me.lblBPFacilityDefault.Size = New System.Drawing.Size(48, 34)
        Me.lblBPFacilityDefault.TabIndex = 5
        Me.lblBPFacilityDefault.Text = "Default Facility"
        Me.lblBPFacilityDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPFacilityActivity
        '
        Me.lblBPFacilityActivity.AutoSize = true
        Me.lblBPFacilityActivity.Location = New System.Drawing.Point(3, 3)
        Me.lblBPFacilityActivity.Name = "lblBPFacilityActivity"
        Me.lblBPFacilityActivity.Size = New System.Drawing.Size(44, 13)
        Me.lblBPFacilityActivity.TabIndex = 1
        Me.lblBPFacilityActivity.Text = "Activity:"
        '
        'cmbBPFacilityActivities
        '
        Me.cmbBPFacilityActivities.FormattingEnabled = true
        Me.cmbBPFacilityActivities.Items.AddRange(New Object() {"Manufacturing", "Invention", "Copying", "RE"})
        Me.cmbBPFacilityActivities.Location = New System.Drawing.Point(5, 19)
        Me.cmbBPFacilityActivities.Name = "cmbBPFacilityActivities"
        Me.cmbBPFacilityActivities.Size = New System.Drawing.Size(170, 21)
        Me.cmbBPFacilityActivities.TabIndex = 2
        Me.cmbBPFacilityActivities.Text = "Select Activity"
        '
        'btnBPFacilitySave
        '
        Me.btnBPFacilitySave.Enabled = false
        Me.btnBPFacilitySave.Location = New System.Drawing.Point(222, 107)
        Me.btnBPFacilitySave.Name = "btnBPFacilitySave"
        Me.btnBPFacilitySave.Size = New System.Drawing.Size(56, 22)
        Me.btnBPFacilitySave.TabIndex = 20
        Me.btnBPFacilitySave.Text = "Save"
        Me.btnBPFacilitySave.UseVisualStyleBackColor = true
        '
        'lblBPFacilityTaxRate
        '
        Me.lblBPFacilityTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPFacilityTaxRate.Location = New System.Drawing.Point(158, 108)
        Me.lblBPFacilityTaxRate.Name = "lblBPFacilityTaxRate"
        Me.lblBPFacilityTaxRate.Size = New System.Drawing.Size(62, 20)
        Me.lblBPFacilityTaxRate.TabIndex = 17
        Me.lblBPFacilityTaxRate.Text = "Tax: 50.0%"
        Me.lblBPFacilityTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBPFacilityTaxRate.Visible = false
        '
        'txtBPFacilityManualTE
        '
        Me.txtBPFacilityManualTE.Location = New System.Drawing.Point(100, 108)
        Me.txtBPFacilityManualTE.MaxLength = 5
        Me.txtBPFacilityManualTE.Name = "txtBPFacilityManualTE"
        Me.txtBPFacilityManualTE.Size = New System.Drawing.Size(35, 20)
        Me.txtBPFacilityManualTE.TabIndex = 16
        Me.txtBPFacilityManualTE.Text = "0%"
        Me.txtBPFacilityManualTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBPFacilityManualTE.Visible = false
        '
        'txtBPFacilityManualME
        '
        Me.txtBPFacilityManualME.Location = New System.Drawing.Point(39, 108)
        Me.txtBPFacilityManualME.MaxLength = 5
        Me.txtBPFacilityManualME.Name = "txtBPFacilityManualME"
        Me.txtBPFacilityManualME.Size = New System.Drawing.Size(35, 20)
        Me.txtBPFacilityManualME.TabIndex = 14
        Me.txtBPFacilityManualME.Text = "0%"
        Me.txtBPFacilityManualME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBPFacilityManualME.Visible = false
        '
        'cmbBPFacilityorArray
        '
        Me.cmbBPFacilityorArray.FormattingEnabled = true
        Me.cmbBPFacilityorArray.ItemHeight = 13
        Me.cmbBPFacilityorArray.Location = New System.Drawing.Point(5, 84)
        Me.cmbBPFacilityorArray.Name = "cmbBPFacilityorArray"
        Me.cmbBPFacilityorArray.Size = New System.Drawing.Size(274, 21)
        Me.cmbBPFacilityorArray.TabIndex = 11
        Me.cmbBPFacilityorArray.Text = "Select Facility / Array"
        '
        'lblBPFacilityUsage
        '
        Me.lblBPFacilityUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPFacilityUsage.Location = New System.Drawing.Point(139, 42)
        Me.lblBPFacilityUsage.Name = "lblBPFacilityUsage"
        Me.lblBPFacilityUsage.Size = New System.Drawing.Size(139, 17)
        Me.lblBPFacilityUsage.TabIndex = 8
        Me.lblBPFacilityUsage.Text = "0.00"
        Me.lblBPFacilityUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBPFacilitySystem
        '
        Me.cmbBPFacilitySystem.FormattingEnabled = true
        Me.cmbBPFacilitySystem.Location = New System.Drawing.Point(139, 61)
        Me.cmbBPFacilitySystem.Name = "cmbBPFacilitySystem"
        Me.cmbBPFacilitySystem.Size = New System.Drawing.Size(139, 21)
        Me.cmbBPFacilitySystem.TabIndex = 10
        Me.cmbBPFacilitySystem.Text = "Select System"
        '
        'cmbBPFacilityRegion
        '
        Me.cmbBPFacilityRegion.FormattingEnabled = true
        Me.cmbBPFacilityRegion.Location = New System.Drawing.Point(5, 61)
        Me.cmbBPFacilityRegion.Name = "cmbBPFacilityRegion"
        Me.cmbBPFacilityRegion.Size = New System.Drawing.Size(130, 21)
        Me.cmbBPFacilityRegion.TabIndex = 9
        Me.cmbBPFacilityRegion.Text = "Select Region"
        '
        'lblBPFacilityManualTE
        '
        Me.lblBPFacilityManualTE.AutoSize = true
        Me.lblBPFacilityManualTE.Location = New System.Drawing.Point(77, 111)
        Me.lblBPFacilityManualTE.Name = "lblBPFacilityManualTE"
        Me.lblBPFacilityManualTE.Size = New System.Drawing.Size(24, 13)
        Me.lblBPFacilityManualTE.TabIndex = 15
        Me.lblBPFacilityManualTE.Text = "TE:"
        Me.lblBPFacilityManualTE.Visible = false
        '
        'lblBPFacilityLocation
        '
        Me.lblBPFacilityLocation.AutoSize = true
        Me.lblBPFacilityLocation.Location = New System.Drawing.Point(3, 44)
        Me.lblBPFacilityLocation.Name = "lblBPFacilityLocation"
        Me.lblBPFacilityLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblBPFacilityLocation.TabIndex = 6
        Me.lblBPFacilityLocation.Text = "Location:"
        '
        'lblBPFacility
        '
        Me.lblBPFacility.AutoSize = true
        Me.lblBPFacility.Location = New System.Drawing.Point(174, 4)
        Me.lblBPFacility.Name = "lblBPFacility"
        Me.lblBPFacility.Size = New System.Drawing.Size(69, 13)
        Me.lblBPFacility.TabIndex = 3
        Me.lblBPFacility.Text = "Facility Type:"
        '
        'chkBPFacilityIncludeUsage
        '
        Me.chkBPFacilityIncludeUsage.AutoSize = true
        Me.chkBPFacilityIncludeUsage.Checked = true
        Me.chkBPFacilityIncludeUsage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPFacilityIncludeUsage.Enabled = false
        Me.chkBPFacilityIncludeUsage.Location = New System.Drawing.Point(80, 42)
        Me.chkBPFacilityIncludeUsage.Name = "chkBPFacilityIncludeUsage"
        Me.chkBPFacilityIncludeUsage.Size = New System.Drawing.Size(60, 17)
        Me.chkBPFacilityIncludeUsage.TabIndex = 7
        Me.chkBPFacilityIncludeUsage.Text = "Usage:"
        Me.chkBPFacilityIncludeUsage.UseVisualStyleBackColor = true
        '
        'lblBPFacilityManualME
        '
        Me.lblBPFacilityManualME.AutoSize = true
        Me.lblBPFacilityManualME.Location = New System.Drawing.Point(14, 111)
        Me.lblBPFacilityManualME.Name = "lblBPFacilityManualME"
        Me.lblBPFacilityManualME.Size = New System.Drawing.Size(26, 13)
        Me.lblBPFacilityManualME.TabIndex = 13
        Me.lblBPFacilityManualME.Text = "ME:"
        Me.lblBPFacilityManualME.Visible = false
        '
        'lblBPFacilityBonus
        '
        Me.lblBPFacilityBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPFacilityBonus.Location = New System.Drawing.Point(6, 108)
        Me.lblBPFacilityBonus.Name = "lblBPFacilityBonus"
        Me.lblBPFacilityBonus.Size = New System.Drawing.Size(150, 20)
        Me.lblBPFacilityBonus.TabIndex = 12
        Me.lblBPFacilityBonus.Text = " Bonus: -20% ME; -20% TE"
        Me.lblBPFacilityBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBPFacilityBonus.Visible = false
        '
        'tabInventionCalcs
        '
        Me.tabInventionCalcs.Controls.Add(Me.lblBPCopyTime)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPT2InventStatus)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPCopyCosts)
        Me.tabInventionCalcs.Controls.Add(Me.txtBPInventionLines)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPInventionLines)
        Me.tabInventionCalcs.Controls.Add(Me.lblInventionChance1)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPDecryptor)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPInventionTime)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPDecryptorStats)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPInventionCost)
        Me.tabInventionCalcs.Controls.Add(Me.cmbBPInventionDecryptor)
        Me.tabInventionCalcs.Controls.Add(Me.lblBPInventionChance)
        Me.tabInventionCalcs.Controls.Add(Me.chkBPIncludeInventionTime)
        Me.tabInventionCalcs.Controls.Add(Me.chkBPIncludeCopyTime)
        Me.tabInventionCalcs.Controls.Add(Me.chkBPIncludeCopyCosts)
        Me.tabInventionCalcs.Controls.Add(Me.chkBPIncludeInventionCosts)
        Me.tabInventionCalcs.Location = New System.Drawing.Point(4, 4)
        Me.tabInventionCalcs.Margin = New System.Windows.Forms.Padding(0)
        Me.tabInventionCalcs.Name = "tabInventionCalcs"
        Me.tabInventionCalcs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInventionCalcs.Size = New System.Drawing.Size(281, 132)
        Me.tabInventionCalcs.TabIndex = 0
        Me.tabInventionCalcs.Text = "Calcs"
        Me.tabInventionCalcs.UseVisualStyleBackColor = true
        '
        'lblBPCopyTime
        '
        Me.lblBPCopyTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPCopyTime.Location = New System.Drawing.Point(179, 111)
        Me.lblBPCopyTime.Name = "lblBPCopyTime"
        Me.lblBPCopyTime.Size = New System.Drawing.Size(99, 17)
        Me.lblBPCopyTime.TabIndex = 36
        Me.lblBPCopyTime.Text = "00:00:00"
        Me.lblBPCopyTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPT2InventStatus
        '
        Me.lblBPT2InventStatus.AutoSize = true
        Me.lblBPT2InventStatus.ForeColor = System.Drawing.Color.Black
        Me.lblBPT2InventStatus.Location = New System.Drawing.Point(1, 4)
        Me.lblBPT2InventStatus.Name = "lblBPT2InventStatus"
        Me.lblBPT2InventStatus.Size = New System.Drawing.Size(70, 13)
        Me.lblBPT2InventStatus.TabIndex = 19
        Me.lblBPT2InventStatus.Text = "T2 Invention:"
        '
        'lblBPCopyCosts
        '
        Me.lblBPCopyCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPCopyCosts.Location = New System.Drawing.Point(71, 111)
        Me.lblBPCopyCosts.Name = "lblBPCopyCosts"
        Me.lblBPCopyCosts.Size = New System.Drawing.Size(105, 17)
        Me.lblBPCopyCosts.TabIndex = 34
        Me.lblBPCopyCosts.Text = "0.00"
        Me.lblBPCopyCosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBPInventionLines
        '
        Me.txtBPInventionLines.Location = New System.Drawing.Point(4, 36)
        Me.txtBPInventionLines.MaxLength = 4
        Me.txtBPInventionLines.Name = "txtBPInventionLines"
        Me.txtBPInventionLines.Size = New System.Drawing.Size(31, 20)
        Me.txtBPInventionLines.TabIndex = 24
        '
        'lblBPInventionLines
        '
        Me.lblBPInventionLines.AutoSize = true
        Me.lblBPInventionLines.Location = New System.Drawing.Point(2, 22)
        Me.lblBPInventionLines.Name = "lblBPInventionLines"
        Me.lblBPInventionLines.Size = New System.Drawing.Size(35, 13)
        Me.lblBPInventionLines.TabIndex = 23
        Me.lblBPInventionLines.Text = "Lines:"
        '
        'lblInventionChance1
        '
        Me.lblInventionChance1.AutoSize = true
        Me.lblInventionChance1.Location = New System.Drawing.Point(2, 60)
        Me.lblInventionChance1.Name = "lblInventionChance1"
        Me.lblInventionChance1.Size = New System.Drawing.Size(47, 13)
        Me.lblInventionChance1.TabIndex = 27
        Me.lblInventionChance1.Text = "Chance:"
        '
        'lblBPDecryptor
        '
        Me.lblBPDecryptor.AutoSize = true
        Me.lblBPDecryptor.Location = New System.Drawing.Point(38, 22)
        Me.lblBPDecryptor.Name = "lblBPDecryptor"
        Me.lblBPDecryptor.Size = New System.Drawing.Size(89, 13)
        Me.lblBPDecryptor.TabIndex = 25
        Me.lblBPDecryptor.Text = "Select Decryptor:"
        '
        'lblBPInventionTime
        '
        Me.lblBPInventionTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPInventionTime.Location = New System.Drawing.Point(179, 75)
        Me.lblBPInventionTime.Name = "lblBPInventionTime"
        Me.lblBPInventionTime.Size = New System.Drawing.Size(98, 17)
        Me.lblBPInventionTime.TabIndex = 32
        Me.lblBPInventionTime.Text = "00:00:00"
        Me.lblBPInventionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPDecryptorStats
        '
        Me.lblBPDecryptorStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPDecryptorStats.Location = New System.Drawing.Point(179, 2)
        Me.lblBPDecryptorStats.Name = "lblBPDecryptorStats"
        Me.lblBPDecryptorStats.Size = New System.Drawing.Size(98, 30)
        Me.lblBPDecryptorStats.TabIndex = 20
        Me.lblBPDecryptorStats.Text = "ME: -4, TE: -3, Bonus Runs: +9"
        Me.lblBPDecryptorStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPInventionCost
        '
        Me.lblBPInventionCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPInventionCost.Location = New System.Drawing.Point(71, 75)
        Me.lblBPInventionCost.Name = "lblBPInventionCost"
        Me.lblBPInventionCost.Size = New System.Drawing.Size(105, 17)
        Me.lblBPInventionCost.TabIndex = 30
        Me.lblBPInventionCost.Text = "0.00"
        Me.lblBPInventionCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBPInventionDecryptor
        '
        Me.cmbBPInventionDecryptor.FormattingEnabled = true
        Me.cmbBPInventionDecryptor.ItemHeight = 13
        Me.cmbBPInventionDecryptor.Location = New System.Drawing.Point(41, 36)
        Me.cmbBPInventionDecryptor.Name = "cmbBPInventionDecryptor"
        Me.cmbBPInventionDecryptor.Size = New System.Drawing.Size(236, 21)
        Me.cmbBPInventionDecryptor.TabIndex = 26
        Me.cmbBPInventionDecryptor.Text = "Interface Alignment Chart"
        '
        'lblBPInventionChance
        '
        Me.lblBPInventionChance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPInventionChance.Location = New System.Drawing.Point(4, 75)
        Me.lblBPInventionChance.Name = "lblBPInventionChance"
        Me.lblBPInventionChance.Size = New System.Drawing.Size(63, 17)
        Me.lblBPInventionChance.TabIndex = 28
        Me.lblBPInventionChance.Text = "100.00%"
        Me.lblBPInventionChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkBPIncludeInventionTime
        '
        Me.chkBPIncludeInventionTime.AutoSize = true
        Me.chkBPIncludeInventionTime.Location = New System.Drawing.Point(179, 59)
        Me.chkBPIncludeInventionTime.Name = "chkBPIncludeInventionTime"
        Me.chkBPIncludeInventionTime.Size = New System.Drawing.Size(99, 17)
        Me.chkBPIncludeInventionTime.TabIndex = 31
        Me.chkBPIncludeInventionTime.Text = "Invention Time:"
        Me.chkBPIncludeInventionTime.UseVisualStyleBackColor = true
        '
        'chkBPIncludeCopyTime
        '
        Me.chkBPIncludeCopyTime.AutoSize = true
        Me.chkBPIncludeCopyTime.Location = New System.Drawing.Point(179, 95)
        Me.chkBPIncludeCopyTime.Name = "chkBPIncludeCopyTime"
        Me.chkBPIncludeCopyTime.Size = New System.Drawing.Size(79, 17)
        Me.chkBPIncludeCopyTime.TabIndex = 35
        Me.chkBPIncludeCopyTime.Text = "Copy Time:"
        Me.chkBPIncludeCopyTime.UseVisualStyleBackColor = true
        '
        'chkBPIncludeCopyCosts
        '
        Me.chkBPIncludeCopyCosts.AutoSize = true
        Me.chkBPIncludeCopyCosts.Location = New System.Drawing.Point(71, 95)
        Me.chkBPIncludeCopyCosts.Name = "chkBPIncludeCopyCosts"
        Me.chkBPIncludeCopyCosts.Size = New System.Drawing.Size(82, 17)
        Me.chkBPIncludeCopyCosts.TabIndex = 33
        Me.chkBPIncludeCopyCosts.Text = "Copy Costs:"
        Me.chkBPIncludeCopyCosts.UseVisualStyleBackColor = true
        '
        'chkBPIncludeInventionCosts
        '
        Me.chkBPIncludeInventionCosts.AutoSize = true
        Me.chkBPIncludeInventionCosts.Location = New System.Drawing.Point(71, 59)
        Me.chkBPIncludeInventionCosts.Name = "chkBPIncludeInventionCosts"
        Me.chkBPIncludeInventionCosts.Size = New System.Drawing.Size(102, 17)
        Me.chkBPIncludeInventionCosts.TabIndex = 29
        Me.chkBPIncludeInventionCosts.Text = "Invention Costs:"
        Me.chkBPIncludeInventionCosts.UseVisualStyleBackColor = true
        '
        'tabT3Calcs
        '
        Me.tabT3Calcs.Controls.Add(Me.lblBPT3Decryptor)
        Me.tabT3Calcs.Controls.Add(Me.cmbBPT3Decryptor)
        Me.tabT3Calcs.Controls.Add(Me.lblBPT3Stats)
        Me.tabT3Calcs.Controls.Add(Me.lblBPRelic)
        Me.tabT3Calcs.Controls.Add(Me.txtBPRelicLines)
        Me.tabT3Calcs.Controls.Add(Me.lblBPRelicLines)
        Me.tabT3Calcs.Controls.Add(Me.lblBPRETime)
        Me.tabT3Calcs.Controls.Add(Me.cmbBPRelic)
        Me.tabT3Calcs.Controls.Add(Me.lblBPRECost)
        Me.tabT3Calcs.Controls.Add(Me.lblBPT3InventionChance)
        Me.tabT3Calcs.Controls.Add(Me.lblBPT3InventionChance1)
        Me.tabT3Calcs.Controls.Add(Me.lblT3InventStatus)
        Me.tabT3Calcs.Controls.Add(Me.chkBPIncludeT3Time)
        Me.tabT3Calcs.Controls.Add(Me.chkBPIncludeT3Costs)
        Me.tabT3Calcs.Location = New System.Drawing.Point(4, 4)
        Me.tabT3Calcs.Name = "tabT3Calcs"
        Me.tabT3Calcs.Size = New System.Drawing.Size(281, 132)
        Me.tabT3Calcs.TabIndex = 2
        Me.tabT3Calcs.Text = "Calcs"
        Me.tabT3Calcs.UseVisualStyleBackColor = true
        '
        'lblBPT3Decryptor
        '
        Me.lblBPT3Decryptor.AutoSize = true
        Me.lblBPT3Decryptor.Location = New System.Drawing.Point(69, 94)
        Me.lblBPT3Decryptor.Name = "lblBPT3Decryptor"
        Me.lblBPT3Decryptor.Size = New System.Drawing.Size(89, 13)
        Me.lblBPT3Decryptor.TabIndex = 53
        Me.lblBPT3Decryptor.Text = "Select Decryptor:"
        '
        'cmbBPT3Decryptor
        '
        Me.cmbBPT3Decryptor.FormattingEnabled = true
        Me.cmbBPT3Decryptor.ItemHeight = 13
        Me.cmbBPT3Decryptor.Location = New System.Drawing.Point(71, 108)
        Me.cmbBPT3Decryptor.Name = "cmbBPT3Decryptor"
        Me.cmbBPT3Decryptor.Size = New System.Drawing.Size(206, 21)
        Me.cmbBPT3Decryptor.TabIndex = 54
        Me.cmbBPT3Decryptor.Text = "Interface Alignment Chart"
        '
        'lblBPT3Stats
        '
        Me.lblBPT3Stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPT3Stats.Location = New System.Drawing.Point(199, 2)
        Me.lblBPT3Stats.Name = "lblBPT3Stats"
        Me.lblBPT3Stats.Size = New System.Drawing.Size(78, 30)
        Me.lblBPT3Stats.TabIndex = 52
        Me.lblBPT3Stats.Text = "ME: -4, TE: -3, End Runs: +9"
        Me.lblBPT3Stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPRelic
        '
        Me.lblBPRelic.AutoSize = true
        Me.lblBPRelic.Location = New System.Drawing.Point(38, 22)
        Me.lblBPRelic.Name = "lblBPRelic"
        Me.lblBPRelic.Size = New System.Drawing.Size(67, 13)
        Me.lblBPRelic.TabIndex = 41
        Me.lblBPRelic.Text = "Select Relic:"
        '
        'txtBPRelicLines
        '
        Me.txtBPRelicLines.Location = New System.Drawing.Point(4, 36)
        Me.txtBPRelicLines.MaxLength = 4
        Me.txtBPRelicLines.Name = "txtBPRelicLines"
        Me.txtBPRelicLines.Size = New System.Drawing.Size(31, 20)
        Me.txtBPRelicLines.TabIndex = 42
        '
        'lblBPRelicLines
        '
        Me.lblBPRelicLines.AutoSize = true
        Me.lblBPRelicLines.Location = New System.Drawing.Point(2, 22)
        Me.lblBPRelicLines.Name = "lblBPRelicLines"
        Me.lblBPRelicLines.Size = New System.Drawing.Size(35, 13)
        Me.lblBPRelicLines.TabIndex = 40
        Me.lblBPRelicLines.Text = "Lines:"
        '
        'lblBPRETime
        '
        Me.lblBPRETime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPRETime.Location = New System.Drawing.Point(179, 75)
        Me.lblBPRETime.Name = "lblBPRETime"
        Me.lblBPRETime.Size = New System.Drawing.Size(98, 17)
        Me.lblBPRETime.TabIndex = 50
        Me.lblBPRETime.Text = "00:00:00"
        Me.lblBPRETime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBPRelic
        '
        Me.cmbBPRelic.FormattingEnabled = true
        Me.cmbBPRelic.ItemHeight = 13
        Me.cmbBPRelic.Items.AddRange(New Object() {"Wrecked", "Malfunctioning", "Intact"})
        Me.cmbBPRelic.Location = New System.Drawing.Point(41, 36)
        Me.cmbBPRelic.Name = "cmbBPRelic"
        Me.cmbBPRelic.Size = New System.Drawing.Size(236, 21)
        Me.cmbBPRelic.TabIndex = 43
        Me.cmbBPRelic.Text = "None"
        '
        'lblBPRECost
        '
        Me.lblBPRECost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPRECost.Location = New System.Drawing.Point(71, 75)
        Me.lblBPRECost.Name = "lblBPRECost"
        Me.lblBPRECost.Size = New System.Drawing.Size(105, 17)
        Me.lblBPRECost.TabIndex = 48
        Me.lblBPRECost.Text = "0.00"
        Me.lblBPRECost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPT3InventionChance
        '
        Me.lblBPT3InventionChance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPT3InventionChance.Location = New System.Drawing.Point(4, 75)
        Me.lblBPT3InventionChance.Name = "lblBPT3InventionChance"
        Me.lblBPT3InventionChance.Size = New System.Drawing.Size(63, 17)
        Me.lblBPT3InventionChance.TabIndex = 46
        Me.lblBPT3InventionChance.Text = "100.00%"
        Me.lblBPT3InventionChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPT3InventionChance1
        '
        Me.lblBPT3InventionChance1.AutoSize = true
        Me.lblBPT3InventionChance1.Location = New System.Drawing.Point(2, 60)
        Me.lblBPT3InventionChance1.Name = "lblBPT3InventionChance1"
        Me.lblBPT3InventionChance1.Size = New System.Drawing.Size(47, 13)
        Me.lblBPT3InventionChance1.TabIndex = 45
        Me.lblBPT3InventionChance1.Text = "Chance:"
        '
        'lblT3InventStatus
        '
        Me.lblT3InventStatus.ForeColor = System.Drawing.Color.Black
        Me.lblT3InventStatus.Location = New System.Drawing.Point(1, 4)
        Me.lblT3InventStatus.Name = "lblT3InventStatus"
        Me.lblT3InventStatus.Size = New System.Drawing.Size(185, 13)
        Me.lblT3InventStatus.TabIndex = 37
        Me.lblT3InventStatus.Text = "T3 Invention:"
        '
        'chkBPIncludeT3Time
        '
        Me.chkBPIncludeT3Time.AutoSize = true
        Me.chkBPIncludeT3Time.Location = New System.Drawing.Point(179, 59)
        Me.chkBPIncludeT3Time.Name = "chkBPIncludeT3Time"
        Me.chkBPIncludeT3Time.Size = New System.Drawing.Size(99, 17)
        Me.chkBPIncludeT3Time.TabIndex = 49
        Me.chkBPIncludeT3Time.Text = "Invention Time:"
        Me.chkBPIncludeT3Time.UseVisualStyleBackColor = true
        '
        'chkBPIncludeT3Costs
        '
        Me.chkBPIncludeT3Costs.AutoSize = true
        Me.chkBPIncludeT3Costs.Location = New System.Drawing.Point(71, 59)
        Me.chkBPIncludeT3Costs.Name = "chkBPIncludeT3Costs"
        Me.chkBPIncludeT3Costs.Size = New System.Drawing.Size(102, 17)
        Me.chkBPIncludeT3Costs.TabIndex = 47
        Me.chkBPIncludeT3Costs.Text = "Invention Costs:"
        Me.chkBPIncludeT3Costs.UseVisualStyleBackColor = true
        '
        'btnBPSaveSettings
        '
        Me.btnBPSaveSettings.Location = New System.Drawing.Point(54, 153)
        Me.btnBPSaveSettings.Name = "btnBPSaveSettings"
        Me.btnBPSaveSettings.Size = New System.Drawing.Size(82, 34)
        Me.btnBPSaveSettings.TabIndex = 14
        Me.btnBPSaveSettings.Text = "Save Settings"
        Me.btnBPSaveSettings.UseVisualStyleBackColor = true
        '
        'txtBPLines
        '
        Me.txtBPLines.Location = New System.Drawing.Point(38, 105)
        Me.txtBPLines.MaxLength = 3
        Me.txtBPLines.Name = "txtBPLines"
        Me.txtBPLines.Size = New System.Drawing.Size(32, 20)
        Me.txtBPLines.TabIndex = 8
        '
        'pictBP
        '
        Me.pictBP.BackColor = System.Drawing.Color.White
        Me.pictBP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictBP.Location = New System.Drawing.Point(6, 12)
        Me.pictBP.Name = "pictBP"
        Me.pictBP.Size = New System.Drawing.Size(68, 69)
        Me.pictBP.TabIndex = 0
        Me.pictBP.TabStop = false
        '
        'txtBPNumBPs
        '
        Me.txtBPNumBPs.Location = New System.Drawing.Point(104, 105)
        Me.txtBPNumBPs.Name = "txtBPNumBPs"
        Me.txtBPNumBPs.Size = New System.Drawing.Size(32, 20)
        Me.txtBPNumBPs.TabIndex = 10
        '
        'btnBPRefreshBP
        '
        Me.btnBPRefreshBP.Location = New System.Drawing.Point(6, 188)
        Me.btnBPRefreshBP.Name = "btnBPRefreshBP"
        Me.btnBPRefreshBP.Size = New System.Drawing.Size(130, 30)
        Me.btnBPRefreshBP.TabIndex = 13
        Me.btnBPRefreshBP.Text = "Refresh"
        Me.btnBPRefreshBP.UseVisualStyleBackColor = true
        '
        'lblBPLines
        '
        Me.lblBPLines.AutoSize = true
        Me.lblBPLines.Location = New System.Drawing.Point(4, 109)
        Me.lblBPLines.Name = "lblBPLines"
        Me.lblBPLines.Size = New System.Drawing.Size(35, 13)
        Me.lblBPLines.TabIndex = 7
        Me.lblBPLines.Text = "Lines:"
        '
        'txtBPME
        '
        Me.txtBPME.Location = New System.Drawing.Point(76, 60)
        Me.txtBPME.MaxLength = 2
        Me.txtBPME.Name = "txtBPME"
        Me.txtBPME.Size = New System.Drawing.Size(29, 20)
        Me.txtBPME.TabIndex = 4
        Me.txtBPME.Text = "0"
        Me.txtBPME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBPRuns
        '
        Me.lblBPRuns.AutoSize = true
        Me.lblBPRuns.Location = New System.Drawing.Point(74, 11)
        Me.lblBPRuns.Name = "lblBPRuns"
        Me.lblBPRuns.Size = New System.Drawing.Size(62, 13)
        Me.lblBPRuns.TabIndex = 0
        Me.lblBPRuns.Text = "Total Runs:"
        '
        'gbBPTeam
        '
        Me.gbBPTeam.Controls.Add(Me.txtBPTeamBonus)
        Me.gbBPTeam.Controls.Add(Me.cmbBPTeam)
        Me.gbBPTeam.Controls.Add(Me.lblBPDefaultTeam)
        Me.gbBPTeam.Controls.Add(Me.btnBPSaveTeam)
        Me.gbBPTeam.Controls.Add(Me.cmbBPTeamActivities)
        Me.gbBPTeam.Enabled = false
        Me.gbBPTeam.Location = New System.Drawing.Point(140, 7)
        Me.gbBPTeam.Name = "gbBPTeam"
        Me.gbBPTeam.Size = New System.Drawing.Size(310, 70)
        Me.gbBPTeam.TabIndex = 15
        Me.gbBPTeam.TabStop = false
        Me.gbBPTeam.Text = "Team Bonus:"
        '
        'txtBPTeamBonus
        '
        Me.txtBPTeamBonus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBPTeamBonus.Location = New System.Drawing.Point(102, 12)
        Me.txtBPTeamBonus.Multiline = true
        Me.txtBPTeamBonus.Name = "txtBPTeamBonus"
        Me.txtBPTeamBonus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBPTeamBonus.Size = New System.Drawing.Size(149, 28)
        Me.txtBPTeamBonus.TabIndex = 20
        '
        'cmbBPTeam
        '
        Me.cmbBPTeam.Location = New System.Drawing.Point(4, 44)
        Me.cmbBPTeam.Name = "cmbBPTeam"
        Me.cmbBPTeam.Size = New System.Drawing.Size(247, 21)
        Me.cmbBPTeam.TabIndex = 19
        Me.cmbBPTeam.Text = "Select Team"
        '
        'lblBPDefaultTeam
        '
        Me.lblBPDefaultTeam.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblBPDefaultTeam.Location = New System.Drawing.Point(253, 7)
        Me.lblBPDefaultTeam.Name = "lblBPDefaultTeam"
        Me.lblBPDefaultTeam.Size = New System.Drawing.Size(55, 34)
        Me.lblBPDefaultTeam.TabIndex = 3
        Me.lblBPDefaultTeam.Text = "Default Team"
        Me.lblBPDefaultTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBPSaveTeam
        '
        Me.btnBPSaveTeam.Enabled = false
        Me.btnBPSaveTeam.Location = New System.Drawing.Point(252, 43)
        Me.btnBPSaveTeam.Name = "btnBPSaveTeam"
        Me.btnBPSaveTeam.Size = New System.Drawing.Size(56, 22)
        Me.btnBPSaveTeam.TabIndex = 4
        Me.btnBPSaveTeam.Text = "Save"
        Me.btnBPSaveTeam.UseVisualStyleBackColor = true
        '
        'cmbBPTeamActivities
        '
        Me.cmbBPTeamActivities.FormattingEnabled = true
        Me.cmbBPTeamActivities.Location = New System.Drawing.Point(4, 16)
        Me.cmbBPTeamActivities.Name = "cmbBPTeamActivities"
        Me.cmbBPTeamActivities.Size = New System.Drawing.Size(92, 21)
        Me.cmbBPTeamActivities.TabIndex = 0
        Me.cmbBPTeamActivities.Text = "Select Activity"
        '
        'chkBPBuildBuy
        '
        Me.chkBPBuildBuy.AutoSize = true
        Me.chkBPBuildBuy.Location = New System.Drawing.Point(12, 86)
        Me.chkBPBuildBuy.Name = "chkBPBuildBuy"
        Me.chkBPBuildBuy.Size = New System.Drawing.Size(119, 17)
        Me.chkBPBuildBuy.TabIndex = 6
        Me.chkBPBuildBuy.Text = "Calculate Build/Buy"
        Me.chkBPBuildBuy.UseVisualStyleBackColor = true
        '
        'txtBPRuns
        '
        Me.txtBPRuns.Location = New System.Drawing.Point(76, 25)
        Me.txtBPRuns.MaxLength = 6
        Me.txtBPRuns.Name = "txtBPRuns"
        Me.txtBPRuns.Size = New System.Drawing.Size(60, 20)
        Me.txtBPRuns.TabIndex = 1
        Me.txtBPRuns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBPAddlCosts
        '
        Me.txtBPAddlCosts.Location = New System.Drawing.Point(38, 130)
        Me.txtBPAddlCosts.MaxLength = 15
        Me.txtBPAddlCosts.Name = "txtBPAddlCosts"
        Me.txtBPAddlCosts.Size = New System.Drawing.Size(98, 20)
        Me.txtBPAddlCosts.TabIndex = 12
        Me.txtBPAddlCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBPAddlCosts
        '
        Me.lblBPAddlCosts.Location = New System.Drawing.Point(4, 126)
        Me.lblBPAddlCosts.Name = "lblBPAddlCosts"
        Me.lblBPAddlCosts.Size = New System.Drawing.Size(39, 28)
        Me.lblBPAddlCosts.TabIndex = 11
        Me.lblBPAddlCosts.Text = "Add'l Costs:"
        '
        'lblBPME
        '
        Me.lblBPME.AutoSize = true
        Me.lblBPME.Location = New System.Drawing.Point(77, 46)
        Me.lblBPME.Name = "lblBPME"
        Me.lblBPME.Size = New System.Drawing.Size(26, 13)
        Me.lblBPME.TabIndex = 2
        Me.lblBPME.Text = "ME:"
        '
        'txtBPTE
        '
        Me.txtBPTE.Location = New System.Drawing.Point(107, 60)
        Me.txtBPTE.MaxLength = 2
        Me.txtBPTE.Name = "txtBPTE"
        Me.txtBPTE.Size = New System.Drawing.Size(29, 20)
        Me.txtBPTE.TabIndex = 5
        Me.txtBPTE.Text = "0"
        Me.txtBPTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBPPE
        '
        Me.lblBPPE.AutoSize = true
        Me.lblBPPE.Location = New System.Drawing.Point(109, 46)
        Me.lblBPPE.Name = "lblBPPE"
        Me.lblBPPE.Size = New System.Drawing.Size(24, 13)
        Me.lblBPPE.TabIndex = 3
        Me.lblBPPE.Text = "TE:"
        '
        'lblBPNumBPs
        '
        Me.lblBPNumBPs.AutoSize = true
        Me.lblBPNumBPs.Location = New System.Drawing.Point(75, 109)
        Me.lblBPNumBPs.Name = "lblBPNumBPs"
        Me.lblBPNumBPs.Size = New System.Drawing.Size(29, 13)
        Me.lblBPNumBPs.TabIndex = 9
        Me.lblBPNumBPs.Text = "BPs:"
        '
        'gbBPShopandCopy
        '
        Me.gbBPShopandCopy.Controls.Add(Me.rbtnBPCopyInvREMats)
        Me.gbBPShopandCopy.Controls.Add(Me.rbtnBPComponentCopy)
        Me.gbBPShopandCopy.Controls.Add(Me.rbtnBPRawmatCopy)
        Me.gbBPShopandCopy.Controls.Add(Me.btnBPCopyMatstoClip)
        Me.gbBPShopandCopy.Controls.Add(Me.btnBPAddBPMatstoShoppingList)
        Me.gbBPShopandCopy.Location = New System.Drawing.Point(4, 174)
        Me.gbBPShopandCopy.Name = "gbBPShopandCopy"
        Me.gbBPShopandCopy.Size = New System.Drawing.Size(293, 58)
        Me.gbBPShopandCopy.TabIndex = 3
        Me.gbBPShopandCopy.TabStop = false
        '
        'rbtnBPCopyInvREMats
        '
        Me.rbtnBPCopyInvREMats.AutoSize = true
        Me.rbtnBPCopyInvREMats.Location = New System.Drawing.Point(190, 38)
        Me.rbtnBPCopyInvREMats.Name = "rbtnBPCopyInvREMats"
        Me.rbtnBPCopyInvREMats.Size = New System.Drawing.Size(89, 17)
        Me.rbtnBPCopyInvREMats.TabIndex = 4
        Me.rbtnBPCopyInvREMats.TabStop = true
        Me.rbtnBPCopyInvREMats.Text = "Invention/RE"
        Me.rbtnBPCopyInvREMats.UseVisualStyleBackColor = true
        '
        'rbtnBPComponentCopy
        '
        Me.rbtnBPComponentCopy.AutoSize = true
        Me.rbtnBPComponentCopy.Checked = true
        Me.rbtnBPComponentCopy.Location = New System.Drawing.Point(190, 8)
        Me.rbtnBPComponentCopy.Name = "rbtnBPComponentCopy"
        Me.rbtnBPComponentCopy.Size = New System.Drawing.Size(84, 17)
        Me.rbtnBPComponentCopy.TabIndex = 2
        Me.rbtnBPComponentCopy.TabStop = true
        Me.rbtnBPComponentCopy.Text = "Components"
        Me.rbtnBPComponentCopy.UseVisualStyleBackColor = true
        '
        'rbtnBPRawmatCopy
        '
        Me.rbtnBPRawmatCopy.AutoSize = true
        Me.rbtnBPRawmatCopy.Location = New System.Drawing.Point(190, 23)
        Me.rbtnBPRawmatCopy.Name = "rbtnBPRawmatCopy"
        Me.rbtnBPRawmatCopy.Size = New System.Drawing.Size(92, 17)
        Me.rbtnBPRawmatCopy.TabIndex = 3
        Me.rbtnBPRawmatCopy.TabStop = true
        Me.rbtnBPRawmatCopy.Text = "Raw Materials"
        Me.rbtnBPRawmatCopy.UseVisualStyleBackColor = true
        '
        'btnBPCopyMatstoClip
        '
        Me.btnBPCopyMatstoClip.Location = New System.Drawing.Point(98, 11)
        Me.btnBPCopyMatstoClip.Name = "btnBPCopyMatstoClip"
        Me.btnBPCopyMatstoClip.Size = New System.Drawing.Size(86, 39)
        Me.btnBPCopyMatstoClip.TabIndex = 1
        Me.btnBPCopyMatstoClip.Text = "Copy to Clipboard"
        Me.btnBPCopyMatstoClip.UseVisualStyleBackColor = true
        '
        'btnBPAddBPMatstoShoppingList
        '
        Me.btnBPAddBPMatstoShoppingList.Location = New System.Drawing.Point(9, 11)
        Me.btnBPAddBPMatstoShoppingList.Name = "btnBPAddBPMatstoShoppingList"
        Me.btnBPAddBPMatstoShoppingList.Size = New System.Drawing.Size(86, 39)
        Me.btnBPAddBPMatstoShoppingList.TabIndex = 0
        Me.btnBPAddBPMatstoShoppingList.Text = "Add to Shopping List"
        Me.btnBPAddBPMatstoShoppingList.UseVisualStyleBackColor = true
        '
        'lblBPCanMakeBPAll
        '
        Me.lblBPCanMakeBPAll.ForeColor = System.Drawing.Color.Red
        Me.lblBPCanMakeBPAll.Location = New System.Drawing.Point(571, 591)
        Me.lblBPCanMakeBPAll.Name = "lblBPCanMakeBPAll"
        Me.lblBPCanMakeBPAll.Size = New System.Drawing.Size(282, 16)
        Me.lblBPCanMakeBPAll.TabIndex = 27
        Me.lblBPCanMakeBPAll.Text = "You Cannot Make All Components for this Item"
        Me.lblBPCanMakeBPAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPRawMatCost
        '
        Me.lblBPRawMatCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPRawMatCost.Location = New System.Drawing.Point(1007, 591)
        Me.lblBPRawMatCost.Name = "lblBPRawMatCost"
        Me.lblBPRawMatCost.Size = New System.Drawing.Size(118, 16)
        Me.lblBPRawMatCost.TabIndex = 24
        Me.lblBPRawMatCost.Text = "0.00"
        Me.lblBPRawMatCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBPRawMatCost1
        '
        Me.lblBPRawMatCost1.AutoSize = true
        Me.lblBPRawMatCost1.Location = New System.Drawing.Point(928, 593)
        Me.lblBPRawMatCost1.Name = "lblBPRawMatCost1"
        Me.lblBPRawMatCost1.Size = New System.Drawing.Size(77, 13)
        Me.lblBPRawMatCost1.TabIndex = 23
        Me.lblBPRawMatCost1.Text = "Raw Mat Cost:"
        Me.lblBPRawMatCost1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBPCanMakeBP
        '
        Me.lblBPCanMakeBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBPCanMakeBP.ForeColor = System.Drawing.Color.Red
        Me.lblBPCanMakeBP.Location = New System.Drawing.Point(8, 591)
        Me.lblBPCanMakeBP.Name = "lblBPCanMakeBP"
        Me.lblBPCanMakeBP.Size = New System.Drawing.Size(250, 16)
        Me.lblBPCanMakeBP.TabIndex = 13
        Me.lblBPCanMakeBP.Text = "You Cannot Make this Item"
        Me.lblBPCanMakeBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPRawMats
        '
        Me.lblBPRawMats.Location = New System.Drawing.Point(569, 235)
        Me.lblBPRawMats.Name = "lblBPRawMats"
        Me.lblBPRawMats.Size = New System.Drawing.Size(562, 20)
        Me.lblBPRawMats.TabIndex = 14
        Me.lblBPRawMats.Text = "Raw Material List"
        Me.lblBPRawMats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPComponentMatCost
        '
        Me.lblBPComponentMatCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBPComponentMatCost.Location = New System.Drawing.Point(449, 591)
        Me.lblBPComponentMatCost.Name = "lblBPComponentMatCost"
        Me.lblBPComponentMatCost.Size = New System.Drawing.Size(118, 16)
        Me.lblBPComponentMatCost.TabIndex = 26
        Me.lblBPComponentMatCost.Text = "0.00"
        Me.lblBPComponentMatCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBPComponentMats
        '
        Me.lblBPComponentMats.Location = New System.Drawing.Point(4, 235)
        Me.lblBPComponentMats.Name = "lblBPComponentMats"
        Me.lblBPComponentMats.Size = New System.Drawing.Size(562, 20)
        Me.lblBPComponentMats.TabIndex = 13
        Me.lblBPComponentMats.Text = "Component Material List"
        Me.lblBPComponentMats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBPComponentMatCost1
        '
        Me.lblBPComponentMatCost1.AutoSize = true
        Me.lblBPComponentMatCost1.Location = New System.Drawing.Point(338, 593)
        Me.lblBPComponentMatCost1.Name = "lblBPComponentMatCost1"
        Me.lblBPComponentMatCost1.Size = New System.Drawing.Size(109, 13)
        Me.lblBPComponentMatCost1.TabIndex = 25
        Me.lblBPComponentMatCost1.Text = "Component Mat Cost:"
        Me.lblBPComponentMatCost1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbBPBlueprintTech
        '
        Me.gbBPBlueprintTech.Controls.Add(Me.chkBPPirateFaction)
        Me.gbBPBlueprintTech.Controls.Add(Me.chkBPStoryline)
        Me.gbBPBlueprintTech.Controls.Add(Me.chkBPNavyFaction)
        Me.gbBPBlueprintTech.Controls.Add(Me.chkBPT3)
        Me.gbBPBlueprintTech.Controls.Add(Me.chkBPT2)
        Me.gbBPBlueprintTech.Controls.Add(Me.chkBPT1)
        Me.gbBPBlueprintTech.Location = New System.Drawing.Point(302, 106)
        Me.gbBPBlueprintTech.Name = "gbBPBlueprintTech"
        Me.gbBPBlueprintTech.Size = New System.Drawing.Size(84, 126)
        Me.gbBPBlueprintTech.TabIndex = 5
        Me.gbBPBlueprintTech.TabStop = false
        Me.gbBPBlueprintTech.Text = "Tech"
        '
        'chkBPPirateFaction
        '
        Me.chkBPPirateFaction.AutoSize = true
        Me.chkBPPirateFaction.Location = New System.Drawing.Point(8, 105)
        Me.chkBPPirateFaction.Name = "chkBPPirateFaction"
        Me.chkBPPirateFaction.Size = New System.Drawing.Size(53, 17)
        Me.chkBPPirateFaction.TabIndex = 5
        Me.chkBPPirateFaction.Text = "Pirate"
        Me.chkBPPirateFaction.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkBPPirateFaction.UseVisualStyleBackColor = true
        '
        'chkBPStoryline
        '
        Me.chkBPStoryline.AutoSize = true
        Me.chkBPStoryline.Location = New System.Drawing.Point(8, 69)
        Me.chkBPStoryline.Name = "chkBPStoryline"
        Me.chkBPStoryline.Size = New System.Drawing.Size(66, 17)
        Me.chkBPStoryline.TabIndex = 3
        Me.chkBPStoryline.Text = "Storyline"
        Me.chkBPStoryline.UseVisualStyleBackColor = true
        '
        'chkBPNavyFaction
        '
        Me.chkBPNavyFaction.AutoSize = true
        Me.chkBPNavyFaction.Location = New System.Drawing.Point(8, 87)
        Me.chkBPNavyFaction.Name = "chkBPNavyFaction"
        Me.chkBPNavyFaction.Size = New System.Drawing.Size(51, 17)
        Me.chkBPNavyFaction.TabIndex = 4
        Me.chkBPNavyFaction.Text = "Navy"
        Me.chkBPNavyFaction.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkBPNavyFaction.UseVisualStyleBackColor = true
        '
        'chkBPT3
        '
        Me.chkBPT3.AutoSize = true
        Me.chkBPT3.Location = New System.Drawing.Point(8, 51)
        Me.chkBPT3.Name = "chkBPT3"
        Me.chkBPT3.Size = New System.Drawing.Size(60, 17)
        Me.chkBPT3.TabIndex = 2
        Me.chkBPT3.Text = "Tech 3"
        Me.chkBPT3.UseVisualStyleBackColor = true
        '
        'chkBPT2
        '
        Me.chkBPT2.AutoSize = true
        Me.chkBPT2.Location = New System.Drawing.Point(8, 33)
        Me.chkBPT2.Name = "chkBPT2"
        Me.chkBPT2.Size = New System.Drawing.Size(60, 17)
        Me.chkBPT2.TabIndex = 1
        Me.chkBPT2.Text = "Tech 2"
        Me.chkBPT2.UseVisualStyleBackColor = true
        '
        'chkBPT1
        '
        Me.chkBPT1.AutoSize = true
        Me.chkBPT1.Location = New System.Drawing.Point(8, 15)
        Me.chkBPT1.Name = "chkBPT1"
        Me.chkBPT1.Size = New System.Drawing.Size(60, 17)
        Me.chkBPT1.TabIndex = 0
        Me.chkBPT1.Text = "Tech 1"
        Me.chkBPT1.UseVisualStyleBackColor = true
        '
        'cmbBPBlueprintSelection
        '
        Me.cmbBPBlueprintSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBPBlueprintSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBPBlueprintSelection.Location = New System.Drawing.Point(4, 29)
        Me.cmbBPBlueprintSelection.Name = "cmbBPBlueprintSelection"
        Me.cmbBPBlueprintSelection.Size = New System.Drawing.Size(382, 21)
        Me.cmbBPBlueprintSelection.TabIndex = 1
        Me.cmbBPBlueprintSelection.Text = "Select Blueprint"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabBlueprints)
        Me.tabMain.Controls.Add(Me.tabUpdatePrices)
        Me.tabMain.Controls.Add(Me.tabManufacturing)
        Me.tabMain.Controls.Add(Me.tabDatacores)
        Me.tabMain.Controls.Add(Me.tabReactions)
        Me.tabMain.Controls.Add(Me.tabMining)
        Me.tabMain.Controls.Add(Me.tabPI)
        Me.tabMain.Location = New System.Drawing.Point(1, 26)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1145, 641)
        Me.tabMain.TabIndex = 1
        '
        'tabPI
        '
        Me.tabPI.Controls.Add(Me.MyListView6)
        Me.tabPI.Controls.Add(Me.btnPISaveSettings)
        Me.tabPI.Controls.Add(Me.gbPIPlanets)
        Me.tabPI.Controls.Add(Me.btnPIReset)
        Me.tabPI.Controls.Add(Me.MyListView5)
        Me.tabPI.Controls.Add(Me.MyListView4)
        Me.tabPI.Controls.Add(Me.MyListView3)
        Me.tabPI.Controls.Add(Me.MyListView2)
        Me.tabPI.Controls.Add(Me.MyListView1)
        Me.tabPI.Location = New System.Drawing.Point(4, 22)
        Me.tabPI.Name = "tabPI"
        Me.tabPI.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPI.Size = New System.Drawing.Size(1137, 615)
        Me.tabPI.TabIndex = 6
        Me.tabPI.Text = "Planetary Interaction"
        Me.tabPI.UseVisualStyleBackColor = true
        '
        'btnPISaveSettings
        '
        Me.btnPISaveSettings.Location = New System.Drawing.Point(315, 47)
        Me.btnPISaveSettings.Name = "btnPISaveSettings"
        Me.btnPISaveSettings.Size = New System.Drawing.Size(92, 23)
        Me.btnPISaveSettings.TabIndex = 74
        Me.btnPISaveSettings.Text = "Save Settings"
        Me.btnPISaveSettings.UseVisualStyleBackColor = true
        '
        'gbPIPlanets
        '
        Me.gbPIPlanets.Controls.Add(Me.chkPILava)
        Me.gbPIPlanets.Controls.Add(Me.chkPIPlasma)
        Me.gbPIPlanets.Controls.Add(Me.chkPIIce)
        Me.gbPIPlanets.Controls.Add(Me.chkPIGas)
        Me.gbPIPlanets.Controls.Add(Me.chkPIOcean)
        Me.gbPIPlanets.Controls.Add(Me.chkPIBarren)
        Me.gbPIPlanets.Controls.Add(Me.chkPIStorm)
        Me.gbPIPlanets.Controls.Add(Me.chkPITemperate)
        Me.gbPIPlanets.Location = New System.Drawing.Point(9, 9)
        Me.gbPIPlanets.Name = "gbPIPlanets"
        Me.gbPIPlanets.Size = New System.Drawing.Size(299, 67)
        Me.gbPIPlanets.TabIndex = 41
        Me.gbPIPlanets.TabStop = false
        Me.gbPIPlanets.Text = "Planets"
        '
        'chkPILava
        '
        Me.chkPILava.AutoSize = true
        Me.chkPILava.Location = New System.Drawing.Point(216, 19)
        Me.chkPILava.Name = "chkPILava"
        Me.chkPILava.Size = New System.Drawing.Size(50, 17)
        Me.chkPILava.TabIndex = 25
        Me.chkPILava.Text = "Lava"
        Me.chkPILava.UseVisualStyleBackColor = true
        '
        'chkPIPlasma
        '
        Me.chkPIPlasma.AutoSize = true
        Me.chkPIPlasma.Location = New System.Drawing.Point(83, 42)
        Me.chkPIPlasma.Name = "chkPIPlasma"
        Me.chkPIPlasma.Size = New System.Drawing.Size(60, 17)
        Me.chkPIPlasma.TabIndex = 27
        Me.chkPIPlasma.Text = "Plasma"
        Me.chkPIPlasma.UseVisualStyleBackColor = true
        '
        'chkPIIce
        '
        Me.chkPIIce.AutoSize = true
        Me.chkPIIce.Location = New System.Drawing.Point(153, 19)
        Me.chkPIIce.Name = "chkPIIce"
        Me.chkPIIce.Size = New System.Drawing.Size(41, 17)
        Me.chkPIIce.TabIndex = 23
        Me.chkPIIce.Text = "Ice"
        Me.chkPIIce.UseVisualStyleBackColor = true
        '
        'chkPIGas
        '
        Me.chkPIGas.AutoSize = true
        Me.chkPIGas.Location = New System.Drawing.Point(83, 19)
        Me.chkPIGas.Name = "chkPIGas"
        Me.chkPIGas.Size = New System.Drawing.Size(45, 17)
        Me.chkPIGas.TabIndex = 24
        Me.chkPIGas.Text = "Gas"
        Me.chkPIGas.UseVisualStyleBackColor = true
        '
        'chkPIOcean
        '
        Me.chkPIOcean.AutoSize = true
        Me.chkPIOcean.Location = New System.Drawing.Point(15, 42)
        Me.chkPIOcean.Name = "chkPIOcean"
        Me.chkPIOcean.Size = New System.Drawing.Size(58, 17)
        Me.chkPIOcean.TabIndex = 26
        Me.chkPIOcean.Text = "Ocean"
        Me.chkPIOcean.UseVisualStyleBackColor = true
        '
        'chkPIBarren
        '
        Me.chkPIBarren.AutoSize = true
        Me.chkPIBarren.Location = New System.Drawing.Point(15, 19)
        Me.chkPIBarren.Name = "chkPIBarren"
        Me.chkPIBarren.Size = New System.Drawing.Size(57, 17)
        Me.chkPIBarren.TabIndex = 22
        Me.chkPIBarren.Text = "Barren"
        Me.chkPIBarren.UseVisualStyleBackColor = true
        '
        'chkPIStorm
        '
        Me.chkPIStorm.AutoSize = true
        Me.chkPIStorm.Location = New System.Drawing.Point(153, 42)
        Me.chkPIStorm.Name = "chkPIStorm"
        Me.chkPIStorm.Size = New System.Drawing.Size(53, 17)
        Me.chkPIStorm.TabIndex = 28
        Me.chkPIStorm.Text = "Storm"
        Me.chkPIStorm.UseVisualStyleBackColor = true
        '
        'chkPITemperate
        '
        Me.chkPITemperate.AutoSize = true
        Me.chkPITemperate.Location = New System.Drawing.Point(216, 42)
        Me.chkPITemperate.Name = "chkPITemperate"
        Me.chkPITemperate.Size = New System.Drawing.Size(77, 17)
        Me.chkPITemperate.TabIndex = 29
        Me.chkPITemperate.Text = "Temperate"
        Me.chkPITemperate.UseVisualStyleBackColor = true
        '
        'btnPIReset
        '
        Me.btnPIReset.Location = New System.Drawing.Point(315, 14)
        Me.btnPIReset.Name = "btnPIReset"
        Me.btnPIReset.Size = New System.Drawing.Size(92, 25)
        Me.btnPIReset.TabIndex = 73
        Me.btnPIReset.Text = "Reset"
        Me.btnPIReset.UseVisualStyleBackColor = true
        '
        'cmbCalcManufacturingTeamActivity
        '
        Me.cmbCalcManufacturingTeamActivity.FormattingEnabled = true
        Me.cmbCalcManufacturingTeamActivity.Items.AddRange(New Object() {"Manufacturing", "Invention", "Copying", "RE"})
        Me.cmbCalcManufacturingTeamActivity.Location = New System.Drawing.Point(3, 9)
        Me.cmbCalcManufacturingTeamActivity.Name = "cmbCalcManufacturingTeamActivity"
        Me.cmbCalcManufacturingTeamActivity.Size = New System.Drawing.Size(92, 21)
        Me.cmbCalcManufacturingTeamActivity.TabIndex = 20
        Me.cmbCalcManufacturingTeamActivity.Text = "Select Activity"
        '
        'ListOptionsMenu
        '
        Me.ListOptionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMarketDataToolStripMenuItem})
        Me.ListOptionsMenu.Name = "ListOptionsMenu"
        Me.ListOptionsMenu.Size = New System.Drawing.Size(167, 26)
        '
        'OpenMarketDataToolStripMenuItem
        '
        Me.OpenMarketDataToolStripMenuItem.Name = "OpenMarketDataToolStripMenuItem"
        Me.OpenMarketDataToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OpenMarketDataToolStripMenuItem.Text = "View Market Data"
        '
        'lstBPComponentMats
        '
        Me.lstBPComponentMats.FullRowSelect = true
        Me.lstBPComponentMats.GridLines = true
        Me.lstBPComponentMats.HideSelection = false
        Me.lstBPComponentMats.Location = New System.Drawing.Point(4, 258)
        Me.lstBPComponentMats.MultiSelect = false
        Me.lstBPComponentMats.Name = "lstBPComponentMats"
        Me.lstBPComponentMats.Size = New System.Drawing.Size(562, 329)
        Me.lstBPComponentMats.TabIndex = 35
        Me.lstBPComponentMats.TabStop = false
        Me.lstBPComponentMats.UseCompatibleStateImageBehavior = false
        Me.lstBPComponentMats.View = System.Windows.Forms.View.Details
        '
        'lstBPRawMats
        '
        Me.lstBPRawMats.FullRowSelect = true
        Me.lstBPRawMats.GridLines = true
        Me.lstBPRawMats.HideSelection = false
        Me.lstBPRawMats.Location = New System.Drawing.Point(569, 258)
        Me.lstBPRawMats.MultiSelect = false
        Me.lstBPRawMats.Name = "lstBPRawMats"
        Me.lstBPRawMats.Size = New System.Drawing.Size(562, 329)
        Me.lstBPRawMats.TabIndex = 34
        Me.lstBPRawMats.TabStop = false
        Me.lstBPRawMats.UseCompatibleStateImageBehavior = false
        Me.lstBPRawMats.View = System.Windows.Forms.View.Details
        '
        'lstPricesView
        '
        Me.lstPricesView.FullRowSelect = true
        Me.lstPricesView.GridLines = true
        Me.lstPricesView.HideSelection = false
        Me.lstPricesView.Location = New System.Drawing.Point(8, 10)
        Me.lstPricesView.MultiSelect = false
        Me.lstPricesView.Name = "lstPricesView"
        Me.lstPricesView.Size = New System.Drawing.Size(691, 321)
        Me.lstPricesView.TabIndex = 0
        Me.lstPricesView.UseCompatibleStateImageBehavior = false
        Me.lstPricesView.View = System.Windows.Forms.View.Details
        '
        'MyListView6
        '
        Me.MyListView6.FullRowSelect = true
        Me.MyListView6.GridLines = true
        Me.MyListView6.HideSelection = false
        Me.MyListView6.Location = New System.Drawing.Point(9, 294)
        Me.MyListView6.MultiSelect = false
        Me.MyListView6.Name = "MyListView6"
        Me.MyListView6.Size = New System.Drawing.Size(398, 311)
        Me.MyListView6.TabIndex = 75
        Me.MyListView6.TabStop = false
        Me.MyListView6.UseCompatibleStateImageBehavior = false
        Me.MyListView6.View = System.Windows.Forms.View.Details
        '
        'MyListView5
        '
        Me.MyListView5.FullRowSelect = true
        Me.MyListView5.GridLines = true
        Me.MyListView5.HideSelection = false
        Me.MyListView5.Location = New System.Drawing.Point(9, 82)
        Me.MyListView5.MultiSelect = false
        Me.MyListView5.Name = "MyListView5"
        Me.MyListView5.Size = New System.Drawing.Size(398, 206)
        Me.MyListView5.TabIndex = 40
        Me.MyListView5.TabStop = false
        Me.MyListView5.UseCompatibleStateImageBehavior = false
        Me.MyListView5.View = System.Windows.Forms.View.Details
        '
        'MyListView4
        '
        Me.MyListView4.FullRowSelect = true
        Me.MyListView4.GridLines = true
        Me.MyListView4.HideSelection = false
        Me.MyListView4.Location = New System.Drawing.Point(715, 214)
        Me.MyListView4.MultiSelect = false
        Me.MyListView4.Name = "MyListView4"
        Me.MyListView4.Size = New System.Drawing.Size(279, 391)
        Me.MyListView4.TabIndex = 39
        Me.MyListView4.TabStop = false
        Me.MyListView4.UseCompatibleStateImageBehavior = false
        Me.MyListView4.View = System.Windows.Forms.View.Details
        '
        'MyListView3
        '
        Me.MyListView3.FullRowSelect = true
        Me.MyListView3.GridLines = true
        Me.MyListView3.HideSelection = false
        Me.MyListView3.Location = New System.Drawing.Point(413, 214)
        Me.MyListView3.MultiSelect = false
        Me.MyListView3.Name = "MyListView3"
        Me.MyListView3.Size = New System.Drawing.Size(279, 391)
        Me.MyListView3.TabIndex = 38
        Me.MyListView3.TabStop = false
        Me.MyListView3.UseCompatibleStateImageBehavior = false
        Me.MyListView3.View = System.Windows.Forms.View.Details
        '
        'MyListView2
        '
        Me.MyListView2.FullRowSelect = true
        Me.MyListView2.GridLines = true
        Me.MyListView2.HideSelection = false
        Me.MyListView2.Location = New System.Drawing.Point(715, 13)
        Me.MyListView2.MultiSelect = false
        Me.MyListView2.Name = "MyListView2"
        Me.MyListView2.Size = New System.Drawing.Size(279, 195)
        Me.MyListView2.TabIndex = 37
        Me.MyListView2.TabStop = false
        Me.MyListView2.UseCompatibleStateImageBehavior = false
        Me.MyListView2.View = System.Windows.Forms.View.Details
        '
        'MyListView1
        '
        Me.MyListView1.FullRowSelect = true
        Me.MyListView1.GridLines = true
        Me.MyListView1.HideSelection = false
        Me.MyListView1.Location = New System.Drawing.Point(413, 13)
        Me.MyListView1.MultiSelect = false
        Me.MyListView1.Name = "MyListView1"
        Me.MyListView1.Size = New System.Drawing.Size(279, 195)
        Me.MyListView1.TabIndex = 36
        Me.MyListView1.TabStop = false
        Me.MyListView1.UseCompatibleStateImageBehavior = false
        Me.MyListView1.View = System.Windows.Forms.View.Details
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.AutoSize = true
        Me.ClientSize = New System.Drawing.Size(1146, 692)
        Me.Controls.Add(Me.txtListEdit)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.mnuStripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuStripMain
        Me.MaximizeBox = false
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EVE ISK per Hour"
        Me.mnuStripMain.ResumeLayout(false)
        Me.mnuStripMain.PerformLayout
        Me.pnlMain.ResumeLayout(false)
        Me.pnlMain.PerformLayout
        Me.tabMining.ResumeLayout(false)
        Me.tabMining.PerformLayout
        Me.gbMineOreProcessingType.ResumeLayout(false)
        Me.gbMineOreProcessingType.PerformLayout
        Me.gbMineTaxBroker.ResumeLayout(false)
        Me.gbMineTaxBroker.PerformLayout
        Me.gbMineStripStats.ResumeLayout(false)
        Me.gbMineStripStats.PerformLayout
        Me.gbMineMiningDroneM3.ResumeLayout(false)
        Me.gbMineMiningDroneM3.PerformLayout
        Me.gbMineJumpCosts.ResumeLayout(false)
        Me.gbMineJumpCosts.PerformLayout
        Me.gbMineHauling.ResumeLayout(false)
        Me.gbMineHauling.PerformLayout
        Me.gbMineBooster.ResumeLayout(false)
        Me.gbMineBooster.PerformLayout
        CType(Me.pictMineLaserOptmize,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pictMineRangeLink,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pictMineFleetBoostShip,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMineRefining.ResumeLayout(false)
        Me.gbMineRefining.PerformLayout
        Me.gbMineStationYield.ResumeLayout(false)
        Me.gbMineStationYield.PerformLayout
        Me.gbMineBaseRefineSkills.ResumeLayout(false)
        Me.gbMineBaseRefineSkills.PerformLayout
        Me.gbMineShipSetup.ResumeLayout(false)
        Me.gbMineSelectShip.ResumeLayout(false)
        Me.gbMineSelectShip.PerformLayout
        CType(Me.pictMineSelectedShip,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbMineShipEquipment.ResumeLayout(false)
        Me.gbMineShipEquipment.PerformLayout
        Me.gbMiningRigs.ResumeLayout(false)
        Me.gbMiningRigs.PerformLayout
        Me.gbMineCrystals.ResumeLayout(false)
        Me.gbMineCrystals.PerformLayout
        Me.gbMineSkills.ResumeLayout(false)
        Me.gbMineSkills.PerformLayout
        Me.gbMineMain.ResumeLayout(false)
        Me.gbMineMain.PerformLayout
        Me.gbMineIncludeOres.ResumeLayout(false)
        Me.gbMineIncludeOres.PerformLayout
        Me.gbMineOreLocSov.ResumeLayout(false)
        Me.gbMineOreLocSov.PerformLayout
        Me.gbMineWHSpace.ResumeLayout(false)
        Me.gbMineWHSpace.PerformLayout
        Me.tabReactions.ResumeLayout(false)
        Me.gbReactionsTaxesFees.ResumeLayout(false)
        Me.gbReactionsTaxesFees.PerformLayout
        Me.gbReactionsSelectedMats.ResumeLayout(false)
        Me.gbReactions.ResumeLayout(false)
        Me.gbReactions.PerformLayout
        Me.gbReactionsHybrid.ResumeLayout(false)
        Me.gbReactionsHybrid.PerformLayout
        Me.gbReactionsBiochem.ResumeLayout(false)
        Me.gbReactionsBiochem.PerformLayout
        Me.gbReactionsOptions.ResumeLayout(false)
        Me.gbReactionsOptions.PerformLayout
        Me.gbReactionsMoonMats.ResumeLayout(false)
        Me.gbReactionsMoonMats.PerformLayout
        Me.tabDatacores.ResumeLayout(false)
        Me.gbDCOptions.ResumeLayout(false)
        Me.gbDCAgentLocSov.ResumeLayout(false)
        Me.gbDCAgentLocSov.PerformLayout
        Me.gbDCTotalIPH.ResumeLayout(false)
        Me.gbDCTotalIPH.PerformLayout
        Me.gbDCPrices.ResumeLayout(false)
        Me.gbDCPrices.PerformLayout
        Me.gbDCAgentTypes.ResumeLayout(false)
        Me.gbDCAgentTypes.PerformLayout
        Me.gbDCBaseSkills.ResumeLayout(false)
        Me.gbDCBaseSkills.PerformLayout
        Me.gbDCDatacores.ResumeLayout(false)
        Me.gbDCDatacores.PerformLayout
        Me.gbDCCodes.ResumeLayout(false)
        Me.gbDCCodes.PerformLayout
        Me.gbDCCorpMinmatar.ResumeLayout(false)
        Me.gbDCCorpMinmatar.PerformLayout
        Me.gbDCCorpAmarr.ResumeLayout(false)
        Me.gbDCCorpAmarr.PerformLayout
        Me.gbDCCorpsCaldari.ResumeLayout(false)
        Me.gbDCCorpsCaldari.PerformLayout
        Me.gbDCCorpsGallente.ResumeLayout(false)
        Me.gbDCCorpsGallente.PerformLayout
        Me.tabManufacturing.ResumeLayout(false)
        Me.gbCalcBPSelectOptions.ResumeLayout(false)
        Me.gbCalcIncludeNoTeam.ResumeLayout(false)
        Me.gbCalcIncludeNoTeam.PerformLayout
        Me.gbIncludeItems.ResumeLayout(false)
        Me.gbIncludeItems.PerformLayout
        Me.gbSize.ResumeLayout(false)
        Me.gbSize.PerformLayout
        Me.gbCalcProdLines.ResumeLayout(false)
        Me.gbCalcProdLines.PerformLayout
        Me.gbCalcCompareType.ResumeLayout(false)
        Me.gbCalcCompareType.PerformLayout
        Me.gbCalcTextColors.ResumeLayout(false)
        Me.gbCalcTextColors.PerformLayout
        Me.gbCalcInvention.ResumeLayout(false)
        Me.gbCalcInvention.PerformLayout
        Me.gbBPRace.ResumeLayout(false)
        Me.gbBPRace.PerformLayout
        Me.tabCalcFacilities.ResumeLayout(false)
        Me.tabCalcFacilityBase.ResumeLayout(false)
        Me.tabCalcFacilityBase.PerformLayout
        Me.tabCalcFacilityComponents.ResumeLayout(false)
        Me.tabCalcFacilityComponents.PerformLayout
        Me.tabCalcFacilityCopy.ResumeLayout(false)
        Me.tabCalcFacilityCopy.PerformLayout
        Me.tabCalcFacilityT2Invention.ResumeLayout(false)
        Me.tabCalcFacilityT2Invention.PerformLayout
        Me.tabCalcFacilityT3Invention.ResumeLayout(false)
        Me.tabCalcFacilityT3Invention.PerformLayout
        Me.tabCalcFacilityCapitals.ResumeLayout(false)
        Me.tabCalcFacilityCapitals.PerformLayout
        Me.tabCalcFacilitySupers.ResumeLayout(false)
        Me.tabCalcFacilitySupers.PerformLayout
        Me.tabCalcFacilityT3Ships.ResumeLayout(false)
        Me.tabCalcFacilityT3Ships.PerformLayout
        Me.tabCalcFacilitySubsystems.ResumeLayout(false)
        Me.tabCalcFacilitySubsystems.PerformLayout
        Me.tabCalcFacilityBoosters.ResumeLayout(false)
        Me.tabCalcFacilityBoosters.PerformLayout
        Me.tabCalcFacilityNoPOS.ResumeLayout(false)
        Me.tabCalcFacilityNoPOS.PerformLayout
        Me.gbCalcFilter.ResumeLayout(false)
        Me.gbCalcBPTech.ResumeLayout(false)
        Me.gbCalcBPTech.PerformLayout
        Me.gbCalcType.ResumeLayout(false)
        Me.gbCalcType.PerformLayout
        Me.gbCalcIncludeOwned.ResumeLayout(false)
        Me.gbCalcIncludeOwned.PerformLayout
        Me.gbCalcAvgPrice.ResumeLayout(false)
        Me.gbCalcAvgPrice.PerformLayout
        Me.gbIncludeTaxesFees.ResumeLayout(false)
        Me.gbIncludeTaxesFees.PerformLayout
        Me.gbCalcTextFilter.ResumeLayout(false)
        Me.gbCalcTextFilter.PerformLayout
        Me.gbCalcBPType.ResumeLayout(false)
        Me.gbCalcBPType.PerformLayout
        Me.gbCalcBPSelect.ResumeLayout(false)
        Me.gbCalcBPSelect.PerformLayout
        Me.gbCalcRelics.ResumeLayout(false)
        Me.gbCalcRelics.PerformLayout
        Me.tabCalcTeams.ResumeLayout(false)
        Me.tabCalcTeamManufacturing.ResumeLayout(false)
        Me.tabCalcTeamManufacturing.PerformLayout
        Me.tabCalcTeamComponents.ResumeLayout(false)
        Me.tabCalcTeamComponents.PerformLayout
        Me.tabCalcTeamInvention.ResumeLayout(false)
        Me.tabCalcTeamInvention.PerformLayout
        Me.tabCalcTeamCopy.ResumeLayout(false)
        Me.tabCalcTeamCopy.PerformLayout
        Me.gbTempMEPE.ResumeLayout(false)
        Me.gbTempMEPE.PerformLayout
        Me.tabUpdatePrices.ResumeLayout(false)
        Me.tabUpdatePrices.PerformLayout
        Me.gbTradeHubSystems.ResumeLayout(false)
        Me.gbTradeHubSystems.PerformLayout
        Me.gbSplitPrices.ResumeLayout(false)
        Me.gbSplitPrices.PerformLayout
        Me.gbManufacturedItems.ResumeLayout(false)
        Me.gbManufacturedItems.PerformLayout
        Me.gbPriceTools.ResumeLayout(false)
        Me.gbPriceTools.PerformLayout
        Me.gbComponents.ResumeLayout(false)
        Me.gbComponents.PerformLayout
        Me.gbItems.ResumeLayout(false)
        Me.gbItems.PerformLayout
        Me.gbPricesTech.ResumeLayout(false)
        Me.gbPricesTech.PerformLayout
        Me.gbPrice.ResumeLayout(false)
        Me.gbPrice.PerformLayout
        Me.gbRawMaterials.ResumeLayout(false)
        Me.gbRawMaterials.PerformLayout
        Me.gbRegions.ResumeLayout(false)
        Me.gbRegions.PerformLayout
        Me.tabBlueprints.ResumeLayout(false)
        Me.tabBlueprints.PerformLayout
        Me.gbFilters.ResumeLayout(false)
        Me.gbFilters.PerformLayout
        Me.gbBPBlueprintType.ResumeLayout(false)
        Me.gbBPBlueprintType.PerformLayout
        Me.gbBPInventionStats.ResumeLayout(false)
        Me.gbBPInventionStats.PerformLayout
        Me.gbBPMEPEImage.ResumeLayout(false)
        Me.gbBPMEPEImage.PerformLayout
        Me.tabBPInventionEquip.ResumeLayout(false)
        Me.tabFacility.ResumeLayout(false)
        Me.tabFacility.PerformLayout
        Me.tabInventionCalcs.ResumeLayout(false)
        Me.tabInventionCalcs.PerformLayout
        Me.tabT3Calcs.ResumeLayout(false)
        Me.tabT3Calcs.PerformLayout
        CType(Me.pictBP,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbBPTeam.ResumeLayout(false)
        Me.gbBPTeam.PerformLayout
        Me.gbBPShopandCopy.ResumeLayout(false)
        Me.gbBPShopandCopy.PerformLayout
        Me.gbBPBlueprintTech.ResumeLayout(false)
        Me.gbBPBlueprintTech.PerformLayout
        Me.tabMain.ResumeLayout(false)
        Me.tabPI.ResumeLayout(false)
        Me.gbPIPlanets.ResumeLayout(false)
        Me.gbPIPlanets.PerformLayout
        Me.ListOptionsMenu.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents mnuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectionExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectionAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlMain As System.Windows.Forms.StatusStrip
    Friend WithEvents pnlCharacter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlShoppingList As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuSelectDefaultChar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemUpdatePrices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectionAddChar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuManageBlueprintsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUserSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbSystems As System.Windows.Forms.GroupBox
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents pnlProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents mnuCheckforUpdates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectionShoppingList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCharacterSkills As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCharacterStandings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlSkills As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSelectionManageAPI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetPOSDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDefaultTabSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDefaultBP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDefaultUpdatePrices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDefaultManufacturing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDefaultDatacores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDefaultReactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDefaultMining As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCurrentResearchAgents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtListEdit As System.Windows.Forms.TextBox
    Friend WithEvents mnuPatchNotes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInventionSuccessMonitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCurrentIndustryJobs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuViewAssets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIndustryUpgradeBelts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabMining As System.Windows.Forms.TabPage
    Friend WithEvents gbMineTaxBroker As System.Windows.Forms.GroupBox
    Friend WithEvents chkMineIncludeTaxes As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineIncludeBrokerFees As System.Windows.Forms.CheckBox
    Friend WithEvents gbMineStripStats As System.Windows.Forms.GroupBox
    Friend WithEvents lblMineRange As System.Windows.Forms.Label
    Friend WithEvents lblMineCycleTime1 As System.Windows.Forms.Label
    Friend WithEvents lblMineRange1 As System.Windows.Forms.Label
    Friend WithEvents lblMineCycleTime As System.Windows.Forms.Label
    Friend WithEvents chkMineRefinedOre As System.Windows.Forms.CheckBox
    Friend WithEvents gbMineMiningDroneM3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMineMiningDroneM3 As System.Windows.Forms.Label
    Friend WithEvents txtMineMiningDroneM3 As System.Windows.Forms.TextBox
    Friend WithEvents chkMineUseFleetBooster As System.Windows.Forms.CheckBox
    Friend WithEvents gbMineJumpCosts As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnMineJumpMinerals As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMineJumpCompress As System.Windows.Forms.RadioButton
    Friend WithEvents chkMineIncludeJumpCosts As System.Windows.Forms.CheckBox
    Friend WithEvents lblMineTotalJumpFuel As System.Windows.Forms.Label
    Friend WithEvents txtMineTotalJumpFuel As System.Windows.Forms.TextBox
    Friend WithEvents lblMineTotalJumpM3 As System.Windows.Forms.Label
    Friend WithEvents txtMineTotalJumpM3 As System.Windows.Forms.TextBox
    Friend WithEvents gbMineHauling As System.Windows.Forms.GroupBox
    Friend WithEvents lblMineHaulerM3 As System.Windows.Forms.Label
    Friend WithEvents txtMineHaulerM3 As System.Windows.Forms.TextBox
    Friend WithEvents lblMineRTSec As System.Windows.Forms.Label
    Friend WithEvents chkMineUseHauler As System.Windows.Forms.CheckBox
    Friend WithEvents lblMineRTMin As System.Windows.Forms.Label
    Friend WithEvents txtMineRTMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMineRTSec As System.Windows.Forms.TextBox
    Friend WithEvents lblMineRoundTripTime As System.Windows.Forms.Label
    Friend WithEvents gbMineBooster As System.Windows.Forms.GroupBox
    Friend WithEvents pictMineLaserOptmize As System.Windows.Forms.PictureBox
    Friend WithEvents pictMineRangeLink As System.Windows.Forms.PictureBox
    Friend WithEvents pictMineFleetBoostShip As System.Windows.Forms.PictureBox
    Friend WithEvents chkMineForemanLaserRangeBoost As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMineIndustReconfig As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineIndustrialReconfig As System.Windows.Forms.Label
    Friend WithEvents chkMineRorqDeployedMode As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMineWarfareLinkSpec As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineWarfareLinkSpec As System.Windows.Forms.Label
    Friend WithEvents cmbMineBoosterShipSkill As System.Windows.Forms.ComboBox
    Friend WithEvents chkMineForemanMindlink As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMineBoosterShip As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMineMiningDirector As System.Windows.Forms.ComboBox
    Friend WithEvents chkMineForemanLaserOpBoost As System.Windows.Forms.CheckBox
    Friend WithEvents lblMineMiningDirector As System.Windows.Forms.Label
    Friend WithEvents cmbMineMiningForeman As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineFleetBoosterShip As System.Windows.Forms.Label
    Friend WithEvents lblMineMiningForeman As System.Windows.Forms.Label
    Friend WithEvents lblMineBoosterShipSkill As System.Windows.Forms.Label
    Friend WithEvents gbMineRefining As System.Windows.Forms.GroupBox
    Friend WithEvents cmbOreProcessing17 As System.Windows.Forms.ComboBox
    Friend WithEvents chkOreProcessing17 As System.Windows.Forms.CheckBox
    Friend WithEvents lblOreProcessing17 As System.Windows.Forms.Label
    Friend WithEvents gbMineStationYield As System.Windows.Forms.GroupBox
    Friend WithEvents lblMineRefineStationTax As System.Windows.Forms.Label
    Friend WithEvents cmbMineStationEff As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineStationEff As System.Windows.Forms.Label
    Friend WithEvents lblMineStationStanding As System.Windows.Forms.Label
    Friend WithEvents txtMineRefineStanding As System.Windows.Forms.TextBox
    Friend WithEvents cmbOreProcessing16 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing15 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing14 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing13 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing12 As System.Windows.Forms.ComboBox
    Friend WithEvents chkOreProcessing16 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing15 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing14 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing13 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing12 As System.Windows.Forms.CheckBox
    Friend WithEvents lblOreProcessing12 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing13 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing14 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing16 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing15 As System.Windows.Forms.Label
    Friend WithEvents cmbOreProcessing6 As System.Windows.Forms.ComboBox
    Friend WithEvents chkOreProcessing6 As System.Windows.Forms.CheckBox
    Friend WithEvents lblOreProcessing6 As System.Windows.Forms.Label
    Friend WithEvents cmbOreProcessing8 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing7 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing11 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing10 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing9 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOreProcessing1 As System.Windows.Forms.ComboBox
    Friend WithEvents chkOreProcessing8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing11 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing5 As System.Windows.Forms.CheckBox
    Friend WithEvents lblOreProcessing8 As System.Windows.Forms.Label
    Friend WithEvents chkOreProcessing4 As System.Windows.Forms.CheckBox
    Friend WithEvents lblOreProcessing7 As System.Windows.Forms.Label
    Friend WithEvents chkOreProcessing3 As System.Windows.Forms.CheckBox
    Friend WithEvents lblOreProcessing11 As System.Windows.Forms.Label
    Friend WithEvents chkOreProcessing2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblOreProcessing1 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing2 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing3 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing10 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing9 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing5 As System.Windows.Forms.Label
    Friend WithEvents lblOreProcessing4 As System.Windows.Forms.Label
    Friend WithEvents gbMineShipSetup As System.Windows.Forms.GroupBox
    Friend WithEvents gbMineSelectShip As System.Windows.Forms.GroupBox
    Friend WithEvents pictMineSelectedShip As System.Windows.Forms.PictureBox
    Friend WithEvents lblMineSelectShip As System.Windows.Forms.Label
    Friend WithEvents cmbMineBaseShipSkill As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMineExhumers As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMineShipType As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineBaseShipSkill As System.Windows.Forms.Label
    Friend WithEvents lblMineExhumers As System.Windows.Forms.Label
    Friend WithEvents gbMineShipEquipment As System.Windows.Forms.GroupBox
    Friend WithEvents gbMiningRigs As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnMineNoRigs As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMineIceRig As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMineMercoxitRig As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMineMiningLaser As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineMiningUpgrade As System.Windows.Forms.Label
    Friend WithEvents gbMineCrystals As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnMineT1Crystals As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMineT2Crystals As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMineNumMiningUpgrades As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMineNumLasers As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMineMiningUpgrade As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMineImplant As System.Windows.Forms.ComboBox
    Friend WithEvents chkMineMichiImplant As System.Windows.Forms.CheckBox
    Friend WithEvents lblMineImplants As System.Windows.Forms.Label
    Friend WithEvents lblMineLaserNumber As System.Windows.Forms.Label
    Friend WithEvents lblMineNumMiningUpgrades As System.Windows.Forms.Label
    Friend WithEvents lblMineMinerTurret As System.Windows.Forms.Label
    Friend WithEvents gbMineSkills As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMineGasIceHarvesting As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineGasIceHarvesting As System.Windows.Forms.Label
    Friend WithEvents cmbMineDeepCore As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineAstrogeology As System.Windows.Forms.Label
    Friend WithEvents cmbMineSkill As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineSkill As System.Windows.Forms.Label
    Friend WithEvents cmbMineAstrogeology As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineDeepCore As System.Windows.Forms.Label
    Friend WithEvents gbMineMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnMineSaveAllSettings As System.Windows.Forms.Button
    Friend WithEvents gbMineIncludeOres As System.Windows.Forms.GroupBox
    Friend WithEvents chkMineIncludeHighSec As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineIncludeNullSec As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineIncludeLowSec As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineIncludeHighYieldOre As System.Windows.Forms.CheckBox
    Friend WithEvents lblMineType As System.Windows.Forms.Label
    Friend WithEvents cmbMineOreType As System.Windows.Forms.ComboBox
    Friend WithEvents gbMineOreLocSov As System.Windows.Forms.GroupBox
    Friend WithEvents chkMineC6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineWH As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineCaldari As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineC2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineMinmatar As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineGallente As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineAmarr As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineC3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineC5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineC1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineC4 As System.Windows.Forms.CheckBox
    Friend WithEvents btnMineReset As System.Windows.Forms.Button
    Friend WithEvents btnMineRefresh As System.Windows.Forms.Button
    Friend WithEvents lstMineGrid As System.Windows.Forms.ListView
    Friend WithEvents tabReactions As System.Windows.Forms.TabPage
    Friend WithEvents gbReactionsTaxesFees As System.Windows.Forms.GroupBox
    Friend WithEvents chkReactionsFees As System.Windows.Forms.CheckBox
    Friend WithEvents chkReactionsTaxes As System.Windows.Forms.CheckBox
    Friend WithEvents lblReactionsFees As System.Windows.Forms.Label
    Friend WithEvents lblReactionsTaxes As System.Windows.Forms.Label
    Friend WithEvents gbReactionsSelectedMats As System.Windows.Forms.GroupBox
    Friend WithEvents lstReactionMats As System.Windows.Forms.ListView
    Friend WithEvents gbReactions As System.Windows.Forms.GroupBox
    Friend WithEvents lblReactionsNumPOS As System.Windows.Forms.Label
    Friend WithEvents txtReactionsNumPOS As System.Windows.Forms.TextBox
    Friend WithEvents btnReactionsSaveSettings As System.Windows.Forms.Button
    Friend WithEvents gbReactionsHybrid As System.Windows.Forms.GroupBox
    Friend WithEvents chkReactionsHybrid As System.Windows.Forms.CheckBox
    Friend WithEvents gbReactionsBiochem As System.Windows.Forms.GroupBox
    Friend WithEvents chkReactionsSimpleBio As System.Windows.Forms.CheckBox
    Friend WithEvents chkReactionsComplexBio As System.Windows.Forms.CheckBox
    Friend WithEvents gbReactionsOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkReactionsRefine As System.Windows.Forms.CheckBox
    Friend WithEvents chkReactionsIgnoreBaseMatPrice As System.Windows.Forms.CheckBox
    Friend WithEvents chkReactionsBuildBasic As System.Windows.Forms.CheckBox
    Friend WithEvents gbReactionsMoonMats As System.Windows.Forms.GroupBox
    Friend WithEvents chkReactionsAdvMoonMats As System.Windows.Forms.CheckBox
    Friend WithEvents chkReactionsProcMoonMats As System.Windows.Forms.CheckBox
    Friend WithEvents lblReactionPOSFuelCost As System.Windows.Forms.Label
    Friend WithEvents btnReactionRefresh As System.Windows.Forms.Button
    Friend WithEvents txtReactionPOSFuelCost As System.Windows.Forms.TextBox
    Friend WithEvents lstReactions As System.Windows.Forms.ListView
    Friend WithEvents tabDatacores As System.Windows.Forms.TabPage
    Friend WithEvents lstDC As System.Windows.Forms.ListView
    Friend WithEvents gbDCOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnDCSaveSettings As System.Windows.Forms.Button
    Friend WithEvents gbDCAgentLocSov As System.Windows.Forms.GroupBox
    Friend WithEvents chkDCThukkerSov As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCKhanidSov As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCMinmatarSov As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCSyndicateSov As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCGallenteSov As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCAmarrSov As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCAmmatarSov As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCaldariSov As System.Windows.Forms.CheckBox
    Friend WithEvents gbDCTotalIPH As System.Windows.Forms.GroupBox
    Friend WithEvents lblDCTotalOptIPH As System.Windows.Forms.Label
    Friend WithEvents lblDCTotalSelectedIPH As System.Windows.Forms.Label
    Friend WithEvents txtDCTotalSelectedIPH As System.Windows.Forms.TextBox
    Friend WithEvents txtDCTotalOptIPH As System.Windows.Forms.TextBox
    Friend WithEvents gbDCPrices As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDCSystemPrices As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDCRegionPrices As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDCUpdatedPrices As System.Windows.Forms.RadioButton
    Friend WithEvents gbDCAgentTypes As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDCRegions As System.Windows.Forms.ComboBox
    Friend WithEvents lblDCRegion As System.Windows.Forms.Label
    Friend WithEvents chkDCLowSecAgents As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCHighSecAgents As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCIncludeAllAgents As System.Windows.Forms.CheckBox
    Friend WithEvents gbDCBaseSkills As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDCResearchMgmt As System.Windows.Forms.ComboBox
    Friend WithEvents lblDCResearchManagement As System.Windows.Forms.Label
    Friend WithEvents lblDCNegotiation As System.Windows.Forms.Label
    Friend WithEvents cmbDCConnections As System.Windows.Forms.ComboBox
    Friend WithEvents lblDCConnections As System.Windows.Forms.Label
    Friend WithEvents cmbDCNegotiation As System.Windows.Forms.ComboBox
    Friend WithEvents gbDCDatacores As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDCSkillLevel17 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel16 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel15 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel14 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel13 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel12 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel11 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel10 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel9 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel8 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel7 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel6 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDCSkillLevel1 As System.Windows.Forms.ComboBox
    Friend WithEvents chkDC17 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC16 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC3 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDatacore17 As System.Windows.Forms.Label
    Friend WithEvents chkDC15 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC14 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC13 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC12 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC11 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC10 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDatacore16 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore4 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore15 As System.Windows.Forms.Label
    Friend WithEvents chkDC9 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDatacore14 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore3 As System.Windows.Forms.Label
    Friend WithEvents chkDC8 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDatacore13 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore2 As System.Windows.Forms.Label
    Friend WithEvents chkDC7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDC6 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDatacore1 As System.Windows.Forms.Label
    Friend WithEvents chkDC5 As System.Windows.Forms.CheckBox
    Friend WithEvents lblDatacore5 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore6 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore7 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore8 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore12 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore11 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore10 As System.Windows.Forms.Label
    Friend WithEvents lblDatacore9 As System.Windows.Forms.Label
    Friend WithEvents gbDCCodes As System.Windows.Forms.GroupBox
    Friend WithEvents lblDCColors As System.Windows.Forms.Label
    Friend WithEvents lblDCRedText As System.Windows.Forms.Label
    Friend WithEvents lblDCOrangeText As System.Windows.Forms.Label
    Friend WithEvents lblDCGrayText As System.Windows.Forms.Label
    Friend WithEvents lblDCBlueText As System.Windows.Forms.Label
    Friend WithEvents lblDCGreenBackColor As System.Windows.Forms.Label
    Friend WithEvents gbDCCorpMinmatar As System.Windows.Forms.GroupBox
    Friend WithEvents lblDCCorp13 As System.Windows.Forms.Label
    Friend WithEvents chkDCCorp13 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDCStanding13 As System.Windows.Forms.TextBox
    Friend WithEvents lblDCCorpLabel4 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp10 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp11 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp12 As System.Windows.Forms.Label
    Friend WithEvents chkDCCorp10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp11 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp12 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDCStanding10 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding11 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding12 As System.Windows.Forms.TextBox
    Friend WithEvents lblDCStanding4 As System.Windows.Forms.Label
    Friend WithEvents btnDCExporttoClip As System.Windows.Forms.Button
    Friend WithEvents gbDCCorpAmarr As System.Windows.Forms.GroupBox
    Friend WithEvents lblDCCorpLabel1 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp1 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp2 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp3 As System.Windows.Forms.Label
    Friend WithEvents chkDCCorp1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDCStanding1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding3 As System.Windows.Forms.TextBox
    Friend WithEvents lblDCStanding1 As System.Windows.Forms.Label
    Friend WithEvents btnDCReset As System.Windows.Forms.Button
    Friend WithEvents gbDCCorpsCaldari As System.Windows.Forms.GroupBox
    Friend WithEvents lblDCCorpLabel2 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp4 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp5 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp6 As System.Windows.Forms.Label
    Friend WithEvents chkDCCorp4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp6 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDCStanding4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding5 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding6 As System.Windows.Forms.TextBox
    Friend WithEvents lblDCStanding2 As System.Windows.Forms.Label
    Friend WithEvents gbDCCorpsGallente As System.Windows.Forms.GroupBox
    Friend WithEvents lblDCCorpLabel3 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp7 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp8 As System.Windows.Forms.Label
    Friend WithEvents lblDCCorp9 As System.Windows.Forms.Label
    Friend WithEvents chkDCCorp7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDCCorp9 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDCStanding7 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding8 As System.Windows.Forms.TextBox
    Friend WithEvents txtDCStanding9 As System.Windows.Forms.TextBox
    Friend WithEvents lblDCStanding3 As System.Windows.Forms.Label
    Friend WithEvents btnDCRefresh As System.Windows.Forms.Button
    Friend WithEvents tabManufacturing As System.Windows.Forms.TabPage
    Friend WithEvents gbCalcBPSelectOptions As System.Windows.Forms.GroupBox
    Friend WithEvents gbCalcInvention As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcDecryptor0 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptor1 As System.Windows.Forms.CheckBox
    Friend WithEvents gbCalcProdLines As System.Windows.Forms.GroupBox
    Friend WithEvents txtCalcLabLines As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcLabLines1 As System.Windows.Forms.Label
    Friend WithEvents lblCalcProdLines1 As System.Windows.Forms.Label
    Friend WithEvents txtCalcProdLines As System.Windows.Forms.TextBox
    Friend WithEvents chkCalcInventionFacilityIncludeTime As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcCopyFacilityIncludeTime As System.Windows.Forms.CheckBox
    Friend WithEvents gbBPRace As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcRaceOther As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRacePirate As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRaceMinmatar As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRaceGallente As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRaceCaldari As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRaceAmarr As System.Windows.Forms.CheckBox
    Friend WithEvents gbCalcType As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCalcSortSVRIPH As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcSortSVR As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcShowProfitPercent As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcProfit As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcIPH As System.Windows.Forms.RadioButton
    Friend WithEvents gbCalcIncludeOwned As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcIncludeT3Owned As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcIncludeT2Owned As System.Windows.Forms.CheckBox
    Friend WithEvents gbCalcAvgPrice As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcSVRIncludeNull As System.Windows.Forms.CheckBox
    Friend WithEvents lblCalcSVRRegion As System.Windows.Forms.Label
    Friend WithEvents lblCalcAvgPrice As System.Windows.Forms.Label
    Friend WithEvents cmbCalcSVRRegion As System.Windows.Forms.ComboBox
    Friend WithEvents txtCalcSVRThreshold As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcSVRThreshold As System.Windows.Forms.Label
    Friend WithEvents cmbCalcAvgPriceDuration As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalcSaveSettings As System.Windows.Forms.Button
    Friend WithEvents gbIncludeTaxesFees As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcTaxes As System.Windows.Forms.CheckBox
    Friend WithEvents gbIncludeItems As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcCanRE As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcCanInvent As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcCanBuild As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalcExportList As System.Windows.Forms.Button
    Friend WithEvents btnCalcPreview As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnCalcReset As System.Windows.Forms.Button
    Friend WithEvents gbCalcCompareType As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCalcCompareBuildBuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcCompareRawMats As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcCompareComponents As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcCompareAll As System.Windows.Forms.RadioButton
    Friend WithEvents gbCalcTextFilter As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcResetTextSearch As System.Windows.Forms.Button
    Friend WithEvents txtCalcItemFilter As System.Windows.Forms.TextBox
    Friend WithEvents gbCalcBPTech As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcPirateFaction As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcStoryline As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcNavyFaction As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcT3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcT2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcT1 As System.Windows.Forms.CheckBox
    Friend WithEvents gbTempMEPE As System.Windows.Forms.GroupBox
    Friend WithEvents txtCalcTempTE As System.Windows.Forms.TextBox
    Friend WithEvents lblTempPE As System.Windows.Forms.Label
    Friend WithEvents txtCalcTempME As System.Windows.Forms.TextBox
    Friend WithEvents lblTempME As System.Windows.Forms.Label
    Friend WithEvents gbCalcBPType As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcMisc As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcSubsystems As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcStructures As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcBoosters As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRigs As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcComponents As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcAmmo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDrones As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcModules As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcShips As System.Windows.Forms.CheckBox
    Friend WithEvents gbCalcFilter As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCalcBPTypeFilter As System.Windows.Forms.ComboBox
    Friend WithEvents gbCalcBPSelect As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCalcBPFavorites As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcAllBPs As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCalcBPOwned As System.Windows.Forms.RadioButton
    Friend WithEvents gbCalcRelics As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcRERelic2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRERelic3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcRERelic1 As System.Windows.Forms.CheckBox
    Friend WithEvents lstManufacturing As System.Windows.Forms.ListView
    Friend WithEvents tabUpdatePrices As System.Windows.Forms.TabPage
    Friend WithEvents gbTradeHubSystems As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPriceSystems As System.Windows.Forms.ComboBox
    Friend WithEvents chkSystems2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystems4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystems5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystems3 As System.Windows.Forms.CheckBox
    Public WithEvents chkSystems1 As System.Windows.Forms.CheckBox
    Friend WithEvents lstPricesView As EVE_Isk_per_Hour.MyListView
    Friend WithEvents txtPriceItemFilter As System.Windows.Forms.TextBox
    Friend WithEvents chkSplitPrices As System.Windows.Forms.CheckBox
    Friend WithEvents gbSplitPrices As System.Windows.Forms.GroupBox
    Friend WithEvents cmbItemsSplitPrices As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRawMatsSplitPrices As System.Windows.Forms.ComboBox
    Friend WithEvents lblItemsSplitPrices As System.Windows.Forms.Label
    Friend WithEvents lblRawMatsSplitPrices As System.Windows.Forms.Label
    Friend WithEvents btnSaveUpdatePrices As System.Windows.Forms.Button
    Friend WithEvents btnEnterPrices As System.Windows.Forms.Button
    Friend WithEvents btnClearItemFilter As System.Windows.Forms.Button
    Friend WithEvents btnToggleAllPriceItems As System.Windows.Forms.Button
    Friend WithEvents btnImportPrices As System.Windows.Forms.Button
    Friend WithEvents lblItemFilter As System.Windows.Forms.Label
    Friend WithEvents gbManufacturedItems As System.Windows.Forms.GroupBox
    Friend WithEvents chkUpdatePricesNoPrice As System.Windows.Forms.CheckBox
    Friend WithEvents chkPriceManufacturedPrices As System.Windows.Forms.CheckBox
    Friend WithEvents gbPriceTools As System.Windows.Forms.GroupBox
    Friend WithEvents chkFuelBlocks As System.Windows.Forms.CheckBox
    Friend WithEvents chkDataInterfaces As System.Windows.Forms.CheckBox
    Friend WithEvents chkTools As System.Windows.Forms.CheckBox
    Friend WithEvents gbComponents As System.Windows.Forms.GroupBox
    Friend WithEvents chkHybrid As System.Windows.Forms.CheckBox
    Friend WithEvents chkComponents As System.Windows.Forms.CheckBox
    Friend WithEvents chkCapitalComponents As System.Windows.Forms.CheckBox
    Friend WithEvents chkCapT2Components As System.Windows.Forms.CheckBox
    Friend WithEvents gbItems As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPriceChargeTypes As System.Windows.Forms.ComboBox
    Friend WithEvents chkCharges As System.Windows.Forms.CheckBox
    Friend WithEvents chkStructures As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoosters As System.Windows.Forms.CheckBox
    Friend WithEvents chkRigs As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPriceShipTypes As System.Windows.Forms.ComboBox
    Friend WithEvents chkSubsystems As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrones As System.Windows.Forms.CheckBox
    Friend WithEvents chkModules As System.Windows.Forms.CheckBox
    Friend WithEvents gbPricesTech As System.Windows.Forms.GroupBox
    Friend WithEvents chkPricesT4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPricesT6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPricesT5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPricesT3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPricesT2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPricesT1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkShips As System.Windows.Forms.CheckBox
    Friend WithEvents gbPrice As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnPercentileBuySell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPercentileBuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPercentileSell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMedBuySell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAvgBuySell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMaxBuySell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMinBuySell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMedBuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAvgBuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMaxBuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMinBuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMedSell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAvgSell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMaxSell As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMinSell As System.Windows.Forms.RadioButton
    Friend WithEvents gbRawMaterials As System.Windows.Forms.GroupBox
    Friend WithEvents chkMisc As System.Windows.Forms.CheckBox
    Friend WithEvents chkAsteroids As System.Windows.Forms.CheckBox
    Friend WithEvents chkPriceRawMaterialPrices As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlanetary As System.Windows.Forms.CheckBox
    Friend WithEvents chkStationComponents As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoosterMats As System.Windows.Forms.CheckBox
    Friend WithEvents chkDroneComponents As System.Windows.Forms.CheckBox
    Friend WithEvents chkMatsandCompounds As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdvancedMats As System.Windows.Forms.CheckBox
    Friend WithEvents chkProcessedMats As System.Windows.Forms.CheckBox
    Friend WithEvents chkRawMats As System.Windows.Forms.CheckBox
    Friend WithEvents chkGas As System.Windows.Forms.CheckBox
    Friend WithEvents chkPolymers As System.Windows.Forms.CheckBox
    Friend WithEvents chkAncientRelics As System.Windows.Forms.CheckBox
    Friend WithEvents chkAncientSalvage As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalvage As System.Windows.Forms.CheckBox
    Friend WithEvents chkDecryptors As System.Windows.Forms.CheckBox
    Friend WithEvents chkDatacores As System.Windows.Forms.CheckBox
    Friend WithEvents chkIceProducts As System.Windows.Forms.CheckBox
    Friend WithEvents chkMinerals As System.Windows.Forms.CheckBox
    Friend WithEvents gbRegions As System.Windows.Forms.GroupBox
    Friend WithEvents chkRegion67 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion45 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion46 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion47 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion48 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion49 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion50 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion51 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion52 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion53 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion54 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion55 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion56 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion57 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion58 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion59 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion60 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion61 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion62 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion63 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion64 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion65 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion66 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion23 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion24 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion25 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion26 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion27 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion28 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion29 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion30 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion31 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion32 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion33 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion34 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion35 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion36 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion37 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion38 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion39 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion40 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion41 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion42 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion43 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion44 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion12 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion13 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion14 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion15 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion16 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion17 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion18 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion19 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion20 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion21 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion22 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion11 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegion1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheckNullLowRegions As System.Windows.Forms.Button
    Friend WithEvents btnCheckEmpireRegions As System.Windows.Forms.Button
    Friend WithEvents btnCheckNoRegions As System.Windows.Forms.Button
    Friend WithEvents btnCheckAllRegions As System.Windows.Forms.Button
    Friend WithEvents tabBlueprints As System.Windows.Forms.TabPage
    Friend WithEvents lblBPSelectBlueprint As System.Windows.Forms.Label
    Friend WithEvents lstBPComponentMats As EVE_Isk_per_Hour.MyListView
    Friend WithEvents lstBPRawMats As EVE_Isk_per_Hour.MyListView
    Friend WithEvents btnBPSaveSettings As System.Windows.Forms.Button
    Friend WithEvents gbBPInventionStats As System.Windows.Forms.GroupBox
    Friend WithEvents chkBPPricePerUnit As System.Windows.Forms.CheckBox
    Friend WithEvents lblBPCompProfit1 As System.Windows.Forms.Label
    Friend WithEvents lblBPTotalCompCost1 As System.Windows.Forms.Label
    Friend WithEvents lblBPRawProfit1 As System.Windows.Forms.Label
    Friend WithEvents lblBPCompIPH1 As System.Windows.Forms.Label
    Friend WithEvents lblBPRawIPH1 As System.Windows.Forms.Label
    Friend WithEvents lblBPRawTotalCost1 As System.Windows.Forms.Label
    Friend WithEvents lblBPTotalUnits As System.Windows.Forms.Label
    Friend WithEvents lblBPFacilityUsage As System.Windows.Forms.Label
    Friend WithEvents lblBPTaxes As System.Windows.Forms.Label
    Friend WithEvents lblBPCompProfit As System.Windows.Forms.Label
    Friend WithEvents lblBPTotalCompCost As System.Windows.Forms.Label
    Friend WithEvents lblBPRawProfit As System.Windows.Forms.Label
    Friend WithEvents lblBPRawTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblBPMarketCost As System.Windows.Forms.Label
    Friend WithEvents lblBPRawIPH As System.Windows.Forms.Label
    Friend WithEvents lblBPCompIPH As System.Windows.Forms.Label
    Friend WithEvents lblBPTotalUnits1 As System.Windows.Forms.Label
    Friend WithEvents chkBPFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents lblBPMarketCost1 As System.Windows.Forms.Label
    Friend WithEvents chkBPTaxes As System.Windows.Forms.CheckBox
    Friend WithEvents tabBPInventionEquip As System.Windows.Forms.TabControl
    Friend WithEvents tabInventionCalcs As System.Windows.Forms.TabPage
    Friend WithEvents txtBPInventionLines As System.Windows.Forms.TextBox
    Friend WithEvents lblBPInventionLines As System.Windows.Forms.Label
    Friend WithEvents lblInventionChance1 As System.Windows.Forms.Label
    Friend WithEvents lblBPDecryptor As System.Windows.Forms.Label
    Friend WithEvents lblBPInventionTime As System.Windows.Forms.Label
    Friend WithEvents lblBPDecryptorStats As System.Windows.Forms.Label
    Friend WithEvents lblBPInventionCost As System.Windows.Forms.Label
    Friend WithEvents cmbBPInventionDecryptor As System.Windows.Forms.ComboBox
    Friend WithEvents lblBPInventionChance As System.Windows.Forms.Label
    Friend WithEvents lblBPT2InventStatus As System.Windows.Forms.Label
    Friend WithEvents chkBPIncludeInventionTime As System.Windows.Forms.CheckBox
    Friend WithEvents tabFacility As System.Windows.Forms.TabPage
    Friend WithEvents lblBPBuyColor As System.Windows.Forms.Label
    Friend WithEvents lblBPBuildColor As System.Windows.Forms.Label
    Friend WithEvents gbBPMEPEImage As System.Windows.Forms.GroupBox
    Friend WithEvents chkBPBuildBuy As System.Windows.Forms.CheckBox
    Friend WithEvents lblBPLines As System.Windows.Forms.Label
    Friend WithEvents lblBPPT As System.Windows.Forms.Label
    Friend WithEvents lblBPNumBPs As System.Windows.Forms.Label
    Friend WithEvents lblBPCPTPT As System.Windows.Forms.Label
    Friend WithEvents txtBPLines As System.Windows.Forms.TextBox
    Friend WithEvents txtBPAddlCosts As System.Windows.Forms.TextBox
    Friend WithEvents txtBPNumBPs As System.Windows.Forms.TextBox
    Friend WithEvents txtBPTE As System.Windows.Forms.TextBox
    Friend WithEvents pictBP As System.Windows.Forms.PictureBox
    Friend WithEvents txtBPME As System.Windows.Forms.TextBox
    Friend WithEvents btnBPRefreshBP As System.Windows.Forms.Button
    Friend WithEvents txtBPRuns As System.Windows.Forms.TextBox
    Friend WithEvents lblBPProductionTime As System.Windows.Forms.Label
    Friend WithEvents lblBPTotalItemPT As System.Windows.Forms.Label
    Friend WithEvents lblBPPE As System.Windows.Forms.Label
    Friend WithEvents lblBPME As System.Windows.Forms.Label
    Friend WithEvents lblBPRuns As System.Windows.Forms.Label
    Friend WithEvents lblBPAddlCosts As System.Windows.Forms.Label
    Friend WithEvents gbBPShopandCopy As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnBPComponentCopy As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPRawmatCopy As System.Windows.Forms.RadioButton
    Friend WithEvents btnBPCopyMatstoClip As System.Windows.Forms.Button
    Friend WithEvents btnBPAddBPMatstoShoppingList As System.Windows.Forms.Button
    Friend WithEvents lblBPCanMakeBPAll As System.Windows.Forms.Label
    Friend WithEvents lblBPRawMatCost As System.Windows.Forms.Label
    Friend WithEvents lblBPRawMatCost1 As System.Windows.Forms.Label
    Friend WithEvents lblBPCanMakeBP As System.Windows.Forms.Label
    Friend WithEvents lblBPRawMats As System.Windows.Forms.Label
    Friend WithEvents lblBPComponentMatCost As System.Windows.Forms.Label
    Friend WithEvents lblBPComponentMats As System.Windows.Forms.Label
    Friend WithEvents lblBPComponentMatCost1 As System.Windows.Forms.Label
    Friend WithEvents gbBPBlueprintTech As System.Windows.Forms.GroupBox
    Friend WithEvents chkBPPirateFaction As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPStoryline As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPNavyFaction As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPT3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPT2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPT1 As System.Windows.Forms.CheckBox
    Friend WithEvents gbBPBlueprintType As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnBPOwnedBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPRigBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPBoosterBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPStructureBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPSubsystemBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPModuleBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPMiscBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPAmmoChargeBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPDroneBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPComponentBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPAllBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPShipBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents cmbBPBlueprintSelection As System.Windows.Forms.ComboBox
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents chkCelestials As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeployables As System.Windows.Forms.CheckBox
    Friend WithEvents chkImplants As System.Windows.Forms.CheckBox
    Friend WithEvents rbtnBPCopyInvREMats As System.Windows.Forms.RadioButton
    Friend WithEvents gbFilters As System.Windows.Forms.GroupBox
    Friend WithEvents chkBPXL As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPLarge As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPMedium As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPSmall As System.Windows.Forms.CheckBox
    Friend WithEvents lblBPBrokerFees As System.Windows.Forms.Label
    Friend WithEvents chkBPBrokerFees As System.Windows.Forms.CheckBox
    Friend WithEvents rbtnBPDeployableBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPCelestialsBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPStationPartsBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBPFavoriteBlueprints As System.Windows.Forms.RadioButton
    Friend WithEvents txtCalcRuns As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcRuns As System.Windows.Forms.Label
    Friend WithEvents gbSize As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcXL As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcLarge As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcMedium As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcSmall As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcCelestials As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDeployables As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcStationParts As System.Windows.Forms.CheckBox
    Friend WithEvents gbCalcTextColors As System.Windows.Forms.GroupBox
    Friend WithEvents lblCalcText As System.Windows.Forms.Label
    Friend WithEvents lblCalcColorCode3 As System.Windows.Forms.Label
    Friend WithEvents lblCalcColorCode4 As System.Windows.Forms.Label
    Friend WithEvents lblCalcColorCode5 As System.Windows.Forms.Label
    Friend WithEvents lblCalcColorCode2 As System.Windows.Forms.Label
    Friend WithEvents lblCalcColorCode1 As System.Windows.Forms.Label
    Friend WithEvents cmbMineRefineStationTax As System.Windows.Forms.ComboBox
    Friend WithEvents chkCalcFees As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreProcessing1 As System.Windows.Forms.CheckBox
    Friend WithEvents mnuRefinery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabPI As System.Windows.Forms.TabPage
    Friend WithEvents MyListView6 As EVE_Isk_per_Hour.MyListView
    Friend WithEvents btnPISaveSettings As System.Windows.Forms.Button
    Friend WithEvents gbPIPlanets As System.Windows.Forms.GroupBox
    Friend WithEvents chkPILava As System.Windows.Forms.CheckBox
    Friend WithEvents chkPIPlasma As System.Windows.Forms.CheckBox
    Friend WithEvents chkPIIce As System.Windows.Forms.CheckBox
    Friend WithEvents chkPIGas As System.Windows.Forms.CheckBox
    Friend WithEvents chkPIOcean As System.Windows.Forms.CheckBox
    Friend WithEvents chkPIBarren As System.Windows.Forms.CheckBox
    Friend WithEvents chkPIStorm As System.Windows.Forms.CheckBox
    Friend WithEvents chkPITemperate As System.Windows.Forms.CheckBox
    Friend WithEvents btnPIReset As System.Windows.Forms.Button
    Friend WithEvents MyListView5 As EVE_Isk_per_Hour.MyListView
    Friend WithEvents MyListView4 As EVE_Isk_per_Hour.MyListView
    Friend WithEvents MyListView3 As EVE_Isk_per_Hour.MyListView
    Friend WithEvents MyListView2 As EVE_Isk_per_Hour.MyListView
    Friend WithEvents MyListView1 As EVE_Isk_per_Hour.MyListView
    Friend WithEvents btnBPForward As System.Windows.Forms.Button
    Friend WithEvents btnBPBack As System.Windows.Forms.Button
    Friend WithEvents tabT3Calcs As System.Windows.Forms.TabPage
    Friend WithEvents lblBPRawSVR As System.Windows.Forms.Label
    Friend WithEvents lblBPBPSVR As System.Windows.Forms.Label
    Friend WithEvents lblBPBPSVR1 As System.Windows.Forms.Label
    Friend WithEvents lblBPRawSVR1 As System.Windows.Forms.Label
    Friend WithEvents txtBPRelicLines As System.Windows.Forms.TextBox
    Friend WithEvents lblBPRelicLines As System.Windows.Forms.Label
    Friend WithEvents lblBPRETime As System.Windows.Forms.Label
    Friend WithEvents lblBPRelic As System.Windows.Forms.Label
    Friend WithEvents cmbBPRelic As System.Windows.Forms.ComboBox
    Friend WithEvents lblBPRECost As System.Windows.Forms.Label
    Friend WithEvents lblBPT3InventionChance1 As System.Windows.Forms.Label
    Friend WithEvents lblT3InventStatus As System.Windows.Forms.Label
    Friend WithEvents chkBPIncludeT3Time As System.Windows.Forms.CheckBox
    Friend WithEvents gbBPTeam As System.Windows.Forms.GroupBox
    Friend WithEvents lblBPCopyCosts As System.Windows.Forms.Label
    Friend WithEvents lblBPCopyTime As System.Windows.Forms.Label
    Friend WithEvents chkBPIncludeCopyTime As System.Windows.Forms.CheckBox
    Friend WithEvents lblBPFacility As System.Windows.Forms.Label
    Friend WithEvents cmbBPFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblBPFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents cmbBPFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBPFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBPFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBPTeamActivities As System.Windows.Forms.ComboBox
    Friend WithEvents lblBPFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents lblBPFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents mnuSaveCurrentTabSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBPFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtBPFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents lblBPFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblBPFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents mnuUpdateData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpdateCRESTTeams As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpdateIndustryFacilities As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpdateCRESTMarketPrices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBPFacilitySave As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuResetData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetBlueprintData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetPriceData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetAgents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetIndustryJobs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResetAssets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuResetAllData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkBPIncludeCopyCosts As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPIncludeInventionCosts As System.Windows.Forms.CheckBox
    Friend WithEvents chkBPIncludeT3Costs As System.Windows.Forms.CheckBox
    Friend WithEvents lblBPFacilityActivity As System.Windows.Forms.Label
    Friend WithEvents cmbBPFacilityActivities As System.Windows.Forms.ComboBox
    Friend WithEvents btnBPSaveTeam As System.Windows.Forms.Button
    Friend WithEvents gbMineWHSpace As System.Windows.Forms.GroupBox
    Friend WithEvents lblBPFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents lblBPDefaultTeam As System.Windows.Forms.Label
    Friend WithEvents cmbBPTeam As System.Windows.Forms.ComboBox
    Friend WithEvents tabCalcFacilities As System.Windows.Forms.TabControl
    Friend WithEvents tabCalcFacilityBase As System.Windows.Forms.TabPage
    Friend WithEvents btnCalcBaseFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcBaseFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcBaseFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcBaseFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcBaseFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcBaseFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcBaseFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcBaseFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcBaseFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcBaseFacilityType As System.Windows.Forms.Label
    Friend WithEvents chkCalcBaseFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcBaseFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcBaseFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcBaseFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents tabCalcFacilitySupers As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilityCapitals As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilityBoosters As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilitySubsystems As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilityT3Ships As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilityComponents As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilityT2Invention As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilityCopy As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcFacilityNoPOS As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcTeams As System.Windows.Forms.TabControl
    Friend WithEvents tabCalcTeamManufacturing As System.Windows.Forms.TabPage
    Friend WithEvents cmbCalcManufacturingTeam As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcManufacturingTeamDefault As System.Windows.Forms.Label
    Friend WithEvents tabCalcTeamInvention As System.Windows.Forms.TabPage
    Friend WithEvents tabCalcTeamCopy As System.Windows.Forms.TabPage
    Friend WithEvents btnCalcSelectColumns As System.Windows.Forms.Button
    Friend WithEvents cmbCalcInventionTeam As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcInventionTeamDefault As System.Windows.Forms.Label
    Friend WithEvents cmbCalcCopyTeam As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcCopyTeamDefault As System.Windows.Forms.Label
    Friend WithEvents chkCalcNoPOSFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcInventionFacilityIncludeCost As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcCopyFacilityIncludeCost As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcManufacturingTeamActivity As System.Windows.Forms.ComboBox
    Friend WithEvents chkCalcIncludeNoTeamManufacturing As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalcSaveManufacturingTeam As System.Windows.Forms.Button
    Friend WithEvents btnCalcSaveInventionTeam As System.Windows.Forms.Button
    Friend WithEvents btnCalcSaveCopyTeam As System.Windows.Forms.Button
    Friend WithEvents txtCalcManufacturingTeamBonus As System.Windows.Forms.TextBox
    Friend WithEvents txtBPTeamBonus As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcInventionTeamBonus As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcCopyTeamBonus As System.Windows.Forms.TextBox
    Friend WithEvents gbCalcIncludeNoTeam As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcIncludeNoTeamCopy As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcIncludeNoTeamInvention As System.Windows.Forms.CheckBox
    Friend WithEvents lblCalcComponentFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcComponentFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcComponentFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcComponentFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcComponentFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcComponentFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcComponentFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcComponentFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcComponentFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcComponentFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcComponentFacilityType As System.Windows.Forms.Label
    Friend WithEvents chkCalcComponentFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcComponentFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcComponentFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcComponentFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcInventionFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcInventionFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcInventionFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcInventionFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcInventionFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcInventionFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcInventionFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcInventionFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcInventionFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcInventionFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcInventionFacilityType As System.Windows.Forms.Label
    Friend WithEvents cmbCalcInventionFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcInventionFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcInventionFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcCopyFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcCopyFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcCopyFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcCopyFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcCopyFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcCopyFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcCopyFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcCopyFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcCopyFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcCopyFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcCopyFacilityType As System.Windows.Forms.Label
    Friend WithEvents cmbCalcCopyFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcCopyFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcCopyFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcNoPOSFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcNoPOSFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcNoPOSFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcNoPOSFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcNoPOSFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcNoPOSFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcNoPOSFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcNoPOSFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcNoPOSFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcNoPOSFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcNoPOSFacilityType As System.Windows.Forms.Label
    Friend WithEvents cmbCalcNoPOSFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcNoPOSFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcNoPOSFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcSuperFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcSuperFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcSuperFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcSuperFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcSuperFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcSuperFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcSuperFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcSuperFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcSuperFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcSuperFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcSuperFacilityType As System.Windows.Forms.Label
    Friend WithEvents chkCalcSuperFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcSuperFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcSuperFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcSuperFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcCapitalFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcCapitalFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcCapitalFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcCapitalFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcCapitalFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcCapitalFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcCapitalFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcCapitalFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcCapitalFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcCapitalFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcCapitalFacilityType As System.Windows.Forms.Label
    Friend WithEvents chkCalcCapitalFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcCapitalFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcCapitalFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcCapitalFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcT3FacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcT3FacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcT3FacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcT3FacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcT3FacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcT3FacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcT3FacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcT3FacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcT3FacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcT3FacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcT3FacilityType As System.Windows.Forms.Label
    Friend WithEvents chkCalcT3FacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcT3FacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcT3FacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcT3FacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcSubsystemFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcSubsystemFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcSubsystemFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcSubsystemFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcSubsystemFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcSubsystemFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcSubsystemFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcSubsystemFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcSubsystemFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcSubsystemFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcSubsystemFacilityType As System.Windows.Forms.Label
    Friend WithEvents chkCalcSubsystemFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcSubsystemFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcSubsystemFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcSubsystemFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents lblCalcBoosterFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents btnCalcBoosterFacilitySave As System.Windows.Forms.Button
    Friend WithEvents lblCalcBoosterFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcBoosterFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcBoosterFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcBoosterFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcBoosterFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcBoosterFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcBoosterFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcBoosterFacilityLocation As System.Windows.Forms.Label
    Friend WithEvents lblCalcBoosterFacilityType As System.Windows.Forms.Label
    Friend WithEvents chkCalcBoosterFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCalcBoosterFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcBoosterFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcBoosterFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents cmbCalcPOSLargeShips As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcPOSLargeShips As System.Windows.Forms.Label
    Friend WithEvents cmbCalcPOSFuelBlocks As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcPOSFuelBlocks As System.Windows.Forms.Label
    Friend WithEvents cmbCalcPOSModules As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcPOSModules As System.Windows.Forms.Label
    Friend WithEvents lblCalcBaseFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents tabCalcTeamComponents As System.Windows.Forms.TabPage
    Friend WithEvents txtCalcComponentManufacturingTeamBonus As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcSaveComponentManufacturingTeam As System.Windows.Forms.Button
    Friend WithEvents cmbCalcComponentManufacturingTeam As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcComponentManufacturingTeamDefault As System.Windows.Forms.Label
    Friend WithEvents chkCalcIncludeNoTeamComponents As System.Windows.Forms.CheckBox
    Friend WithEvents lblBPT3Decryptor As System.Windows.Forms.Label
    Friend WithEvents cmbBPT3Decryptor As System.Windows.Forms.ComboBox
    Friend WithEvents lblBPT3Stats As System.Windows.Forms.Label
    Friend WithEvents lblBPT3InventionChance As System.Windows.Forms.Label
    Friend WithEvents chkCalcDecryptorforT3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcDecryptorforT2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblCalcDecryptorUse As System.Windows.Forms.Label
    Friend WithEvents btnBPSaveBP As System.Windows.Forms.Button
    Friend WithEvents tabCalcFacilityT3Invention As System.Windows.Forms.TabPage
    Friend WithEvents lblCalcT3InventionFacilityManualTE As System.Windows.Forms.Label
    Friend WithEvents lblCalcT3InventionFacilityDefault As System.Windows.Forms.Label
    Friend WithEvents chkCalcT3InventionFacilityIncludeTime As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalcT3InventionFacilitySave As System.Windows.Forms.Button
    Friend WithEvents chkCalcT3InventionFacilityIncludeCost As System.Windows.Forms.CheckBox
    Friend WithEvents lblCalcT3InventionFacilityTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtCalcT3InventionFacilityManualTE As System.Windows.Forms.TextBox
    Friend WithEvents txtCalcT3InventionFacilityManualME As System.Windows.Forms.TextBox
    Friend WithEvents cmbCalcT3InventionFacilityorArray As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcT3InventionFacilitySystem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCalcT3InventionFacilityRegion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCalcT3InventionFacilityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCalcT3InventionFacilityManualME As System.Windows.Forms.Label
    Friend WithEvents lblCalcT3InventionFacilityBonus As System.Windows.Forms.Label
    Friend WithEvents mnuResetCRESTDates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkCalcInventionFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents lblCalcInventionInclude As System.Windows.Forms.Label
    Friend WithEvents lblCalcCopyInclude As System.Windows.Forms.Label
    Friend WithEvents chkCalcCopyFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents lblCalcT3InventionInclude As System.Windows.Forms.Label
    Friend WithEvents chkCalcT3InventionFacilityIncludeUsage As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcT3DestroyersFacility As System.Windows.Forms.CheckBox
    Friend WithEvents chkCalcCapComponentsFacility As System.Windows.Forms.CheckBox
    Friend WithEvents lblCalcBPs As System.Windows.Forms.Label
    Friend WithEvents txtCalcNumBPs As System.Windows.Forms.TextBox
    Friend WithEvents chkCalcAutoCalcT2NumBPs As System.Windows.Forms.CheckBox
    Friend WithEvents chkMineCompressedOre As System.Windows.Forms.CheckBox
    Friend WithEvents gbMineOreProcessingType As System.Windows.Forms.GroupBox
    Friend WithEvents chkMineUnrefinedOre As System.Windows.Forms.CheckBox
    Friend WithEvents gbMineBaseRefineSkills As System.Windows.Forms.GroupBox
    Friend WithEvents lblMineRefineryEfficiency As System.Windows.Forms.Label
    Friend WithEvents cmbMineRefining As System.Windows.Forms.ComboBox
    Friend WithEvents lblMineRefining As System.Windows.Forms.Label
    Friend WithEvents cmbMineRefineryEff As System.Windows.Forms.ComboBox
    Friend WithEvents ListOptionsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenMarketDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkUpdatePricesCRESTHistory As System.Windows.Forms.CheckBox
    Friend WithEvents txtBPFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblBPFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcBaseFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcBaseFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcComponentFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcComponentFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcCopyFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcCopyFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcInventionFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcInventionFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcT3InventionFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcT3InventionFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcCapitalFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcCapitalFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcSuperFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcSuperFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcT3FacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcT3FacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcSubsystemFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcSubsystemFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcBoosterFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcBoosterFacilityManualTax As System.Windows.Forms.Label
    Friend WithEvents txtCalcNoPOSFacilityManualTax As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcNoPOSFacilityManualTax As System.Windows.Forms.Label

End Class


' Class for Blueprint functions
Imports System.Data.SQLite

Public Class Blueprint

    ' Base variables
    Private BlueprintID As Long
    Private BlueprintName As String
    Private BlueprintGroup As String
    Private ItemID As Long
    Private ItemName As String
    Private ItemCategory As String
    Private ItemCategoryID As Long
    Private ItemGroup As String
    Private ItemGroupID As Long
    Private TechLevel As Integer
    Private PortionSize As Long ' Number of items produced by one run of blueprint
    Private BaseProductionTime As Long ' In seconds
    Private MaxProductionLimit As Integer
    Private ItemType As Integer
    Private BlueprintRace As Integer
    Private ItemVolume As Double ' Volume of produced item (1 item only)

    Private NumberofBlueprints As Integer

    ' If we compare the components for building or buying
    Private BuildBuy As Boolean
    Private HasBuildableComponents As Boolean = False
    Private AdditionalCosts As Double

    ' Taxes/Fees
    '   �	Buy - When you buy something off the market (Buy from someone�s Sell Order � So Minimum Sell), you don�t pay taxes or broker fees
    '       o	No Tax, No Broker Fee
    '   �	Sell Order - When you set up a sell order, you pay broker fees up front and taxes for items when sold. (This will be min sell usually)
    '       o	Tax, Broker Fee
    '   �	Buy Order - When you set up buy order, you pay broker fees up front but no tax when someone sells to you. (This is max buy usually).
    '       o	No Tax, Broker Fee
    '   �	Sell - When you Sell to a buy order (simple sell), you only pay taxes. (This will be Max buy)
    '       o 	Tax, No Broker Fee
    Private Taxes As Double ' See Above - Sell Order or Sell
    Private BPTaxes As Double ' Public updatable number for display updates, for easy updates when clicked
    Private BrokerFees As Double ' See above - Sell Order or Buy Order
    Private BPBrokerFees As Double ' Public updatable number for display updates, for easy updates when clicked

    ' New cost variables
    Private BaseJobCost As Double ' Total per material used * average price

    ' Base Fees for activity
    Private JobFee As Double

    ' How much it costs to use each facility to manufacture items and parts
    Private ManufacturingFacilityUsage As Double
    Private IncludeManufacturingUsage As Boolean
    Private ComponentFacilityUsage As Double
    Private CapComponentFacilityUsage As Double

    ' Team costs
    Private ManufacturingTeamFee As Double
    Private ComponentTeamFee As Double
    Private InventionTeamFee As Double
    Private CopyTeamFee As Double

    ' Variables for calcuations
    Private BPProductionTime As Double ' Production Time for 1 Run of Blueprint 
    Private TotalProductionTime As Double ' Production Time for 1 run of BP plus any components (this is to compare buying components vs. making them)
    Private iME As Double ' ME of Blueprint
    Private iTE As Double ' TE of Blueprint
    Private UserRuns As Long ' Number of runs for blueprint the user selects
    Private NumberofBPs As Integer ' Number of blueprints that the user is running
    Private NumberofProductionLines As Integer ' Number of production lines the user is using
    Private NumberofLaboratoryLines As Integer ' Number of laboratory lines the user is using
    Private ComponentProductionTimes As New List(Of Double) ' A list of production times for components in this BP

    ' Character skills we are making this blueprint with
    Private BPCharacter As Character ' The character for this BP
    Private IndustrySkill As Integer ' Industry skill level of character
    Private AdvancedIndustrySkill As Integer ' Old Production Efficiency skill, now reduces TE on building and researching
    Private AIImplantValue As Double ' Advanced Industry Implant on character
    Private CopyImplantValue As Double ' Copy implant value for this character

    ' Can do variables
    Private CanInventRE As Boolean ' if the sent character for the blueprint can invent it from a T1 or artifact
    Private CanBuildBP As Boolean ' if the user can build this BP
    Private CanBuildAll As Boolean ' if the user can build this BP and all components

    ' Material lists
    Private RawMaterials As Materials ' The list of All Raw materials for this item including the raw mats to make the buildable components in info list
    Private ComponentMaterials As Materials ' List of all the required materials to make the item as shown in info list

    ' Saving all the materials for each built component
    Private BuiltComponentList As BuiltItemList

    ' Skills required to make it
    Private ReqBuildSkills As New EVESkillList ' Just this BP
    Private ReqBuildComponentSkills As New EVESkillList ' All the skills to build just the components

    ' Invention variables
    Private ReqInventionSkills As New EVESkillList ' For inventing this BP
    Private ReqCopySkills As New EVESkillList ' For copying the BPC
    Private InventionMaterials As Materials
    Private CopyMaterials As Materials ' Some copies require items
    Private InventionChance As Double
    Private InventionDecryptor As Decryptor
    Private Relic As String ' Name of relic
    Private TotalInventedRuns As Integer ' Number of runs an invention job will produce
    Private SingleInventedBPCRuns As Integer ' The runs on one bp invented
    Private NumInventionJobs As Integer ' Number of invention jobs we will do

    Private CopyCost As Double ' Total Cost of the BPCs for the T2 item - for copy materials for things like data sheets, etc when needed
    Private CopyTime As Double ' Total time in seconds to copy the BPCs needed for the T2 item
    Private CopyUsage As Double ' Total Cost to make a copy

    Private IncludeCopyTime As Boolean
    Private IncludeCopyCosts As Boolean
    Private IncludeCopyUsage As Boolean

    Private InventionTime As Double ' Total time in seconds to invent this bp
    Private InventionCosts As Double ' Total cost for all the invention runs to get enough successful inventions for these runs
    Private InventionUsage As Double ' Total cost to do this activity in a facility

    Private TotalInventionCost As Double ' Total cost to run this invention job for this bp

    Private IncludeInventionCosts As Boolean
    Private IncludeInventionTime As Boolean
    Private IncludeInventionUsage As Boolean ' just the facility usage, not the full cost use for both T2 and T3

    Private AdvManufacturingSkillLevelBonus As Double ' The total TE reduction from skills required to invent and build this item (T2/T3)

    Private InventionT3BPCTypeID As Long ' BP used to invent the BP we are building

    ' Price Variables
    Private ItemMarketCost As Double ' Market cost of item 
    Private TotalRawCost As Double
    Private TotalComponentCost As Double
    Private TotalRawProfit As Double
    Private TotalComponentProfit As Double
    Private TotalRawProfitPercent As Double
    Private TotalComponentProfitPercent As Double
    Private TotalIPHRaw As Double
    Private TotalIPHComponent As Double

    ' Save all the settings here, which has all the standings, fees, etc in it
    Private UserSettings As ApplicationSettings

    ' What team they are using for this job
    Private ManufacturingTeam As IndustryTeam
    Private ComponentManufacturingTeam As IndustryTeam
    Private InventionTeam As IndustryTeam
    Private CopyTeam As IndustryTeam

    ' What facility are they using to produce?
    Private ManufacturingFacility As IndustryFacility
    Private ComponentManufacturingFacility As IndustryFacility
    Private CapitalComponentManufacturingFacility As IndustryFacility ' For all capital parts
    Private CopyFacility As IndustryFacility
    Private InventionFacility As IndustryFacility

    ' BP numbers
    Private RunsPerBP As Integer
    Private NumBPs As Integer

    ' T1 Constructor
    Public Sub New(ByVal BlueprintID As Long, ByVal BPRuns As Long, ByVal BPME As Double, ByVal BPTE As Double,
                   ByVal NumBlueprints As Integer, ByVal NumProductionLines As Integer, ByVal BPCharacter As Character, _
                   ByVal UserSettings As ApplicationSettings, ByVal BPBuildBuy As Boolean, ByVal UserAddlCosts As Double, BPTeam As IndustryTeam, _
                   ByVal BPProductionFacility As IndustryFacility, ByVal BPComponentProductionTeam As IndustryTeam, ByVal BPComponentProductionFacility As IndustryFacility, _
                   ByVal BPCapComponentProductionFacility As IndustryFacility)

        Call InitClass(BlueprintID, BPRuns, BPME, BPTE, NumBlueprints, NumProductionLines, BPCharacter, _
                       UserSettings, BPBuildBuy, UserAddlCosts, BPTeam, _
                       BPProductionFacility, BPComponentProductionTeam, BPComponentProductionFacility, BPCapComponentProductionFacility)

    End Sub

    ' T2/T3 Constructor
    Public Sub New(ByVal BlueprintID As Long, ByVal BPRuns As Long, ByVal BPME As Double, ByVal BPTE As Double,
                   ByVal NumBlueprints As Integer, ByVal NumProductionLines As Integer, ByVal NumLaboratoryLines As Integer, ByVal BPCharacter As Character, _
                   ByVal UserSettings As ApplicationSettings, ByVal UserAddlCosts As Double, _
                   ByVal BPProductionTeam As IndustryTeam, ByVal BPProductionFacility As IndustryFacility, _
                   ByVal BPComponentProductionTeam As IndustryTeam, ByVal BPComponentProductionFacility As IndustryFacility, _
                   ByVal BPCapComponentProductionFacility As IndustryFacility, _
                   ByVal BPBuildBuy As Boolean, ByVal BPDecryptor As Decryptor, _
                   ByVal BPInventionFacility As IndustryFacility, BPInventionTeam As IndustryTeam, _
                   ByVal BPCopyFacility As IndustryFacility, BPCopyTeam As IndustryTeam, InventionItemTypeID As Long)

        Dim SQL As String = ""

        ' Init the class first
        Call InitClass(BlueprintID, BPRuns, BPME, BPTE, NumBlueprints, NumProductionLines, BPCharacter, _
               UserSettings, BPBuildBuy, UserAddlCosts, BPProductionTeam, _
               BPProductionFacility, BPComponentProductionTeam, BPComponentProductionFacility, BPCapComponentProductionFacility)

        ' 3406 laboratory operation and 24624 is adv laboratory operation
        NumberofLaboratoryLines = NumLaboratoryLines

        ' Save copy and invention facility
        CopyFacility = BPCopyFacility
        InventionFacility = BPInventionFacility

        ' Invention variable inputs - The BPC or Relic first
        InventionT3BPCTypeID = InventionItemTypeID

        ' Set the Decryptor data
        InventionDecryptor = BPDecryptor

        ' Invention and Copy costs/times are set after getting the full base job materials
        IncludeInventionCosts = InventionFacility.IncludeActivityCost
        IncludeInventionTime = InventionFacility.IncludeActivityTime
        IncludeInventionUsage = InventionFacility.IncludeActivityUsage

        IncludeCopyCosts = CopyFacility.IncludeActivityCost
        IncludeCopyTime = CopyFacility.IncludeActivityTime
        IncludeCopyUsage = CopyFacility.IncludeActivityUsage

        ' Save teams
        InventionTeam = BPInventionTeam
        CopyTeam = BPCopyTeam

        InventionTeamFee = 0
        CopyTeamFee = 0

    End Sub

    ' Looks up the bae BP data for all constuctors and sets the initial values
    Private Sub InitClass(ByVal InitBPID As Long, ByVal InitBPRuns As Long, ByVal InitBPME As Double, ByVal InitBPTE As Double,
                          ByVal NumBlueprints As Integer, ByVal NumProductionLines As Integer, ByVal InitCharacter As Character, _
                          ByVal InitBPUserSettings As ApplicationSettings, ByVal BPBuildBuy As Boolean, ByVal UserAddlCosts As Double, _
                          ByVal InitBPProductionTeam As IndustryTeam, ByVal InitProductionFacility As IndustryFacility, _
                          ByVal InitComponentProductionTeam As IndustryTeam, ByVal InitComponentProductionFacility As IndustryFacility, _
                          ByVal InitCapComponentProductionFacilty As IndustryFacility)

        Dim readerBP As SQLiteDataReader
        Dim readerCost As SQLiteDataReader
        Dim SQL As String = ""

        SQL = "SELECT BLUEPRINT_ID, BLUEPRINT_NAME, BLUEPRINT_GROUP, ITEM_ID, ITEM_NAME, ITEM_CATEGORY_ID, ITEM_CATEGORY,"
        SQL = SQL & "ITEM_GROUP_ID, ITEM_GROUP, TECH_LEVEL, PORTION_SIZE, BASE_PRODUCTION_TIME,"
        SQL = SQL & "MAX_PRODUCTION_LIMIT, ITEM_TYPE, RACE_ID, VOLUME "
        SQL = SQL & "FROM ALL_BLUEPRINTS INNER JOIN INVENTORY_TYPES ON ALL_BLUEPRINTS.ITEM_ID = INVENTORY_TYPES.typeID "
        SQL = SQL & "WHERE BLUEPRINT_ID =" & InitBPID

        DBCommand = New SQLiteCommand(SQL, DB)
        readerBP = DBCommand.ExecuteReader

        If readerBP.Read Then
            ' Set the variables
            BlueprintID = readerBP.GetInt64(0)
            BlueprintName = readerBP.GetString(1)
            BlueprintGroup = readerBP.GetString(2)
            ItemID = readerBP.GetInt64(3)
            ItemName = readerBP.GetString(4)
            ItemCategoryID = readerBP.GetInt64(5)
            ItemCategory = readerBP.GetString(6)
            ItemGroupID = readerBP.GetInt64(7)
            ItemGroup = readerBP.GetString(8)
            TechLevel = readerBP.GetInt32(9)
            PortionSize = readerBP.GetInt64(10)
            BaseProductionTime = readerBP.GetInt64(11)
            MaxProductionLimit = readerBP.GetInt32(12)
            ItemType = readerBP.GetInt32(13)
            If Not readerBP.IsDBNull(12) Then
                BlueprintRace = readerBP.GetInt32(14)
            Else
                BlueprintRace = 0
            End If
            ItemVolume = readerBP.GetDouble(15) * PortionSize ' Ammo, blocks, bombs, etc have more items per run
        Else
            Exit Sub
        End If

        readerBP.Close()

        ' Settings
        UserSettings = InitBPUserSettings

        RawMaterials = New Materials
        ComponentMaterials = New Materials
        InventionMaterials = New Materials
        CopyMaterials = New Materials

        CopyCost = 0
        CopyTime = 0
        TotalInventionCost = 0
        InventionTime = 0

        ManufacturingFacilityUsage = 0
        ComponentFacilityUsage = 0
        CapComponentFacilityUsage = 0

        CopyUsage = 0
        InventionUsage = 0

        BaseJobCost = 0
        JobFee = 0

        ManufacturingTeamFee = 0
        ComponentTeamFee = 0

        InventionDecryptor = NoDecryptor
        Relic = ""
        TotalInventedRuns = 0

        NumInventionJobs = 0

        ' Do build/buy 
        BuildBuy = BPBuildBuy

        iME = InitBPME
        iTE = InitBPTE

        Taxes = 0
        BrokerFees = 0

        ' See if we want to include the costs
        IncludeManufacturingUsage = InitProductionFacility.IncludeActivityUsage

        ' If they send zero lines, then set to the user skills
        If NumProductionLines = 0 Then ' 3387 mass production and 24625 is adv mass production
            NumberofProductionLines = BPCharacter.Skills.GetSkillLevel(3387) + BPCharacter.Skills.GetSkillLevel(24625) + 1
        Else
            NumberofProductionLines = NumProductionLines
        End If

        NumberofBPs = NumBlueprints

        AdditionalCosts = UserAddlCosts

        UserRuns = InitBPRuns

        BPCharacter = InitCharacter

        ' Set the skills to use for this blueprint - changed to type ID's due to name changes (1/29/2014)
        AdvancedIndustrySkill = BPCharacter.Skills.GetSkillLevel(3388)
        IndustrySkill = BPCharacter.Skills.GetSkillLevel(3380)

        ' Add production implant from settings
        AIImplantValue = 1 - InitBPUserSettings.ManufacturingImplantValue

        ' Teams
        ManufacturingTeam = InitBPProductionTeam
        ComponentManufacturingTeam = InitComponentProductionTeam

        ' Production facilities
        ManufacturingFacility = InitProductionFacility
        ComponentManufacturingFacility = InitComponentProductionFacility
        CapitalComponentManufacturingFacility = InitCapComponentPRoductionFacilty

        ' Set the flag if the user sent to this blueprint can invent it
        CanInventRE = False ' Can invent T1 BP to this T2 BP
        CanBuildBP = True ' Can build BP (assume we can until we change it)
        CanBuildAll = True ' Can build all components (assume we can until we change it)

        HasBuildableComponents = False

        ' Look up the cost for the final item
        SQL = "SELECT PRICE FROM ITEM_PRICES WHERE ITEM_ID =" & ItemID

        DBCommand = New SQLiteCommand(SQL, DB)
        readerCost = DBCommand.ExecuteReader

        Dim ItemCost As Double

        If readerCost.Read Then
            ItemCost = readerCost.GetDouble(0)
        Else
            ItemCost = 0
        End If

        ' Full cost of items is portion size (ammo, bombs, etc) times runs times cost
        ItemMarketCost = ItemCost * UserRuns * PortionSize

        BuiltComponentList = New BuiltItemList

        readerCost.Close()
        readerCost = Nothing
        readerBP.Close()
        readerBP = Nothing
        DBCommand = Nothing

    End Sub

    ' Base build function that takes a look at the number of blueprints the user wants to use and then builts each blueprint batch
    Public Sub BuildItems(ByVal SetTaxes As Boolean, ByVal SetBrokerFees As Boolean, ByVal SetProductionCosts As Boolean)

        ' Need to check for the number of BPs sent and run multiple batches if necessary. Also, look at the number of lines per batch
        If NumberofBPs = 1 Then
            'Just run the normal function and it will set everything
            Call BuildItem(SetTaxes, SetBrokerFees, SetProductionCosts)
        Else
            ' Need to figure out the number of batches - treat any item that is built with more than one blueprint differently
            ' Assumptions - They want the most effcient way to build. Ie, 96 runs, 9 bps, then do 6 batches of 11, and 3 of 10. 
            ' So max the number of runs per BP to equally distribute batches

            Dim BPBatches As Integer = NumberofBPs ' Number of bps is the number of batches unless greater than user runs
            Dim ExtraRuns As Integer
            Dim RunsperBP As Integer
            Dim AdjRunsperBP As Integer

            Dim BatchBlueprint As Blueprint

            ' Divide the runs by number of bps - take whole amount first.
            If UserRuns >= NumberofBPs Then
                RunsperBP = CInt(Math.Floor(UserRuns / NumberofBPs))
                ExtraRuns = CInt(UserRuns - (RunsperBP * NumberofBPs))
            Else
                ' bp batches = number of runs
                BPBatches = CInt(UserRuns)
                ' Reset num bps for this
                NumberofBPs = CInt(UserRuns)
                RunsperBP = 1
                ExtraRuns = 0
            End If

            ' Fill a list of runs per bp
            Dim BatchList As New List(Of Integer)

            For i = 0 To BPBatches - 1
                ' As we add the runs, adjust with extra runs proportionally until they are gone
                If ExtraRuns <> 0 Then
                    ' Since it's a fraction of a total batch run, this will always just be one until gone
                    AdjRunsperBP = RunsperBP + 1
                    ExtraRuns = ExtraRuns - 1 ' Adjust extra
                Else
                    ' No extra runs, so just add the original runs now
                    AdjRunsperBP = RunsperBP
                End If

                BatchList.Add(AdjRunsperBP)
            Next

            ' Now we just build each BP for the runs in the batch and total up all the variables - apply additional costs per batch
            For i = 0 To BatchList.Count - 1
                If TechLevel = 1 Then
                    BatchBlueprint = New Blueprint(BlueprintID, BatchList(i), iME, iTE, 1, NumberofProductionLines, BPCharacter, UserSettings, BuildBuy, _
                                                   CDbl(AdditionalCosts / BatchList.Count), ManufacturingTeam, ManufacturingFacility, ComponentManufacturingTeam, _
                                                   ComponentManufacturingFacility, CapitalComponentManufacturingFacility)
                Else
                    BatchBlueprint = New Blueprint(BlueprintID, BatchList(i), iME, iTE, 1, NumberofProductionLines, NumberofLaboratoryLines, BPCharacter, UserSettings, _
                                                   CDbl(AdditionalCosts / BatchList.Count), ManufacturingTeam, ManufacturingFacility, ComponentManufacturingTeam, _
                                                   ComponentManufacturingFacility, CapitalComponentManufacturingFacility, BuildBuy, InventionDecryptor, InventionFacility, _
                                                   InventionTeam, CopyFacility, CopyTeam, InventionT3BPCTypeID)
                End If

                Call BatchBlueprint.BuildItem(SetTaxes, SetBrokerFees, SetProductionCosts)

                With BatchBlueprint
                    ' Save all the variables
                    If BatchBlueprint.HasBuildableComponents And HasBuildableComponents = False Then
                        HasBuildableComponents = True
                    End If

                    If BatchBlueprint.CanInventRE And CanInventRE = False Then
                        CanInventRE = True
                    End If

                    ' Assumption is that we can build the bp
                    If Not BatchBlueprint.CanBuildBP And CanBuildBP = True Then
                        CanBuildBP = False
                    End If

                    If Not BatchBlueprint.CanBuildAll And CanBuildAll = True Then
                        CanBuildAll = False
                    End If

                    ' Material lists
                    RawMaterials.InsertMaterialList(.GetRawMaterials.GetMaterialList)

                    If Not IsNothing(.GetComponentMaterials.GetMaterialList) Then
                        ComponentMaterials.InsertMaterialList(.GetComponentMaterials.GetMaterialList)
                    End If

                    If Not IsNothing(.GetInventionMaterials.GetMaterialList) Then
                        InventionMaterials.InsertMaterialList(.GetInventionMaterials.GetMaterialList)
                    End If

                    If Not IsNothing(.GetBPCCopyMaterials.GetMaterialList) Then
                        CopyMaterials.InsertMaterialList(.GetBPCCopyMaterials.GetMaterialList)
                    End If

                    For Each BI In .GetBPComponentsList.GetBuiltItemList
                        BuiltComponentList.AddBuiltItem(BI)
                    Next

                    BPProductionTime += .GetProductionTime
                    TotalProductionTime += .GetTotalProductionTime

                    ' Skills required to make it
                    ReqBuildSkills = .GetReqBPSkills
                    ReqBuildComponentSkills = .GetReqComponentSkills
                    ReqCopySkills = .ReqCopySkills
                    ReqInventionSkills = .ReqInventionSkills

                    CopyCost += .GetBPCCopyCost()
                    CopyTime += .GetBPCCopyTime()
                    CopyUsage += .GetBPCCopyUsage()

                    InventionUsage += .GetBPInventionUsage()
                    InventionCosts += .GetBPInventionCost()
                    InventionTime += .GetBPInventionTime()

                    TotalInventionCost += .GetBPTotalInventionCosts

                    InventionChance = .GetInventionChance
                    InventionDecryptor = .GetDecryptor
                    Relic = .GetRelic()
                    SingleInventedBPCRuns = .GetInventedRuns
                    NumInventionJobs += .GetInventionJobs

                    Taxes += .GetBPTaxes
                    BrokerFees += .GetBPBrokerFees

                    ' New cost variables
                    BaseJobCost += .GetBaseJobCost

                    ' Base Fees for activity
                    JobFee += .GetJobFee

                    ' How much it costs to use each facility to manufacture items and parts
                    ManufacturingFacilityUsage += .GetManufacturingFacilityUsage
                    ComponentFacilityUsage += .GetComponentFacilityUsage
                    CapComponentFacilityUsage += .GetCapComponentFacilityUsage

                    ' Team costs
                    ManufacturingTeamFee += .GetManufacturingTeamFee
                    ComponentTeamFee += .GetComponentTeamFee
                    InventionTeamFee = 0 ' No invention teams
                    CopyTeamFee += .CopyTeamFee

                    ' Just run the update price function for all other prices since we have the mat lists
                    Call SetPriceData(SetTaxes, SetBrokerFees)

                End With
            Next

        End If

    End Sub

    ' Sets the material versions for our blueprint
    Private Sub BuildItem(ByVal SetTaxes As Boolean, ByVal SetBrokerFees As Boolean, ByVal SetProductionCosts As Boolean)
        ' Database stuff
        Dim SQL As String
        Dim readerBP As SQLiteDataReader
        Dim readerME As SQLiteDataReader

        Dim TempME As Double
        Dim TempTE As Double
        Dim OwnedBP As Boolean = False

        ' Recursion variables
        Dim ComponentBlueprint As Blueprint = Nothing
        Dim TempSkills As New EVESkillList

        ' The current material we are working with
        Dim CurrentMaterial As Material
        Dim CurrentMatQuantity As Long
        Dim T1BaseItem As Boolean = False

        ' Temp Materials for passing
        Dim TempMaterials As New Materials

        Dim TempNumBPs As Integer = 1

        ' Select all materials to buid this BP
        SQL = "SELECT BLUEPRINT_ID, MATERIAL_ID, QUANTITY, MATERIAL, MATERIAL_CATEGORY, ACTIVITY, MATERIAL_VOLUME, PRICE, ADJUSTED_PRICE, groupID "
        SQL = SQL & "FROM ALL_BLUEPRINT_MATERIALS LEFT OUTER JOIN ITEM_PRICES ON ALL_BLUEPRINT_MATERIALS.MATERIAL_ID = ITEM_PRICES.ITEM_ID, INVENTORY_TYPES "
        SQL = SQL & "WHERE ALL_BLUEPRINT_MATERIALS.BLUEPRINT_ID =" & BlueprintID & " AND ACTIVITY = 1 AND MATERIAL_ID = INVENTORY_TYPES.typeID"

        DBCommand = New SQLiteCommand(SQL, DB)
        readerBP = DBCommand.ExecuteReader

        ' For each material in the blueprint, calculate the total mats
        ' and load them into the list
        While readerBP.Read
            If readerBP.GetString(4) = "Skill" Then
                ' It's a skill, so just add it to the main list of BP skills
                ReqBuildSkills.InsertSkill(readerBP.GetInt64(1), readerBP.GetInt32(2), 0, False, 0, "", Nothing, True)
            Else
                ' Set the current material
                CurrentMaterial = New Material(readerBP.GetInt64(1), readerBP.GetString(3), readerBP.GetString(4), readerBP.GetInt64(2), readerBP.GetDouble(6), If(readerBP.IsDBNull(7), 0, readerBP.GetDouble(7)), "")

                ' Save the base costs
                BaseJobCost += CurrentMaterial.GetQuantity * readerBP.GetDouble(8)

                ' Set the quantity: required = max(runs,ceil(round(runs * baseQuantity * materialModifier,2))
                CurrentMatQuantity = CLng(Math.Max(UserRuns, Math.Ceiling(Math.Round(UserRuns * CurrentMaterial.GetQuantity * SetBPMaterialModifier(), 2))))

                ' Update the quantity - just add the negative percent of the ME modifier to 1 and multiply
                Call CurrentMaterial.SetQuantity(CurrentMatQuantity)

                ' If it has a value in ALL_BLUEPRINTS, then the item can be built from it's own BP
                SQL = "SELECT BLUEPRINT_ID, TECH_LEVEL FROM ALL_BLUEPRINTS WHERE ITEM_ID =" & CurrentMaterial.GetMaterialTypeID
                DBCommand = New SQLiteCommand(SQL, DB)
                readerME = DBCommand.ExecuteReader

                ' Treat augmented drones, polarized weapons, and all ship skins as just base blueprints - don't build the T2 items that they use (yet)
                If readerME.Read And Not (BlueprintName.Contains("'Augmented'") And CurrentMaterial.GetMaterialGroup = "Drone") _
                    And Not BlueprintName.Contains("Edition") And Not BlueprintName.Contains("Polarized") Then
                    ' We can build it from another BP
                    HasBuildableComponents = True

                    ' Look up the ME/TE and owned data for the bp
                    Call GetMETEforBP(readerME.GetInt64(0), readerME.GetInt32(1), TempME, TempTE, OwnedBP)

                    ' Update the current material's ME
                    CurrentMaterial.SetItemME(CStr(TempME))

                    ' We can build it from another BP, See if it's a T1 Item
                    Select Case readerBP.GetString(4)
                        Case "Ship", "Drone", "Module", "Charge"
                            T1BaseItem = True
                        Case Else
                            T1BaseItem = False
                    End Select

                    Dim TempComponentFacility As IndustryFacility

                    ' Build the T1 component
                    If readerBP.GetDouble(9) = AdvCapitalComponentGroupID Or readerBP.GetDouble(9) = CapitalComponentGroupID Then
                        ' Use capital component facility
                        TempComponentFacility = CapitalComponentManufacturingFacility
                    ElseIf T1BaseItem Then
                        ' Want to build this in the manufacturing facility we are using
                        TempComponentFacility = ManufacturingFacility
                    Else ' Components
                        TempComponentFacility = ComponentManufacturingFacility
                    End If

                    ' For now only assume 1 bp and 1 line to build it - Later this section will have to be updated to use the remaining lines or maybe lines = numbps
                    ComponentBlueprint = New Blueprint(readerME.GetInt64(0), CLng(CurrentMaterial.GetQuantity), TempME, TempTE, _
                              1, 1, BPCharacter, UserSettings, BuildBuy, _
                              0, ComponentManufacturingTeam, TempComponentFacility, _
                              ComponentManufacturingTeam, ComponentManufacturingFacility, CapitalComponentManufacturingFacility)

                    ' Set this blueprint with the quantity needed and get it's mats *** Recursive Call *** - Changed Recyle to use varible instead of False - 3/16/2014
                    Call ComponentBlueprint.BuildItem(SetTaxes, SetBrokerFees, SetProductionCosts)

                    ' Determine if the component should be bought, or we should build it and add to the correct list
                    If BuildBuy Then
                        ' Only build BPs that we own (if the user wants us to limit this) and the mat cost is greater than build, or no mat cost loaded (no market price so no idea if it's cheaper to buy or not) - Build it
                        If CurrentMaterial.GetTotalCost = 0 Or (CurrentMaterial.GetTotalCost > ComponentBlueprint.GetRawMaterials.GetTotalMaterialsCost _
                                                                And ((UserSettings.SuggestBuildBPNotOwned) Or (OwnedBP And Not UserSettings.SuggestBuildBPNotOwned))) Then
                            '*** BUILD ***
                            ' We want to build this item
                            CurrentMaterial.SetBuildItem(True)

                            ' Save the production time for this component
                            Call ComponentProductionTimes.Add(ComponentBlueprint.GetProductionTime)

                            ' Get the skills for BP to build it and add them to the list
                            TempSkills = ComponentBlueprint.GetReqBPSkills

                            ' Building this, so add fees to current (taxes for mats added in building item)
                            ManufacturingFacilityUsage += ComponentBlueprint.GetManufacturingFacilityUsage

                            ' Get the component usage
                            Select Case ComponentBlueprint.GetItemGroupID
                                Case AdvCapitalComponentGroupID, CapitalComponentGroupID
                                    CapComponentFacilityUsage += ComponentBlueprint.GetManufacturingFacilityUsage
                                Case Else
                                    ComponentFacilityUsage += ComponentBlueprint.GetManufacturingFacilityUsage
                            End Select

                            ' Save the component team fees
                            ComponentTeamFee += ComponentBlueprint.GetManufacturingTeamFee

                            ' Since we are building this item, set the material cost to build cost per item, not buy
                            CurrentMaterial.SetBuildCost(ComponentBlueprint.GetRawMaterials.GetTotalMaterialsCost / CurrentMaterial.GetQuantity)

                            ' Insert the raw mats of this blueprint
                            RawMaterials.InsertMaterialList(ComponentBlueprint.GetRawMaterials.GetMaterialList)

                            ' Save the item built, it's ME and the materials it used
                            Dim TempBuiltItem As New BuiltItem
                            TempBuiltItem.ItemTypeID = CurrentMaterial.GetMaterialTypeID
                            TempBuiltItem.ItemName = CurrentMaterial.GetMaterialName
                            TempBuiltItem.ItemQuantity = CurrentMaterial.GetQuantity
                            TempBuiltItem.BuildME = TempME
                            TempBuiltItem.BuildMaterials = ComponentBlueprint.GetRawMaterials

                            BuiltComponentList.AddBuiltItem(TempBuiltItem)

                        Else ' *** BUY ***
                            ' We want to buy this item, don't add raw mats but add the component to the buy list (raw mats)
                            CurrentMaterial.SetBuildItem(False)
                            ' Also, not adding the build time to the lists
                            RawMaterials.InsertMaterial(CurrentMaterial)
                        End If

                        ' Finally, insert all components into the build/buy list
                        ComponentMaterials.InsertMaterial(CurrentMaterial)

                    Else ' *** BUILD COMPONENT ALWAYS ***

                        ' We want to build this item
                        CurrentMaterial.SetBuildItem(True)

                        ' Save the production time for this component
                        Call ComponentProductionTimes.Add(ComponentBlueprint.GetProductionTime)

                        ' Get the skills for BP to build it and add them to the list
                        TempSkills = ComponentBlueprint.GetReqBPSkills

                        ' Get the component usage
                        Select Case ComponentBlueprint.GetItemGroupID
                            Case AdvCapitalComponentGroupID, CapitalComponentGroupID
                                CapComponentFacilityUsage += ComponentBlueprint.GetManufacturingFacilityUsage
                            Case Else
                                ComponentFacilityUsage += ComponentBlueprint.GetManufacturingFacilityUsage
                        End Select

                        ' Save the component team fees
                        ComponentTeamFee += ComponentBlueprint.GetManufacturingTeamFee

                        ' Insert the raw mats of this blueprint
                        RawMaterials.InsertMaterialList(ComponentBlueprint.GetRawMaterials.GetMaterialList)

                        ' Insert the existing component that we are using into the component list
                        ComponentMaterials.InsertMaterial(CurrentMaterial)

                        ' Save the item built, it's ME and the materials it used
                        Dim TempBuiltItem As New BuiltItem
                        TempBuiltItem.ItemTypeID = CurrentMaterial.GetMaterialTypeID
                        TempBuiltItem.ItemName = CurrentMaterial.GetMaterialName
                        TempBuiltItem.ItemQuantity = CurrentMaterial.GetQuantity
                        TempBuiltItem.BuildME = TempME
                        TempBuiltItem.BuildMaterials = ComponentBlueprint.GetRawMaterials

                        BuiltComponentList.AddBuiltItem(TempBuiltItem)

                    End If

                    ' If we build this blueprint, add on the skills required
                    If TempSkills.NumSkills <> 0 Then
                        ReqBuildComponentSkills.InsertSkills(TempSkills, True)
                    End If

                    ' Check if we can build all components. If we can't make one item then we set it to false and leave it that way
                    If CanBuildAll Then
                        If Not UserHasReqSkills(BPCharacter.Skills, ComponentBlueprint.GetReqBPSkills) Then
                            ' Can't build this item, so we can't build all components from main blueprint
                            CanBuildAll = False
                        End If
                    End If


                Else ' Just raw material or T2 drone for augmented drones, ORE Mack and Polarized weapons, insert into list

                    If readerME.HasRows And ((BlueprintName.Contains("'Augmented'") Or CurrentMaterial.GetMaterialGroup = "Drone") _
                    Or Not BlueprintName.Contains("Edition") Or Not BlueprintName.Contains("Polarized")) Then
                        ' This is a component, so look up the ME of the item to put on the material before adding (fixes issue when searching for shopping list items of the same type - no ME is "-" and these have an me
                        ' For example, see modulate core strip miner and polarized heavy pulse weapons.
                        Call GetMETEforBP(readerME.GetInt64(0), readerME.GetInt32(1), TempME, TempTE, OwnedBP)
                        CurrentMaterial.SetItemME(CStr(TempME))
                    End If

                    ' We are not building these
                    CurrentMaterial.SetBuildItem(False)

                    ' Insert the raw mats
                    RawMaterials.InsertMaterial(CurrentMaterial)
                    ' Also insert into component list
                    ComponentMaterials.InsertMaterial(CurrentMaterial)

                End If

                readerME.Close()
                readerME = Nothing

            End If

        End While

        readerBP.Close()
        readerBP = Nothing
        DBCommand = Nothing

        ' Set the build flag for the blueprint
        If UserHasReqSkills(BPCharacter.Skills, ReqBuildSkills) Then
            CanBuildBP = True
        Else
            CanBuildBP = False
        End If

        ' Set the Advanced Skill levels to build this item for later application of Production Time
        AdvManufacturingSkillLevelBonus = SetAdvManufacturingSkillLevels(ReqBuildSkills)

        ' Set the invention data if this is a T2
        If (TechLevel = BlueprintTechLevel.T2 Or TechLevel = BlueprintTechLevel.T3) _
            And (Not BlueprintName.Contains("Edition") And Not BlueprintName.Contains("Polarized") And Not BlueprintName.Contains("Augmented")) Then
            ' Set the T2/T3 skills to invent from the T1 version
            Call SetInventionSkills()

            ' Set the T2/T3 skills to copy from the T1 BPC
            Call SetCopySkills()

            ' Set the invention flag
            CanInventRE = UserHasReqSkills(BPCharacter.Skills, ReqInventionSkills)

            ' Use typical invention costs to invent this
            Call InventREBlueprint(Not CanInventRE)

        End If

        ' Set the production time
        Call SetProductionTime()

        ' Set taxes and fees on this item only (materials set in shopping list)
        Taxes = GetTaxes(ItemMarketCost)
        BrokerFees = GetBrokerFee(ItemMarketCost)

        ' Set the costs for making this item
        Call SetManufacturingCostsAndFees()

        ' Update the total time, if we used components
        If Not IsNothing(ComponentProductionTimes) Then
            TotalProductionTime = TotalProductionTime + GetComponentProductionTime(ComponentProductionTimes)
        End If

        ' Add all the times here - only include copy, re, and invention times here since it's the total time
        TotalProductionTime = TotalProductionTime + BPProductionTime + CopyTime + InventionTime
        ' Finally, add in the copy, invention and RE time if they sent it
        BPProductionTime = BPProductionTime + CopyTime + InventionTime

        ' Finally set all the price data
        Call SetPriceData(SetTaxes, SetBrokerFees)

    End Sub

    ' Determine ProductionTime of Components - they have 15 components, and 10 usable production lines, then take the max time, and sum up the rest and divide as sections of the max
    ' So if they have a 10 minute component, and 5, 1 minute components, we can make all in 2 jobs and the total time is 10 min. If they go over max jobs,
    ' then take the max component and add on the max job of the 2nd component
    ' TO DO - FIX
    Private Function GetComponentProductionTime(ByVal SentTimes As List(Of Double)) As Double
        Dim MaxComponentTime As Double = 0
        Dim RemainingTimeSum As Double = 0
        Dim JobTimeSum As Double = 0
        Dim Temp As New List(Of Double)
        Dim JobCount As Integer

        Dim i As Integer
        Dim SessionTime As Double

        'Dim ProductionCombos As New List(Of BPCombinations) ' Each entry is a combination, each index is a line, total time is the combined times
        'Dim CurrentBPCombo As BPCombinations = Nothing
        ''Dim BPTimeStartIndex As Integer
        'Dim LinesIndex As Integer
        'Dim TimeIndex As Integer
        'Dim CompareTime As Double
        'Dim MinimumTimeIndex As Integer

        'Dim TopBPTimesperCombo() As Double

        If SentTimes.Count = 0 Then
            Return 0
        End If

        'If TestingVersion Then
        '    ' Simple case 1
        '    If NumberofProductionLines = 1 Then
        '        ' Just sum up the times
        '        For i = 0 To SentTimes.Count - 1
        '            SessionTime = SessionTime + SentTimes(i)
        '        Next

        '    ElseIf ComponentProductionTimes.Count <= NumberofProductionLines Then
        '        ' Simple case 2
        '        ' Just return the max, we can make all the others within the time to make the first,
        '        ' we have enough lines, and we have to wait for the first to end
        '        SessionTime = SentTimes.Max

        '    Else ' Hard case, need to find most optimal combination

        '        ' Set the lines
        '        ReDim CurrentBPCombo.CombinedTimes(NumberofProductionLines - 1)
        '        LinesIndex = 0
        '        BPTimeStartIndex = 0

        '        ' This is the number of combinations we should get
        '        For i = 0 To SentTimes.Count - 1

        '            ' Loop through each blueprint and each set of combos, start on a new initial bp time
        '            For j = 0 To SentTimes.Count - 1

        '                ' This moves the index from the start (say 3) to loop back to 0 when necessary
        '                If BPTimeStartIndex + j < SentTimes.Count Then
        '                    ' If less than count, just increment with j from start
        '                    TimeIndex = BPTimeStartIndex + j
        '                ElseIf BPTimeStartIndex + j > SentTimes.Count Then
        '                    ' If we go over count, then the index must have been set to 0 (when equal) so increment the timeindex
        '                    TimeIndex += 1
        '                Else ' equal
        '                    TimeIndex = 0
        '                End If

        '                ' Loop through each BP and move through the index
        '                CurrentBPCombo.CombinedTimes(LinesIndex) = CurrentBPCombo.CombinedTimes(LinesIndex) + SentTimes(TimeIndex)

        '                ' Reset line index so we add to the right line
        '                If LinesIndex = CurrentBPCombo.CombinedTimes.Count - 1 Then
        '                    LinesIndex = 0
        '                Else
        '                    LinesIndex += 1
        '                End If

        '            Next

        '            ' Insert the current bp combo into the list, then start processing the next combination
        '            ProductionCombos.Insert(i, CurrentBPCombo)

        '            ' Increment the BP Start index
        '            BPTimeStartIndex += 1
        '            ' Reset combined times
        '            LinesIndex = 0
        '            ReDim CurrentBPCombo.CombinedTimes(NumberofProductionLines - 1)

        '        Next

        '        ' Now we should have a list of possible line and bp time (bps) time combinations
        '        ' Find the largest of each index and save time - This is the max time it will take to make all the blueprints in that combo
        '        ReDim TopBPTimesperCombo(ProductionCombos.Count - 1)

        '        For i = 0 To ProductionCombos.Count - 1
        '            TopBPTimesperCombo(i) = ProductionCombos(i).CombinedTimes.Max
        '        Next

        '        ' Finally, find the minimum time of the maximums from the combos (save the index by doing a loop instead of just getting the min)
        '        ' This is the ideal BP production combination and the optimal time to make the item
        '        For i = 0 To TopBPTimesperCombo.Count - 1
        '            CompareTime = TopBPTimesperCombo(i)

        '            If CompareTime < SessionTime Or SessionTime = 0 Then
        '                SessionTime = CompareTime
        '                MinimumTimeIndex = i
        '            End If
        '        Next

        '    End If

        'Else

        ' Easy case - NOT WORKING RIGHT - LOOK AT FENRIR
        If NumberofProductionLines = 1 Then
            ' Nothing simpler than this, it's just the total time to make components back to back
            For i = 0 To SentTimes.Count - 2
                RemainingTimeSum = RemainingTimeSum + SentTimes(i)
            Next

            SessionTime = RemainingTimeSum

        Else
            If ComponentProductionTimes.Count <= NumberofProductionLines Then
                ' Just return the max, we can make all the others within the time to make the first,
                ' we have enough lines, and we have to wait for the first to end
                SessionTime = SentTimes.Max
            Else ' Have some extra bps to make vs. lines - IE 7 components and 4 lines
                ' The max time is the metric for time per session
                MaxComponentTime = SentTimes.Max
                ' Sort the array (in ascending order)
                SentTimes.Sort()
                ' Sum up the rest of the jobs, skipping the last one
                For i = 0 To SentTimes.Count - 2
                    RemainingTimeSum = RemainingTimeSum + SentTimes(i)
                Next

                If MaxComponentTime > RemainingTimeSum Then
                    ' We can do all jobs in the time it takes to make the longest one
                    SessionTime = MaxComponentTime
                Else
                    ' Have more than one set to do
                    ' Reset time
                    RemainingTimeSum = 0
                    JobTimeSum = 0
                    JobCount = 1 ' First new job
                    ' Loop through times, and save index of last time that fits, start largest to smallest skipping first one
                    For i = SentTimes.Count - 2 To 1 Step -1
                        JobTimeSum = JobTimeSum + SentTimes(i)
                        If JobTimeSum > MaxComponentTime Then
                            ' We went over, so pull off the last time and step back i
                            JobTimeSum = JobTimeSum - SentTimes(i)
                            i = i + 1
                            If JobCount < NumberofProductionLines Then
                                ' One production line gone and we have more, move to the next
                                JobCount = JobCount + 1
                                ' Save this job time
                                RemainingTimeSum = RemainingTimeSum + JobTimeSum
                                JobTimeSum = 0
                            Else
                                ' No more lines left, need to get a new job going
                                ' Need to add this to the time and exit
                                RemainingTimeSum = RemainingTimeSum + JobTimeSum
                                Exit For
                            End If
                        End If
                    Next

                    If JobCount = NumberofProductionLines Then
                        ' Need to get the time of the next session, call this again and get the next session time
                        Dim j As Integer = i - 1
                        ' Copy in the final values
                        For i = 0 To j - 1
                            Temp.Add(SentTimes(i))
                        Next

                        RemainingTimeSum = RemainingTimeSum + GetComponentProductionTime(Temp)
                    End If

                    ' Add up the final time
                    SessionTime = MaxComponentTime + RemainingTimeSum

                End If

            End If
        End If
        'End If

        Return SessionTime

    End Function

    ' Sets the Production time for this Blueprint
    Private Sub SetProductionTime()
        ' For total runs
        Dim FullJobSessions As Long = 0
        Dim JobsPerBatch As Long = 0

        ' For 1 run of this item add in the modifier plus skill level modifiers
        BPProductionTime = BaseProductionTime * SetBPTimeModifier() * AdvManufacturingSkillLevelBonus

        ' Figure out how many jobs per batch we need to run, find the smallest of the two
        If NumberofBPs > NumberofProductionLines Then
            JobsPerBatch = NumberofProductionLines
        ElseIf NumberofBPs <= NumberofProductionLines Then
            JobsPerBatch = NumberofBPs
        End If

        ' Batches more than runs aren't used, so just normalize to runs
        If JobsPerBatch > UserRuns Then
            JobsPerBatch = UserRuns
        End If

        ' Now find the number of job sessions of 1 run each we need to do, round up to next whole integer - 1.1 sessions is 2
        FullJobSessions = CLng(Math.Ceiling(UserRuns / JobsPerBatch))

        ' Total time is just the total sessions multiplied by the production time
        BPProductionTime = FullJobSessions * BPProductionTime

    End Sub

    ' Sets all price data for the user to get on this blueprint, Set public so can reset with fees/taxes
    Public Sub SetPriceData(ByVal SetTaxes As Boolean, ByVal SetBrokerFees As Boolean)
        Dim TaxesFeesUsage As Double = 0

        If SetTaxes Then
            BPTaxes = Taxes
        Else
            BPTaxes = 0
        End If

        If SetBrokerFees Then
            BPBrokerFees = BrokerFees
        Else
            BPBrokerFees = 0
        End If

        TaxesFeesUsage = BPTaxes + BPBrokerFees + ManufacturingFacilityUsage

        If ComponentManufacturingFacility.IncludeActivityUsage Then
            TaxesFeesUsage += ComponentFacilityUsage
        End If

        If CapitalComponentManufacturingFacility.IncludeActivityUsage Then
            TaxesFeesUsage += CapComponentFacilityUsage
        End If

        ' Totals
        TotalRawCost = RawMaterials.GetTotalMaterialsCost + TotalInventionCost + TaxesFeesUsage + AdditionalCosts
        TotalComponentCost = ComponentMaterials.GetTotalMaterialsCost + TotalInventionCost + TaxesFeesUsage + AdditionalCosts

        ' Profit market cost - total cost of mats and invention and fees
        TotalRawProfit = ItemMarketCost - TotalRawCost
        TotalComponentProfit = ItemMarketCost - TotalComponentCost

        If ItemMarketCost = 0 Then
            TotalRawProfitPercent = 0
            TotalComponentProfitPercent = 0
        Else
            TotalRawProfitPercent = 1 - (TotalRawCost / ItemMarketCost)
            TotalComponentProfitPercent = 1 - (TotalComponentCost / ItemMarketCost)
        End If

        ' Final Calculation
        ' ISK per Hour (divide total cost by production time in seconds for a isk per second calc, then multiply by 3600 for isk per hour)
        TotalIPHRaw = TotalRawProfit / TotalProductionTime * 3600 ' Build everything

        ' If we are doing build/buy then the total IPH will be the same as RAW since the lists are identical for what to buy 
        If BuildBuy Then
            TotalIPHComponent = TotalIPHRaw
        Else
            TotalIPHComponent = TotalComponentProfit / BPProductionTime * 3600 ' Buy all components, just production time of BP
        End If

    End Sub

    ' Returns the bonus for the team of the sent bonus
    Private Function GetTeamBonus(Team As IndustryTeam, BonusType As String) As Double
        Dim TotalTeamBonus As Double = 0 ' More than one team can affect the total
        Dim SQL As String
        Dim rsSearch As SQLite.SQLiteDataReader

        ' Normalize
        TotalTeamBonus = 1

        For i = 0 To Team.Bonuses.Count - 1
            If Team.Bonuses(i).BonusType = BonusType Then

                SQL = "SELECT 'X' FROM INDUSTRY_GROUP_SPECIALTIES "
                SQL = SQL & "WHERE SPECIALTY_GROUP_ID = " & Team.Bonuses(i).BonusSpecialtyGroupID & " "
                SQL = SQL & "AND GROUP_ID = " & ItemGroupID

                DBCommand = New SQLiteCommand(SQL, DB)
                rsSearch = DBCommand.ExecuteReader

                If rsSearch.Read Then
                    ' Each bonus multiplies against the other
                    TotalTeamBonus = ((100 - Team.Bonuses(i).BonusValue) * TotalTeamBonus) / 100
                End If
            End If
        Next

        Return TotalTeamBonus

    End Function

    ' Calculates the total material muliplier for the blueprint based on the bp, facility and team bonuses
    Private Function SetBPMaterialModifier() As Double

        Dim TeamBonus As Double = GetTeamBonus(ManufacturingTeam, "ME")

        ' Material modifier is the BP ME, Facility, and team bonus - Facility is saved as a straight multiplier, the others need to be set
        Return TeamBonus * (1 - (iME / 100)) * ManufacturingFacility.MaterialMultiplier

    End Function

    ' Gets the ME/TE for the BP
    Public Sub GetMETEforBP(ByVal BlueprintID As Long, ByVal BPTech As Integer, ByRef RefME As Double, ByRef RefTE As Double, ByRef OwnedBP As Boolean)
        Dim SQL As String
        Dim readerLookup As SQLiteDataReader

        ' The user can't define an ME or TE for this blueprint, so just look it up
        SQL = "SELECT ME, TE, OWNED FROM OWNED_BLUEPRINTS WHERE USER_ID =" & BPCharacter.ID & " AND BLUEPRINT_ID =" & CStr(BlueprintID) & " AND OWNED <> 0 "
        DBCommand = New SQLiteCommand(SQL, DB)
        readerLookup = DBCommand.ExecuteReader

        If readerLookup.Read Then
            RefME = readerLookup.GetDouble(0)
            RefTE = readerLookup.GetDouble(1)
            ' Check if owned
            OwnedBP = CBool(readerLookup.GetInt64(2))
        Else
            ' T2
            If BPTech = BlueprintTechLevel.T2 Or BPTech = BlueprintTechLevel.T3 Then
                RefME = BaseT2T3ME
                RefTE = BaseT2T3TE
            Else
                RefME = UserSettings.DefaultBPME
                RefTE = UserSettings.DefaultBPTE
            End If
            OwnedBP = False
        End If

        readerLookup.Close()
        readerLookup = Nothing

    End Sub

    ' Calculates the total time muliplier for the blueprint based on the bp, facility, implants and team bonuses
    Private Function SetBPTimeModifier() As Double
        Dim Modifier As Double

        Dim TeamBonus As Double = GetTeamBonus(ManufacturingTeam, "TE")

        ' Time modifier is the BP ME, Facility, and team bonus - Facility is saved as a straight multiplier, the others need to be set, then do the skills
        Modifier = TeamBonus * (1 - (iTE / 100)) * ManufacturingFacility.TimeMultiplier * AIImplantValue * (1 - (IndustrySkill * 0.04)) * (1 - (AdvancedIndustrySkill * 0.03))

        Return Modifier

    End Function

    ' Returns T/F if the user has the required skills sent in when compared to character skills
    Private Function UserHasReqSkills(ByVal EVESkillList As EVESkillList, ByVal RequiredSkills As EVESkillList) As Boolean
        Dim i As Integer
        Dim SkillFound As Boolean = False
        Dim HasSkills As Boolean = False

        ' Compare the required invention skills from blueprint to user skills
        ' Start looping through the skills for the blueprint
        If RequiredSkills.NumSkills <> 0 Then
            For i = 0 To RequiredSkills.GetSkillList.Count - 1
                ' Check for the skill in the character skills for the appropriate level
                If EVESkillList.GetSkillLevel(RequiredSkills.GetSkillList(i).TypeID) <> 0 Then
                    SkillFound = True
                End If

                If SkillFound Then
                    If EVESkillList.GetSkillLevel(RequiredSkills.GetSkillList(i).TypeID) < RequiredSkills.GetSkillList(i).Level Then
                        ' They have this skill but it isn't the correct level
                        ' They don't have this, so just leave
                        Return False
                    End If
                Else
                    ' Skill not found, just leave
                    Return False
                End If

                SkillFound = False
            Next
        Else
            ' If the Req Skills is empty, then return true since there are no required skills
            Return True
        End If

        Return True

    End Function

    ' Sets the fees for setting up a job to build this item
    Private Sub SetManufacturingCostsAndFees()
        Dim FacilityUsage As Double = 0

        If IncludeManufacturingUsage Then
            ' baseJobCost = Sum(eachmaterialquantity * adjustedPrice) - set in build function
            ' jobFee = baseJobCost * systemCostIndex * runs
            JobFee = BaseJobCost * ManufacturingFacility.CostIndex * UserRuns

            ' teamCost = jobFee * teamCostModifier
            ManufacturingTeamFee = JobFee * ManufacturingTeam.CostModifier

            ' facilityUsage = (jobFee + teamCost) * taxRate
            FacilityUsage = (JobFee + ManufacturingTeamFee) * ManufacturingFacility.TaxRate

            ' totalInstallationCost = jobFee + teamCost + facilityTax
            ManufacturingFacilityUsage = JobFee + ManufacturingTeamFee + FacilityUsage
        Else
            ManufacturingFacilityUsage = 0
        End If

    End Sub

    ' Totals up all the skill levels for advanced manufacturing skills for TE reduction bonus
    Private Function SetAdvManufacturingSkillLevels(BuildSkills As EVESkillList) As Double
        Dim BonusSum As Double = 1

        'These skills for T2 now reduce TE by 1% per level for the manufacturing job with Pheobe
        '3398	Advanced Large Ship Construction
        '3397	Advanced Medium Ship Construction
        '3395	Advanced Small Ship Construction
        '11444	Amarr Starship Engineering
        '11454	Caldari Starship Engineering
        '11448  Electromagnetic Physics
        '11453  Electronic Engineering
        '11450	Gallente Starship Engineering
        '11446  Graviton Physics
        '11433	High Energy Physics
        '11443  Hydromagnetic Physics
        '11447  Laser Physics
        '11452  Mechanical Engineering
        '11445	Minmatar Starship Engineering
        '11529  Molecular Engineering
        '11451  Nuclear Physics
        '11441  Plasma Physics
        '11455  Quantum Physics
        '11449  Rocket Science
        ' Read through all the skills and if the ID is in the list, then sum up the levels
        For i = 0 To BuildSkills.NumSkills - 1
            Select Case BuildSkills.GetSkillList(i).TypeID
                Case 3398, 3397, 3395, 11444, 11454, 11448, 11453, 11450, 11446, 11433, 11443, 11447, 11452, 11445, 11529, 11451, 11441, 11455, 11449
                    ' each skill is mulitplied by 1 then normalized percentage, then mulitiplied to any others to get the bonus
                    BonusSum = BonusSum * (1 - 0.01 * BPCharacter.Skills.GetSkillLevel(BuildSkills.GetSkillList(i).TypeID))
            End Select
        Next

        Return BonusSum

    End Function

    ' Returns a string that states what type of T1 BPC the sent T2 BPID is for invention purposes. Also returns the Max Runs and name of the BPC
    Public Function GetT1BPCType(ByVal BPID As Long, ByRef MaxBPCRuns As Integer, ByRef BPName As String) As String
        Dim SQL As String
        Dim readerBP As SQLiteDataReader
        Dim T1MatGroupName As String
        Dim T1MatCategoryName As String

        SQL = "SELECT ITEM_CATEGORY, ITEM_GROUP, MAX_PRODUCTION_LIMIT, BLUEPRINT_NAME FROM ALL_BLUEPRINTS "
        SQL = SQL & "WHERE BLUEPRINT_ID IN (SELECT blueprintTypeID FROM INDUSTRY_ACTIVITY_PRODUCTS WHERE productTypeID = " & BPID & " AND activityID = 8)"
        DBCommand = New SQLiteCommand(SQL, DB)
        readerBP = DBCommand.ExecuteReader

        If readerBP.Read() Then
            T1MatCategoryName = readerBP.GetString(0)
            T1MatGroupName = readerBP.GetString(1)
            MaxBPCRuns = readerBP.GetInt32(2)
            BPName = readerBP.GetString(3)

            Return T1MatGroupName
        Else
            MaxBPCRuns = 0
            BPName = ""
            Return ""
        End If

    End Function

#Region "Invention/RE Functions"

    ' Sets the invention cost and materials for this BP
    Private Sub InventREBlueprint(Optional ByVal UseTypical As Boolean = False)
        Dim AvgRunsforSuccess As Double
        Dim readerBP As SQLiteDataReader
        Dim readerCost As SQLiteDataReader
        Dim MatCost As Double = 0

        Dim SQL As String
        Dim InventionMat As Material = Nothing
        Dim CopyMat As Material = Nothing
        Dim SingleInventionMats As New Materials
        Dim SingleCopyMats As New Materials
        Dim NumInventionSessions As Long = 0 ' How many sessions (runs per set of lines) ie. 10 runs 5 lines = 2 sessions

        ' First select the datacores needed
        SQL = "SELECT MATERIAL_ID, MATERIAL, MATERIAL_CATEGORY, QUANTITY, MATERIAL_VOLUME, PRICE, MATERIAL_GROUP "
        SQL = SQL & "FROM ALL_BLUEPRINT_MATERIALS LEFT OUTER JOIN ITEM_PRICES ON ALL_BLUEPRINT_MATERIALS.MATERIAL_ID = ITEM_PRICES.ITEM_ID "
        SQL = SQL & "WHERE BLUEPRINT_ID = " & InventionT3BPCTypeID & " AND PRODUCT_ID = " & BlueprintID & " "
        SQL = SQL & "AND ACTIVITY = 8 AND MATERIAL_CATEGORY <> 'Skill'"

        DBCommand = New SQLiteCommand(SQL, DB)
        readerBP = DBCommand.ExecuteReader()

        ' Get all the Datacores
        While readerBP.Read
            If readerBP.GetString(6) = "Datacores" Then
                ' Add this to the invention materials - add price for data cores, 0 cost for interfaces
                InventionMat = New Material(readerBP.GetInt64(0), readerBP.GetString(1), readerBP.GetString(2), _
                                           readerBP.GetInt64(3), readerBP.GetDouble(4), If(readerBP.IsDBNull(5), 0, readerBP.GetDouble(5)), "")
                SingleInventionMats.InsertMaterial(InventionMat)
            End If
        End While

        readerBP.Close()
        readerBP = Nothing
        DBCommand = Nothing

        ' If they selected a decryptor, add that cost for one invention run
        If InventionDecryptor.Name <> None Then
            Dim DecryptorCost As Double

            ' Look up the cost for the material
            SQL = "SELECT PRICE FROM ITEM_PRICES WHERE ITEM_ID =" & InventionDecryptor.TypeID

            DBCommand = New SQLiteCommand(SQL, DB)
            readerCost = DBCommand.ExecuteReader

            If readerCost.Read Then
                DecryptorCost = readerCost.GetDouble(0)
            Else
                DecryptorCost = 0
            End If

            readerCost.Close()
            readerCost = Nothing
            DBCommand = Nothing

            InventionMat = New Material(InventionDecryptor.TypeID, InventionDecryptor.Name, "Decryptors", 1, 0.1, DecryptorCost, "")
            SingleInventionMats.InsertMaterial(InventionMat)

        End If

        ' If this is T3, get the relic and add it to the list of invention materials
        If TechLevel = BlueprintTechLevel.T3 Then
            ' Look up the cost for the material
            SQL = "SELECT PRICE, ITEM_NAME FROM ITEM_PRICES WHERE ITEM_ID =" & InventionT3BPCTypeID

            DBCommand = New SQLiteCommand(SQL, DB)
            readerCost = DBCommand.ExecuteReader

            If readerCost.Read Then
                InventionMat = New Material(InventionT3BPCTypeID, readerCost.GetString(1), "Ancient Relics", 1, 100, readerCost.GetDouble(0), "")
                SingleInventionMats.InsertMaterial(InventionMat)
            End If

            readerCost.Close()
            readerCost = Nothing
            DBCommand = Nothing

        End If

        ' Get and set the invention chance
        InventionChance = SetInventionChance(UseTypical)

        ' Use the max runs for the T2 item and this should be the invented runs for one bpc - TO DO check industry_products for this value as quantity
        If TechLevel = BlueprintTechLevel.T2 Then
            SingleInventedBPCRuns = MaxProductionLimit + InventionDecryptor.RunMod
        Else
            SQL = "SELECT typeName FROM INVENTORY_TYPES WHERE typeID = " & CStr(InventionT3BPCTypeID)

            DBCommand = New SQLiteCommand(SQL, DB)
            readerBP = DBCommand.ExecuteReader()

            ' Base it off of the relic type - need to look it up based on the TypeID
            ' TO DO - use industry products to get the quantity for the runs on t3 - make new function
            If readerBP.Read Then
                ' Set the name
                Relic = readerBP.GetString(0)
                If readerBP.GetString(0).Contains(IntactRelic) Then
                    MaxProductionLimit = 20
                ElseIf readerBP.GetString(0).Contains(MalfunctioningRelic) Then
                    MaxProductionLimit = 10
                ElseIf readerBP.GetString(0).Contains(WreckedRelic) Then
                    MaxProductionLimit = 3
                Else
                    MaxProductionLimit = 3
                End If
            Else
                MaxProductionLimit = 3
                Relic = WreckedRelic
            End If

            ' Set the final runs for one bp
            SingleInventedBPCRuns = MaxProductionLimit + InventionDecryptor.RunMod
        End If

        ' Averages and final cost per run
        AvgRunsforSuccess = 1 / InventionChance

        ' Set how many total invention runs we will need to do - take the number of bpc's we'll need and multiply by how many runs for a success - round up
        NumInventionJobs = CInt(Math.Ceiling(AvgRunsforSuccess * Math.Ceiling(UserRuns / SingleInventedBPCRuns)))

        ' Now set the total runs we will get from all jobs
        TotalInventedRuns = CInt(Math.Ceiling(UserRuns / SingleInventedBPCRuns) * SingleInventedBPCRuns)

        ' Find the number of invention sessions we'll need to invent the number of runs for this item. This will be used in the copy and invention times
        ' Basically, the number avg number of runs for success times the total runs wanted is the total invention runs needed for single runs. Divide this
        ' by the invented runs, then divide that by how many laboratory lines we are using.  Need to round up each time
        ' Ex. avgruns = 2, user runs = 100, inventedruns = 10, lines = 10 => 200/10 = 20/10 = 2 invention sessions to get enough bps to make 100 runs.
        NumInventionSessions = CLng(Math.Ceiling(NumInventionJobs / NumberofLaboratoryLines))

        If IncludeCopyTime And TechLevel <> BlueprintTechLevel.T3 Then
            ' Set the total copy time based on the number of invention sessions we need, divided by the lab lines they have
            CopyTime = GetCopyTime(NumInventionJobs) * Math.Ceiling(NumInventionSessions / NumberofLaboratoryLines)
        Else
            CopyTime = 0 ' No copies for T3
        End If

        If IncludeCopyCosts And TechLevel <> BlueprintTechLevel.T3 Then
            ' Get the copy materials and update
            SQL = "SELECT MATERIAL_ID, MATERIAL, MATERIAL_CATEGORY, QUANTITY, MATERIAL_VOLUME, PRICE, MATERIAL_GROUP "
            SQL = SQL & "FROM ALL_BLUEPRINT_MATERIALS LEFT OUTER JOIN ITEM_PRICES ON ALL_BLUEPRINT_MATERIALS.MATERIAL_ID = ITEM_PRICES.ITEM_ID "
            SQL = SQL & "WHERE BLUEPRINT_ID = " & InventionT3BPCTypeID & " AND PRODUCT_ID = " & InventionT3BPCTypeID & " "
            SQL = SQL & "AND ACTIVITY = 5 AND MATERIAL_CATEGORY <> 'Skill'"

            DBCommand = New SQLiteCommand(SQL, DB)
            readerBP = DBCommand.ExecuteReader()

            ' Get all the mats and add
            While readerBP.Read
                ' Add this to the copy materials 
                CopyMat = New Material(readerBP.GetInt64(0), readerBP.GetString(1), readerBP.GetString(2), _
                                            readerBP.GetInt64(3), readerBP.GetDouble(4), If(readerBP.IsDBNull(5), 0, readerBP.GetDouble(5)), "")
                SingleCopyMats.InsertMaterial(CopyMat)
            End While

            readerBP.Close()
            readerBP = Nothing
            DBCommand = Nothing

            If Not IsNothing(SingleCopyMats.GetMaterialList) Then
                ' Update the copy mats to reflect the number of copy runs we will do and save into the final list
                For i = 0 To SingleCopyMats.GetMaterialList.Count - 1
                    SingleCopyMats.GetMaterialList(i).SetQuantity(SingleCopyMats.GetMaterialList(i).GetQuantity * NumInventionJobs)
                Next

                ' Now insert all the materials in a new list to get the correct cost (kind of a hack, need a better process - no automatic way to update the total price in a material list)
                For i = 0 To SingleCopyMats.GetMaterialList.Count - 1
                    CopyMaterials.InsertMaterial(SingleCopyMats.GetMaterialList(i))
                Next
            End If

            ' Finally set the cost
            CopyCost = CopyMaterials.GetTotalMaterialsCost
        Else
            CopyCost = 0 ' No copies for T3
        End If

        If IncludeCopyUsage And TechLevel <> BlueprintTechLevel.T3 Then
            ' Set the copy cost based on the number of copies we'll need
            CopyUsage = GetCopyUsage(NumInventionJobs)
            InventionMaterials.InsertMaterial(New Material(0, "Copy Usage", "Usage", 1, 0, CopyUsage, ""))
        Else
            CopyUsage = 0 ' No copies for T3
        End If

        ' Set invention time
        If IncludeInventionTime Then
            InventionTime = GetInventionTime() * Math.Ceiling(NumInventionSessions / NumberofLaboratoryLines)
        Else
            InventionTime = 0
        End If

        ' Set invention usage
        If IncludeInventionUsage Then
            ' Set the usage for these invention jobs
            InventionUsage = GetInventionUsage(NumInventionJobs)
            ' Add the usage
            InventionMaterials.InsertMaterial(New Material(0, "Invention Usage", "Usage", 1, 0, InventionUsage, ""))
        Else
            InventionUsage = 0
        End If

        ' Finally set the total cost
        If IncludeInventionCosts Then
            ' Update the invention mats to reflect the number of invention runs we will do and save into the final list
            For i = 0 To SingleInventionMats.GetMaterialList.Count - 1
                SingleInventionMats.GetMaterialList(i).SetQuantity(SingleInventionMats.GetMaterialList(i).GetQuantity * NumInventionJobs)
            Next

            ' Now insert all the materials in a new list to get the correct cost (kind of a hack, need a better process - no automatic way to update the total price in a material list)
            For i = 0 To SingleInventionMats.GetMaterialList.Count - 1
                InventionMaterials.InsertMaterial(SingleInventionMats.GetMaterialList(i))
            Next

            ' Add the type of T1 BPC we will need to the invention materials
            Dim BPCName As String = ""
            Dim MaxRuns As Integer = 0
            Dim BPCGroup = GetT1BPCType(BlueprintID, MaxRuns, BPCName) ' Returned by reference

            If TechLevel = BlueprintTechLevel.T2 Then
                ' Add the BPC's for T2
                InventionMaterials.InsertMaterial(New Material(InventionT3BPCTypeID, BPCName & " (" & CStr(1) & " Runs)", BPCGroup, NumInventionJobs, 0, 0, ""))
            End If

            InventionCosts = InventionMaterials.GetTotalMaterialsCost

            ' Set the total cost for the sent runs by totaling all to get success needed, then dividing it by the runs invented
            ' (some bps have more runs than 1 - i.e. Drones = 10) to get the cost per run, then multiply that cost by the number of runs - Later add copy costs here
            TotalInventionCost = (InventionCosts + InventionUsage + CopyCost + CopyUsage) / TotalInventedRuns * UserRuns
        Else
            TotalInventionCost = InventionUsage + CopyUsage
        End If

    End Sub

    ' Sets the invention chance of the blueprint if set
    Private Function SetInventionChance(ByVal UseTypical As Boolean) As Double
        Dim BaseInventionChance As Double

        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim readerLookup As SQLiteDataReader
        Dim SQL As String

        Dim EncryptionSkillLevel As Integer
        Dim DatacoreSkillLevels(1) As Integer

        ' Get the base invention chance from the activities for the T1 BPO
        SQL = "SELECT probability FROM INDUSTRY_ACTIVITY_PRODUCTS WHERE blueprintTypeID = " & InventionT3BPCTypeID
        SQL = SQL & " AND activityID = 8 AND productTypeID = " & BlueprintID

        DBCommand = New SQLiteCommand(SQL, DB)
        readerLookup = DBCommand.ExecuteReader()
        readerLookup.Read()

        If readerLookup.HasRows Then
            BaseInventionChance = readerLookup.GetDouble(0)
        Else
            BaseInventionChance = 0
        End If

        ' Pull out the invention skills
        For i = 0 To ReqInventionSkills.GetSkillList.Count - 1
            SQL = "SELECT typeName FROM INVENTORY_TYPES WHERE typeID =" & ReqInventionSkills.GetSkillList(i).TypeID

            DBCommand = New SQLiteCommand(SQL, DB)
            readerLookup = DBCommand.ExecuteReader()
            readerLookup.Read()

            ' Look up the level of the character's skills
            If CStr(readerLookup(0).ToString).Contains("Encryption") Then
                EncryptionSkillLevel = BPCharacter.Skills.GetSkillLevel(ReqInventionSkills.GetSkillList(i).TypeID)
            Else ' A datacore skill
                DatacoreSkillLevels(j) = BPCharacter.Skills.GetSkillLevel(ReqInventionSkills.GetSkillList(i).TypeID)
                j = j + 1
            End If

            readerLookup.Close()

            readerLookup = Nothing
            DBCommand = Nothing
        Next

        If Not UseTypical Then
            ' BaseChance * [ 1 + (((ScienceSkill1 + ScienceSkill2) / 30) + (EncryptionSkill / 40 ))]
            InventionChance = BaseInventionChance * (1 + (((DatacoreSkillLevels(0) + DatacoreSkillLevels(1)) / 30) + (EncryptionSkillLevel / 40))) * InventionDecryptor.ProductionMod
            '(1 + (0.01 * EncryptionSkillLevel) + (0.02 * (DatacoreSkillLevels(0) + DatacoreSkillLevels(1)))) * InventionDecryptor.ProductionMod
        Else
            ' Just use typical invention costs - ie, all level 4 skills
            InventionChance = BaseInventionChance * (1 + (((4 + 4) / 30) + (4 / 40))) * InventionDecryptor.ProductionMod
        End If

        Return InventionChance

    End Function

    ' Sets the cost of doing the number of invention jobs sent
    Private Function GetInventionUsage(InventionJobs As Double) As Double
        'jobFee = baseJobCost * systemCostIndex * 0.02
        Return BaseJobCost * InventionFacility.CostIndex * 0.02 * InventionJobs
    End Function

    ' Gets the invention time for the sent BP and returns it in seconds
    Private Function GetInventionTime() As Double
        Dim SQL As String
        Dim readerLookup As SQLiteDataReader
        Dim TempTime As Double

        ' Look up the blueprint name from the sent blueprint ID
        If TechLevel = BlueprintTechLevel.T3 Then
            ' Hardcode this to 3600 for now. Later need to figure out the logic for looking it up, since the "T1" BP is a relic, we can't do anything but invent it and don't want to include it in the all_blueprints table since we only use that to select what to build
            TempTime = 3600
        Else
            ' Look it up
            SQL = "SELECT BASE_INVENTION_TIME FROM ALL_BLUEPRINTS WHERE BLUEPRINT_ID =" & InventionT3BPCTypeID

            DBCommand = New SQLiteCommand(SQL, DB)
            readerLookup = DBCommand.ExecuteReader

            ' inventionTime = baseInventionTime * facilityModifier * 3% of AI level * implant (doesn't work) * team if set
            If readerLookup.Read Then
                TempTime = CDbl(readerLookup.GetInt64(0)) * InventionFacility.TimeMultiplier * (1 - 0.03 * AdvancedIndustrySkill) * GetTeamBonus(InventionTeam, "TE") * 1 '* InventionImplantValue
            Else
                TempTime = 0
            End If

            readerLookup.Close()
        End If

        Return TempTime

    End Function

    ' Sets and returns the copy cost for the number of copies sent
    Private Function GetCopyUsage(NumberofCopies As Integer) As Double
        ' jobFee = baseJobCost * systemCostIndex * 0.02 * runs * runsPerCopy (just use the total number of copies here)
        Return BaseJobCost * CopyFacility.CostIndex * 0.02 * NumberofCopies
    End Function

    ' Returns the copy time for a single T1 copy in seconds to copy the sent number of runs
    Private Function GetCopyTime(UserCopyRuns As Integer) As Double
        Dim SQL As String
        Dim readerLookup As SQLiteDataReader
        Dim TempTime As Decimal

        ' Look up the blueprint name from the sent blueprint ID 
        SQL = "SELECT BASE_COPY_TIME FROM ALL_BLUEPRINTS WHERE BLUEPRINT_ID =" & InventionT3BPCTypeID

        DBCommand = New SQLiteCommand(SQL, DB)
        readerLookup = DBCommand.ExecuteReader

        ' copyTime = BaseCopyTime * runs * runsperBP * (1 - (0.05 * science)) * facility copyslotmod * (1-implant) * (1-Team value)
        If readerLookup.Read Then ' 3402 is science skill - just use the number of runs we need to make
            TempTime = CDec((readerLookup.GetInt64(0)) * UserCopyRuns * (1 - (0.05 * BPCharacter.Skills.GetSkillLevel(3402))) * CopyFacility.TimeMultiplier * (1 - UserSettings.CopyImplantValue) * GetTeamBonus(CopyTeam, "TE"))
        Else
            TempTime = 0
        End If

        readerLookup.Close()

        Return TempTime

    End Function

    ' Sets the skills for inventing this blueprint (T2 or T3 blueprint types)
    Private Sub SetInventionSkills()
        Dim SQL As String = ""
        Dim readerItems As SQLiteDataReader

        ' Tech 2 items are invented from T1 blueprint copies, so take the T1 component ID and look it up for
        ' the invention skill requirements (for datacores and data interface)
        SQL = "SELECT MATERIAL_ID, QUANTITY FROM ALL_BLUEPRINT_MATERIALS "
        SQL = SQL & "WHERE BLUEPRINT_ID = " & InventionT3BPCTypeID & " "
        SQL = SQL & "AND ACTIVITY = 8 AND MATERIAL_CATEGORY = 'Skill'"

        DBCommand = New SQLiteCommand(SQL, DB)
        readerItems = DBCommand.ExecuteReader

        ' Just add all the skills and levels
        While readerItems.Read
            ReqInventionSkills.InsertSkill(readerItems.GetInt64(0), readerItems.GetInt32(1), 0, False, 0, "", Nothing, True)
        End While

        readerItems.Close()
        readerItems = Nothing
        DBCommand = Nothing

    End Sub

    ' Sets the skills for copying this blueprint (T2 or T3 blueprint types)
    Private Sub SetCopySkills()
        Dim SQL As String = ""
        Dim readerItems As SQLiteDataReader

        ' Tech 2 items are invented from T1 blueprint copies, so take the T1 component ID and look it up for
        ' the invention skill requirements (for datacores and data interface)
        SQL = "SELECT MATERIAL_ID, QUANTITY FROM ALL_BLUEPRINT_MATERIALS "
        SQL = SQL & "WHERE BLUEPRINT_ID = " & InventionT3BPCTypeID & " "
        SQL = SQL & "AND ACTIVITY = 5 AND MATERIAL_CATEGORY = 'Skill'"

        DBCommand = New SQLiteCommand(SQL, DB)
        readerItems = DBCommand.ExecuteReader

        ' Just add all the skills and levels
        While readerItems.Read
            ReqCopySkills.InsertSkill(readerItems.GetInt64(0), readerItems.GetInt32(1), 0, False, 0, "", Nothing, True)
        End While

        readerItems.Close()
        readerItems = Nothing
        DBCommand = Nothing

    End Sub

#End Region

#Region "Get Functions"

#Region "Invention Gets"

    ' Returns the copy time for a T1 copy used to make a T2
    Public Function GetBPCCopyTime() As Double
        Return CopyTime
    End Function

    ' Returns the total usage cost to make the copy
    Public Function GetBPCCopyUsage() As Double
        Return CopyUsage
    End Function

    ' Returns the total cost of materials for the copy - TO DO need to add this, zero for now
    Public Function GetBPCCopyCost() As Double
        Return CopyCost ' Only return the cost of the materials
    End Function

    ' Returns the list of materials used to make a copy for this BP
    Public Function GetBPCCopyMaterials() As Materials
        Return CopyMaterials
    End Function

    ' Returns the invention time in friendly format it took to make a T2/T3 BPC 
    Public Function GetBPInventionTime() As Double
        Return InventionTime
    End Function

    ' Gets the invention usage fees for installing this invention job for this BP
    Public Function GetBPInventionUsage() As Double
        Return InventionUsage
    End Function

    ' Gets the total Invention Cost of this Blueprint if it can be invented
    Public Function GetBPInventionCost() As Double
        Return InventionCosts ' Only return the cost of the materials
    End Function

    ' Gets the total invention costs - usage, costs of copy and invention
    Public Function GetBPTotalInventionCosts() As Double
        Return TotalInventionCost
    End Function

    ' Returns the list of invention materials used
    Public Function GetInventionMaterials() As Materials
        Return InventionMaterials
    End Function

    ' Returns the decryptor used in this BP
    Public Function GetDecryptor() As Decryptor
        Return InventionDecryptor
    End Function

    ' Returns the Relic name used in this BP
    Public Function GetRelic() As String
        Return Relic
    End Function

    ' Gets the Invention Chance this blueprint is invented if it can be
    Public Function GetInventionChance() As Double
        Return InventionChance
    End Function

    ' Gets the total invented runs for each BPC
    Public Function GetInventedRuns() As Integer
        Return SingleInventedBPCRuns
    End Function

    ' Returns the number of jobs we'll have to do
    Public Function GetInventionJobs() As Integer
        Return NumInventionJobs
    End Function

    ' Returns the Invention facility we used
    Public Function GetInventionFacility() As IndustryFacility
        Return InventionFacility
    End Function

    ' Returns the Copy facility we used
    Public Function GetCopyFacility() As IndustryFacility
        Return CopyFacility
    End Function

#End Region

    ' Returns the total usage for all facilities that we used to build something (not invention and copying)
    Public Function GetTotalBuildFacilityUsage() As Double
        Return ManufacturingFacilityUsage + ComponentFacilityUsage + CapComponentFacilityUsage
    End Function

    ' Returns the manufacturing facility used
    Public Function GetManufacturingFacility() As IndustryFacility
        Return ManufacturingFacility
    End Function

    ' Returns the component manufacturing facility used
    Public Function GetComponentManufacturingFacility() As IndustryFacility
        Return ComponentManufacturingFacility
    End Function

    ' Returns the capital component manufacturing facility used
    Public Function GetCapitalComponentManufacturingFacility() As IndustryFacility
        Return CapitalComponentManufacturingFacility
    End Function

    ' Returns the base job cost for this blueprint
    Public Function GetBaseJobCost() As Double
        Return BaseJobCost
    End Function

    ' Returns the base team cost for this blueprint
    Public Function GetManufacturingTeamFee() As Double
        Return ManufacturingTeamFee
    End Function

    ' Returns the team fee for component team
    Public Function GetComponentTeamFee() As Double
        Return ComponentTeamFee
    End Function

    ' Returns the Job fee based on the system index
    Public Function GetJobFee() As Double
        Return JobFee
    End Function

    ' Returns the cost of setting up a job to build this item
    Public Function GetManufacturingFacilityUsage() As Double
        Return ManufacturingFacilityUsage
    End Function

    ' Returns the base facility tax/fee for this blueprints components
    Public Function GetComponentFacilityUsage() As Double
        Return ComponentFacilityUsage
    End Function

    ' Returns the base facility tax/fee for this blueprint's cap components
    Public Function GetCapComponentFacilityUsage() As Double
        Return CapComponentFacilityUsage
    End Function

    ' Returns the max production limit for this blueprint
    Public Function GetMaxProductionLimit() As Long

        If TechLevel = 1 Then
            Return MaxProductionLimit
        ElseIf TechLevel = 2 Then
            If TotalInventedRuns = 0 Then
                Return MaxProductionLimit
            Else
                Return TotalInventedRuns
            End If
        Else
            Return MaxProductionLimit
        End If

    End Function

    ' Returns the Tech Level of the blueprint
    Public Function GetTechLevel() As Integer
        Return TechLevel
    End Function

    ' Returns the Runs that were sent to this blueprint
    Public Function GetUserRuns() As Long
        Return UserRuns
    End Function

    ' Returns the item type of the blueprint, which is really the Tech that I set instead of what is in the DB I.e. 'Augmented' drones show as T2 but act more like faction even though the BP's need T2 skills - however, they can't be invented anymore
    Public Function GetItemType() As Integer
        Return ItemType
    End Function

    ' Returns the Item ID made from this blueprint
    Public Function GetItemID() As Long
        Return ItemID
    End Function

    ' Returns the sum of taxes for setting up a sell order for this BP item
    Public Function GetBPTaxes() As Double
        Return BPTaxes
    End Function

    ' Returns the total broker fees for 
    Public Function GetBPBrokerFees() As Double
        Return BPBrokerFees
    End Function

    ' Returns the total units this blueprint muliplied by runs, will create
    Public Function GetTotalUnits() As Long
        Return PortionSize * UserRuns
    End Function

    ' Returns the production time as a double for just the blueprint
    Public Function GetProductionTime() As Double
        Return BPProductionTime
    End Function

    ' Returns the production time as a double for all components
    Public Function GetTotalProductionTime() As Double
        Return TotalProductionTime
    End Function

    ' Returns the Race ID of the item built by this BP
    Public Function GetRaceID() As Integer
        Return BlueprintRace
    End Function

    ' Returns the category for the item this BP builds
    Public Function GetItemCategory() As String
        Return ItemCategory
    End Function

    ' Returns the category id for the item this BP builds
    Public Function GetItemCategoryID() As Long
        Return ItemCategoryID
    End Function

    ' Function returns the array of the required character skills for building this blueprint
    Public Function GetReqBPSkills() As EVESkillList
        Return ReqBuildSkills
    End Function

    ' Returns the total cost of the blueprint using raw materials
    Public Function GetTotalRawCost() As Double
        Return TotalRawCost
    End Function

    ' Returns the total cost of the blueprint using components
    Public Function GetTotalComponentCost() As Double
        Return TotalComponentCost
    End Function

    ' Returns the total profit for the blueprint using raw materials
    Public Function GetTotalRawProfit() As Double
        Return TotalRawProfit
    End Function

    ' Returns the total profit for the blueprint using components
    Public Function GetTotalComponentProfit() As Double
        Return TotalComponentProfit
    End Function

    ' Returns the total profitas a percent for the blueprint using raw materials
    Public Function GetTotalRawProfitPercent() As Double
        Return TotalRawProfitPercent
    End Function

    ' Returns the total profit as a percent for the blueprint using components
    Public Function GetTotalComponentProfitPercent() As Double
        Return TotalComponentProfitPercent
    End Function

    ' Returns the Isk per hour using Raw mats
    Public Function GetTotalIskperHourRaw() As Double
        Return TotalIPHRaw
    End Function

    ' Returns the Isk per hour using components
    Public Function GetTotalIskperHourComponents() As Double
        Return TotalIPHComponent
    End Function

    ' Returns whether this BP had buildable components or not
    Public Function HasComponents() As Boolean
        Return HasBuildableComponents
    End Function

    ' Gets the Item Group of the Blueprint
    Public Function GetItemGroup() As String
        Return ItemGroup
    End Function

    ' Returns the group of blueprint
    Public Function GetBPGroup() As String
        Return BlueprintGroup
    End Function

    ' Gets the Item's GroupID of the blueprint
    Public Function GetItemGroupID() As Long
        Return ItemGroupID
    End Function

    ' Gets the built item's volume
    Public Function GetItemVolume() As Double
        Return ItemVolume
    End Function

    ' Gets the total volume of the items built
    Public Function GetTotalItemVolume() As Double
        Return ItemVolume * UserRuns
    End Function

    ' Returns the component lists used to build this item, with materials
    Public Function GetBPComponentsList() As BuiltItemList
        Return CType(BuiltComponentList.Clone, BuiltItemList)
    End Function

    ' Returns the required skills to build all the components for this bp
    Public Function GetReqComponentSkills() As EVESkillList
        Return ReqBuildComponentSkills
    End Function

    ' Function returns the array of all the character skills to invent this blueprint
    Public Function GetReqInventionSkills() As EVESkillList
        Return ReqInventionSkills
    End Function

    ' Function returns the array of all the character skills to copy this blueprint
    Public Function GetReqCopySkills() As EVESkillList
        Return ReqCopySkills
    End Function

    ' Returns the total list of raw materials for the Blueprint
    Public Function GetRawMaterials() As Materials
        Return RawMaterials
    End Function

    ' Returns the Components and other mats for the Blueprint
    Public Function GetComponentMaterials() As Materials
        Return ComponentMaterials
    End Function

    ' Returns information on the item that this BP makes, For now, name, runs and the type id
    Public Function GetBPItemData() As Material
        Dim TempMat As Material

        ' Volume doesn't matter
        TempMat = New Material(ItemID, ItemName, ItemGroup, UserRuns, 0, ItemMarketCost, "")

        Return TempMat
    End Function

    ' Returns the TypeID of the BP
    Public Function GetBPTypeID() As Long
        Return BlueprintID
    End Function

    ' Returns the blueprint name
    Public Function GetBPName() As String
        Return BlueprintName
    End Function

    ' Returns the number of blueprints used
    Public Function GetNumBPs() As Integer
        Return NumberofBPs
    End Function

    ' Gets the market price of the produced item from this blueprint
    Public Function GetItemMarketPrice() As Double
        Return ItemMarketCost
    End Function

    ' Gets the raw build cost for one unit
    Public Function GetRawItemUnitPrice() As Double
        Return GetTotalRawCost() / PortionSize
    End Function

    ' Gets the component build cost for one unit
    Public Function GetComponentItemUnitPrice() As Double
        Return GetTotalComponentCost() / PortionSize
    End Function

    ' Returns T/F if the user for this blueprint can build  the blueprint
    Public Function UserCanBuildBlueprint() As Boolean
        Return CanBuildBP
    End Function

    ' Returns T/F if the user for this blueprint can build all components
    Public Function UserCanBuildAllComponents() As Boolean
        Return CanBuildAll
    End Function

    Public Function UserCanInventRE() As Boolean
        Return CanInventRE
    End Function

    ' Returns the ME of the blueprint
    Public Function GetME() As Double
        Return iME
    End Function

    ' Returns the TE of the blueprint
    Public Function GetTE() As Double
        Return iTE
    End Function

    ' Returns the additional costs the user sent in
    Public Function GetAdditionalCosts() As Double
        Return AdditionalCosts
    End Function

#End Region

End Class

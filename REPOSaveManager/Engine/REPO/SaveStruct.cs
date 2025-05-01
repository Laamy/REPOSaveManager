using Newtonsoft.Json;

namespace REPOSaveManager;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class DateAndTime
{
    public string __type
    {
        get; set;
    }
    public string value
    {
        get; set;
    }
}

public class DictionaryOfDictionaries
{
    public string __type
    {
        get; set;
    }
    public Value value
    {
        get; set;
    }
}

public class Item
{
    [JsonProperty("Item Cart Medium")] // converter i use doess this shiut i dont care about
    public int ItemCartMedium
    {
        get; set;
    }

    [JsonProperty("Item Cart Small")]
    public int ItemCartSmall
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery")]
    public int ItemDroneBattery
    {
        get; set;
    }

    [JsonProperty("Item Drone Feather")]
    public int ItemDroneFeather
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible")]
    public int ItemDroneIndestructible
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque")]
    public int ItemDroneTorque
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity")]
    public int ItemDroneZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Extraction Tracker")]
    public int ItemExtractionTracker
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped")]
    public int ItemGrenadeDuctTaped
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive")]
    public int ItemGrenadeExplosive
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human")]
    public int ItemGrenadeHuman
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave")]
    public int ItemGrenadeShockwave
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun")]
    public int ItemGrenadeStun
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun")]
    public int ItemGunHandgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Shotgun")]
    public int ItemGunShotgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq")]
    public int ItemGunTranq
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large")]
    public int ItemHealthPackLarge
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium")]
    public int ItemHealthPackMedium
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small")]
    public int ItemHealthPackSmall
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat")]
    public int ItemMeleeBaseballBat
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan")]
    public int ItemMeleeFryingPan
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer")]
    public int ItemMeleeInflatableHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sledge Hammer")]
    public int ItemMeleeSledgeHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sword")]
    public int ItemMeleeSword
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive")]
    public int ItemMineExplosive
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave")]
    public int ItemMineShockwave
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun")]
    public int ItemMineStun
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity")]
    public int ItemOrbZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal")]
    public int ItemPowerCrystal
    {
        get; set;
    }

    [JsonProperty("Item Rubber Duck")]
    public int ItemRubberDuck
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count")]
    public int ItemUpgradeMapPlayerCount
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy")]
    public int ItemUpgradePlayerEnergy
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump")]
    public int ItemUpgradePlayerExtraJump
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range")]
    public int ItemUpgradePlayerGrabRange
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength")]
    public int ItemUpgradePlayerGrabStrength
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health")]
    public int ItemUpgradePlayerHealth
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed")]
    public int ItemUpgradePlayerSprintSpeed
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch")]
    public int ItemUpgradePlayerTumbleLaunch
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker")]
    public int ItemValuableTracker
    {
        get; set;
    }

    [JsonProperty("Item Cart Medium/1")]
    public int ItemCartMedium1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human/1")]
    public int ItemGrenadeHuman1
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/1")]
    public int ItemPowerCrystal1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/1")]
    public int ItemUpgradePlayerSprintSpeed1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump/1")]
    public int ItemUpgradePlayerExtraJump1
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/2")]
    public int ItemPowerCrystal2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/1")]
    public int ItemUpgradePlayerGrabStrength1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave/1")]
    public int ItemGrenadeShockwave1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/1")]
    public int ItemUpgradePlayerHealth1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave/2")]
    public int ItemGrenadeShockwave2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range/1")]
    public int ItemUpgradePlayerGrabRange1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count/1")]
    public int ItemUpgradeMapPlayerCount1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/1")]
    public int ItemUpgradePlayerEnergy1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium/1")]
    public int ItemHealthPackMedium1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium/2")]
    public int ItemHealthPackMedium2
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque/1")]
    public int ItemDroneTorque1
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery/1")]
    public int ItemDroneBattery1
    {
        get; set;
    }

    [JsonProperty("Item Cart Small/1")]
    public int ItemCartSmall1
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer/1")]
    public int ItemMeleeInflatableHammer1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large/1")]
    public int ItemHealthPackLarge1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large/2")]
    public int ItemHealthPackLarge2
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave/3")]
    public int ItemGrenadeShockwave3
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small/2")]
    public int ItemHealthPackSmall2
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/3")]
    public int ItemPowerCrystal3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/2")]
    public int ItemUpgradePlayerEnergy2
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan/1")]
    public int ItemMeleeFryingPan1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/2")]
    public int ItemUpgradePlayerSprintSpeed2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/2")]
    public int ItemUpgradePlayerHealth2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/2")]
    public int ItemUpgradePlayerGrabStrength2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range/2")]
    public int ItemUpgradePlayerGrabRange2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump/2")]
    public int ItemUpgradePlayerExtraJump2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/3")]
    public int ItemUpgradePlayerEnergy3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/4")]
    public int ItemUpgradePlayerEnergy4
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small/3")]
    public int ItemHealthPackSmall3
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun/1")]
    public int ItemMineStun1
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun/2")]
    public int ItemMineStun2
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive/1")]
    public int ItemGrenadeExplosive1
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity/1")]
    public int ItemDroneZeroGravity1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun/1")]
    public int ItemGrenadeStun1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/3")]
    public int ItemUpgradePlayerSprintSpeed3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range/3")]
    public int ItemUpgradePlayerGrabRange3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/3")]
    public int ItemUpgradePlayerGrabStrength3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/5")]
    public int ItemUpgradePlayerEnergy5
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/6")]
    public int ItemUpgradePlayerEnergy6
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/4")]
    public int ItemUpgradePlayerSprintSpeed4
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/3")]
    public int ItemUpgradePlayerHealth3
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped/1")]
    public int ItemGrenadeDuctTaped1
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity/1")]
    public int ItemOrbZeroGravity1
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive/1")]
    public int ItemMineExplosive1
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun/1")]
    public int ItemGunHandgun1
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat/1")]
    public int ItemMeleeBaseballBat1
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive/2")]
    public int ItemMineExplosive2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch/1")]
    public int ItemUpgradePlayerTumbleLaunch1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/4")]
    public int ItemUpgradePlayerGrabStrength4
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/7")]
    public int ItemUpgradePlayerEnergy7
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun/2")]
    public int ItemGunHandgun2
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave/1")]
    public int ItemMineShockwave1
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker/1")]
    public int ItemValuableTracker1
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave/2")]
    public int ItemMineShockwave2
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/4")]
    public int ItemPowerCrystal4
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium/3")]
    public int ItemHealthPackMedium3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/5")]
    public int ItemUpgradePlayerGrabStrength5
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/8")]
    public int ItemUpgradePlayerEnergy8
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/9")]
    public int ItemUpgradePlayerEnergy9
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/5")]
    public int ItemUpgradePlayerSprintSpeed5
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/10")]
    public int ItemUpgradePlayerEnergy10
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/6")]
    public int ItemUpgradePlayerSprintSpeed6
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/4")]
    public int ItemUpgradePlayerHealth4
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch/2")]
    public int ItemUpgradePlayerTumbleLaunch2
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq/1")]
    public int ItemGunTranq1
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible/1")]
    public int ItemDroneIndestructible1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/6")]
    public int ItemUpgradePlayerGrabStrength6
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump/3")]
    public int ItemUpgradePlayerExtraJump3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/11")]
    public int ItemUpgradePlayerEnergy11
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/12")]
    public int ItemUpgradePlayerEnergy12
    {
        get; set;
    }
}

public class ItemBatteryUpgrades
{
    [JsonProperty("Item Cart Medium")]
    public int ItemCartMedium
    {
        get; set;
    }

    [JsonProperty("Item Cart Small")]
    public int ItemCartSmall
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery")]
    public int ItemDroneBattery
    {
        get; set;
    }

    [JsonProperty("Item Drone Feather")]
    public int ItemDroneFeather
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible")]
    public int ItemDroneIndestructible
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque")]
    public int ItemDroneTorque
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity")]
    public int ItemDroneZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Extraction Tracker")]
    public int ItemExtractionTracker
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped")]
    public int ItemGrenadeDuctTaped
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive")]
    public int ItemGrenadeExplosive
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human")]
    public int ItemGrenadeHuman
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave")]
    public int ItemGrenadeShockwave
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun")]
    public int ItemGrenadeStun
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun")]
    public int ItemGunHandgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Shotgun")]
    public int ItemGunShotgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq")]
    public int ItemGunTranq
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large")]
    public int ItemHealthPackLarge
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium")]
    public int ItemHealthPackMedium
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small")]
    public int ItemHealthPackSmall
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat")]
    public int ItemMeleeBaseballBat
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan")]
    public int ItemMeleeFryingPan
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer")]
    public int ItemMeleeInflatableHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sledge Hammer")]
    public int ItemMeleeSledgeHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sword")]
    public int ItemMeleeSword
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive")]
    public int ItemMineExplosive
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave")]
    public int ItemMineShockwave
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun")]
    public int ItemMineStun
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity")]
    public int ItemOrbZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal")]
    public int ItemPowerCrystal
    {
        get; set;
    }

    [JsonProperty("Item Rubber Duck")]
    public int ItemRubberDuck
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count")]
    public int ItemUpgradeMapPlayerCount
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy")]
    public int ItemUpgradePlayerEnergy
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump")]
    public int ItemUpgradePlayerExtraJump
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range")]
    public int ItemUpgradePlayerGrabRange
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength")]
    public int ItemUpgradePlayerGrabStrength
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health")]
    public int ItemUpgradePlayerHealth
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed")]
    public int ItemUpgradePlayerSprintSpeed
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch")]
    public int ItemUpgradePlayerTumbleLaunch
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker")]
    public int ItemValuableTracker
    {
        get; set;
    }
}

public class ItemsPurchased
{
    [JsonProperty("Item Cart Medium")]
    public int ItemCartMedium
    {
        get; set;
    }

    [JsonProperty("Item Cart Small")]
    public int ItemCartSmall
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery")]
    public int ItemDroneBattery
    {
        get; set;
    }

    [JsonProperty("Item Drone Feather")]
    public int ItemDroneFeather
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible")]
    public int ItemDroneIndestructible
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque")]
    public int ItemDroneTorque
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity")]
    public int ItemDroneZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Extraction Tracker")]
    public int ItemExtractionTracker
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped")]
    public int ItemGrenadeDuctTaped
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive")]
    public int ItemGrenadeExplosive
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human")]
    public int ItemGrenadeHuman
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave")]
    public int ItemGrenadeShockwave
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun")]
    public int ItemGrenadeStun
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun")]
    public int ItemGunHandgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Shotgun")]
    public int ItemGunShotgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq")]
    public int ItemGunTranq
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large")]
    public int ItemHealthPackLarge
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium")]
    public int ItemHealthPackMedium
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small")]
    public int ItemHealthPackSmall
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat")]
    public int ItemMeleeBaseballBat
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan")]
    public int ItemMeleeFryingPan
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer")]
    public int ItemMeleeInflatableHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sledge Hammer")]
    public int ItemMeleeSledgeHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sword")]
    public int ItemMeleeSword
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive")]
    public int ItemMineExplosive
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave")]
    public int ItemMineShockwave
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun")]
    public int ItemMineStun
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity")]
    public int ItemOrbZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal")]
    public int ItemPowerCrystal
    {
        get; set;
    }

    [JsonProperty("Item Rubber Duck")]
    public int ItemRubberDuck
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count")]
    public int ItemUpgradeMapPlayerCount
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy")]
    public int ItemUpgradePlayerEnergy
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump")]
    public int ItemUpgradePlayerExtraJump
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range")]
    public int ItemUpgradePlayerGrabRange
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength")]
    public int ItemUpgradePlayerGrabStrength
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health")]
    public int ItemUpgradePlayerHealth
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed")]
    public int ItemUpgradePlayerSprintSpeed
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch")]
    public int ItemUpgradePlayerTumbleLaunch
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker")]
    public int ItemValuableTracker
    {
        get; set;
    }
}

public class ItemsPurchasedTotal
{
    [JsonProperty("Item Cart Medium")]
    public int ItemCartMedium
    {
        get; set;
    }

    [JsonProperty("Item Cart Small")]
    public int ItemCartSmall
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery")]
    public int ItemDroneBattery
    {
        get; set;
    }

    [JsonProperty("Item Drone Feather")]
    public int ItemDroneFeather
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible")]
    public int ItemDroneIndestructible
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque")]
    public int ItemDroneTorque
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity")]
    public int ItemDroneZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Extraction Tracker")]
    public int ItemExtractionTracker
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped")]
    public int ItemGrenadeDuctTaped
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive")]
    public int ItemGrenadeExplosive
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human")]
    public int ItemGrenadeHuman
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave")]
    public int ItemGrenadeShockwave
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun")]
    public int ItemGrenadeStun
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun")]
    public int ItemGunHandgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Shotgun")]
    public int ItemGunShotgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq")]
    public int ItemGunTranq
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large")]
    public int ItemHealthPackLarge
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium")]
    public int ItemHealthPackMedium
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small")]
    public int ItemHealthPackSmall
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat")]
    public int ItemMeleeBaseballBat
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan")]
    public int ItemMeleeFryingPan
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer")]
    public int ItemMeleeInflatableHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sledge Hammer")]
    public int ItemMeleeSledgeHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sword")]
    public int ItemMeleeSword
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive")]
    public int ItemMineExplosive
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave")]
    public int ItemMineShockwave
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun")]
    public int ItemMineStun
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity")]
    public int ItemOrbZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal")]
    public int ItemPowerCrystal
    {
        get; set;
    }

    [JsonProperty("Item Rubber Duck")]
    public int ItemRubberDuck
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count")]
    public int ItemUpgradeMapPlayerCount
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy")]
    public int ItemUpgradePlayerEnergy
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump")]
    public int ItemUpgradePlayerExtraJump
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range")]
    public int ItemUpgradePlayerGrabRange
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength")]
    public int ItemUpgradePlayerGrabStrength
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health")]
    public int ItemUpgradePlayerHealth
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed")]
    public int ItemUpgradePlayerSprintSpeed
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch")]
    public int ItemUpgradePlayerTumbleLaunch
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker")]
    public int ItemValuableTracker
    {
        get; set;
    }
}

public class ItemStatBattery
{
    [JsonProperty("Item Cart Medium")]
    public int ItemCartMedium
    {
        get; set;
    }

    [JsonProperty("Item Cart Small")]
    public int ItemCartSmall
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery")]
    public int ItemDroneBattery
    {
        get; set;
    }

    [JsonProperty("Item Drone Feather")]
    public int ItemDroneFeather
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible")]
    public int ItemDroneIndestructible
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque")]
    public int ItemDroneTorque
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity")]
    public int ItemDroneZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Extraction Tracker")]
    public int ItemExtractionTracker
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped")]
    public int ItemGrenadeDuctTaped
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive")]
    public int ItemGrenadeExplosive
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human")]
    public int ItemGrenadeHuman
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave")]
    public int ItemGrenadeShockwave
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun")]
    public int ItemGrenadeStun
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun")]
    public int ItemGunHandgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Shotgun")]
    public int ItemGunShotgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq")]
    public int ItemGunTranq
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large")]
    public int ItemHealthPackLarge
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium")]
    public int ItemHealthPackMedium
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small")]
    public int ItemHealthPackSmall
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat")]
    public int ItemMeleeBaseballBat
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan")]
    public int ItemMeleeFryingPan
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer")]
    public int ItemMeleeInflatableHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sledge Hammer")]
    public int ItemMeleeSledgeHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sword")]
    public int ItemMeleeSword
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive")]
    public int ItemMineExplosive
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave")]
    public int ItemMineShockwave
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun")]
    public int ItemMineStun
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity")]
    public int ItemOrbZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal")]
    public int ItemPowerCrystal
    {
        get; set;
    }

    [JsonProperty("Item Rubber Duck")]
    public int ItemRubberDuck
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count")]
    public int ItemUpgradeMapPlayerCount
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy")]
    public int ItemUpgradePlayerEnergy
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump")]
    public int ItemUpgradePlayerExtraJump
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range")]
    public int ItemUpgradePlayerGrabRange
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength")]
    public int ItemUpgradePlayerGrabStrength
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health")]
    public int ItemUpgradePlayerHealth
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed")]
    public int ItemUpgradePlayerSprintSpeed
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch")]
    public int ItemUpgradePlayerTumbleLaunch
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker")]
    public int ItemValuableTracker
    {
        get; set;
    }

    [JsonProperty("Item Cart Medium/1")]
    public int ItemCartMedium1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human/1")]
    public int ItemGrenadeHuman1
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/1")]
    public int ItemPowerCrystal1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/1")]
    public int ItemUpgradePlayerSprintSpeed1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump/1")]
    public int ItemUpgradePlayerExtraJump1
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/2")]
    public int ItemPowerCrystal2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/1")]
    public int ItemUpgradePlayerGrabStrength1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave/1")]
    public int ItemGrenadeShockwave1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/1")]
    public int ItemUpgradePlayerHealth1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave/2")]
    public int ItemGrenadeShockwave2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range/1")]
    public int ItemUpgradePlayerGrabRange1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count/1")]
    public int ItemUpgradeMapPlayerCount1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/1")]
    public int ItemUpgradePlayerEnergy1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium/1")]
    public int ItemHealthPackMedium1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium/2")]
    public int ItemHealthPackMedium2
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque/1")]
    public int ItemDroneTorque1
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery/1")]
    public int ItemDroneBattery1
    {
        get; set;
    }

    [JsonProperty("Item Cart Small/1")]
    public int ItemCartSmall1
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer/1")]
    public int ItemMeleeInflatableHammer1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large/1")]
    public int ItemHealthPackLarge1
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large/2")]
    public int ItemHealthPackLarge2
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave/3")]
    public int ItemGrenadeShockwave3
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small/2")]
    public int ItemHealthPackSmall2
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/3")]
    public int ItemPowerCrystal3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/2")]
    public int ItemUpgradePlayerEnergy2
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan/1")]
    public int ItemMeleeFryingPan1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/2")]
    public int ItemUpgradePlayerSprintSpeed2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/2")]
    public int ItemUpgradePlayerHealth2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/2")]
    public int ItemUpgradePlayerGrabStrength2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range/2")]
    public int ItemUpgradePlayerGrabRange2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump/2")]
    public int ItemUpgradePlayerExtraJump2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/3")]
    public int ItemUpgradePlayerEnergy3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/4")]
    public int ItemUpgradePlayerEnergy4
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small/3")]
    public int ItemHealthPackSmall3
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun/1")]
    public int ItemMineStun1
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun/2")]
    public int ItemMineStun2
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive/1")]
    public int ItemGrenadeExplosive1
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity/1")]
    public int ItemDroneZeroGravity1
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun/1")]
    public int ItemGrenadeStun1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/3")]
    public int ItemUpgradePlayerSprintSpeed3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range/3")]
    public int ItemUpgradePlayerGrabRange3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/3")]
    public int ItemUpgradePlayerGrabStrength3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/5")]
    public int ItemUpgradePlayerEnergy5
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/6")]
    public int ItemUpgradePlayerEnergy6
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/4")]
    public int ItemUpgradePlayerSprintSpeed4
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/3")]
    public int ItemUpgradePlayerHealth3
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped/1")]
    public int ItemGrenadeDuctTaped1
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity/1")]
    public int ItemOrbZeroGravity1
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive/1")]
    public int ItemMineExplosive1
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun/1")]
    public int ItemGunHandgun1
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat/1")]
    public int ItemMeleeBaseballBat1
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive/2")]
    public int ItemMineExplosive2
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch/1")]
    public int ItemUpgradePlayerTumbleLaunch1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/4")]
    public int ItemUpgradePlayerGrabStrength4
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/7")]
    public int ItemUpgradePlayerEnergy7
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun/2")]
    public int ItemGunHandgun2
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave/1")]
    public int ItemMineShockwave1
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker/1")]
    public int ItemValuableTracker1
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave/2")]
    public int ItemMineShockwave2
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal/4")]
    public int ItemPowerCrystal4
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium/3")]
    public int ItemHealthPackMedium3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/5")]
    public int ItemUpgradePlayerGrabStrength5
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/8")]
    public int ItemUpgradePlayerEnergy8
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/9")]
    public int ItemUpgradePlayerEnergy9
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/5")]
    public int ItemUpgradePlayerSprintSpeed5
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/10")]
    public int ItemUpgradePlayerEnergy10
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed/6")]
    public int ItemUpgradePlayerSprintSpeed6
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health/4")]
    public int ItemUpgradePlayerHealth4
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch/2")]
    public int ItemUpgradePlayerTumbleLaunch2
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq/1")]
    public int ItemGunTranq1
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible/1")]
    public int ItemDroneIndestructible1
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength/6")]
    public int ItemUpgradePlayerGrabStrength6
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump/3")]
    public int ItemUpgradePlayerExtraJump3
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/11")]
    public int ItemUpgradePlayerEnergy11
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy/12")]
    public int ItemUpgradePlayerEnergy12
    {
        get; set;
    }
}

public class ItemsUpgradesPurchased
{
    [JsonProperty("Item Cart Medium")]
    public int ItemCartMedium
    {
        get; set;
    }

    [JsonProperty("Item Cart Small")]
    public int ItemCartSmall
    {
        get; set;
    }

    [JsonProperty("Item Drone Battery")]
    public int ItemDroneBattery
    {
        get; set;
    }

    [JsonProperty("Item Drone Feather")]
    public int ItemDroneFeather
    {
        get; set;
    }

    [JsonProperty("Item Drone Indestructible")]
    public int ItemDroneIndestructible
    {
        get; set;
    }

    [JsonProperty("Item Drone Torque")]
    public int ItemDroneTorque
    {
        get; set;
    }

    [JsonProperty("Item Drone Zero Gravity")]
    public int ItemDroneZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Extraction Tracker")]
    public int ItemExtractionTracker
    {
        get; set;
    }

    [JsonProperty("Item Grenade Duct Taped")]
    public int ItemGrenadeDuctTaped
    {
        get; set;
    }

    [JsonProperty("Item Grenade Explosive")]
    public int ItemGrenadeExplosive
    {
        get; set;
    }

    [JsonProperty("Item Grenade Human")]
    public int ItemGrenadeHuman
    {
        get; set;
    }

    [JsonProperty("Item Grenade Shockwave")]
    public int ItemGrenadeShockwave
    {
        get; set;
    }

    [JsonProperty("Item Grenade Stun")]
    public int ItemGrenadeStun
    {
        get; set;
    }

    [JsonProperty("Item Gun Handgun")]
    public int ItemGunHandgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Shotgun")]
    public int ItemGunShotgun
    {
        get; set;
    }

    [JsonProperty("Item Gun Tranq")]
    public int ItemGunTranq
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Large")]
    public int ItemHealthPackLarge
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Medium")]
    public int ItemHealthPackMedium
    {
        get; set;
    }

    [JsonProperty("Item Health Pack Small")]
    public int ItemHealthPackSmall
    {
        get; set;
    }

    [JsonProperty("Item Melee Baseball Bat")]
    public int ItemMeleeBaseballBat
    {
        get; set;
    }

    [JsonProperty("Item Melee Frying Pan")]
    public int ItemMeleeFryingPan
    {
        get; set;
    }

    [JsonProperty("Item Melee Inflatable Hammer")]
    public int ItemMeleeInflatableHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sledge Hammer")]
    public int ItemMeleeSledgeHammer
    {
        get; set;
    }

    [JsonProperty("Item Melee Sword")]
    public int ItemMeleeSword
    {
        get; set;
    }

    [JsonProperty("Item Mine Explosive")]
    public int ItemMineExplosive
    {
        get; set;
    }

    [JsonProperty("Item Mine Shockwave")]
    public int ItemMineShockwave
    {
        get; set;
    }

    [JsonProperty("Item Mine Stun")]
    public int ItemMineStun
    {
        get; set;
    }

    [JsonProperty("Item Orb Zero Gravity")]
    public int ItemOrbZeroGravity
    {
        get; set;
    }

    [JsonProperty("Item Power Crystal")]
    public int ItemPowerCrystal
    {
        get; set;
    }

    [JsonProperty("Item Rubber Duck")]
    public int ItemRubberDuck
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Map Player Count")]
    public int ItemUpgradeMapPlayerCount
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Energy")]
    public int ItemUpgradePlayerEnergy
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Extra Jump")]
    public int ItemUpgradePlayerExtraJump
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Range")]
    public int ItemUpgradePlayerGrabRange
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Grab Strength")]
    public int ItemUpgradePlayerGrabStrength
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Health")]
    public int ItemUpgradePlayerHealth
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Sprint Speed")]
    public int ItemUpgradePlayerSprintSpeed
    {
        get; set;
    }

    [JsonProperty("Item Upgrade Player Tumble Launch")]
    public int ItemUpgradePlayerTumbleLaunch
    {
        get; set;
    }

    [JsonProperty("Item Valuable Tracker")]
    public int ItemValuableTracker
    {
        get; set;
    }
}

public class PlayerHasCrown
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerHealth
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerNames
{
    public string __type
    {
        get; set;
    }
    public Value value
    {
        get; set;
    }
}

public class PlayerUpgradeExtraJump
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeHealth
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeLaunch
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeMapPlayerCount
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeRange
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeSpeed
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeStamina
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeStrength
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class PlayerUpgradeThrow
{
    [JsonProperty("76561198930262816")]
    public int _76561198930262816
    {
        get; set;
    }
}

public class RepoSaveRoot
{
    public Value GetMain() => dictionaryOfDictionaries.value;

    public DictionaryOfDictionaries dictionaryOfDictionaries
    {
        get; set;
    }
    public PlayerNames playerNames
    {
        get; set;
    }
    public TimePlayed timePlayed
    {
        get; set;
    }
    public DateAndTime dateAndTime
    {
        get; set;
    }
    public TeamName teamName
    {
        get; set;
    }
}

public class RunStats
{
    public int level
    {
        get; set;
    }
    public int currency
    {
        get; set;
    }
    public int lives
    {
        get; set;
    }
    public int chargingStationCharge
    {
        get; set;
    }
    public int totalHaul
    {
        get; set;
    }

    [JsonProperty("save level")]
    public int savelevel
    {
        get; set;
    }
}

public class TeamName
{
    public string __type
    {
        get; set;
    }
    public string value
    {
        get; set;
    }
}

public class TimePlayed
{
    public string __type
    {
        get; set;
    }
    public double value
    {
        get; set;
    }
}

public class Value
{
    public RunStats runStats
    {
        get; set;
    }
    public ItemsPurchased itemsPurchased
    {
        get; set;
    }
    public ItemsPurchasedTotal itemsPurchasedTotal
    {
        get; set;
    }
    public ItemsUpgradesPurchased itemsUpgradesPurchased
    {
        get; set;
    }
    public ItemBatteryUpgrades itemBatteryUpgrades
    {
        get; set;
    }
    public PlayerHealth playerHealth
    {
        get; set;
    }
    public PlayerUpgradeHealth playerUpgradeHealth
    {
        get; set;
    }
    public PlayerUpgradeStamina playerUpgradeStamina
    {
        get; set;
    }
    public PlayerUpgradeExtraJump playerUpgradeExtraJump
    {
        get; set;
    }
    public PlayerUpgradeLaunch playerUpgradeLaunch
    {
        get; set;
    }
    public PlayerUpgradeMapPlayerCount playerUpgradeMapPlayerCount
    {
        get; set;
    }
    public PlayerUpgradeSpeed playerUpgradeSpeed
    {
        get; set;
    }
    public PlayerUpgradeStrength playerUpgradeStrength
    {
        get; set;
    }
    public PlayerUpgradeRange playerUpgradeRange
    {
        get; set;
    }
    public PlayerUpgradeThrow playerUpgradeThrow
    {
        get; set;
    }
    public PlayerHasCrown playerHasCrown
    {
        get; set;
    }
    public Item item
    {
        get; set;
    }
    public ItemStatBattery itemStatBattery
    {
        get; set;
    }

    [JsonProperty("76561198930262816")]
    public string _76561198930262816
    {
        get; set;
    }
}


using System.Collections.Generic;

namespace Pd2TradeApi.Server.Models.DTOs.Shared
{
    public static class ItemSubcategoryList
    {
        public static Dictionary<ItemCategoryList, List<string>> ItemSubCategoryList = new Dictionary<ItemCategoryList, List<string>> {
        {
            ItemCategoryList.BodyArmor,
            new List<string>
            {
                "Quilted Armor",
                "Leather Armor",
                "Hard Leather Armor",
                "Studded Leather",
                "Ring Mail",
                "Scale Mail",
                "Breast Plate",
                "Chain Mail",
                "Splint Mail",
                "Light Plate",
                "Field Plate",
                "Plate Mail",
                "Gothic Plate",
                "Full Plate",
                "Ancient Armor",
                "Ghost Armor",
                "Serpentskin Armor",
                "Demonhide Armor",
                "Trellised Armor",
                "Linked Armor",
                "Tigulated Mail",
                "Cuirass",
                "Mesh Armor",
                "Russet Armor",
                "Mage Plate",
                "Sharktooth Armor",
                "Template Coat",
                "Embossed Plate",
                "Chaos Armor",
                "Ornate Armor",
                "Dusk Shroud",
                "Wyrmhide",
                "Scarab Husk",
                "Wire Fleece",
                "Diamond Mail",
                "Loricate Mail",
                "Great Hauberk",
                "Bone Weave",
                "Balrog Skin",
                "Archon Plate",
                "Kraken Shell",
                "Hellforge Plate",
                "Lacquered Plate",
                "Shadow Plate",
                "Sacred Armor"
            }
        },
        {
            ItemCategoryList.Boot,
            new List<string>
            {
                "Leather Boots",
                "Heavy Boots",
                "Chain Boots",
                "Light Plated Boots",
                "Greaves",
                "Demonhide Boots",
                "Sharkskin Boots",
                "Mesh Boots",
                "Battle Boots",
                "War Boots",
                "Wyrmhide Boots",
                "Scarabshell Boots",
                "Boneweave Boots",
                "Mirrored Boots",
                "Myrmidon Boots"
            }
        },
        {
            ItemCategoryList.Glove,
            new List<string>
            {
                "Leather Gloves",
                "Heavy Gloves",
                "Chain Gloves",
                "Light Gauntlets",
                "Gauntlets",
                "Demonhide Gloves",
                "Sharkskin Gloves",
                "Heavy Bracers",
                "Battle Gauntlets",
                "War Gauntlets",
                "Bramble Mitts",
                "Vampirebone Gloves",
                "Vambraces",
                "Crusader Gauntlets",
                "Ogre Gauntlets"
            }
        },
        {
            ItemCategoryList.Belt,
            new List<string>
            {
                "Sash",
                "Light Belt",
                "Belt",
                "Heavy Belt",
                "Plated Belt",
                "Demonhide Sash",
                "Shareskin Belt",
                "Mesh Belt",
                "Battle Belt",
                "War Belt",
                "Spiderweb Sash",
                "Vampirefang Belt",
                "Mithril Coil",
                "Troll BElt",
                "Colossus Girdle"
            }
        },
        {
            ItemCategoryList.Helmet,
            new List<string>
            {
                "Cap",
                "Skull Cap",
                "Helm",
                "Full Helm",
                "Mask",
                "Bone Helm",
                "Great Helm",
                "Crown",
                "War Hat",
                "Sallet",
                "Casque",
                "Basinet",
                "Death Mask",
                "Grim Helm",
                "Winged Helm",
                "Grand Crown",
                "Shako",
                "Hydraskull",
                "Armet",
                "Giant Conch",
                "Demonhead",
                "Bone Visage",
                "Spired Helm",
                "Corona",
            }
        },
        {
            ItemCategoryList.BarbarianHelm,
            new List<string>
            {
                "Jawbone Cap",
                "Fanged Helm",
                "Horned Helm",
                "Assault Helmet",
                "Avenger Guard",
                "Jawbone Visor",
                "Lion Helm",
                "Rage Mask",
                "Savage Helmet",
                "Slayer Guard",
                "Carnage Helm",
                "Fury Visor",
                "Destroyer Helm",
                "Conquerer Crown",
                "Guardian Crown"

            }
        },
        {
            ItemCategoryList.DruidPelt,
            new List<string>
            {
                "Wolf Head",
                "Hawk Helm",
                "Antlers",
                "Falcon Mask",
                "Spirit Mask",
                "Alpha Helm",
                "Griffon Headdress",
                "Hunters Guise",
                "Sacred Feathers",
                "Totemic Mask",
                "Blood Spirit",
                "Sun Spirit",
                "Earth Spirit",
                "Sky Spirit",
                "DreamSpirit"

            }
        },
        {
            ItemCategoryList.Circlet,
            new List<string>
            {
                "Circlet",
                "Coronet",
                "Tiara",
                "Diadem"
            }
        },
        {
            ItemCategoryList.ShrunkenHead,
            new List<string>
            {
                "Preserved Head",
                "Zombie Head",
                "Unraveller Head",
                "Gargoyle Head",
                "Demon Head",
                "Mummified Trophy",
                "Fetish Trophy",
                "Sexton Trophy",
                "Cantor Trophy",
                "Hierophant Trophy",
                "Minion Skull",
                "Hellspawn Skull",
                "Overseer Skull",
                "Succubae Skull",
                "Bloodlord Skull"

            }
        },
        {
            ItemCategoryList.Shield,
            new List<string>
            {
                "Buckler",
                "Small Shield",
                "Large Shield",
                "Kite Shield",
                "Spiked Shield",
                "Bone Shield",
                "Tower Shield",
                "Gothic Shield",
                "Defender",
                "Scutum",
                "Dragon Shield",
                "Barbed Shield",
                "Grim Shield",
                "Pavise",
                "Anicent Shield",
                "Heater",
                "Luna",
                "Hyperion",
                "Monarch",
                "Blood Barrier",
                "Troll Nest",
                "Aegis",
                "Ward"
            }
        },
        {
            ItemCategoryList.PaladinShield,
            new List<string>
            {
                "Targe",
                "Rondache",
                "Heraldric Shield",
                "Aerin Shield",
                "Crown Shield",
                "Akaran Targe",
                "Protector Shield",
                "Gilded Shield",
                "Royal Shield",
                "Sacred Targe",
                "Sacred Rondache",
                "Kurast Shield",
                "Zakarum Shield",
                "Vortex Shield"
            }
        },
        {
            ItemCategoryList.Ring,
            new List<string>
            {
                "Eturn",
                "Sloop",
                "Blue Band",
                "Orange",
                "Chain"
            }
        },
        {
            ItemCategoryList.Amulet,
            new List<string>
            {
                "Sun",
                "Cross",
                "Star"
            }
        },
        {
            ItemCategoryList.OneHandAxe,
            new List<string>
            {
                "Hand Axe",
                "Axe",
                "Double Axe",
                "Military Pick",
                "War Axe",
                "Hatchet",
                "Cleaver",
                "Twin Axe",
                "Crowbill",
                "Naga",
                "Tomahawk",
                "Small Crescent",
                "Ettin Axe",
                "War Spike",
                "Berserker Axe"
            }
        },
        {
            ItemCategoryList.TwoHandAxe,
            new List<string>
            {
                "Large Axe",
                "Broad Axe",
                "Battle Axe",
                "Great Axe",
                "Giant Axe",
                "Military Axe",
                "Bearded Axe",
                "Tabar",
                "Gothic Axe",
                "Ancient Axe",
                "Feral Axe",
                "Silver-edged Axe",
                "Decapitator",
                "Champion Axe",
                "Glorious Axe"
            }
        },
        {
            ItemCategoryList.Bow,
            new List<string>
            {
                "Short Bow",
                "Hunters Bow",
                "Long Bow",
                "Composite Bow",
                "Short Battle Bow",
                "Long Battle Bow",
                "Short War Bow",
                "Long War Bow",
                "Edge Bow",
                "Razor Bow",
                "Cedar Bow",
                "Double Bow",
                "Short Siege Bow",
                "Large Seige Bow",
                "Rune Bow",
                "Gothic Bow",
                "Spider Bow",
                "Blade Bow",
                "Shadow Bow",
                "Great Bow",
                "Diamond Bow",
                "Crusader Bow",
                "Ward Bow",
                "Hydra Bow",
                "Stag Bow",
                "Reflex Bow",
                "Ashwood Bow",
                "Ceremonial Bow",
                "Matriarchal Bow",
                "Grand Matron Bow"
            }
        },
        {
            ItemCategoryList.Crossbow,
            new List<string>
            {
                "Light Crossbow",
                "Crossbow",
                "Heavy Crossbow",
                "Repeating Crossbow",
                "Arbalest",
                "Siege Crossbow",
                "Ballista",
                "Chu-Ko-Nu",
                "Pellet Bow",
                "Gorgon Crossbow",
                "Colossus Crossbow",
                "Demon Crossbow"
            }
        },
        {
            ItemCategoryList.Dagger,
            new List<string>
            {
                "Dagger",
                "Dirk",
                "Kris",
                "Blade",
                "Poignard",
                "Rondel",
                "Cinquedeas",
                "Stiletto",
                "Bone Knife",
                "Mithril Point",
                "Fanged Knife",
                "Legend Spike"
            }
        },
        {
            ItemCategoryList.Javelin,
            new List<string>
            {
                "Javelin",
                "Pilum",
                "Short Spear",
                "Glaive",
                "Throwing Spear",
                "War Javelin",
                "Great Pilum",
                "Simbilan",
                "Spiculum",
                "Harpoon",
                "Hyperion Javelin",
                "Stygian Pilum",
                "Balrog Spear",
                "Ghost Glaive",
                "Winged Harpoon",
                "Maidan Javelin",
                "Ceremonial Javelin",
                "Matriarchal Javelin"
            }
        },
        {
            ItemCategoryList.Mace,
            new List<string>
            {
                "Mace",
                "Morning Star",
                "Flail",
                "Flanged Mace",
                "Jagged Star",
                "Knout",
                "Reinforce Mace",
                "Devil Star",
                "Scourge"
            }
        },
        {
            ItemCategoryList.Polearm,
            new List<string>
            {
                "Bardiche",
                "Voulge",
                "Scythe",
                "Poleaxe",
                "Halbred",
                "War Scythe",
                "Lochaber Axe",
                "Bill",
                "Battle Scythe",
                "Partizan",
                "Bec-De-Corbin",
                "Grim Scythe",
                "Ogre Axe",
                "Colossus Voulge",
                "Threasher",
                "Cryptic Axe",
                "Great Poleaxe",
                "Giant Thresher"
            }
        },
        {
            ItemCategoryList.Scepter,
            new List<string>
            {
                "Scepter",
                "Giant Scepter",
                "War Scepter",
                "Rune Sceptar",
                "Holy Water Sprinkler",
                "Divine Scepter",
                "Mighty Sceptar",
                "Seraph Rod",
                "Caduceus"
            }
        },
        {
            ItemCategoryList.Spear,
            new List<string>
            {
                "Spear",
                "Triden",
                "Brandistock",
                "Spetum",
                "Pike",
                "War Spear",
                "Fuscina",
                "War Fork",
                "Yari",
                "Lance",
                "Hyperion Spear",
                "Stygian Pike",
                "Mancatcher",
                "Ghost Spear",
                "War Pike",
                "Maidan Spear",
                "Maiden Pike",
                "Ceremonial Spear",
                "Ceremonial Pike",
                "Matriarchal Spear",
                "Matriarchal Pike"
            }
        },
        {
            ItemCategoryList.Staff,
            new List<string>
            {
                "Short Staff",
                "Long Staff",
                "Gnarled Staff",
                "Battle Staff",
                "War Staff",
                "Jo Staff",
                "Quarter Staff",
                "Cedar Staff",
                "Gothic Staff",
                "Rune Staff",
                "Walking Stick",
                "Stalagmite",
                "Elder Staff",
                "Shillagh",
                "Archon Staff"
            }
        },
        {
            ItemCategoryList.OneHandSword,
            new List<string>
            {
                "Short Sword",
                "Schimitar",
                "Sabre",
                "Falchion",
                "Crystal Sword",
                "Broad Sword",
                "Long Sword",
                "War Sword",
                "Galdius",
                "Cutlass",
                "Shamshir",
                "Tulwar",
                "Cap",
                "Dimensional Blade",
                "Battle Sword",
                "Rune Sword",
                "Ancient Sword",
                "Falcata",
                "Ataghan",
                "Elegant Blade",
                "Hyrdra Edge",
                "Phase Blade",
                "Conquest Blade",
                "Cryptic Sword",
                "Mythical Sword"
            }
        },
        {
            ItemCategoryList.TwoHandSword,
            new List<string>
            {
                "Two-Handed Sword",
                "Claymore",
                "Giant Sword",
                "Bastard Sword",
                "Flanberge",
                "Great Sword",
                "Espandon",
                "Dalcian Falx",
                "Cap",
                "Tusk Sword",
                "Gothic Sword",
                "Zweihander",
                "Executioner Sword",
                "Legend Sword",
                "Highland Blade",
                "Balrog Blade",
                "Champion Sword",
                "Colossus Sword",
                "Colossus Blade"
            }
        },
        {
            ItemCategoryList.Claw,
            new List<string>
            {
                "Katar",
                "Wrist Blade",
                "Hatchet Hands",
                "Cestus",
                "Claws",
                "Blade Talons",
                "Scissors Katar",
                "Quhab",
                "Wrist Spike",
                "Fascia",
                "Hand Scythe",
                "Greater Claws",
                "Greater Talons",
                "Scissors Quhab",
                "Suwayyah",
                "Wrist Sword",
                "War Fist",
                "Battle Cestus",
                "Feral Claws",
                "Runic Talons",
                "Scissors Suwayyah"
            }
        },
        {
            ItemCategoryList.Throwable,
            new List<string>
            {
                "Throwing Knife",
                "Throwing Axe",
                "Balanced Knife",
                "Blanaced Axe",
                "Battle Dart",
                "Francisca",
                "War Dart",
                "Hurlbat",
                "Flying Knife",
                "Flying Axe",
                "Winged Knife",
                "Winged Axe"
            }
        },
        {
            ItemCategoryList.Wand,
            new List<string>
            {
                "Wand",
                "Yew Wand",
                "Bone Wand",
                "Grim Wand",
                "Burnt Wand",
                "Petrified Wand",
                "Tomb Wand",
                "Grave Wand",
                "Polished Wand",
                "Ghost Wand",
                "Lich Wand",
                "Unearthed Wand"
            }
        },
        {
            ItemCategoryList.Orb,
            new List<string>
            {
                "Eagle Orb",
                "Sacred Globe",
                "Smoked Sphere",
                "Clapsed Orb",
                "Jared's Stone",
                "Glowing Orb",
                "Crystalline Globe",
                "Cloudy Sphere",
                "Sparkling Ball",
                "Swirling Crystal",
                "Heavenly Stone",
                "Eldritch Orb",
                "Demon Heart",
                "Vortex Orb",
                "Dimensional Shard"
            }
        },
        {
            ItemCategoryList.Gem,
            new List<string>
            {
                "Amethyst",
                "Diamond",
                "Emerald",
                "Ruby",
                "Sapphire",
                "Topaz",
                "Skull"
            }
        },
        {
            ItemCategoryList.Rune,
            new List<string>
            {
                "El",
                "Eld",
                "Tir",
                "Nef",
                "Eth",
                "Ith",
                "Tal",
                "Ral",
                "Ort",
                "Thul",
                "Cap",
                "Amn",
                "Sol",
                "Shael",
                "Dol",
                "Hel",
                "Io",
                "Lum",
                "Ko",
                "Fal",
                "Lem",
                "Pul",
                "Um",
                "Mal",
                "Ist",
                "Gul",
                "Vex",
                "Ohm",
                "Lo",
                "Sur",
                "Ber",
                "Jah",
                "Cham",
                "Zod"
            }
        },
        {
            ItemCategoryList.Charm,
            new List<string>
            {
                "Small",
                "Large",
                "Grand"
            }
        },
        {
            ItemCategoryList.Jewel,
            new List<string>
            {
                "Pink",
                "Blue",
                "Peach",
                "Green",
                "Red",
                "White"
            }
        },
        {
            ItemCategoryList.Scroll,
            new List<string>
            {
                "Portal",
                "Identification"
            }
        },
        {
            ItemCategoryList.Tome,
            new List<string>
            {
                "Portal",
                "Identification"
            }
        },
        {
            ItemCategoryList.Potion,
            new List<string>
            {
                "Cap",
                "Cap",
                "Cap",
            }
        }
    };
    }
}

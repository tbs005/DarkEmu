﻿///////////////////////////////////////////////////////////////////////////
// SRX Revo: Ingame Messages list
// Created by: http://xcoding.net
///////////////////////////////////////////////////////////////////////////

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SrxRevo
{
    class IngameMessages
    {
        public const ushort
            GUILD_STORAGE_LEVEL_TO_LOW = 0x4C4A,
            UIIT_STT_ERR_COMMON_INVALID_OPERATION = 0x3C4C,
            UIIT_STT_ERR_COMMON_TOO_FAR = 0x4,
            UIIT_STT_SOCKETERR_NOT_EXIST_RECIPE = 0x6C08,
            UIIT_STT_SOCKETERR_OVERFLOW_RESERVED_SOCKET_HOLE_COUNT = 0x6C09,
            UIIT_STT_SOCKETERR_CANT_HOLE_PUNCHING_THIS_ITEM = 0x6C0A,
            UIIT_STT_SOCKETERR_THIS_HOLE_PUNCHED_ALREADY = 0x6C0B,
            UIIT_STT_SOCKETERR_SAME_SOCKET_STONE_IS_INSERTED = 0x6C0C,
            UIIT_STT_SOCKETERR_THERE_IS_NO_EMPTY_HOLE = 0x6C0D,
            UIIT_STT_SOCKETERR_THE_ITEM_ISNT_PARING_THIS_SOCKET_STONE = 0x6C0E,
            UIIT_STT_SOCKETERR_THIS_HOLE_USED_ALREADY = 0x6C0F,
            UIIT_STT_SOCKETERR_ITEM_LEVEL_LESS_THAN_THIS_SOCKET_STONE = 0x6C10,
            UIIT_STT_SOCKETERR_THIS_HOLE_IS_EMPTY = 0x6C11,
            UIIT_STT_SOCKETERR_CANT_BE_LOADED_MULTIPLE_TIME = 0x6C12,
            UIIT_STT_SOCKETERR_ITS_NOT_SOCKET_STUFF = 0x6C13,
            UIIT_MSG_STRGERR_INVALID_TARGET = 3,
            UIIT_MSG_STRGERR_INVENTORY_FULL = 0x1807,
            UIIT_MSG_STRGERR_CANT_SUMMON_MULTIPLE_COSOBJ = 0x185C,
            UIIT_MSG_STRGERR_EQUIPITEM = 0x180E,
            UIIT_MSG_STRGERR_HIGHER_LEVEL_REQUIRED = 0x1810,
            UIIT_MSG_STRGERR_HIGHER_LEVEL_REQUIRED_TO_USE_THISITEM = 0x186C,
            UIIT_MSG_COSPETERR_CANT_USEITEM = 0x187A,
            UIIT_MSG_STRGERR_NOT_ENOUGH_GOLD = 0x180F,
            UIIT_MSG_STRGERR_ENABLEINPUT_FEWERTHAN_REMAIN = 0x1815,
            UIIT_MSG_STRGERR_GENDER_MISMATCH = 0x1816,
            UITT_MSG_CUSTOM_ARMOR_TYPE_WRONG = 0x1832,
            UIIT_MSG_STRGERR_BUSY = 0x181E,
            UIIT_MSG_STRGERR_CANNOT_DEAL_NORMALCY = 0x1820,
            UIIT_MSG_STRGERR_INVENTORY_FULL_DEAL_CANCEL = 0x1822,
            UIIT_MSG_STRGERR_TIMEOUT = 0x1826,
            UIIT_MSG_STRGERR_CANNOT_FIND_TARGET = 0x1827,
            UIIT_MSG_STRGERR_TRADING_DENIED = 0x1828,
            UIIT_MSG_STRGERR_SPECIFY_POSITIVE_NUMBER_ONLY = 0x1829,
            UIIT_MSG_STRGERR_EXCHANGE_CANCEL = 0x182B,
            UIIT_MSG_STRGERR_TRADING_CANCELED_BY_USER = 0x182C,
            UIIT_MSG_STRGERR_NOT_ENOUGH_OPPONENT_INV_SPACE = 0x1836,
            UIIT_MSG_STRGERR_CANT_EQUIP_RAZED_ITEM = 0x1837,
            UIIT_MSG_STRGERR_CANNOT_BE_DROPPED = 0x1838,
            UIIT_MSG_STRGERR_CANNOT_BE_PICKED = 0x1839,
            UIIT_MSG_STRGERR_CANNOT_BE_TRADED = 0x183A,
            UIIT_MSG_STRGERR_CANNOT_DEAL_AT_SHOP = 0x183B,
            UIIT_MSG_STRGERR_ONLY_TRADER_CAN_BUY_SPECIALTY = 0x1860,
            UIIT_MSG_STRGERR_DONT_HAVE_ANY_TRADECART_TO_PICK_SPECIALTY = 0x1861,
            UIIT_MSG_STRGERR_CANNOT_BE_USED = 0x183E,
            UIIT_MSG_STRGERR_CANT_SELL_EQUIPED_ITEM = 0x183F,
            UIIT_MSG_STRGERR_INVALID_TARGET_STORAGE = 0x1843,
            UIIT_MSG_STRGERR_DEALER_DONT_TREAT_THIS_ITEM = 0x1845,
            UIIT_MSG_STRGERR_CANT_SWAP_JOBITEM = 0x1846,
            UIIT_MSG_STRGERR_WAIT_FOR_JOBCHANGE_COMPLETE = 0x1847,
            UIIT_MSG_STRGERR_CANT_DETACH_JOBITEM_IN_BATTLESTATE = 0x1848,
            UIIT_MSG_STRGERR_YOU_CANT_ACTIVATE_CART = 0x1849,
            UIIT_MSG_STRGERR_YOU_CANT_DEAL_SPECIALTY = 0x1850,
            UIIT_MSG_STRGERR_CANT_HAVE_CART = 0x185A,
            UIIT_MSG_STRGERR_CANT_BE_STORED = 0x180B,
            UIIT_MSG_STRGERR_LOCKED_BY_OTHER_ONE = 0x1812,
            UIIT_MSG_STRGERR_TRADE_BAY_FULL = 0x1821,
            UIIT_MSG_STRGERR_COUNTRY_MISMATCH = 0x182F,
            UIIT_MSG_STRGERR_HIGHER_STRENGTH_REQUIRED = 0x1830,
            UIIT_MSG_STRGERR_HIGHER_INTELLECT_REQUIRED = 0x1831,
            UIIT_MSG_STRGERR_PREV_TELESCROLL_ALREADY_WORKING = 0x185D,
            UIIT_MSG_STRGERR_CAN_NOT_BE_MERGED = 0x1819,
            UIIT_MSG_STRGERR_TARGET_ITEM_STOCK_FULL = 0x181A,
            UIIT_MSG_STRGERR_WAIT_FOR_REUSE_DELAY = 0x18BF,
            UIIT_MSG_STRGERR_CANT_TELEPORT_WITH_CART = 0x185E,
            UIIT_MSG_STRGERR_YOUR_CARAVAN_ISNT_OWNER_OF_THIS_SPECIALTY = 0x1862,
            UIIT_MSG_STRGERR_YOU_ARENT_BUYER_OF_THIS_SPECIALTY = 0x1863,
            UIIT_MSG_STRGERR_CANT_DEAL_SPECIALTY_SINCE_TOO_FAR_FROM_CART = 0x1865,
            UIIT_MSG_STRGERR_ALL_JOB_ACTIVATION_PROHIBITED = 0x1866,
            UIIT_MSG_STRGERR_CAN_ACTIVATE_ROBBER_ONLY = 0x1867,
            UIIT_MSG_STRGERR_DEALER_DONT_TREAT_STOLEN_ITEM = 0x1868,
            UIIT_MSG_STRGERR_CANT_USEITEM_WHILE_INTERACT = 0x1835,
            UIIT_MSG_STRGERR_ONLY_ROBBER_CAN_USE_THIS_ITEM = 0x186A,
            UIIT_MSG_STRGERR_CANT_OPERATE_REQUESTED_JOB_DURING_LOGOUT = 0x186B,
            UIIT_MSG_STRGERR_CANT_DROP_EQUIPED_ITEM_DIRECTLY = 0x186D,
            UIIT_MSG_STRGERR_CANT_PICK_ITEM_WHILE_TELEPORT_WORK = 0x186E,
            UIIT_MSG_STRGERR_ROBBER_CANT_PICK_HIS_ITEM = 0x186F,
            UIIT_MSG_STRGERR_WAIT_FOR_JOBITEM_DETACH_COMPLETE = 0x1870,
            UIIT_MSG_CANNOT_BE_USED_ITEM_CART = 0x1871,
            UIIT_MSG_STRGERR_POSSESSION_LIMIT_EXCEEDED = 0x1872,
            UIIT_MSG_STRGERR_TO_USE_ITEM_TARGET_MUSTBE_SELECTED = 0x1873,
            UIIT_MSG_STRGERR_CANNOT_BE_PICKED_AT_QUEST_ACHIEVE_CONDITION = 0x1874,
            UIIT_MSG_STRGERR_MURDERER_CANT_USE_PORTAL_SCROLL = 0x1875,
            UIIT_MSG_STRGERR_MURDERER_CANT_SUMMON_VEHICLE = 0x1876,
            UIIT_MSG_STRGERR_REQUESTED_JOB_BLOCKED_BY_QUEST = 0x185F,
            UIIT_MSG_STRGERR_CANT_DETACH_FREEBATTLEITEM_IN_BATTLESTATE = 0x1877,
            UIIT_MSG_COS_CAN_NOT_CREATE_BATTLE = 0x1878,
            UIIT_MSG_COS_CREATE_DUNGEON = 0x1879,
            UIIT_MSG_STRGERR_NOT_ENOUGH_SILK_TO_BUY_ITEM = 0x1880,
            UIIT_MSG_STRGERR_NOT_ENOUGH_SILK_TO_GIFT = 0x1881,
            UIIT_MSG_SILKMALL_SOLDOUT_ITEM = 0x18CF,
            UIIT_STT_CASH_MALL_LEVEL_LIMIT_ERROR = 0x1808,
            UIIT_MSG_STRGERR_CANT_MUTATE_EQUIPED_ITEM = 0x1882,
            UIIT_MSG_STRGERR_CANT_MUTATE_SINCE_EQUIP_CLASS_TOO_HIGH = 0x1883,
            UIIT_MSG_STRGERR_INVALID_TRANSGENDER_TARGET = 0x1884,
            UIIT_MSG_STRGERR_CANT_FIND_LAST_TELEPOS = 0x1885,
            UIIT_MSG_STRGERR_CANT_FIND_LAST_DIEDPOS = 0x1886,
            UIIT_MSG_STRGERR_ONLY_THE_DEAD_CAN_USE_RESURRECT_SCROLL = 0x1887,
            UIIT_MSG_STRGERR_THERE_IS_NO_ITEM_TO_REPAIR = 0x1888,
            UIIT_SKILL_USE_FAIL_CHAR_DEAD = 0x1889,
            UIIT_MSG_STRGERR_STORAGE_OPERATION_BLOCKED = 0x1834,
            UIIT_MSG_CHAR_SKIN_ERR_ARMOR = 0x1892,
            UIIT_SKILL_USE_FAIL_OVERLAP = 0x1894,
            UIIT_MSG_STRGERR_MAX_TRADING_LIMIT_EXCEEDED = 0x1893,
            UIIT_MSG_STRGERR_ROBBER_CANT_SUMMON_CART_IN_TOWN = 0x1895,
            UIIT_MSG_CANT_STRIP_TIME_COS_RECALL = 0x189D,
            UIIT_MGS_ERR_FRPVP_DURING_CHANGE = 0x18AD,
            UIIT_MSG_COS_STATE_IS_NOT_SUMMONABLE = 0x18A4,
            UIIT_MSG_COS_CANT_SUMMON_OVER_MAX_COUNT = 0x18A8,
            UIIT_MSG_COS_CANT_SUMMON_DUPLICATE_PETTYPE = 0x18A9,
            UIIT_MSG_COSPETERR_CANT_PETSUM_HIGHLEVEL = 0x18A5,
            UIIT_MSG_COSPETERR_CANT_PETRE_DEADPET = 0x18A6,
            UIIT_MSG_COSPETERR_CANT_PETRE_BATTLE = 0x18A7,
            UIIT_MSG_COSPETERR_CANT_MOVETO_SUMITEM = 0x18B1,
            UIIT_MSG_COSPETERR_CANT_MOVETO_CHEST2 = 0x18B2,
            UIIT_MSG_COSPETERR_HGPFULL_NODRINK = 0x18B3,
            UIIT_MSG_COSPETERR_CANT_TRADE = 0x18B6,
            UIIT_MSG_COSPETERR_CANT_SELL_ACTIVATED_COSITEM = 0x18B7,
            UIIT_MSG_COSPETERR_CANT_SUMMON_FREEBATTLE = 0x18B9,
            UIIT_MSG_STRGERR_DEAL_FAIL_NON_ITEM = 0x1823,
            UIIT_MSG_GUILD_STORE_BUY_LIMIT = 0x18DB,
            UIIT_MSG_PREMIUM_USE_OVER = 0x18C6,
            UIIT_MSG_PREMIUM_NOT_USE = 0x18CC,
            UIIT_MSG_SPECIALTY_ERR_TRADESHOP = 0x18D1,
            UIIT_MSG_ERROR_RE_BUY_OBJECT_CANT = 0x18D3,
            UIIT_MSG_JOBITEM_WEAR_ERR_NOJOB = 0x189E,
            UIIT_MSG_JOBITEM_WEAR_ERR_NOALIAS = 0x189F,
            UIIT_MSG_JOBITEM_WEAR_ERR_PARTY = 0x18A0,
            UIIT_MSG_JOBITEM_WEAR_ERR_CHAO = 0x18A1,
            UIIT_MSG_JOBITEM_WEAR_ERR_NOPOSITION = 0x18A2,
            UIIT_MSG_JOBITEM_WEAR_ERR_WEARLIMIT = 0x18A3,
            UIIT_MSG_SPECIALTY_ERR_NOTSELL = 0x18AF,
            UIIT_MSG_SPECIALTY_ERR_QUEST_NOTCOMPLETE = 0x18B0,
            UIIT_MSG_GUILDWARERR_NOT_WEAR_JOBITEM = 0x18C3,
            UIIT_MSG_JOBITEM_WEAR_ERR_RIDE = 0x18CA,
            UIIT_STT_FALSE_NAME_CHANGE = 0x18FF,
            UIIT_MSG_GUILD_ITEM_RIGHT_LIMIT = 0x18BC,
            UIIT_MSG_UNION_NOT_ERROR = 0x18BD,
            UIIT_MSG_GUILD_SOLDIER_FREEPK_ERROR = 0x18C8,
            UIIT_MSG_GUILD_SOLDIER_FREEPK_ERROR_SUMMON = 0x18BE,
            UIIT_MSG_GUILD_SOLDIER_SAME_SUMMON_LIMIT = 0x18C9,
            UIIT_MSG_GUILD_SOLDIER_NOT_RIGHT = 0x18CB,
            UIIT_MSG_GUILD_SOLDIER_RACE_DIFFERENT = 0x18D2,
            UIIT_MSG_GUILD_LACK_GP = 0x18C5,
            UIIT_MSG_GUILD_RECALL_ERROR = 0x18C2,
            UIIT_MSG_GUILD_RECALL_LIMIT = 0x18C7,
            UIIT_MSG_WARENETWORK_ERROR_TRIANGLE = 0x18CD,
            UIIT_MSG_STRGERR_PARTY_INVENTORY_FULL = 0x18DA,
            UIIT_MSG_TC_LACK_HONOR_POINT = 0x18D4,
            UIIT_MSG_FORT_NOT_USE_ITEM = 0x18F4,
            UIIT_STT_FORT_ITEMUSE_ERROR_POSITION = 0x18E0,
            UIIT_STT_FORT_ITEMUSE_ERROR_FORTIN = 0x18E1,
            UIIT_STT_FORT_ITEMUSE_ERROR_FORTPERIOD = 0x18E2,
            UIIT_STT_FORT_ITEMUSE_ERROR_ONLY_ATTGUILD = 0x18E3,
            UIIT_STT_FORT_ITEMUSE_ERROR_ONLY_DEFENGUILD = 0x18E4,
            UIIT_MSG_FORT_POSITION_GRANT_FAIL_05 = 0x18E5,
            UIIT_MSG_GUILDERR_PERMISSION_DENIED = 0x18E7,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_NOTBUILD = 0x18E8,
            UIIT_MSG_FORT_PORTALSTONE_FAIL_02 = 0x18E9,
            UIIT_MSG_FORT_ITEMUSE_ERR_NOTPORTAL = 0x18EB,
            UIIT_SKILL_USE_FAIL_WRONGTARGET = 0x18ED,
            UIIT_MSG_FORT_SCROLL_FAIL = 0x18EE,
            UIIT_MSG_FORT_ITEMUSE_ERR_NUMLIMIT = 0x18EF,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_ALREADY_BUILD = 0x18F1,
            UIIT_MSG_FORT_ETC_ERROR_WRONGACTION_FORTWAR = 0x18F2,
            UIIT_MSG_ITEM_USE_REVERSE_PORTAL_RETRUN_TO_INS = 0x18F5,
            UIIT_MSG_HWANITEM_CANNOT_USE = 0x18F7,
            UIIT_MSG_NASRUN_EXTENSION_ITEM_USE_AFTER_AWAKE = 0x18F8,
            UIIT_MSG_NASRUN_NOT_AWAKE_WEAR_ERROR = 0x18F9,
            UIIT_CTL_NASRUN_NOT_TRADE = 0x18FA,
            UIIT_STT_STORAGE_EXPANSION_USE_ERORR = 0x18FE,
            UIIT_MSG_NOT_ENOUGH_COIN = 0x184A,
            UIIT_MGS_ARENA_NOT_ENOUGH_COIN = 0x184D,
            UIIT_STT_RENT_EQ_ITEM_USED_ERORR = 0x183C,
            UIIT_STT_RENT_EXP_ITEM_USED_ERORR = 0x183D,
            UIIT_MSG_SPECIALTY_ERR_NOTTRADE = 0x184E,
            UIIT_MSG_COLLECTION_WINDOW_RECORD_ERR = 0x1818,
            UIIT_MSG_PARTYMATCH_RECORD_ERROR_PARTYLEADER = 0x184F,
            UIIT_MGS_ERR_GOD_LEVEL = 0x1851,
            UIIT_MSG_INSTANCEDUNGEON_ERROR_MSG_01 = 0x1852,
            UIIT_STT_MSG_ONLY_INVENTORY_CAN_USED = 0x1859,
            UIIT_MSG_DUNGEON_FREE_TICKET_ENTERD_ERROR = 0x1855,
            UIIT_MSG_DUNGEON_FREE_TICKET_ENTERD_NOT_USED = 0x1856,
            UIIT_MSG_PARTYERR_UNKNOWN_ERROR = 2,
            UIIT_MSG_PARTYERR_INVALID_TARGET = 3,
            UIIT_MSG_PARTYERR_UNKNOWN_OPERATION = 5,
            UIIT_MSG_PARTYMATCH_ERROR_BUSY = 0x2C06,
            UIIT_MSG_PARTYERR_OUT_OF_LEVEL = 0x2C07,
            UIIT_MSG_PARTYERR_ALREADY_FULL = 0x2C08,
            UIIT_MSG_PARTYERR_TOO_LOW_CREATOR_LEVEL = 0x2C0A,
            UIIT_MSG_PARTYERR_CREATE_PARTY_REFUSED = 0x2C0C,
            UIIT_MSG_PARTYERR_CANT_FIND_PARTY = 0x2C1C,
            UIIT_MSG_PARTYERR_CANT_FIND_CREATER = 0x2C0E,
            UIIT_MSG_PARTYERR_INVALID_USER = 0x2C0F,
            UIIT_MSG_PARTYERR_TIMEOUT = 0x2C10,
            UIIT_MSG_PARTYERR_CREATER_LEFT_PARTY = 0x2C11,
            UIIT_MSG_PARTYERR_MEMBER_FULL_EXP_SHARED_PARTY = 0x2C13,
            UIIT_MSG_PARTYERR_MEMBER_FULL_NONEEXP_SHARED_PARTY = 0x2C14,
            UIIT_MSG_PARTYERR_JOIN_PARTY_REFUSED = 0x2C17,
            UIIT_MSG_PARTYERR_MEMBER_OF_ANOTHER_PARTY = 0x2C18,
            UIIT_MSG_PARTYMATCH_JOIN_ERROR_DUPLE = 0x2C24,
            UIIT_MSG_PARTYMATCH_JOIN_ERROR_LEVEL = 0x2C1E,
            UIIT_MSG_PARTYMATCH_RECORD_ERROR_AGAIN = 0x2C1B,
            UIIT_MSG_PARTYMATCH_RECORD_ERROR_INVITE = 0x2C25,
            UIIT_MSG_JOBITEM_WEAR_ERR_PARTYMATCH = 0x2C26,
            UIIT_MGS_ARENA_ERR_CANT_PARTY_WITH_OPPONENT_IN_BATTLE_ARENA = 0x2C28,
            UIIT_MGS_ARENA_ERR_FREGIST_PARTY_IN_BATTLE_ARENA = 0x2C29,
            UIIT_MGS_GHOST_ERR_CANT_PARTY_WITH_OPPONENT_IN_GHOST = 0x2C2E,
            UIIT_MGS_GHOST_ERR_FREGIST_PARTY_IN_GHOST = 0x2C2F,
            UIIT_MSG_PARTY_USER_MISSMATCH = 0x2C23,
            UIIT_MSG_PARTYERR_EXISTING_MEMBER = 0x2C12,
            UIIT_SKILL_USE_FAIL_NOTLEARN = 0x3003,
            UIIT_SKILL_USE_FAIL_NOTENOUGHMP = 0x3004,
            UIIT_SKILL_USE_FAIL_NOTENOUGHHP = 0x3013,
            UIIT_SKILL_USE_FAIL_TIMEDELAY_COOL_TIME = 0x3005,
            UIIT_SKILL_USE_FAIL_WRONGDISTANCE = 0x3007,
            UIIT_SKILL_USE_FAIL_NOTENOUGHLEVEL = 0x3008,
            UIIT_SKILL_USE_FAIL_WRONGWEAPON = 0x300D,
            UIIT_SKILL_USE_FAIL_BROKEN_WEAPON = 0x300F,
            UIIT_SKILL_USE_FAIL_PATH_INTERRUPTED = 0x3010,
            UIIT_SKILL_USE_FAIL_NONESELECTETARGET = 0x3011,
            UIIT_SKILL_USE_FAIL_RESURRECT = 0x3012,
            UIIT_MSG_SKILL_USE_FAIL_DAILY_PKLIMIT_EXCEEDED = 0x3014,
            UIIT_MSG_SKILL_USE_FAIL_TOTAL_PKLIMIT_EXCEEDED = 0x3015,
            UIIT_MSG_SKILL_USE_FAIL_ITS_NOT_A_BATTLE_FIELD = 0x3018,
            UIIT_MSG_SKILL_USE_FAIL_WAITFOR_JOB_ACTIVATE = 0x3019,
            UIIT_MSG_SKILL_USE_FAIL_CANT_USESKILL_IN_RIDESTATE = 0x3021,
            UIIT_MSG_SKILL_USE_FAIL_CANT_ATTACK_PARTY_MEMBER = 0x3022,
            UIIT_MSG_SKILL_USE_FAIL_CANT_ATTACK_PARTYMEMBERS_COS = 0x3023,
            UIIT_MSG_SKILL_USE_FAIL_CANT_ATTACK_CARAVAN_LEVEL1 = 0x3024,
            UIIT_MSG_SKILL_USE_FAIL_PK_PROHIBITED_IN_THIS_SERVER = 0x3025,
            UIIT_STT_SKILLUSE_FAIL_CANT_BATTLE_STATE = 0x3028,
            UIIT_STT_SKILL_USE_FAIL_OVERLAP_COUNT = 0x3029,
            UIIT_STT_EU_BAN_TRANS_SKILL = 0x3030,
            UIIT_STT_EU_BAN_HAWN_TRANS = 0x3031,
            UIIT_STT_SKILL_USE_FAIL_MUSICAL_RANGE = 0x3032,
            UIIT_STT_SKILL_USE_FAIL_MONSTER_CLASS = 0x3033,
            UIIT_STT_SKILL_USE_DO_STEALTH = 0x3034,
            UIIT_STT_SKILL_USE_FAIL_TARGET_LV = 0x3035,
            UIIT_STT_SKILL_USE_FAIL_GROGGY = 0x3036,
            UIIT_MSG_QUEST_ERR_CANNOT_MAKE_TRAP = 0x3037,
            UIIT_MSG_QUEST_ERR_CANNOT_MAKE_TRAP_EXIST_MONSTER = 0x3038,
            UIIT_SKILL_USE_FAIL_DUPLICATE = 0x3039,
            UIIT_MSG_FORT_BATTLE_ERR_CANT_ATTACK_GUILD = 0x303B,
            UIIT_MSG_FORT_BATTLE_ERR_CANT_ATTACK_ALLYGUILD = 0x303C,
            UIIT_MSG_FORT_BATTLE_ERR_CAN_ATTACK_ONLYSIEGEWEAPON = 0x303D,
            UIIT_MSG_FORT_BATTLE_ERR_CAN_ATTACK_DEFGUILD = 0x303E,
            UIIT_MSG_FORT_BATTLE_ERR_CAN_ATTACK_ATTGUILD = 0x303F,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_NOTDESTROYGUARD = 0x3040,
            UIIT_MSG_FORT_BATTLE_ERR_CAN_ONLYPERIODFORT = 0x3043,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_06 = 0x282F,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_DELAYTIME = 0x3046,
            UIIT_MGS_ARENA_FLAG_OWNER_CANT_USE_SKILL = 0x3048,
            UIIT_MSG_GHOST_CANT_SKILL = 0x301B,
            UIIT_STT_SKILL_POINT_INSUFFICIENCY = 0x340A,
            UIIT_STT_SKILL_LEARN_INT_INSUFFICIENCY = 0x3404,
            UIIT_STT_SKILL_LEARN_STR_INSUFFICIENCY = 0x3403,
            UIIT_STT_SKILL_LEARN_MASTERY_TOTAL_LIMIT = 0x3805,
            UIIT_STT_SKILL_LEARN_MASTERY_LIMIT = 0x3804,
            UIIT_STT_SKILL_POINT_INSUFFICIENCY_MASTERY = 0x3802,
            UIIT_MSG_WITHDRAW_SKILL_FAIL_NOT_LEARN = 0x7801,
            UIIT_MSG_WITHDRAW_SKILL_FAIL_INVALID_LEVEL = 0x7802,
            UIIT_MSG_WITHDRAW_SKILL_FAIL_UNKNOWN = 0x7803,
            UIIT_MSG_WITHDRAW_SKILL_FAIL_NOT_ENOUGH_GOLD = 0x7804,
            UIIT_MSG_WITHDRAW_SKILL_FAIL_NOT_ENOUGH_POTION = 0x7805,
            UIIT_MSG_WITHDRAW_SKILL_FAIL_DEPENDANCY_LIMIT = 0x7806,
            UIIT_MSG_FLEAMARKET_ERR_INVALID_PRICE = 0x3C08,
            UIIT_MSG_FLEAMARKET_ERR_NOTHING_TO_SELL = 0x3C0C,
            UIIT_MSG_FLEAMARKET_ERR_MARKET_CLOSED = 0x3C0E,
            UIIT_MSG_FLEAMARKET_ERR_NOT_ENOUGH_GOLD = 0x3C52,
            UIIT_MSG_FLEAMARKET_ERR_INVENTORY_FULL = 0x3C53,
            UIIT_MSG_FLEAMARKET_ERR_HOST_LEFT = 0x3C15,
            UIIT_MSG_FLEAMARKET_ERR_IM_BUSY = 0x3C16,
            UIIT_MSG_FLEAMARKET_ERR_CLOSED_BY_HOST = 0x3C17,
            UIIT_MSG_FLEAMARKET_ERR_MARKET_FULL = 0x3C18,
            UIIT_MSG_FLEAMARKET_ERR_INVALID_HOST_STATE = 0x3C2B,
            UIIT_MSG_FLEAMARKET_ERR_CUSTOMER_BANNED = 0x3C2C,
            UIIT_MSG_FLEAMARKET_ERR_CANT_OPEN_MARKET_IN_RIDESTATE = 0x3C34,
            UIIT_MSG_FLEAMARKET_ERR_NOT_ALLOWED_FMARKETNAME = 0x3C38,
            UIIT_MSG_FLEAMARKET_ERR_CANT_OPEN_MARKET_MURDERER = 0x3C39,
            UIIT_MSG_FREEMARKET_NOTUSE_JOB = 0x3C3B,
            UIIT_MSG_WARENETWORK_ERROR_FAIL = 0x3C43,
            UIIT_MSG_WARENETWORK_SCAN_FAIL = 0x3C46,
            UIIT_MSG_WARENETWORK_USE_CITY = 0x3C49,
            UIIT_MSG_WARENETWORK_BUY_ERROR = 0x3C51,
            UIIT_MSG_COSPETERR_CANT_PICKITEM1 = 0x18B4,
            UIIT_MSG_COSPETERR_CANT_PICKITEM2 = 0x18B5,
            UIIT_MSG_COSERR_YOU_DONT_HAVE_ACTIVE_COS_OBJ = 0x4406,
            UIIT_MSG_COSERR_YOU_CANT_CONTROL_THIS_OBJ = 0x4407,
            UIIT_MSG_COSERR_CANT_SELL_RIDING_COS = 0x4409,
            UIIT_MSG_COSERR_CANT_SELL_REQUESTED_COS = 0x440A,
            UIIT_MSG_COSERR_CANT_SELL_COS_HAVE_ITEMS = 0x440B,
            UIIT_MSG_COSPETERR_PETNAME_NOTPUT = 0x440E,
            UIIT_MSG_COSPETERR_PETNAME_SUMENESS = 0x440F,
            UIIT_MSG_COSPETERR_CANT_DEACTIVATE_IN_DEADSTATE = 0x4411,
            UIIT_MSG_INTERACTION_FAIL_I_DONT_HAVE_ANYTHING_FOR_YOU = 0x1C06,
            UIIT_MSG_INTERACTION_FAIL_NOT_ENOUGH_MONEY = 0x1C07,
            UIIT_MSG_INTERACTION_FAIL_IM_BUSY = 0x1C0B,
            UIIT_MSG_INTERACTION_FAIL_CANT_USE_TELEPORT_WITH_TRADECART = 0x1C10,
            UIIT_MSG_INTERACTION_FAIL_TOO_FAR_FROM_TRADECART = 0x1C13,
            UIIT_MSG_INTERACTION_FAIL_TELESCROLL_ALREADY_WORKING = 0x1C14,
            UIIT_MSG_INTERACTION_FAIL_CANNOT_BE_REPAIRED = 0x1C11,
            UIIT_MSG_INTERACTION_FAIL_CANNOT_BE_REVIVED = 0x1C12,
            UIIT_MSG_INTERACTION_FAIL_OUT_OF_REQUIRED_LEVEL_FOR_TELEPORT = 0x1C15,
            UIIT_MSG_INTERACTION_FAIL_MURDERER_CAN_USE_PORTAL_STRUCTURE = 0x1C16,
            UIIT_INTERACTION_FAIL_ONLY_ROBBER_CAN_TELEPORT_TO_THIEFDEN = 0x1C18,
            UIIT_MSG_NEWBIE_RETURN_LV20_OVER = 0x1C20,
            UIIT_MSG_NEWBIE_RETURN_ERROR = 0x1C21,
            UIIT_MSG_FORT_ENTRANCE_FORTRESS_FAIL_01 = 0x1C1A,
            UIIT_MSG_FORT_PORTALSTONE_FAIL_04 = 0x1C1B,
            UIIT_MSG_FORT_ENTRANCE_FORTRESS_FAIL_02 = 0x1C1C,
            UIIT_MSG_FORT_NOT_POSSESS_FORTRESS_MEMBER = 0x1C1D,
            UIIT_MSG_FORT_ETC_ERR_CANT_ENTER_5MINBEFORE = 0x1C1E,
            UIIT_MSG_QUEST_ROC_CANNOT_ENTRANCE = 0x1C23,
            UIIT_MSG_INTERACTION_FAIL_OUT_OF_REQUIRED_NUMBER_FOR_TELEPORT = 0x1C25,
            UIIT_MSG_EGYPT_TOMB_ENTRANCE_CONDITION_ERROR_01 = 0x1C27,
            UIIT_MSG_EGYPT_TOMB_ENTRANCE_CONDITION_ERROR_02 = 0x1C28,
            UIIT_MSG_EGYPT_TOMB_ENTRANCE_CONDITION_ERROR_05 = 0x1C2A,
            UIIT_MSG_FLAGWAR_GAME_JOB_NOT_ENTER = 0x1C2B,
            UIIT_MSG_EGYPT_SHRINE_ENTRANCE_CONDITION_ERROR_01 = 0x1C2C,
            UIIT_MSG_EGYPT_SHRINE_ENTRANCE_CONDITION_ERROR_04 = 0x1C2D,
            UIIT_MSG_EGYPT_SHRINE_ENTRANCE_CONDITION_ERROR_03 = 0x1C2E,
            UIIT_MSG_EGYPT_SHRINE_ENTRANCE_CONDITION_ERROR_02 = 0x1C2F,
            UIIT_MSG_INTERACTION_FAIL_CANT_USE_TELEPORT_WITH_RIDE = 0x1C30,
            UIIT_MSG_INSTANCEDUNGEON_ERROR_MSG_02 = 0x1C31,
            UIIT_MSG_EGYPT_MENU_ERROR_UNIONMEMBER = 0x1C26,
            UIIT_MGS_ERR_GOD_LIMIT_TIME = 0x1C32,
            UIIT_MGS_ERR_GOD_TELEPORT_HOLE_NOT_PARTY = 0x1C33,
            UIIT_MGS_ERR_GOD_INS_WORLD = 0x1C35,
            UIIT_MGS_ERR_GOD_DEADSTATE = 0x1C36,
            UIIT_MGS_ERR_GOD_TELEPORT_HOLE_NOT_TOWN = 0x1C37,
            UIIT_MGS_ERR_GOD_BATTLE_STATE = 0x1C38,
            UIIT_MGS_ERR_GOD_GUILD = 0x1C39,
            UIIT_MSG_LOGOUT_ERR_CANT_LOGOUT_WHILE_TELEPORT_WORKING = 0x802,
            UIIT_MSG_LOGOUT_ERR_CANT_LOGOUT_IN_BATTLE_STATE = 0x801,
            UIIT_MSG_GUILDERR_TARGET_BUSY = 0x4C06,
            UIIT_MSG_GUILDERR_IM_DEAD = 0x4C07,
            UIIT_MSG_GUILDERR_TOO_LOW_CREATOR_LEVEL = 0x4C0A,
            UIIT_MSG_GUILDERR_NOT_ENOUGH_GOLD = 0x4C0C,
            UIIT_MSG_GUILDERR_EXISTING_MEMBER = 0x4C12,
            UIIT_MSG_GUILDERR_MEMBER_FULL = 0x4C13,
            UIIT_MSG_GUILDERR_JOIN_GUILD_REFUSED = 0x4C16,
            UIIT_MSG_GUILDERR_MEMBER_OF_ANOTHER_GUILD = 0x4C17,
            UIIT_MSG_GUILDERR_INVALID_GUILDNAME_LEN = 0x4C18,
            UIIT_MSG_GUILDERR_NOT_ALLOWED_GUILDNAME = 0x4C19,
            UIIT_MSG_GUILDERR_SAME_GUILDNAME_EXIST = 0x4C1A,
            UIIT_MSG_GUILDERR_CANT_CREATE_GUILD_IN_DB = 0x4C1B,
            UIIT_MSG_GUILDERR_CANT_ADD_MEMBER_IN_DB = 0x4C1C,
            UIIT_MSG_GUILDERR_CANT_FIND_MEMBER = 0x4C1D,
            UIIT_MSG_ERROR_GUILD_LEVEL_UP_FULL = 0x4C21,
            UIIT_MSG_GUILDERR_INVALID_MASTER_COMMENT_TITLE = 0x4C22,
            UIIT_MSG_GUILDERR_INVALID_MASTER_COMMENT = 0x4C23,
            UIIT_MSG_GUILDERR_TARGET_PERMISSION_DENIED = 0x4C24,
            UIIT_MSG_GUILDERR_CANT_ALLY_TO_OWN_GUILD = 0x4C26,
            UIIT_MSG_GUILDERR_ALREADY_ALLIED = 0x4C27,
            UIIT_MSG_GUILDERR_TARGET_GUILD_HAS_ALLIANCE_ALREADY = 0x4C28,
            UIIT_MSG_GUILDERR_ALLIANCE_FULL = 0x4C29,
            UIIT_MSG_GUILDERR_TOO_LOW_CREATOR_ALLIANCE = 0x4C2A,
            UIIT_MSG_GUILDERR_TOO_LOW_JOINER_ALLIANCE = 0x4C2B,
            UIIT_MSG_ERROR_GUILD_LEVEL_UP_GOLD_DEFICIT = 0x4C31,
            UIIT_MSG_ERROR_GUILD_LEVEL_UP_GP_DEFICIT = 0x4C32,
            UIIT_MSG_GUILD_EXPULSION_NOTEXP = 0x4C36,
            UIIT_MSG_MRELEASEERR_NOTSECEDE = 0x4C38,
            UIIT_MSG_MRELEASEERR_NOTREMOVE = 0x4C39,
            UIIT_MSG_GUILDERR_CANT_FIND_TARGET_GUILD = 0x4C25,
            UIIT_MSG_GUILDWARERR_ENEMYGUILD = 0x4C3A,
            UIIT_MSG_GUILDERR_TARGET_GUILD_MASTER_IS_NOT_IN_GAME = 0x4C3B,
            UIIT_MSG_GUILDWARERR_ALLYGUILD = 0x4C41,
            UIIT_MSG_QUESTION_GUILD_RESPECT_ALLY_NOTALLY = 0x4C42,
            UIIT_MSG_GUILD_ERROR_BREAK_WAR = 0x4C46,
            UIIT_MSG_GUILDWARERR_GUILD_CREATE_PENALTY = 0x4C3C,
            UIIT_MSG_GUILD_PENALTY = 0x4C3D,
            UIIT_MSG_GUILDWARERR_MAX_HOSTILE_GUILD = 0x4C3E,
            UIIT_MSG_GUILDWARERR_TARGET_MAX_HOSTILE_GUILD = 0x4C3F,
            UIIT_CTL_GUILD_JOIN_JOB_ERROR = 0x4C56,
            UIIT_CTL_GUILD_CREATE_JOB_ERROR = 0x4C57,
            UIIT_MSG_GUILD_UNION_CHAT_FULL = 0x4C4B,
            UIIT_MSG_GUILD_WAREHOUSE_INTERRUPT = 0x4C48,
            UIIT_MSG_GUILD_WAREHOUSE_LIMIT = 0x4C4A,
            UIIT_MSG_GUILD_WAREHOUSE_USE_ING = 0x4C4C,
            UIIT_MSG_GUILD_ERROR_NAME_GRANT_SPECIAL_LETTER = 0x4C4D,
            UIIT_MSG_GUILD_SOLDIER_ABILITY_OVER = 0x4C53,
            UIIT_MSG_GUILD_SOLDIER_ABILITY_SELECT_ERROR = 0x4C54,
            UIIT_MSG_GUILD_SOLDIER_LEAVE_MASTER_ERROR = 0x4C55,
            UIIT_MSG_FORT_POSITION_GRANT_FAIL_04 = 0x4C58,
            UIIT_MSG_FORT_POSITION_GRANT_FAIL_03 = 0x4C59,
            UIIT_MSG_FORT_POSITION_GRANT_FAIL_02 = 0x4C5A,
            UIIT_MSG_FORT_POSITION_GRANT_FAIL_06 = 0x4C5C,
            UIIT_MSG_FORT_POSITION_GRANT_FAIL_01 = 0x4C5D,
            UIIT_MGS_ARENA_ERR_FREQUEST_WAR_IN_BATTLE_ARENA = 0x4C7A,
            UIIT_MGS_GHOST_ERR_FREQUEST_WAR_IN_GHOST = 0x4C7B,
            UIIT_MSG_JSERR_ROBBER_CANT_ENTER_TOWN_WITH_CART = 0xC01,
            UIIT_MSG_JSERR_PREVIOUS_TELEPORT_WORKING = 0xC03,
            UIIT_MSG_COS_CAN_NOT_ENTER_DUNGEON = 0xC04,
            UIIT_MSG_SPECIALTY_ANNOUNCE_SELL_READY = 0xC08,
            UIIT_MSG_SPECIALTY_ANNOUNCE_SELL_START = 0xC09,
            UIIT_MSG_SPECIALTY_ANNOUNCE_SELL_END = 0xC0A,
            UIIT_MSG_JSERR_LOGOUT_ALLOWED = 0xC0D,
            UIIT_MSG_ENCHANT_FAILED = 0x5423,
            UIIT_MSG_ENCHANT_NOT_ENOUGH_ITEM = 0x67,
            UIIT_STRGERR_CANNOT_BE_USED_TO_TARGET = 0x5811,
            UIIT_MSG_ALCHEMY_NOT_ENOUGH_INVENTORY = 0x5808,
            UIIT_MSG_ENCHANTERR_RONDO2_UNREPAIRABLE_ITEM = 0x5813,
            UIIT_MSG_TC_ERROR_NOT_RONDO_HONOR_ITEM = 0x5815,
            UIIT_STT_NASRUN_NOT_BREAK = 0x5817,
            UIIT_MSG_ENCHANT_SLOT_MISMATCH_REINFORCE = 0x64,
            UIIT_MSG_REINFORCERR_TARGET_EQUIP_NOT_LOADED = 0x5406,
            UIIT_MSG_REINFORCERR_LOAD_EQUIP_FIRST = 0x5415,
            UIIT_MSG_REINFORCERR_RECIPE_NOT_LOADED = 0x5407,
            UIIT_MSG_REINFORCERR_ONLY_EQUIPITEM_CAN_BE_REINFORCED = 0x5408,
            UIIT_MSG_REINFORCERR_RECIPE_MISMATCH = 0x5427,
            UIIT_MSG_REINFORCERR_EQUIPCLASS_MISMATCH_PROB_UP = 0x540A,
            UIIT_MSG_REINFORCERR_EQUIPCLASS_MISMATCH_ATHANASIA = 0x540B,
            UIIT_MSG_REINFORCERR_EQUIPCLASS_MISMATCH_SOLID = 0x540C,
            UIIT_MSG_REINFORCERR_OPTLEVEL_MISMATCH_ATHANASIA = 0x540D,
            UIIT_MSG_REINFORCERR_OPTLEVEL_MISMATCH_SOLID = 0x540E,
            UIIT_MSG_REINFORCERR_TARGETEQUIP_CANT_BE_REINFORCED = 0x540F,
            UIIT_MSG_REINFORCERR_IS_NOT_REINFORCE_STUFF = 0x5410,
            UIIT_MSG_REINFORCERR_STUFF_CANT_BE_LOADED_MULTIPLE_TIME = 0x5412,
            UIIT_MSG_REINFORCERR_NO_ITEM_LOADED = 0x5413,
            UIIT_MSG_REINFORCERR_INVALID_ITEM_SLOT = 0x5414,
            UIIT_MSG_REINFORCERR_CANNOT_OPEN_FLEAMARKET = 0x5416,
            UIIT_MSG_REINFORCERR_CANNOT_JOIN_FLEAMARKET = 0x5417,
            UIIT_MSG_REINFORCERR_CANNOT_USE_ALCHEMY_AT_FLEAMARKET = 0x5418,
            UIIT_MSG_REINFORCERR_CANNOT_TRADE = 0x5419,
            UIIT_MSG_STRGERR_ASTRAL = 0x5424,
            UIIT_MSG_ENCHANT_EQUIPCLASS_MISMATCH = 0x5421,
            UIIT_MSG_STRGERR_MAGICSTONE2_MAX = 0x5422,
            UIIT_MSG_TC_ERROR_ENCHANT_HONOR_ITEM = 0x5425,
            UIIT_MSG_REINFORCERR_ALREADY_DONE = 0x5426,
            UIIT_MSG_STRGERR_MAGICSTONE_LUCK_MAX = 0x64,
            UIIT_MSG_STRGERR_MAGICSTONE_ATHANASIA_MAX = 0x65,
            UIIT_MSG_STRGERR_MAGICSTONE_SOLID_MAX = 0x66,
            UIIT_MSG_ENCHANT_SLOT_MISMATCH_MAGICSTONE = 0x68,
            UIIT_MSG_FRIENDERR_FULLLIST = 0x6408,
            UIIT_MSG_FRIENDERR_ALREADYFRIEND = 0x6409,
            UIIT_MSG_FRIEND_SYSCANCEL = 0x640A,
            UIIT_MSG_FRIENDERR_REFUSAL = 0x640B,
            UIIT_MSG_FRIENDERR_UNKNOWNUSER = 0x640D,
            UIIT_MSG_FRIEND_SYSPROGRESS = 0x640E,
            UIIT_MSG_FRIENDERR_TARGETLISTFULL = 0x640F,
            UIIT_STT_ERR_COMMON_INVALID_TARGET = 3,
            UIIT_MSG_TC_ERROR_DIE_PASSING = 0x6807,
            UIIT_MSG_TC_ERROR_OPEN_LEVEL = 0x6809,
            UIIT_MSG_TC_ERROR_OPEN_GOLD = 0x680A,
            UIIT_MSG_TC_ERROR_TRAININGCAMP_NOTHING = 0x680B,
            UIIT_MSG_TC_ERROR_TRAININGCAMP_ALREADY_ENTRY = 0x680F,
            UIIT_MSG_TC_ERROR_OTHER_TRAININGCAMP_ENTRY = 0x6812,
            UIIT_MSG_TC_ERROR_SECOND_GUARDIAN_COUNT_OVER = 0x6810,
            UIIT_MSG_TC_ERROR_STUDENT_COUNT_OVER = 0x6828,
            UIIT_MSG_TC_ERROR_INVITE_REJECTION = 0x6811,
            UIIT_MSG_TC_ERROR_ORDER_WORK = 0x6816,
            UIIT_MSG_GUILD_COMMON_NOTEXIST = 0x6817,
            UIIT_MSG_TC_ERROR_GRADUATION_LEVER = 0x681A,
            UIIT_MSG_TC_ERROR_NOT_OPEN_7D = 0x681C,
            UIIT_MSG_TC_ERROR_ALREADY_OPEN = 0x6825,
            UIIT_MSG_TC_ERROR_NOT_INVITE_24T = 0x681F,
            UIIT_MSG_TC_ERROR_NOT_OUT_24T = 0x6821,
            UIIT_MSG_TC_ERROR_POSIBLE_41L = 0x6822,
            UIIT_MSG_TC_ERROR_JOB_DRESS = 0x6823,
            UIIT_MSG_TC_ERROR_NOT_INFORMATION = 0x6826,
            UIIT_MSG_TC_ERROR_NOT_POSITION = 0x6824,
            UIIT_MSG_TC_ERROR_NOT_ENTRY_24T = 0x681E,
            UIIT_MSG_TC_ERROR_NOT_BAN_24T = 0x6820,
            UIIT_MSG_TC_ERROR_NOT_DISORGANIZATION_7D = 0x681D,
            UIIT_STT_TC_BAN_MACHING_ERROR = 0x6829,
            UIIT_MSG_TC_ERROR_INVITE_TYPE_DIFFERENT = 0x682A,
            UIIT_MSG_AVATAR_MAGICOPTION_ADD_ERORR = 6,
            UIIT_STT_AVATAR_MAGICOPTION_ADD_FAIL = 7,
            UIIT_STT_AVATAR_MAGICOPTION_ONLY_AVATAR = 8,
            UIIT_STT_AVATAR_MAGICOPTION_WRONG = 0xA,
            UIIT_MSG_MLEAVEERR_USERNOTEXIST = 0x640D,
            UIIT_MSG_LETTERERR_SENDERR = 0x6410,
            UIIT_MSG_LETTERERR_FULLLETTERBOX = 0x6414,
            UIIT_MSG_MRELEASEERR_NOTVOTING = 0x5008,
            UIIT_MSG_JOBGUILD_JOIN_ERR_LEVEL = 0x4819,
            UIIT_MSG_JOBGUILD_JOIN_ERR_OVERLAP = 0x4820,
            UIIT_MSG_JOBITEM_WEAR_ERR_NOGUILD = 0x4821,
            UIIT_CTL_JOBGUILD_WITHD_ERR_WEARITEM = 0x4822,
            UIIT_MSG_ALIAS_CREATE_ERR_NOTRULE = 0x4823,
            UIIT_MSG_JOBGUILD_JOIN_ERR_EXPIRE = 0x4824,
            UIIT_MSG_ALIAS_CREATE_ERR_NAMEDULPLICATE = 0x4826,
            UIIT_MSG_JOBINFO_OLD_NOTEXIST = 0x4829,
            UIIT_MSG_PARTYMATCH_RECORD_ERROR_JOBWITHDRAW = 0x482B,
            UIIT_MSG_JOBGUILD_WITHD_ERR_QUEST = 0x482E,
            UIIT_MSG_COS_BAN_FOLLOW_COS = 0x4005,
            UIIT_SKILL_USE_FAIL_SEALED = 0x4002,
            UIIT_MSG_FORT_ETC_ERROR_ONLYGUILDMASTER_ACTION = 0x2807,
            UIIT_MSG_FORT_MANAGER_TAX_ERROR_01 = 0x2808,
            UIIT_MSG_FORT_MANAGER_EMPLOY_DUPLICATE = 0x2809,
            UIIT_MSG_FORT_SMITH_PRODUCT_ERROR_01 = 0x280A,
            UIIT_MSG_FORT_ETC_ERROR_NOTJOINGUILD = 0x280B,
            UIIT_MSG_FORT_ETC_ERROR_TOOLESSGUILDLV = 0x280C,
            UIIT_MSG_FORT_ETC_ERROR_TOOLESSGUILDMB = 0x280D,
            UIIT_MSG_FORT_OFFICIAL_FORTWAR_APPLY_ERROR_03 = 0x2810,
            UIIT_MSG_FORT_ETC_ERROR_ALREADYPOSSESSFORT = 0x2811,
            UIIT_MSG_FORT_ETC_ERROR_WRONGALLIANCE = 0x2812,
            UIIT_MSG_FORT_OFFICIAL_FORTWAR_APPLY_ERROR_01 = 0x2813,
            UIIT_MSG_FORT_OFFICIAL_FORTWAR_APPLY_ERROR_02 = 0x2814,
            UIIT_MSG_FORT_MANAGER_TAX_ERROR_02 = 0x2815,
            UIIT_MSG_FORT_SMITH_PRODUCT_ERROR_02 = 0x2816,
            UIIT_MSG_FORT_SMITH_PRODUCT_ERROR_03 = 0x2819,
            UIIT_MSG_FORT_SMITH_PRODUCT_ERROR_04 = 0x281A,
            UIIT_MSG_FORT_SMITH_PRODUCT_ERROR_05 = 0x281B,
            UIIT_MSG_FORT_SMITH_PRODUCT_ERROR_06 = 0x281D,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_01 = 0x2832,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_02 = 0x283C,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_03 = 0x2829,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_04 = 0x282A,
            UIIT_MSG_FORT_STRUCTURE_ACTION_ERROR_05 = 0x282B,
            UIIT_MSG_FORT_BATTLEAIDE_REPAIR_FAIL = 0x2830,
            UIIT_MSG_FORT_BATTLEAIDE_UPGRADE_FAIL2 = 0x2834,
            UIIT_MSG_FORT_BATTLEAIDE_UPGRADE_FAIL = 0x2836,
            UIIT_MSG_FORT_BATTLEAIDE_UPGRADE_FAIL3 = 0x2837,
            UIIT_MSG_FORT_BATTLEAIDE_UPGRADE_FAIL4 = 0x2839,
            UIIT_MSG_FORT_MANAGER_TAX_ERROR_03 = 0x2838,
            UIIT_MSG_FORT_PORTALSTONE_FAIL_01 = 0x7C08,
            UIIT_MSG_FORT_PORTALSTONE_FAIL_03 = 0x7C07,
            UIIT_STT_OPEN_MARKET_ENTER_PAGE_ERROR = 0x7007,
            UIIT_STT_OPEN_MARKET_ENTER_ERROR = 0x7008,
            UIIT_STT_OPEN_MARKET_SELL_IMPOSSIBLE = 0x700B,
            UIIT_MSG_GUILD_LACK_GOLD = 0x700D,
            UIIT_STT_OPEN_MARKET_BUYING_ERROR = 0x701A,
            UIIT_STT_OPEN_MARKET_FIND_ERROR = 0x701B,
            UIIT_STT_OPEN_MARKET_COST_OVER_ERROR = 0x701C,
            UIIT_STT_OPEN_MARKET_TEXT_ERROR = 0x701D,
            UIIT_STT_OPEN_MARKET_RECEIPTED_ITEM_ERROR = 0x701E,
            UIIT_STT_OPEN_MARKET_CANCEL_ITEM_ERROR = 0x7020,
            UIIT_STT_OPEN_MARKET_MIN_TEXT_ERROR = 0x7021,
            UIIT_STT_OPEN_MARKET_ENTERD_PET_ERROR = 0x7022,
            UIIT_STT_PARTY_SUMMON_IMPOSSILBE_1 = 0x1C37,
            UIIT_STT_PARTY_SUMMON_IMPOSSILBE_2 = 0x1C25,
            UIIT_STT_PARTY_SUMMON_IMPOSSILBE_3 = 0x1C2C,
            UIIT_STT_PARTY_SUMMON_IMPOSSILBE_4 = 0x1C2B,
            UIIT_STT_PARTY_SUMMON_IMPOSSILBE_6 = 0x1C30,
            UIIT_STT_PARTY_SUMMON_IMPOSSILBE_7 = 0x1C39,
            UIIT_STT_PARTY_SUMMON_IMPOSSILBE_8 = 0x1C36,
            UIIT_STT_PARTY_SUMMON_WAIT_ERR = 0x1C3A,
            UIIT_STT_BOX_INVEN_FULL = 0x9404,
            UIIT_STT_BOX_INVENL_NOT_ENOUGH = 0x9403;
    }
}

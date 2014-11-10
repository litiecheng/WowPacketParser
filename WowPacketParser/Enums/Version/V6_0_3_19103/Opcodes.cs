using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V6_0_3_19103
{
    public static class Opcodes_6_0_3
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ACTIVATETAXI, 0x0311 | 0x10000},
            {Opcode.CMSG_ACTIVATETAXIEXPRESS, 0x1B52 | 0x10000},
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x03F4 | 0x10000},
            {Opcode.CMSG_ADD_FRIEND, 0x0DB9},
            {Opcode.CMSG_ADD_IGNORE, 0x1321},
            {Opcode.CMSG_ADD_MUTE, 0x098A},
            {Opcode.CMSG_AREATRIGGER, 0x01B4},
            {Opcode.CMSG_ATTACKSTOP, 0x065B},
            {Opcode.CMSG_ATTACKSWING, 0x1E9B},
            {Opcode.CMSG_AUCTION_HELLO, 0x13EA},
            {Opcode.CMSG_AUTH_CONTINUED_SESSION, 0x0485},
            {Opcode.CMSG_AUTH_SESSION, 0x0487},
            {Opcode.CMSG_BANKER_ACTIVATE, 0x1B24},
            {Opcode.CMSG_BATTLE_PET_NAME_QUERY, 0x041C},
            {Opcode.CMSG_BATTLE_PAY_GET_PRODUCT_LIST_QUERY, 0x1389},
            {Opcode.CMSG_BATTLE_PAY_GET_PURCHASE_LIST_QUERY, 0x120C},
            {Opcode.CMSG_BINDER_ACTIVATE, 0x02F3},
            {Opcode.CMSG_BUYBACK_ITEM, 0x02D3},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x0A25 | 0x10000},
            {Opcode.CMSG_CANCEL_AURA, 0x08AE},
            {Opcode.CMSG_CANCEL_TRADE, 0x1159},
            {Opcode.CMSG_CAST_SPELL, 0x08FE},
            {Opcode.CMSG_CHAR_CREATE, 0x070D},
            {Opcode.CMSG_CHAR_CUSTOMIZE, 0x072A},
            {Opcode.CMSG_CHAR_DELETE, 0x030E},
            {Opcode.CMSG_CHAR_ENUM, 0x0918},
            {Opcode.CMSG_CHAR_RACE_OR_FACTION_CHANGE, 0x1209},
            {Opcode.CMSG_CHAR_RENAME, 0x038B | 0x10000},
            {Opcode.CMSG_CHAR_UNDELETE_ENUM, 0x0F2D},
            {Opcode.CMSG_CREATURE_QUERY, 0x0505},
            {Opcode.CMSG_DB_QUERY_BULK, 0x138B | 0x10000},
            {Opcode.CMSG_DEL_FRIEND, 0x0F2A | 0x10000},
            {Opcode.CMSG_DEL_IGNORE, 0x033D},
            {Opcode.CMSG_DEL_MUTE, 0x0128},
            {Opcode.CMSG_DESTROY_ITEM, 0x01EE},
            {Opcode.CMSG_ENABLETAXI, 0x00D2},
            {Opcode.CMSG_EQUIPMENT_SET_SAVE, 0x1B54},
            {Opcode.CMSG_FACTION_BONUS_INFO, 0x0928},
            {Opcode.CMSG_FORCE_MOVE_ROOT_ACK, 0x0B73},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x03AE},
            {Opcode.CMSG_GAMEOBJ_REPORT_USE, 0x0B19 | 0x10000},
            {Opcode.CMSG_GAMEOBJ_USE, 0x082E},
            {Opcode.CMSG_GOSSIP_HELLO, 0x00F3},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x0332 | 0x10000},
            {Opcode.CMSG_GUILD_QUERY, 0x0930},
            {Opcode.CMSG_GUILD_QUERY_RANKS, 0x0C37},
            {Opcode.CMSG_GUILD_REQUEST_PARTY_STATE, 0x0A8E},
            {Opcode.CMSG_GUILD_ROSTER, 0x0638},
            {Opcode.CMSG_ITEM_REFUND_INFO, 0x0924},
            {Opcode.CMSG_JOIN_CHANNEL, 0x0B4B},
            {Opcode.CMSG_LOAD_SCREEN, 0x0B08},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x03C2 | 0x10000},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x1911},
            {Opcode.CMSG_LOOT, 0x01B1},
            {Opcode.CMSG_LOG_DISCONNECT, 0x04D5},
            {Opcode.CMSG_MESSAGECHAT_AFK, 0x1BDC | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_CHANNEL, 0x0913 | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_DND, 0x0AAB | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_EMOTE, 0x113C | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x0B1B | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_PARTY, 0x0134},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x1884 | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x1829},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x1161 | 0x10000},
            {Opcode.CMSG_MOVE_GRAVITY_DISABLE_ACK, 0x0553},
            {Opcode.CMSG_MOVE_FALL_LAND, 0x0D54},
            {Opcode.CMSG_MOVE_FORCE_RUN_SPEED_CHANGE_ACK, 0x0B7C},
            {Opcode.CMSG_MOVE_FORCE_SWIM_SPEED_CHANGE_ACK, 0x008A},
            {Opcode.CMSG_MOVE_HEARTBEAT, 0x19C1},
            {Opcode.CMSG_MOVE_JUMP, 0x0282},
            {Opcode.CMSG_MOVE_SET_COLLISION_HEIGHT_ACK, 0x0141},
            {Opcode.CMSG_MOVE_SET_FACING, 0x19D2},
            {Opcode.CMSG_MOVE_SET_PITCH, 0x0D92},
            {Opcode.CMSG_MOVE_SET_RUN_MODE, 0x0D51},
            {Opcode.CMSG_MOVE_SET_WALK_MODE, 0x0544},
            {Opcode.CMSG_MOVE_START_ASCEND, 0x0D41},
            {Opcode.CMSG_MOVE_START_BACKWARD, 0x0583},
            {Opcode.CMSG_MOVE_START_DESCEND, 0x0B79},
            {Opcode.CMSG_MOVE_START_FORWARD, 0x0521},
            {Opcode.CMSG_MOVE_START_PITCH_DOWN, 0x1974},
            {Opcode.CMSG_MOVE_START_PITCH_UP, 0x0151},
            {Opcode.CMSG_MOVE_START_SWIM, 0x0B7A},
            {Opcode.CMSG_MOVE_START_TURN_LEFT, 0x000B},
            {Opcode.CMSG_MOVE_START_TURN_RIGHT, 0x0D14},
            {Opcode.CMSG_MOVE_START_STRAFE_LEFT, 0x0082},
            {Opcode.CMSG_MOVE_START_STRAFE_RIGHT, 0x1151},
            {Opcode.CMSG_MOVE_STOP, 0x0513},
            {Opcode.CMSG_MOVE_STOP_ASCEND, 0x197C},
            {Opcode.CMSG_MOVE_STOP_PITCH, 0x0503},
            {Opcode.CMSG_MOVE_STOP_STRAFE, 0x01D1},
            {Opcode.CMSG_MOVE_STOP_SWIM, 0x097C},
            {Opcode.CMSG_MOVE_STOP_TURN, 0x0964},
            {Opcode.CMSG_MOVE_TIME_SKIPPED, 0x19C2},
            {Opcode.CMSG_MOVE_WORLDPORT_ACK, 0x0938},
            {Opcode.CMSG_NAME_QUERY, 0x0B15},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x0ECB},
            {Opcode.CMSG_PAGE_TEXT_QUERY, 0x0BBB},
            {Opcode.CMSG_PET_ACTION, 0x133A},
            {Opcode.CMSG_PET_CAST_SPELL, 0x0286},
            {Opcode.CMSG_PET_NAME_QUERY, 0x1433},
            {Opcode.CMSG_PING, 0x0416},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0B1D},
            {Opcode.CMSG_QUESTGIVER_QUERY_QUEST, 0x1924},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0x0131},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x0704},
            {Opcode.CMSG_QUEST_NPC_QUERY, 0x0B81},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x0BD9},
            {Opcode.CMSG_QUEST_QUERY, 0x09A6},
            {Opcode.CMSG_QUEUED_MESSAGES_END, 0x04DF},
            {Opcode.CMSG_RANDOM_ROLL, 0x12AA},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x1981},
            {Opcode.CMSG_REORDER_CHARACTERS, 0x0DAA},
            {Opcode.CMSG_REPAIR_ITEM, 0x0B54},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x0F3E},
            {Opcode.CMSG_RETURN_TO_GRAVEYARD, 0x12EA},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x0053},
            {Opcode.CMSG_SEND_MAIL, 0x0910},
            {Opcode.CMSG_SELL_ITEM, 0x0351},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x0599},
            {Opcode.CMSG_SET_LOOT_SPECIALIZATION, 0x0226 | 0x10000},
            {Opcode.CMSG_SET_SELECTION, 0x05BD},
            {Opcode.CMSG_SET_SPECIALIZATION, 0x0AC5},
            {Opcode.CMSG_SHOWING_CLOAK, 0x0132},
            {Opcode.CMSG_SHOWING_HELM, 0x11E1},
            {Opcode.CMSG_SPELLCLICK, 0x0BC2},
            {Opcode.CMSG_SUSPEND_COMMS_ACK, 0x0C56},
            {Opcode.CMSG_TRAINER_BUY_SPELL, 0x0A28},
            {Opcode.CMSG_TRAINER_LIST, 0x0A2E},
            {Opcode.CMSG_TRANSMOGRIFY_ITEMS, 0x0A85},
            {Opcode.CMSG_TEXT_EMOTE, 0x1901 | 0x10000},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x0003},
            {Opcode.CMSG_UNDELETE_CHARACTER, 0x0D99},
            {Opcode.CMSG_UNDELETE_COOLDOWN_STATUS_QUERY, 0x19A9},
            {Opcode.CMSG_UNLEARN_SKILL, 0x0A26 | 0x10000},
            {Opcode.CMSG_USE_ITEM, 0x08B6},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x12A1},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x098D | 0x10000},
            {Opcode.CMSG_VOID_STORAGE_QUERY, 0x019E},
            {Opcode.CMSG_VOID_STORAGE_TRANSFER, 0x0463},
            {Opcode.CMSG_VOID_STORAGE_UNLOCK, 0x13BB},
            {Opcode.CMSG_VOID_SWAP_ITEM, 0x0619},
            {Opcode.CMSG_WARDEN_DATA, 0x0BA1 | 0x10000},
            {Opcode.CMSG_WHO, 0x1322},

            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0120},
            {Opcode.SMSG_ACCOUNT_MOUNT_UPDATE, 0x0140},
            {Opcode.SMSG_ACTION_BUTTONS, 0x1D1F},
            {Opcode.SMSG_ADDON_INFO, 0x1D9F},
            {Opcode.SMSG_AI_REACTION, 0x0BA1},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_ACCOUNT, 0x0123},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_PLAYER, 0x0030},
            {Opcode.SMSG_ARENA_SEASON_WORLD_STATE, 0x09E3},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x1204},
            {Opcode.SMSG_ATTACKSTART, 0x1D3E},
            {Opcode.SMSG_ATTACKSTOP, 0x1382},
            {Opcode.SMSG_AUCTION_COMMAND_RESULT, 0x0B2D},
            {Opcode.SMSG_AUCTION_HELLO, 0x011F},
            {Opcode.SMSG_AUCTION_LIST_RESULT, 0x19D2 | 0x20000},
            {Opcode.SMSG_AURA_UPDATE, 0x091C},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x1759},
            {Opcode.SMSG_AUTH_RESPONSE, 0x0DA9},
            {Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE, 0x0F2A},
            {Opcode.SMSG_BATTLE_PAY_GET_PRODUCT_LIST_RESPONSE, 0x12A4},
            {Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE, 0x168A},
            {Opcode.SMSG_BATTLE_PET_NAME_QUERY_RESPONSE, 0x09EC},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x19A2},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x01A3},
            {Opcode.SMSG_BINDER_CONFIRM, 0x0B11},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x0A30},
            {Opcode.SMSG_BUY_FAILED, 0x013A},
            {Opcode.SMSG_BUY_ITEM, 0x0BD1},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x0643},
            {Opcode.SMSG_CHANNEL_NOTIFY_JOINED, 0x1602},
            {Opcode.SMSG_CHANNEL_START, 0x016C},
            {Opcode.SMSG_CHANNEL_UPDATE, 0x19DB},
            {Opcode.SMSG_CHAR_CREATE, 0x0107},
            {Opcode.SMSG_CHAR_CUSTOMIZE, 0x1932},
            {Opcode.SMSG_CHAR_CUSTOMIZE_RESULT, 0x0BAA},
            {Opcode.SMSG_CHAR_DELETE, 0x0BC4},
            {Opcode.SMSG_CHAR_ENUM, 0x05AF},
            {Opcode.SMSG_CHAR_FACTION_CHANGE, 0x0810},
            {Opcode.SMSG_CHAR_RENAME, 0x0D89},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x080D},
            {Opcode.SMSG_CONTACT_STATUS, 0x1BEA},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x0BE2},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x0A26 | 0x20000},
            {Opcode.SMSG_CRITERIA_UPDATE_ACCOUNT, 0x0912},
            {Opcode.SMSG_CRITERIA_UPDATE_PLAYER, 0x1904},
            {Opcode.SMSG_DANCE_STUDIO_CREATE_RESULT, 0x178D},
            {Opcode.SMSG_DB_REPLY, 0x1939},
            {Opcode.SMSG_EMOTE, 0x071D | 0x20000},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x0F1E},
            {Opcode.SMSG_EQUIPMENT_SET_SAVED, 0x0027},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x0B1E},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS_GLUE_SCREEN, 0x1540},
            {Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x08A5},
            {Opcode.SMSG_FORCE_RUN_SPEED_CHANGE, 0x08F5},
            {Opcode.SMSG_FORCE_SWIM_SPEED_CHANGE, 0x061A},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x128A},
            {Opcode.SMSG_GOSSIP_COMPLETE, 0x15D1},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x1746},
            {Opcode.SMSG_GOSSIP_POI, 0x011E | 0x20000},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_DATA, 0x1866},
            {Opcode.SMSG_GUILD_BANK_MONEY_WITHDRAWN, 0x1047},
            {Opcode.SMSG_GUILD_EVENT, 0x1027},
            {Opcode.SMSG_GUILD_EVENT_PRESENCE_CHANGE, 0x1228},
            {Opcode.SMSG_GUILD_MOTD, 0x1825},
            {Opcode.SMSG_GUILD_PARTY_STATE_RESPONSE, 0x1225},
            {Opcode.SMSG_GUILD_PERMISSIONS_QUERY_RESULTS, 0x1827},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x1046},
            {Opcode.SMSG_GUILD_RANK, 0x1218},
            {Opcode.SMSG_GUILD_RECIPES, 0x1078},
            {Opcode.SMSG_GUILD_ROSTER, 0x1026},
            {Opcode.SMSG_HIGHEST_THREAT_UPDATE, 0x059A},
            {Opcode.SMSG_HOTFIX_INFO, 0x1D1D},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x0B10},
            {Opcode.SMSG_INITIAL_SETUP, 0x0B07},
            {Opcode.SMSG_INITIAL_SPELLS, 0x0A81},
            {Opcode.SMSG_INIT_CURRENCY,  0x0B06},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x0B04},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x010D},
            {Opcode.SMSG_LEARNED_SPELL, 0x08AB},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x0F36},
            {Opcode.SMSG_LFG_JOIN_RESULT, 0x0F72},
            {Opcode.SMSG_LIST_INVENTORY, 0x0940},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x1530},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x09AA},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0B19 | 0x20000},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x0FAD},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0B21},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x052D},
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x0B3F},
            {Opcode.SMSG_MESSAGECHAT, 0x0603},
            {Opcode.SMSG_MONSTER_MOVE, 0x0994},
            {Opcode.SMSG_MOTD, 0x0442},
            {Opcode.SMSG_MOVE_GRAVITY_DISABLE, 0x02C6},
            {Opcode.SMSG_MOVE_ROOT, 0x1B5A},
            {Opcode.SMSG_MOVE_SET_COLLISION_HEIGHT, 0x008D},
            {Opcode.SMSG_MOVE_UPDATE_TELEPORT, 0x03D5},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x0828},
            {Opcode.SMSG_NEW_WORLD, 0x0206},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x1122},
            {Opcode.SMSG_ON_CANCEL_EXPECTED_RIDE_VEHICLE_AURA, 0x053F},
            {Opcode.SMSG_PAGE_TEXT_QUERY_RESPONSE, 0x05A0},
            {Opcode.SMSG_PERIODICAURALOG, 0x0B1B},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x0D0E},
            {Opcode.SMSG_PET_SPELLS, 0x0174},
            {Opcode.SMSG_PLAY_SOUND, 0x02D2},
            {Opcode.SMSG_PLAY_SPELL_VISUAL_KIT, 0x0171},
            {Opcode.SMSG_PLAYER_MOVE, 0x0ACE},
            {Opcode.SMSG_PONG, 0x17CA},
            {Opcode.SMSG_POWER_UPDATE, 0x0B27},
            {Opcode.SMSG_QUERY_TIME_RESPONSE, 0x1DB0},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x15B3},
            {Opcode.SMSG_QUESTGIVER_STATUS, 0x1567},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0x17C6},
            {Opcode.SMSG_QUEST_NPC_QUERY_RESPONSE, 0x1591},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x1715},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x1547},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x0D8F},
            {Opcode.SMSG_RESEARCH_SETUP_HISTORY, 0x0A25 | 0x20000},
            {Opcode.SMSG_BATTLEFIELD_RATED_INFO, 0x1F0A},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x175A},
            {Opcode.SMSG_RESUME_COMMS, 0x07C9},
            {Opcode.SMSG_SEND_MAIL_RESULT, 0x0302 | 0x20000},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x1A82},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x1884 | 0x20000},
            {Opcode.SMSG_SET_FORCED_REACTIONS, 0x09A9},
            {Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0x02D4},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x113C | 0x20000},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x00D1},
            {Opcode.SMSG_SET_PROFICIENCY, 0x00D3},
            {Opcode.SMSG_SET_TIME_ZONE_INFORMATION, 0x153E},
            {Opcode.SMSG_SET_VIGNETTE, 0x09AC},
            {Opcode.SMSG_SPELLDAMAGESHIELD, 0x188A},
            {Opcode.SMSG_SPELLENERGIZELOG, 0x137C | 0x20000},
            {Opcode.SMSG_SPELLHEALLOG, 0x0114},
            {Opcode.SMSG_SPELLLOGEXECUTE, 0x1823 | 0x20000},
            {Opcode.SMSG_SPELLNONMELEEDAMAGELOG, 0x11FB},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x082A | 0x20000},
            {Opcode.SMSG_SPELL_GO, 0x1161 | 0x20000},
            {Opcode.SMSG_SPELL_START, 0x0803 | 0x20000},
            {Opcode.SMSG_SPELL_UPDATE_CHAIN_TARGETS, 0x0374},
            {Opcode.SMSG_SPLINE_MOVE_GRAVITY_DISABLE, 0x03B2},
            {Opcode.SMSG_SPLINE_MOVE_SET_FLIGHT_SPEED, 0x060C},
            {Opcode.SMSG_SPLINE_MOVE_SET_RUN_BACK_SPEED, 0x0086},
            {Opcode.SMSG_SPLINE_MOVE_SET_RUN_SPEED, 0x1B9A},
            {Opcode.SMSG_SPLINE_MOVE_SET_SWIM_SPEED, 0x098D},
            {Opcode.SMSG_SPLINE_MOVE_SET_WALK_SPEED, 0x01D5},
            {Opcode.SMSG_SPLINE_MOVE_UNSET_HOVER, 0x1959},
            {Opcode.SMSG_STANDSTATE_UPDATE, 0x1311},
            {Opcode.SMSG_SUSPEND_COMMS, 0x076A},
            {Opcode.SMSG_SUSPEND_TOKEN, 0x12A2},
            {Opcode.SMSG_TALENTS_INFO, 0x012D},
            {Opcode.SMSG_TEXT_EMOTE, 0x0383},
            {Opcode.SMSG_THREAT_UPDATE, 0x03A9},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x03B1},
            {Opcode.SMSG_TRAINER_LIST, 0x0BA9},
            {Opcode.SMSG_TRANSFER_PENDING, 0x172A},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x020F},
            {Opcode.SMSG_UNDELETE_CHARACTER_RESPONSE, 0x0344},
            {Opcode.SMSG_UNDELETE_COOLDOWN_STATUS_RESPONSE, 0x0310},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x1520},
            {Opcode.SMSG_UPDATE_OBJECT, 0x122C | 0x20000},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x03EC},
            {Opcode.SMSG_VOID_STORAGE_CONTENTS, 0x0108},
            {Opcode.SMSG_VOID_TRANSFER_RESULT, 0x0539},
            {Opcode.SMSG_VOID_STORAGE_TRANSFER_CHANGES, 0x0321},
            {Opcode.SMSG_VOID_ITEM_SWAP_RESPONSE, 0x1131},
            {Opcode.SMSG_WARDEN_DATA, 0x0BEC},
            {Opcode.SMSG_WEATHER, 0x073E | 0x20000},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x13DC},
            {Opcode.SMSG_WHO, 0x0601},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x11AC},
            {Opcode.SMSG_ZONE_UNDER_ATTACK, 0x1401},
        };
    }
}

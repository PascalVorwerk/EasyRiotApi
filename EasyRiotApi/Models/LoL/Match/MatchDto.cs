using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoL.Match;

public class MatchDto
{
    [JsonPropertyName("metadata")]
    public MetadataDto Metadata { get; set; } = null!;
    [JsonPropertyName("info")]
    public InfoDto Info { get; set; } = null!;
}

public class BanDto
{
    [JsonPropertyName("championId")] public int ChampionId { get; set; }

    [JsonPropertyName("pickTurn")] public int PickTurn { get; set; }
}

public class ChallengesDto
{
    [JsonPropertyName("12AssistStreakCount")]
    public int _12AssistStreakCount { get; set; }

    [JsonPropertyName("InfernalScalePickup")]
    public int InfernalScalePickup { get; set; }

    [JsonPropertyName("SWARM_DefeatAatrox")]
    public int SwarmDefeatAatrox { get; set; }

    [JsonPropertyName("SWARM_DefeatBriar")]
    public int SwarmDefeatBriar { get; set; }

    [JsonPropertyName("SWARM_DefeatMiniBosses")]
    public int SwarmDefeatMiniBosses { get; set; }

    [JsonPropertyName("SWARM_EvolveWeapon")]
    public int SwarmEvolveWeapon { get; set; }

    [JsonPropertyName("SWARM_Have3Passives")]
    public int SwarmHave3Passives { get; set; }

    [JsonPropertyName("SWARM_KillEnemy")] public int SwarmKillEnemy { get; set; }

    [JsonPropertyName("SWARM_PickupGold")] public int SwarmPickupGold { get; set; }

    [JsonPropertyName("SWARM_ReachLevel50")]
    public int SwarmReachLevel50 { get; set; }

    [JsonPropertyName("SWARM_Survive15Min")]
    public int SwarmSurvive15Min { get; set; }

    [JsonPropertyName("SWARM_WinWith5EvolvedWeapons")]
    public int SwarmWinWith5EvolvedWeapons { get; set; }

    [JsonPropertyName("abilityUses")] public int AbilityUses { get; set; }

    [JsonPropertyName("acesBefore15Minutes")]
    public int AcesBefore15Minutes { get; set; }

    [JsonPropertyName("alliedJungleMonsterKills")]
    public int AlliedJungleMonsterKills { get; set; }

    [JsonPropertyName("baronBuffGoldAdvantageOverThreshold")]
    public int BaronBuffGoldAdvantageOverThreshold { get; set; }

    [JsonPropertyName("baronTakedowns")] public int BaronTakedowns { get; set; }

    [JsonPropertyName("blastConeOppositeOpponentCount")]
    public int BlastConeOppositeOpponentCount { get; set; }

    [JsonPropertyName("bountyGold")] public int BountyGold { get; set; }

    [JsonPropertyName("buffsStolen")] public int BuffsStolen { get; set; }

    [JsonPropertyName("completeSupportQuestInTime")]
    public int CompleteSupportQuestInTime { get; set; }

    [JsonPropertyName("controlWardTimeCoverageInRiverOrEnemyHalf")]
    public double ControlWardTimeCoverageInRiverOrEnemyHalf { get; set; }

    [JsonPropertyName("controlWardsPlaced")]
    public int ControlWardsPlaced { get; set; }

    [JsonPropertyName("damagePerMinute")] public double DamagePerMinute { get; set; }

    [JsonPropertyName("damageTakenOnTeamPercentage")]
    public double DamageTakenOnTeamPercentage { get; set; }

    [JsonPropertyName("dancedWithRiftHerald")]
    public int DancedWithRiftHerald { get; set; }

    [JsonPropertyName("deathsByEnemyChamps")]
    public int DeathsByEnemyChamps { get; set; }

    [JsonPropertyName("dodgeSkillShotsSmallWindow")]
    public int DodgeSkillShotsSmallWindow { get; set; }

    [JsonPropertyName("doubleAces")] public int DoubleAces { get; set; }

    [JsonPropertyName("dragonTakedowns")] public int DragonTakedowns { get; set; }

    [JsonPropertyName("earliestBaron")] public double EarliestBaron { get; set; }

    [JsonPropertyName("earliestDragonTakedown")]
    public double EarliestDragonTakedown { get; set; }

    [JsonPropertyName("earlyLaningPhaseGoldExpAdvantage")]
    public int EarlyLaningPhaseGoldExpAdvantage { get; set; }

    [JsonPropertyName("effectiveHealAndShielding")]
    public double EffectiveHealAndShielding { get; set; }

    [JsonPropertyName("elderDragonKillsWithOpposingSoul")]
    public int ElderDragonKillsWithOpposingSoul { get; set; }

    [JsonPropertyName("elderDragonMultikills")]
    public int ElderDragonMultikills { get; set; }

    [JsonPropertyName("enemyChampionImmobilizations")]
    public int EnemyChampionImmobilizations { get; set; }

    [JsonPropertyName("enemyJungleMonsterKills")]
    public int EnemyJungleMonsterKills { get; set; }

    [JsonPropertyName("epicMonsterKillsNearEnemyJungler")]
    public int EpicMonsterKillsNearEnemyJungler { get; set; }

    [JsonPropertyName("epicMonsterKillsWithin30SecondsOfSpawn")]
    public int EpicMonsterKillsWithin30SecondsOfSpawn { get; set; }

    [JsonPropertyName("epicMonsterSteals")]
    public int EpicMonsterSteals { get; set; }

    [JsonPropertyName("epicMonsterStolenWithoutSmite")]
    public int EpicMonsterStolenWithoutSmite { get; set; }

    [JsonPropertyName("fastestLegendary")] public double FastestLegendary { get; set; }

    [JsonPropertyName("firstTurretKilled")]
    public int FirstTurretKilled { get; set; }

    [JsonPropertyName("fistBumpParticipation")]
    public int FistBumpParticipation { get; set; }

    [JsonPropertyName("flawlessAces")] public int FlawlessAces { get; set; }

    [JsonPropertyName("fullTeamTakedown")] public int FullTeamTakedown { get; set; }

    [JsonPropertyName("gameLength")] public double GameLength { get; set; }

    [JsonPropertyName("goldPerMinute")] public double GoldPerMinute { get; set; }

    [JsonPropertyName("hadOpenNexus")] public int HadOpenNexus { get; set; }

    [JsonPropertyName("highestWardKills")] public int HighestWardKills { get; set; }

    [JsonPropertyName("immobilizeAndKillWithAlly")]
    public int ImmobilizeAndKillWithAlly { get; set; }

    [JsonPropertyName("initialBuffCount")] public int InitialBuffCount { get; set; }

    [JsonPropertyName("initialCrabCount")] public int InitialCrabCount { get; set; }

    [JsonPropertyName("jungleCsBefore10Minutes")]
    public double JungleCsBefore10Minutes { get; set; }

    [JsonPropertyName("junglerKillsEarlyJungle")]
    public int JunglerKillsEarlyJungle { get; set; }

    [JsonPropertyName("junglerTakedownsNearDamagedEpicMonster")]
    public int JunglerTakedownsNearDamagedEpicMonster { get; set; }

    [JsonPropertyName("kTurretsDestroyedBeforePlatesFall")]
    public int KTurretsDestroyedBeforePlatesFall { get; set; }

    [JsonPropertyName("kda")] public double Kda { get; set; }

    [JsonPropertyName("killAfterHiddenWithAlly")]
    public int KillAfterHiddenWithAlly { get; set; }

    [JsonPropertyName("killParticipation")]
    public double KillParticipation { get; set; }

    [JsonPropertyName("killedChampTookFullTeamDamageSurvived")]
    public int KilledChampTookFullTeamDamageSurvived { get; set; }

    [JsonPropertyName("killingSprees")] public int KillingSprees { get; set; }

    [JsonPropertyName("killsNearEnemyTurret")]
    public int KillsNearEnemyTurret { get; set; }

    [JsonPropertyName("killsOnLanersEarlyJungleAsJungler")]
    public int KillsOnLanersEarlyJungleAsJungler { get; set; }

    [JsonPropertyName("killsOnRecentlyHealedByAramPack")]
    public int KillsOnRecentlyHealedByAramPack { get; set; }

    [JsonPropertyName("killsUnderOwnTurret")]
    public int KillsUnderOwnTurret { get; set; }

    [JsonPropertyName("killsWithHelpFromEpicMonster")]
    public int KillsWithHelpFromEpicMonster { get; set; }

    [JsonPropertyName("knockEnemyIntoTeamAndKill")]
    public int KnockEnemyIntoTeamAndKill { get; set; }

    [JsonPropertyName("landSkillShotsEarlyGame")]
    public int LandSkillShotsEarlyGame { get; set; }

    [JsonPropertyName("laneMinionsFirst10Minutes")]
    public int LaneMinionsFirst10Minutes { get; set; }

    [JsonPropertyName("laningPhaseGoldExpAdvantage")]
    public int LaningPhaseGoldExpAdvantage { get; set; }

    [JsonPropertyName("legendaryCount")] public int LegendaryCount { get; set; }

    [JsonPropertyName("legendaryItemUsed")]
    public List<int> LegendaryItemUsed { get; set; } = null!;

    [JsonPropertyName("lostAnInhibitor")] public int LostAnInhibitor { get; set; }

    [JsonPropertyName("maxCsAdvantageOnLaneOpponent")]
    public double MaxCsAdvantageOnLaneOpponent { get; set; }

    [JsonPropertyName("maxKillDeficit")] public int MaxKillDeficit { get; set; }

    [JsonPropertyName("maxLevelLeadLaneOpponent")]
    public int MaxLevelLeadLaneOpponent { get; set; }

    [JsonPropertyName("mejaisFullStackInTime")]
    public int MejaisFullStackInTime { get; set; }

    [JsonPropertyName("moreEnemyJungleThanOpponent")]
    public double MoreEnemyJungleThanOpponent { get; set; }

    [JsonPropertyName("multiKillOneSpell")]
    public int MultiKillOneSpell { get; set; }

    [JsonPropertyName("multiTurretRiftHeraldCount")]
    public int MultiTurretRiftHeraldCount { get; set; }

    [JsonPropertyName("multikills")] public int Multikills { get; set; }

    [JsonPropertyName("multikillsAfterAggressiveFlash")]
    public int MultikillsAfterAggressiveFlash { get; set; }

    [JsonPropertyName("outerTurretExecutesBefore10Minutes")]
    public int OuterTurretExecutesBefore10Minutes { get; set; }

    [JsonPropertyName("outnumberedKills")] public int OutnumberedKills { get; set; }

    [JsonPropertyName("outnumberedNexusKill")]
    public int OutnumberedNexusKill { get; set; }

    [JsonPropertyName("perfectDragonSoulsTaken")]
    public int PerfectDragonSoulsTaken { get; set; }

    [JsonPropertyName("perfectGame")] public int PerfectGame { get; set; }

    [JsonPropertyName("pickKillWithAlly")] public int PickKillWithAlly { get; set; }

    [JsonPropertyName("playedChampSelectPosition")]
    public int PlayedChampSelectPosition { get; set; }

    [JsonPropertyName("poroExplosions")] public int PoroExplosions { get; set; }

    [JsonPropertyName("quickCleanse")] public int QuickCleanse { get; set; }

    [JsonPropertyName("quickFirstTurret")] public int QuickFirstTurret { get; set; }

    [JsonPropertyName("quickSoloKills")] public int QuickSoloKills { get; set; }

    [JsonPropertyName("riftHeraldTakedowns")]
    public int RiftHeraldTakedowns { get; set; }

    [JsonPropertyName("saveAllyFromDeath")]
    public int SaveAllyFromDeath { get; set; }

    [JsonPropertyName("scuttleCrabKills")] public int ScuttleCrabKills { get; set; }

    [JsonPropertyName("skillshotsDodged")] public int SkillshotsDodged { get; set; }

    [JsonPropertyName("skillshotsHit")] public int SkillshotsHit { get; set; }

    [JsonPropertyName("snowballsHit")] public int SnowballsHit { get; set; }

    [JsonPropertyName("soloBaronKills")] public int SoloBaronKills { get; set; }

    [JsonPropertyName("soloKills")] public int SoloKills { get; set; }

    [JsonPropertyName("stealthWardsPlaced")]
    public int StealthWardsPlaced { get; set; }

    [JsonPropertyName("survivedSingleDigitHpCount")]
    public int SurvivedSingleDigitHpCount { get; set; }

    [JsonPropertyName("survivedThreeImmobilizesInFight")]
    public int SurvivedThreeImmobilizesInFight { get; set; }

    [JsonPropertyName("takedownOnFirstTurret")]
    public int TakedownOnFirstTurret { get; set; }

    [JsonPropertyName("takedowns")] public int Takedowns { get; set; }

    [JsonPropertyName("takedownsAfterGainingLevelAdvantage")]
    public int TakedownsAfterGainingLevelAdvantage { get; set; }

    [JsonPropertyName("takedownsBeforeJungleMinionSpawn")]
    public int TakedownsBeforeJungleMinionSpawn { get; set; }

    [JsonPropertyName("takedownsFirstXMinutes")]
    public int TakedownsFirstXMinutes { get; set; }

    [JsonPropertyName("takedownsInAlcove")]
    public int TakedownsInAlcove { get; set; }

    [JsonPropertyName("takedownsInEnemyFountain")]
    public int TakedownsInEnemyFountain { get; set; }

    [JsonPropertyName("teamBaronKills")] public int TeamBaronKills { get; set; }

    [JsonPropertyName("teamDamagePercentage")]
    public double TeamDamagePercentage { get; set; }

    [JsonPropertyName("teamElderDragonKills")]
    public int TeamElderDragonKills { get; set; }

    [JsonPropertyName("teamRiftHeraldKills")]
    public int TeamRiftHeraldKills { get; set; }

    [JsonPropertyName("thirdInhibitorDestroyedTime")]
    public double ThirdInhibitorDestroyedTime { get; set; }

    [JsonPropertyName("tookLargeDamageSurvived")]
    public int TookLargeDamageSurvived { get; set; }

    [JsonPropertyName("turretPlatesTaken")]
    public int TurretPlatesTaken { get; set; }

    [JsonPropertyName("turretTakedowns")] public int TurretTakedowns { get; set; }

    [JsonPropertyName("turretsTakenWithRiftHerald")]
    public int TurretsTakenWithRiftHerald { get; set; }

    [JsonPropertyName("twentyMinionsIn3SecondsCount")]
    public int TwentyMinionsIn3SecondsCount { get; set; }

    [JsonPropertyName("twoWardsOneSweeperCount")]
    public int TwoWardsOneSweeperCount { get; set; }

    [JsonPropertyName("unseenRecalls")] public int UnseenRecalls { get; set; }

    [JsonPropertyName("visionScoreAdvantageLaneOpponent")]
    public double VisionScoreAdvantageLaneOpponent { get; set; }

    [JsonPropertyName("visionScorePerMinute")]
    public double VisionScorePerMinute { get; set; }

    [JsonPropertyName("voidMonsterKill")] public int VoidMonsterKill { get; set; }

    [JsonPropertyName("wardTakedowns")] public int WardTakedowns { get; set; }

    [JsonPropertyName("wardTakedownsBefore20M")]
    public int WardTakedownsBefore20M { get; set; }

    [JsonPropertyName("wardsGuarded")] public int WardsGuarded { get; set; }

    [JsonPropertyName("getTakedownsInAllLanesEarlyJungleAsLaner")]
    public int? GetTakedownsInAllLanesEarlyJungleAsLaner { get; set; }

    [JsonPropertyName("killsOnOtherLanesEarlyJungleAsLaner")]
    public int? KillsOnOtherLanesEarlyJungleAsLaner { get; set; }

    [JsonPropertyName("shortestTimeToAceFromFirstTakedown")]
    public double? ShortestTimeToAceFromFirstTakedown { get; set; }

    [JsonPropertyName("highestChampionDamage")]
    public int? HighestChampionDamage { get; set; }

    [JsonPropertyName("soloTurretsLategame")]
    public int? SoloTurretsLategame { get; set; }

    [JsonPropertyName("firstTurretKilledTime")]
    public double? FirstTurretKilledTime { get; set; }

    [JsonPropertyName("highestCrowdControlScore")]
    public int? HighestCrowdControlScore { get; set; }
}


public class InfoDto
{
    [JsonPropertyName("endOfGameResult")] public string EndOfGameResult { get; set; } = null!;

    [JsonPropertyName("gameCreation")] public long GameCreation { get; set; }

    [JsonPropertyName("gameDuration")] public int GameDuration { get; set; }

    [JsonPropertyName("gameEndTimestamp")] public long GameEndTimestamp { get; set; }

    [JsonPropertyName("gameId")] public long GameId { get; set; }

    [JsonPropertyName("gameMode")] public string GameMode { get; set; } = null!;

    [JsonPropertyName("gameName")] public string GameName { get; set; } = null!;

    [JsonPropertyName("gameStartTimestamp")]
    public long GameStartTimestamp { get; set; }

    [JsonPropertyName("gameType")] public string GameType { get; set; } = null!;

    [JsonPropertyName("gameVersion")] public string GameVersion { get; set; } = null!;

    [JsonPropertyName("mapId")] public int MapId { get; set; }

    [JsonPropertyName("participants")] public List<ParticipantDto> Participants { get; set; } = null!;

    [JsonPropertyName("platformId")] public string PlatformId { get; set; } = null!;

    [JsonPropertyName("queueId")] public int QueueId { get; set; }

    [JsonPropertyName("teams")] public List<TeamDto> Teams { get; set; } = null!;

    [JsonPropertyName("tournamentCode")] public string TournamentCode { get; set; } = null!;
}

public class MetadataDto
{
    [JsonPropertyName("dataVersion")] public string DataVersion { get; set; } = null!;

    [JsonPropertyName("matchId")] public string MatchId { get; set; } = null!;

    [JsonPropertyName("participants")] public List<string> Participants { get; set; } = null!;
}

public class MissionsDto
{
    [JsonPropertyName("playerScore0")] public int PlayerScore0 { get; set; }

    [JsonPropertyName("playerScore1")] public int PlayerScore1 { get; set; }

    [JsonPropertyName("playerScore2")] public int PlayerScore2 { get; set; }

    [JsonPropertyName("playerScore3")] public int PlayerScore3 { get; set; }

    [JsonPropertyName("playerScore4")] public int PlayerScore4 { get; set; }

    [JsonPropertyName("playerScore5")] public int PlayerScore5 { get; set; }

    [JsonPropertyName("playerScore6")] public int PlayerScore6 { get; set; }

    [JsonPropertyName("playerScore7")] public int PlayerScore7 { get; set; }

    [JsonPropertyName("playerScore8")] public int PlayerScore8 { get; set; }

    [JsonPropertyName("playerScore9")] public int PlayerScore9 { get; set; }

    [JsonPropertyName("playerScore10")] public int PlayerScore10 { get; set; }

    [JsonPropertyName("playerScore11")] public int PlayerScore11 { get; set; }
}

public class ObjectivesDto
{
    [JsonPropertyName("baron")] public ObjectiveDto Baron { get; set; } = null!;

    [JsonPropertyName("champion")] public ObjectiveDto Champion { get; set; } = null!;

    [JsonPropertyName("dragon")] public ObjectiveDto Dragon { get; set; } = null!;

    [JsonPropertyName("horde")] public ObjectiveDto Horde { get; set; } = null!;

    [JsonPropertyName("inhibitor")] public ObjectiveDto Inhibitor { get; set; } = null!;

    [JsonPropertyName("riftHerald")] public ObjectiveDto RiftHerald { get; set; } = null!;

    [JsonPropertyName("tower")] public ObjectiveDto Tower { get; set; } = null!;
}

public class ParticipantDto
{
    [JsonPropertyName("allInPings")] public int AllInPings { get; set; }

    [JsonPropertyName("assistMePings")] public int AssistMePings { get; set; }

    [JsonPropertyName("assists")] public int Assists { get; set; }

    [JsonPropertyName("baronKills")] public int BaronKills { get; set; }

    [JsonPropertyName("basicPings")] public int BasicPings { get; set; }

    [JsonPropertyName("bountyLevel")] public int BountyLevel { get; set; }

    [JsonPropertyName("challenges")] public ChallengesDto Match { get; set; } = null!;

    [JsonPropertyName("champExperience")] public int ChampExperience { get; set; }

    [JsonPropertyName("champLevel")] public int ChampLevel { get; set; }

    [JsonPropertyName("championId")] public int ChampionId { get; set; }

    [JsonPropertyName("championName")] public string ChampionName { get; set; } = null!;

    [JsonPropertyName("championTransform")]
    public int ChampionTransform { get; set; }

    [JsonPropertyName("commandPings")] public int CommandPings { get; set; }

    [JsonPropertyName("consumablesPurchased")]
    public int ConsumablesPurchased { get; set; }

    [JsonPropertyName("damageDealtToBuildings")]
    public int DamageDealtToBuildings { get; set; }

    [JsonPropertyName("damageDealtToObjectives")]
    public int DamageDealtToObjectives { get; set; }

    [JsonPropertyName("damageDealtToTurrets")]
    public int DamageDealtToTurrets { get; set; }

    [JsonPropertyName("damageSelfMitigated")]
    public int DamageSelfMitigated { get; set; }

    [JsonPropertyName("dangerPings")] public int DangerPings { get; set; }

    [JsonPropertyName("deaths")] public int Deaths { get; set; }

    [JsonPropertyName("detectorWardsPlaced")]
    public int DetectorWardsPlaced { get; set; }

    [JsonPropertyName("doubleKills")] public int DoubleKills { get; set; }

    [JsonPropertyName("dragonKills")] public int DragonKills { get; set; }

    [JsonPropertyName("eligibleForProgression")]
    public bool EligibleForProgression { get; set; }

    [JsonPropertyName("enemyMissingPings")]
    public int EnemyMissingPings { get; set; }

    [JsonPropertyName("enemyVisionPings")] public int EnemyVisionPings { get; set; }

    [JsonPropertyName("firstBloodAssist")] public bool FirstBloodAssist { get; set; }

    [JsonPropertyName("firstBloodKill")] public bool FirstBloodKill { get; set; }

    [JsonPropertyName("firstTowerAssist")] public bool FirstTowerAssist { get; set; }

    [JsonPropertyName("firstTowerKill")] public bool FirstTowerKill { get; set; }

    [JsonPropertyName("gameEndedInEarlySurrender")]
    public bool GameEndedInEarlySurrender { get; set; }

    [JsonPropertyName("gameEndedInSurrender")]
    public bool GameEndedInSurrender { get; set; }

    [JsonPropertyName("getBackPings")] public int GetBackPings { get; set; }

    [JsonPropertyName("goldEarned")] public int GoldEarned { get; set; }

    [JsonPropertyName("goldSpent")] public int GoldSpent { get; set; }

    [JsonPropertyName("holdPings")] public int HoldPings { get; set; }

    [JsonPropertyName("individualPosition")]
    public string IndividualPosition { get; set; } = null!;

    [JsonPropertyName("inhibitorKills")] public int InhibitorKills { get; set; }

    [JsonPropertyName("inhibitorTakedowns")]
    public int InhibitorTakedowns { get; set; }

    [JsonPropertyName("inhibitorsLost")] public int InhibitorsLost { get; set; }

    [JsonPropertyName("item0")] public int Item0 { get; set; }

    [JsonPropertyName("item1")] public int Item1 { get; set; }

    [JsonPropertyName("item2")] public int Item2 { get; set; }

    [JsonPropertyName("item3")] public int Item3 { get; set; }

    [JsonPropertyName("item4")] public int Item4 { get; set; }

    [JsonPropertyName("item5")] public int Item5 { get; set; }

    [JsonPropertyName("item6")] public int Item6 { get; set; }

    [JsonPropertyName("itemsPurchased")] public int ItemsPurchased { get; set; }

    [JsonPropertyName("killingSprees")] public int KillingSprees { get; set; }

    [JsonPropertyName("kills")] public int Kills { get; set; }

    [JsonPropertyName("lane")] public string Lane { get; set; } = null!;

    [JsonPropertyName("largestCriticalStrike")]
    public int LargestCriticalStrike { get; set; }

    [JsonPropertyName("largestKillingSpree")]
    public int LargestKillingSpree { get; set; }

    [JsonPropertyName("largestMultiKill")] public int LargestMultiKill { get; set; }

    [JsonPropertyName("longestTimeSpentLiving")]
    public int LongestTimeSpentLiving { get; set; }

    [JsonPropertyName("magicDamageDealt")] public int MagicDamageDealt { get; set; }

    [JsonPropertyName("magicDamageDealtToChampions")]
    public int MagicDamageDealtToChampions { get; set; }

    [JsonPropertyName("magicDamageTaken")] public int MagicDamageTaken { get; set; }

    [JsonPropertyName("missions")] public MissionsDto Missions { get; set; } = null!;

    [JsonPropertyName("needVisionPings")] public int NeedVisionPings { get; set; }

    [JsonPropertyName("neutralMinionsKilled")]
    public int NeutralMinionsKilled { get; set; }

    [JsonPropertyName("nexusKills")] public int NexusKills { get; set; }

    [JsonPropertyName("nexusLost")] public int NexusLost { get; set; }

    [JsonPropertyName("nexusTakedowns")] public int NexusTakedowns { get; set; }

    [JsonPropertyName("objectivesStolen")] public int ObjectivesStolen { get; set; }

    [JsonPropertyName("objectivesStolenAssists")]
    public int ObjectivesStolenAssists { get; set; }

    [JsonPropertyName("onMyWayPings")] public int OnMyWayPings { get; set; }

    [JsonPropertyName("participantId")] public int ParticipantId { get; set; }

    [JsonPropertyName("pentaKills")] public int PentaKills { get; set; }

    [JsonPropertyName("perks")] public PerksDto Perks { get; set; } = null!;

    [JsonPropertyName("physicalDamageDealt")]
    public int PhysicalDamageDealt { get; set; }

    [JsonPropertyName("physicalDamageDealtToChampions")]
    public int PhysicalDamageDealtToChampions { get; set; }

    [JsonPropertyName("physicalDamageTaken")]
    public int PhysicalDamageTaken { get; set; }

    [JsonPropertyName("placement")] public int Placement { get; set; }

    [JsonPropertyName("playerAugment1")] public int PlayerAugment1 { get; set; }

    [JsonPropertyName("playerAugment2")] public int PlayerAugment2 { get; set; }

    [JsonPropertyName("playerAugment3")] public int PlayerAugment3 { get; set; }

    [JsonPropertyName("playerAugment4")] public int PlayerAugment4 { get; set; }

    [JsonPropertyName("playerAugment5")] public int PlayerAugment5 { get; set; }

    [JsonPropertyName("playerAugment6")] public int PlayerAugment6 { get; set; }

    [JsonPropertyName("playerSubteamId")] public int PlayerSubteamId { get; set; }

    [JsonPropertyName("profileIcon")] public int ProfileIcon { get; set; }

    [JsonPropertyName("pushPings")] public int PushPings { get; set; }

    [JsonPropertyName("puuid")] public string Puuid { get; set; } = null!;

    [JsonPropertyName("quadraKills")] public int QuadraKills { get; set; }

    [JsonPropertyName("riotIdGameName")] public string RiotIdGameName { get; set; } = null!;

    [JsonPropertyName("riotIdTagline")] public string RiotIdTagline { get; set; } = null!;

    [JsonPropertyName("role")] public string Role { get; set; } = null!;

    [JsonPropertyName("sightWardsBoughtInGame")]
    public int SightWardsBoughtInGame { get; set; }

    [JsonPropertyName("spell1Casts")] public int Spell1Casts { get; set; }

    [JsonPropertyName("spell2Casts")] public int Spell2Casts { get; set; }

    [JsonPropertyName("spell3Casts")] public int Spell3Casts { get; set; }

    [JsonPropertyName("spell4Casts")] public int Spell4Casts { get; set; }

    [JsonPropertyName("subteamPlacement")] public int SubteamPlacement { get; set; }

    [JsonPropertyName("summoner1Casts")] public int Summoner1Casts { get; set; }

    [JsonPropertyName("summoner1Id")] public int Summoner1Id { get; set; }

    [JsonPropertyName("summoner2Casts")] public int Summoner2Casts { get; set; }

    [JsonPropertyName("summoner2Id")] public int Summoner2Id { get; set; }

    [JsonPropertyName("summonerId")] public string SummonerId { get; set; } = null!;

    [JsonPropertyName("summonerLevel")] public int SummonerLevel { get; set; }

    [JsonPropertyName("summonerName")] public string SummonerName { get; set; } = null!;

    [JsonPropertyName("teamEarlySurrendered")]
    public bool TeamEarlySurrendered { get; set; }

    [JsonPropertyName("teamId")] public int TeamId { get; set; }

    [JsonPropertyName("teamPosition")] public string TeamPosition { get; set; } = null!;

    [JsonPropertyName("timeCCingOthers")] public int TimeCCingOthers { get; set; }

    [JsonPropertyName("timePlayed")] public int TimePlayed { get; set; }

    [JsonPropertyName("totalAllyJungleMinionsKilled")]
    public int TotalAllyJungleMinionsKilled { get; set; }

    [JsonPropertyName("totalDamageDealt")] public int TotalDamageDealt { get; set; }

    [JsonPropertyName("totalDamageDealtToChampions")]
    public int TotalDamageDealtToChampions { get; set; }

    [JsonPropertyName("totalDamageShieldedOnTeammates")]
    public int TotalDamageShieldedOnTeammates { get; set; }

    [JsonPropertyName("totalDamageTaken")] public int TotalDamageTaken { get; set; }

    [JsonPropertyName("totalEnemyJungleMinionsKilled")]
    public int TotalEnemyJungleMinionsKilled { get; set; }

    [JsonPropertyName("totalHeal")] public int TotalHeal { get; set; }

    [JsonPropertyName("totalHealsOnTeammates")]
    public int TotalHealsOnTeammates { get; set; }

    [JsonPropertyName("totalMinionsKilled")]
    public int TotalMinionsKilled { get; set; }

    [JsonPropertyName("totalTimeCCDealt")] public int TotalTimeCcDealt { get; set; }

    [JsonPropertyName("totalTimeSpentDead")]
    public int TotalTimeSpentDead { get; set; }

    [JsonPropertyName("totalUnitsHealed")] public int TotalUnitsHealed { get; set; }

    [JsonPropertyName("tripleKills")] public int TripleKills { get; set; }

    [JsonPropertyName("trueDamageDealt")] public int TrueDamageDealt { get; set; }

    [JsonPropertyName("trueDamageDealtToChampions")]
    public int TrueDamageDealtToChampions { get; set; }

    [JsonPropertyName("trueDamageTaken")] public int TrueDamageTaken { get; set; }

    [JsonPropertyName("turretKills")] public int TurretKills { get; set; }

    [JsonPropertyName("turretTakedowns")] public int TurretTakedowns { get; set; }

    [JsonPropertyName("turretsLost")] public int TurretsLost { get; set; }

    [JsonPropertyName("unrealKills")] public int UnrealKills { get; set; }

    [JsonPropertyName("visionClearedPings")]
    public int VisionClearedPings { get; set; }

    [JsonPropertyName("visionScore")] public int VisionScore { get; set; }

    [JsonPropertyName("visionWardsBoughtInGame")]
    public int VisionWardsBoughtInGame { get; set; }

    [JsonPropertyName("wardsKilled")] public int WardsKilled { get; set; }

    [JsonPropertyName("wardsPlaced")] public int WardsPlaced { get; set; }

    [JsonPropertyName("win")] public bool Win { get; set; }
}

public class PerksDto
{
    [JsonPropertyName("statPerks")] public PerkStatsDto StatPerks { get; set; } = null!;

    [JsonPropertyName("styles")] public List<PerkStyleDto> Styles { get; set; } = null!;
}

public class ObjectiveDto
{
    [JsonPropertyName("first")] public bool First { get; set; }

    [JsonPropertyName("kills")] public int Kills { get; set; }
}

public class PerkStyleSelectionDto
{
    [JsonPropertyName("perk")] public int Perk { get; set; }

    [JsonPropertyName("var1")] public int Var1 { get; set; }

    [JsonPropertyName("var2")] public int Var2 { get; set; }

    [JsonPropertyName("var3")] public int Var3 { get; set; }
}

public class PerkStatsDto
{
    [JsonPropertyName("defense")] public int Defense { get; set; }

    [JsonPropertyName("flex")] public int Flex { get; set; }

    [JsonPropertyName("offense")] public int Offense { get; set; }
}

public class PerkStyleDto
{
    [JsonPropertyName("description")] public string Description { get; set; } = null!;

    [JsonPropertyName("selections")] public List<PerkStyleSelectionDto> Selections { get; set; } = null!;

    [JsonPropertyName("style")] public int Style { get; set; }
}

public class TeamDto
{
    [JsonPropertyName("bans")] public List<BanDto> Bans { get; set; } = null!;

    [JsonPropertyName("objectives")] public ObjectivesDto Objectives { get; set; } = null!;

    [JsonPropertyName("teamId")] public int TeamId { get; set; }

    [JsonPropertyName("win")] public bool Win { get; set; }
}
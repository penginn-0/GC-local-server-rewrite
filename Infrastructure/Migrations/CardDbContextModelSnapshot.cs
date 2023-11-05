﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CardDbContext))]
    partial class CardDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Domain.Entities.CardBdatum", b =>
                {
                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("card_id");

                    b.Property<string>("Bdata")
                        .HasColumnType("TEXT")
                        .HasColumnName("bdata");

                    b.Property<long>("BdataSize")
                        .HasColumnType("INTEGER")
                        .HasColumnName("bdata_size");

                    b.HasKey("CardId");

                    b.ToTable("card_bdata", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CardDetail", b =>
                {
                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("card_id");

                    b.Property<long>("Pcol1")
                        .HasColumnType("INTEGER")
                        .HasColumnName("pcol1");

                    b.Property<long>("Pcol2")
                        .HasColumnType("INTEGER")
                        .HasColumnName("pcol2");

                    b.Property<long>("Pcol3")
                        .HasColumnType("INTEGER")
                        .HasColumnName("pcol3");

                    b.Property<long>("Fcol1")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fcol1");

                    b.Property<long>("Fcol2")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fcol2");

                    b.Property<long>("Fcol3")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fcol3");

                    b.Property<string>("LastPlayTenpoId")
                        .HasColumnType("TEXT")
                        .HasColumnName("last_play_tenpo_id");

                    b.Property<long?>("LastPlayTime")
                        .HasColumnType("INTEGER")
                        .HasColumnName("last_play_time");

                    b.Property<long>("ScoreBi1")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_bi1");

                    b.Property<long>("ScoreI1")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_i1");

                    b.Property<long>("ScoreUi1")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_ui1");

                    b.Property<long>("ScoreUi2")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_ui2");

                    b.Property<long>("ScoreUi3")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_ui3");

                    b.Property<long>("ScoreUi4")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_ui4");

                    b.Property<long>("ScoreUi5")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_ui5");

                    b.Property<long>("ScoreUi6")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_ui6");

                    b.HasKey("CardId", "Pcol1", "Pcol2", "Pcol3");

                    b.ToTable("card_detail", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CardMain", b =>
                {
                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("card_id");

                    b.Property<string>("AchieveStatus")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("achieve_status");

                    b.Property<string>("Created")
                        .HasColumnType("TEXT")
                        .HasColumnName("created");

                    b.Property<long>("Fcol1")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fcol1");

                    b.Property<long>("Fcol2")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fcol2");

                    b.Property<long>("Fcol3")
                        .HasColumnType("INTEGER")
                        .HasColumnName("fcol3");

                    b.Property<string>("Modified")
                        .HasColumnType("TEXT")
                        .HasColumnName("modified");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("player_name");

                    b.Property<long>("ScoreI1")
                        .HasColumnType("INTEGER")
                        .HasColumnName("score_i1");

                    b.HasKey("CardId");

                    b.ToTable("card_main", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CardPlayCount", b =>
                {
                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("card_id");

                    b.Property<long>("LastPlayedTime")
                        .HasColumnType("INTEGER")
                        .HasColumnName("last_played_time");

                    b.Property<long>("PlayCount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("play_count");

                    b.HasKey("CardId");

                    b.ToTable("CardPlayCount", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.GlobalScoreRank", b =>
                {
                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvatarId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Fcol1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LastPlayTenpoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pref")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PrefId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenpoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("TitleId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalScore")
                        .HasColumnType("INTEGER");

                    b.HasKey("CardId");

                    b.ToTable("GlobalScoreRank", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MonthlyScoreRank", b =>
                {
                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvatarId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Fcol1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LastPlayTenpoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pref")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PrefId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenpoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("TitleId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalScore")
                        .HasColumnType("INTEGER");

                    b.HasKey("CardId");

                    b.ToTable("MonthlyScoreRank", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OnlineMatch", b =>
                {
                    b.Property<long>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Guid")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("INTEGER");

                    b.HasKey("MatchId");

                    b.ToTable("OnlineMatches", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OnlineMatchEntry", b =>
                {
                    b.Property<long>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("EntryId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("AvatarId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MachineId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MatchRemainingTime")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MatchTimeout")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MatchWaitTime")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pref")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("PrefId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<long>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TenpoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenpoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("TitleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MatchId", "EntryId");

                    b.ToTable("OnlineMatchEntries", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.PlayNumRank", b =>
                {
                    b.Property<int>("MusicId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrevRank")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrevRank2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rank2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MusicId");

                    b.ToTable("PlayNumRank", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ShopScoreRank", b =>
                {
                    b.Property<long>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvatarId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Fcol1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LastPlayTenpoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pref")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PrefId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenpoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("TitleId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalScore")
                        .HasColumnType("INTEGER");

                    b.HasKey("CardId");

                    b.ToTable("ShopScoreRank", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OnlineMatchEntry", b =>
                {
                    b.HasOne("Domain.Entities.OnlineMatch", null)
                        .WithMany("Entries")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.OnlineMatch", b =>
                {
                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}

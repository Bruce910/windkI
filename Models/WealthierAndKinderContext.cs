using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Final10._14.Models;

public partial class WealthierAndKinderContext : DbContext
{
    public WealthierAndKinderContext()
    {
    }

    public WealthierAndKinderContext(DbContextOptions<WealthierAndKinderContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TBlock> TBlocks { get; set; }

    public virtual DbSet<TComment> TComments { get; set; }

    public virtual DbSet<TDistrict> TDistricts { get; set; }

    public virtual DbSet<TEmployeeMember> TEmployeeMembers { get; set; }

    public virtual DbSet<TFollower> TFollowers { get; set; }

    public virtual DbSet<TGroupMember> TGroupMembers { get; set; }

    public virtual DbSet<THashtag> THashtags { get; set; }

    public virtual DbSet<THelp> THelps { get; set; }

    public virtual DbSet<THelpClass> THelpClasses { get; set; }

    public virtual DbSet<THelpMessageRecord> THelpMessageRecords { get; set; }

    public virtual DbSet<THelpSkill> THelpSkills { get; set; }

    public virtual DbSet<TLike> TLikes { get; set; }

    public virtual DbSet<TLoginRecord> TLoginRecords { get; set; }

    public virtual DbSet<TMatch> TMatches { get; set; }

    public virtual DbSet<TMemberSkill> TMemberSkills { get; set; }

    public virtual DbSet<TMessage> TMessages { get; set; }

    public virtual DbSet<TOrder> TOrders { get; set; }

    public virtual DbSet<TOrderDetail> TOrderDetails { get; set; }

    public virtual DbSet<TPersonMember> TPersonMembers { get; set; }

    public virtual DbSet<TPointList> TPointLists { get; set; }

    public virtual DbSet<TPost> TPosts { get; set; }

    public virtual DbSet<TProduct> TProducts { get; set; }

    public virtual DbSet<TProductCategory> TProductCategories { get; set; }

    public virtual DbSet<TSponsor> TSponsors { get; set; }

    public virtual DbSet<TSponsorCategory> TSponsorCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WealthierAndKinder;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TBlock>(entity =>
        {
            entity.HasKey(e => e.FBlockSid);

            entity.ToTable("tBlock");

            entity.Property(e => e.FBlockSid).HasColumnName("fBlockSId");
            entity.Property(e => e.FBlockType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fBlockType");
            entity.Property(e => e.FBlockUserId)
                .HasMaxLength(20)
                .HasColumnName("fBlockUserId");
            entity.Property(e => e.FUserId)
                .HasMaxLength(20)
                .HasColumnName("fUserId");
        });

        modelBuilder.Entity<TComment>(entity =>
        {
            entity.HasKey(e => e.FCommentId);

            entity.ToTable("tComment");

            entity.Property(e => e.FCommentId).HasColumnName("fCommentId");
            entity.Property(e => e.FContent)
                .HasMaxLength(500)
                .HasColumnName("fContent");
            entity.Property(e => e.FCratedAt).HasColumnName("fCratedAT");
            entity.Property(e => e.FPostId).HasColumnName("fPostId");
            entity.Property(e => e.FUpdateAt).HasColumnName("fUpdateAt");
            entity.Property(e => e.FUserId)
                .HasMaxLength(20)
                .HasColumnName("fUserId");
        });

        modelBuilder.Entity<TDistrict>(entity =>
        {
            entity.HasKey(e => e.FDistrictId);

            entity.ToTable("tDistrict");

            entity.Property(e => e.FDistrictId).HasColumnName("fDistrictId");
            entity.Property(e => e.FDistrict)
                .HasMaxLength(50)
                .HasColumnName("fDistrict");
        });

        modelBuilder.Entity<TEmployeeMember>(entity =>
        {
            entity.HasKey(e => e.FEmployeeSid);

            entity.ToTable("tEmployeeMember");

            entity.Property(e => e.FEmployeeSid).HasColumnName("fEmployeeSId");
            entity.Property(e => e.FAccount)
                .HasMaxLength(50)
                .HasColumnName("fAccount");
            entity.Property(e => e.FBirthDate).HasColumnName("fBirthDate");
            entity.Property(e => e.FEmail)
                .HasMaxLength(50)
                .HasColumnName("fEmail");
            entity.Property(e => e.FFirstName)
                .HasMaxLength(50)
                .HasColumnName("fFirstName");
            entity.Property(e => e.FIdentification)
                .HasMaxLength(20)
                .HasColumnName("fIdentification");
            entity.Property(e => e.FIp)
                .HasMaxLength(50)
                .HasColumnName("fIp");
            entity.Property(e => e.FLastName)
                .HasMaxLength(50)
                .HasColumnName("fLastName");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FPassword)
                .HasMaxLength(20)
                .HasColumnName("fPassword");
            entity.Property(e => e.FPermissions).HasColumnName("fPermissions");
            entity.Property(e => e.FRegDate).HasColumnName("fRegDate");
            entity.Property(e => e.FSex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fSex");
            entity.Property(e => e.FStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fStatus");
            entity.Property(e => e.FUserName)
                .HasMaxLength(50)
                .HasColumnName("fUserName");
        });

        modelBuilder.Entity<TFollower>(entity =>
        {
            entity.HasKey(e => e.FFollowerSid);

            entity.ToTable("tFollower");

            entity.Property(e => e.FFollowerSid).HasColumnName("fFollowerSId");
            entity.Property(e => e.FFollower)
                .HasMaxLength(20)
                .HasColumnName("fFollower");
            entity.Property(e => e.FFollowing)
                .HasMaxLength(20)
                .HasColumnName("fFollowing");
        });

        modelBuilder.Entity<TGroupMember>(entity =>
        {
            entity.HasKey(e => e.FGroupSid);

            entity.ToTable("tGroupMember");

            entity.Property(e => e.FGroupSid).HasColumnName("fGroupSId");
            entity.Property(e => e.FAccount)
                .HasMaxLength(50)
                .HasColumnName("fAccount");
            entity.Property(e => e.FCoLocation)
                .HasMaxLength(50)
                .HasColumnName("fCoLocation");
            entity.Property(e => e.FCorporation)
                .HasMaxLength(50)
                .HasColumnName("fCorporation");
            entity.Property(e => e.FEmail)
                .HasMaxLength(50)
                .HasColumnName("fEmail");
            entity.Property(e => e.FIp)
                .HasMaxLength(50)
                .HasColumnName("fIp");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FPassword)
                .HasMaxLength(20)
                .HasColumnName("fPassword");
            entity.Property(e => e.FPermissions).HasColumnName("fPermissions");
            entity.Property(e => e.FRegDate).HasColumnName("fRegDate");
            entity.Property(e => e.FRepresentName)
                .HasMaxLength(50)
                .HasColumnName("fRepresentName");
            entity.Property(e => e.FStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fStatus");
            entity.Property(e => e.FTotalCapital).HasColumnName("fTotalCapital");
            entity.Property(e => e.FUniBusinessNo)
                .HasMaxLength(50)
                .HasColumnName("fUniBusinessNo");
        });

        modelBuilder.Entity<THashtag>(entity =>
        {
            entity.HasKey(e => e.FHashTagSid);

            entity.ToTable("tHashtag");

            entity.Property(e => e.FHashTagSid).HasColumnName("fHashTagSId");
            entity.Property(e => e.FHashTag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fHashTag");
            entity.Property(e => e.FMemberType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fMemberType");
            entity.Property(e => e.FPostId).HasColumnName("fPostId");
            entity.Property(e => e.FUserId)
                .HasMaxLength(20)
                .HasColumnName("fUserId");
        });

        modelBuilder.Entity<THelp>(entity =>
        {
            entity.HasKey(e => e.FHelpId);

            entity.ToTable("tHelp");

            entity.Property(e => e.FHelpId).HasColumnName("fHelpId");
            entity.Property(e => e.FDistrictId).HasColumnName("fDistrictId");
            entity.Property(e => e.FExpDate)
                .HasColumnType("datetime")
                .HasColumnName("fExpDate");
            entity.Property(e => e.FHelpClassId).HasColumnName("fHelpClassId");
            entity.Property(e => e.FHelpDescribe)
                .HasMaxLength(200)
                .HasColumnName("fHelpDescribe");
            entity.Property(e => e.FHelpSkillId).HasColumnName("fHelpSkillId");
            entity.Property(e => e.FHelpStatus).HasColumnName("fHelpStatus");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FMemberType).HasColumnName("fMemberType");
            entity.Property(e => e.FMfdDate)
                .HasColumnType("datetime")
                .HasColumnName("fMfdDate");
            entity.Property(e => e.FName)
                .HasMaxLength(50)
                .HasColumnName("fName");
            entity.Property(e => e.FNid)
                .HasMaxLength(50)
                .HasColumnName("fNId");
            entity.Property(e => e.FPhone)
                .HasMaxLength(50)
                .HasColumnName("fPhone");
            entity.Property(e => e.FTaxId).HasColumnName("fTaxID");
        });

        modelBuilder.Entity<THelpClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tHelpClass");

            entity.Property(e => e.FHelpClass)
                .HasMaxLength(50)
                .HasColumnName("fHelpClass");
            entity.Property(e => e.FHelpClassId)
                .ValueGeneratedOnAdd()
                .HasColumnName("fHelpClassId");
        });

        modelBuilder.Entity<THelpMessageRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tHelpMessageRecord");

            entity.Property(e => e.FContent)
                .HasMaxLength(200)
                .HasColumnName("fContent");
            entity.Property(e => e.FHelpId).HasColumnName("fHelpId");
            entity.Property(e => e.FMessageRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("fMessageRecord");
            entity.Property(e => e.FPublicOrNot).HasColumnName("fPublicOrNot");
            entity.Property(e => e.FSendDate)
                .HasColumnType("datetime")
                .HasColumnName("fSendDate");
        });

        modelBuilder.Entity<THelpSkill>(entity =>
        {
            entity.HasKey(e => e.FHelpSkillId);

            entity.ToTable("tHelpSkill");

            entity.Property(e => e.FHelpSkillId).HasColumnName("fHelpSkillId");
            entity.Property(e => e.FHelpSkill)
                .HasMaxLength(50)
                .HasColumnName("fHelpSkill");
        });

        modelBuilder.Entity<TLike>(entity =>
        {
            entity.HasKey(e => e.FLikesSid);

            entity.ToTable("tLikes");

            entity.Property(e => e.FLikesSid).HasColumnName("fLikesSId");
            entity.Property(e => e.FPostId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fPostId");
            entity.Property(e => e.FTimestamp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fTimestamp");
            entity.Property(e => e.FUserId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fUserId");
        });

        modelBuilder.Entity<TLoginRecord>(entity =>
        {
            entity.HasKey(e => e.FLogId);

            entity.ToTable("tLoginRecord");

            entity.Property(e => e.FLogId).HasColumnName("fLogId");
            entity.Property(e => e.FIp)
                .HasMaxLength(50)
                .HasColumnName("fIp");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("fTimestamp");
        });

        modelBuilder.Entity<TMatch>(entity =>
        {
            entity.HasKey(e => e.FMatchId);

            entity.ToTable("tMatch");

            entity.Property(e => e.FMatchId).HasColumnName("fMatchId");
            entity.Property(e => e.FGrade).HasColumnName("fGrade");
            entity.Property(e => e.FGradeDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fGradeDateTime");
            entity.Property(e => e.FHelpId).HasColumnName("fHelpId");
            entity.Property(e => e.FMatchDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fMatchDateTime");
            entity.Property(e => e.FMatchStatus)
                .HasDefaultValue(2)
                .HasColumnName("fMatchStatus");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FMessage)
                .HasMaxLength(200)
                .HasColumnName("fMessage");
            entity.Property(e => e.FPoint).HasColumnName("fPoint");
        });

        modelBuilder.Entity<TMemberSkill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tMemberSkill");

            entity.Property(e => e.FHelpSkillId).HasColumnName("fHelpSkillId");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
        });

        modelBuilder.Entity<TMessage>(entity =>
        {
            entity.HasKey(e => e.FMessid);

            entity.ToTable("tMessage");

            entity.Property(e => e.FMessid).HasColumnName("fMessid");
            entity.Property(e => e.FMessContent)
                .HasMaxLength(50)
                .HasColumnName("fMessContent");
            entity.Property(e => e.FRid)
                .HasMaxLength(20)
                .HasColumnName("fRId");
            entity.Property(e => e.FSid)
                .HasMaxLength(20)
                .HasColumnName("fSId");
            entity.Property(e => e.FTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("fTimestamp");
        });

        modelBuilder.Entity<TOrder>(entity =>
        {
            entity.HasKey(e => e.FOrderId);

            entity.ToTable("tOrder");

            entity.Property(e => e.FOrderId).HasColumnName("fOrderId");
            entity.Property(e => e.FBeginTime)
                .HasColumnType("datetime")
                .HasColumnName("fBeginTime");
            entity.Property(e => e.FExecStatus).HasColumnName("fExecStatus");
            entity.Property(e => e.FFinishTime)
                .HasColumnType("datetime")
                .HasColumnName("fFinishTime");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FOrderTime)
                .HasColumnType("datetime")
                .HasColumnName("fOrderTime");
            entity.Property(e => e.FProof)
                .HasColumnType("image")
                .HasColumnName("fProof");
            entity.Property(e => e.FStatus).HasColumnName("fStatus");
            entity.Property(e => e.FTotalHelpPoint).HasColumnName("fTotalHelpPoint");
        });

        modelBuilder.Entity<TOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tOrderDetail");

            entity.Property(e => e.FAmount).HasColumnName("fAmount");
            entity.Property(e => e.FHelpPoint).HasColumnName("fHelpPoint");
            entity.Property(e => e.FOrderDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("fOrderDetailId");
            entity.Property(e => e.FOrderId).HasColumnName("fOrderId");
            entity.Property(e => e.FProductId).HasColumnName("fProductId");
        });

        modelBuilder.Entity<TPersonMember>(entity =>
        {
            entity.HasKey(e => e.FPersonSid);

            entity.ToTable("tPersonMember");

            entity.Property(e => e.FPersonSid).HasColumnName("fPersonSId");
            entity.Property(e => e.FAccount)
                .HasMaxLength(50)
                .HasColumnName("fAccount");
            entity.Property(e => e.FBirthDate).HasColumnName("fBirthDate");
            entity.Property(e => e.FDistrictId).HasColumnName("fDistrictId");
            entity.Property(e => e.FEmail)
                .HasMaxLength(50)
                .HasColumnName("fEmail");
            entity.Property(e => e.FFirstName)
                .HasMaxLength(50)
                .HasColumnName("fFirstName");
            entity.Property(e => e.FIdentification)
                .HasMaxLength(20)
                .HasColumnName("fIdentification");
            entity.Property(e => e.FIp)
                .HasMaxLength(50)
                .HasColumnName("fIp");
            entity.Property(e => e.FLastName)
                .HasMaxLength(50)
                .HasColumnName("fLastName");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FMemberImage).HasColumnName("fMemberImage");
            entity.Property(e => e.FPassword)
                .HasMaxLength(20)
                .HasColumnName("fPassword");
            entity.Property(e => e.FPermissions).HasColumnName("fPermissions");
            entity.Property(e => e.FRegDate).HasColumnName("fRegDate");
            entity.Property(e => e.FSex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fSex");
            entity.Property(e => e.FStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fStatus");
            entity.Property(e => e.FTotalAsset).HasColumnName("fTotalAsset");
            entity.Property(e => e.FTotalHelpPoint).HasColumnName("fTotalHelpPoint");
            entity.Property(e => e.FUserName)
                .HasMaxLength(50)
                .HasColumnName("fUserName");
        });

        modelBuilder.Entity<TPointList>(entity =>
        {
            entity.HasKey(e => e.FPointListId);

            entity.ToTable("tPointList");

            entity.Property(e => e.FPointListId).HasColumnName("fPointListId");
            entity.Property(e => e.FMatchId).HasColumnName("fMatchId");
            entity.Property(e => e.FMemberId)
                .HasMaxLength(20)
                .HasColumnName("fMemberId");
            entity.Property(e => e.FOrderId).HasColumnName("fOrderId");
            entity.Property(e => e.FRecordTime)
                .HasColumnType("datetime")
                .HasColumnName("fRecordTime");
            entity.Property(e => e.FSourse).HasColumnName("fSourse");
        });

        modelBuilder.Entity<TPost>(entity =>
        {
            entity.HasKey(e => e.FPostId);

            entity.ToTable("tPost");

            entity.Property(e => e.FPostId).HasColumnName("fPostId");
            entity.Property(e => e.FFinStatement)
                .HasColumnType("image")
                .HasColumnName("fFinStatement");
            entity.Property(e => e.FLikes).HasColumnName("fLikes");
            entity.Property(e => e.FMemberType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fMemberType");
            entity.Property(e => e.FParentCommentId).HasColumnName("fParentCommentId");
            entity.Property(e => e.FPostContent)
                .HasMaxLength(256)
                .HasColumnName("fPostContent");
            entity.Property(e => e.FTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("fTimestamp");
            entity.Property(e => e.FUserId)
                .HasMaxLength(20)
                .HasColumnName("fUserId");
            entity.Property(e => e.FUserName)
                .HasMaxLength(50)
                .HasColumnName("fUserName");
        });

        modelBuilder.Entity<TProduct>(entity =>
        {
            entity.HasKey(e => e.FProductId);

            entity.ToTable("tProduct");

            entity.Property(e => e.FProductId).HasColumnName("fProductId");
            entity.Property(e => e.FDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fDescription");
            entity.Property(e => e.FProductCategoryId).HasColumnName("fProductCategoryId");
            entity.Property(e => e.FProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fProductName");
            entity.Property(e => e.FSales).HasColumnName("fSales");
            entity.Property(e => e.FSponsorId).HasColumnName("fSponsorId");
            entity.Property(e => e.FStatus).HasColumnName("fStatus");
            entity.Property(e => e.FStock).HasColumnName("fStock");
            entity.Property(e => e.FUnitlHelpPoint).HasColumnName("fUnitlHelpPoint");
        });

        modelBuilder.Entity<TProductCategory>(entity =>
        {
            entity.HasKey(e => e.FProductCategoryId);

            entity.ToTable("tProductCategory");

            entity.Property(e => e.FProductCategoryId).HasColumnName("fProductCategoryId");
            entity.Property(e => e.FDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fDescription");
            entity.Property(e => e.FProductCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fProductCategoryName");
        });

        modelBuilder.Entity<TSponsor>(entity =>
        {
            entity.HasKey(e => e.FSponsorId);

            entity.ToTable("tSponsor");

            entity.Property(e => e.FSponsorId).HasColumnName("fSponsorId");
            entity.Property(e => e.FAddress)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("fAddress");
            entity.Property(e => e.FCapital)
                .HasColumnType("money")
                .HasColumnName("fCapital");
            entity.Property(e => e.FIntroduction)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fIntroduction");
            entity.Property(e => e.FPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fPhone");
            entity.Property(e => e.FSponsorCategoryId).HasColumnName("fSponsorCategoryId");
            entity.Property(e => e.FSponsorName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fSponsorName");
            entity.Property(e => e.FStatus).HasColumnName("fStatus");
        });

        modelBuilder.Entity<TSponsorCategory>(entity =>
        {
            entity.HasKey(e => e.FSponsorCategoryId);

            entity.ToTable("tSponsorCategory");

            entity.Property(e => e.FSponsorCategoryId).HasColumnName("fSponsorCategoryId");
            entity.Property(e => e.FDescriptionFDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fDescription\r\nfDescription");
            entity.Property(e => e.FSponsorCategoryrName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fSponsorCategoryrName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

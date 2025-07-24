using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.GT
{
    public class bol_GT_Team
    {

    }
    public class bol_Team_Detail {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string TeamLeader { get; set; }
        public string CashCollector { get; set; }
        public string City { get; set; }
        public Boolean IsActive { get; set; }
        public List<bol_Team_Member> TeamMembers { get; set; }
        public int CityID { get; set; }
        public string TeamLeaderFullName { get; set; }
        public string[] CashCollectorArray { get; set; }
        public List<bol_GroupLeader> CashCollectorList { get; set; }
    }
    public class bol_Team_Member_Req
    {
        public int ActionParam { get; set; }
        public int TeamID { get; set; }
    }
    public class bol_Team_Member {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
    }
    public class bol_Search
    {
        public int searchTeamName { get; set; }
        public int searchCity { get; set; }
        public int searchGroupName { get; set; }
    }
    public class bol_Team_List_Req
    {
        public int ActionParam { get; set; }
        public int searchTeamName { get; set; }
        public int searchCity { get; set; }
    }
    public class bol_UpdateTeamNameReq
    {
        public int ActionParam { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }
    public class bol_GetTeamMemberList
    {
        public int ActionParam { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string CashCollector { get; set; }
    }
    public class bol_AddNewTeamReq
    {
        public int ActionParam { get; set; }
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string TeamMembers { get; set; }
        public string TeamLeader { get; set; }
        public int City { get; set; }
        public string CashCollector { get; set; }
        public Boolean Active { get; set; }
    }
    public class bol_Group_List_Req
    {
        public int ActionParam { get; set; }
        public int searchGroupName { get; set; }
    }
    public class bol_Group_Detail
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string[] GroupLeader { get; set; }
        public Boolean Active { get; set; }
        public List<bol_UpdateTeamNameReq> Teams { get; set; }
        public List<bol_GroupLeader> GroupLeader1{get; set;}
    }
    public class bol_TeamReq
    {
        public int ActionParam { get; set; }
        public int GroupID { get; set; }
    }
    public class bol_GroupLeaderList
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
    }
    public class bol_AddGroupReq
    {
        public int ActionParam { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string GroupLeader { get; set; }
        public string GroupMember { get; set; }
        public Boolean Active { get; set; }
        public string CreatedBy { get; set; }
    }
    public class bol_GroupLeader
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
    }
    public class bol_Member
    {
        public string GroupName { get; set; }
        public string TeamName { get; set; }
        public string TeamLeader { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsTeamLeader { get; set; }
        public Boolean IsGroupLeader { get; set; }
        public Boolean CanTeamLeader { get; set; }
        public Boolean CanGroupLeader { get; set; }
        public int GroupID { get; set; }
        public int TeamID { get; set; }
        public  string GroupLeader { get; set; }
        public string UpdatedBy { get; set; }
        public int PreviousTeamID { get; set; }
        public string PreviousTeamLeader { get; set; }
    }
    public class bol_member_req
    {
        public string searchMember { get; set; }
        public int searchGroup { get; set; }
        public int searchTeam { get; set; }
    }
   
}

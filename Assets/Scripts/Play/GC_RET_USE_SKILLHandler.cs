﻿//This code create by CodeEngine
namespace SPacket.SocketInstance
{
    //接收消息后，技能播放逻辑脚本
    public class GC_RET_USE_SKILLHandler : Ipacket
    {
        public uint Execute(PacketDistributed ipacket)
        {
            //GC_RET_USE_SKILL packet = (GC_RET_USE_SKILL)ipacket;
           // if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;
            //enter your logic
            //int nSkillId = packet.SkillId;
            //int nSenderId = packet.SenderId;
            //int nTargetID = packet.TargetId;

            //Obj_Character Sender = Singleton<ObjManager>.GetInstance().FindObjCharacterInScene(nSenderId);
            //if (Sender == null)
            //{
            //    return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;

            //}
            //if (Sender.SkillCore == null)
            //{
            //    return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
            //}
            //int nFailType = (int)SKILLUSEFAILTYPE.INVALID;
            //if (packet.HasSkillfailType)
            //{
            //    nFailType = packet.SkillfailType;
            //}
            //Tab_SkillEx skillex = TableManager.GetSkillExByID(nSkillId, 0);
            //if (skillex == null)
            //{
            //    return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
            //}
            //			if(skillex.CheckTime!=-1&&(Sender.ObjType ==GameDefine_Globe.OBJ_TYPE.OBJ_MAIN_PLAYER))
            //			{
            //				return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
            //			}
            //if (GameManager.gameManager.RunningScene == 13)//新手教程地图里放完xp特效后消失
            //{
            //    Tab_SkillBase skillbase = TableManager.GetSkillBaseByID(skillex.BaseId, 0);
            //    if ((skillbase.SkillClass & (int)SKILLCLASS.XP) != 0)
            //    {
            //        SkillBarLogic.Instance().PlayXPActiveEffect(false);
            //    }
            //}
            string szSkillName = "";
            //if (packet.HasSkillname)
            //{
            //    szSkillName = packet.Skillname;
            //}
            //?????????
            //if (nFailType == 0)
            //{
            //    GameManager.gameManager.PlayerDataPool.Usingskill = 0;
            //    return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
            //}
            //else
            //{

            //    int _rangeEffectType = skillex.RangeEffectType;
            //    if ((Sender.ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_NPC))
            //    {
            //        if (_rangeEffectType != -1)
            //        {
            //            Sender.PlaySkillRangeEffect(nSkillId);
            //        }


            //    }


            //    if (szSkillName != "")
            //    {
            //        Sender.SkillCore.UseSkill(nSkillId, nSenderId, nTargetID, szSkillName);
            //        Debug.Log("ffff" + nTargetID);
            //    }
            //    else
            //    {
            //        Sender.SkillCore.UseSkill(nSkillId, nSenderId, nTargetID);
            //        Debug.Log("ffff" + nTargetID);
            //    }

            //}
            return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
        }
    }
    public enum PACKET_EXE
    {
        PACKET_EXE_ERROR = 0,
        PACKET_EXE_BREAK,
        PACKET_EXE_CONTINUE,
        PACKET_EXE_NOTREMOVE,
        PACKET_EXE_NOTREMOVE_ERROR,
    }
    public interface Ipacket
    {
        uint Execute(PacketDistributed packet);
    }
}

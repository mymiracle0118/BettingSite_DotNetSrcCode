﻿using Models.DimFrontDUser;
using System;
using System.Data;

namespace Services.DimFrontDUser
{
    public interface IDimFrontService
    {
        DataSet RefreshToken(string userid, string rt);
        DataSet Framelogin(Framelogin framelogin);
        DataSet UserLogin(UserLogin userLogin);
        DataSet GetDate();
        DataSet ChkIP(String ip);
        DataSet CheckWords(Guid uu_id, int uid, String ip, String param, String proname);
        DataSet Login(Login login);
        DataSet VerifyCode(VerifyCode vc);
        DataSet GetAuth(Guid uguid, String lvlno);
        DataSet AuthOn(Guid uguid, String lvlno);
        DataSet AuthOff(VerifyCode vc);
        DataSet VerifyCodeTele(VerifyCode vc);
        DataSet UserCheckTele(Guid uguid, String lvlno);
        DataSet GenOtpTele(Guid uguid);
        DataSet AuthOnTele(AuthOnTele aot);
        DataSet AuthOffTele(VerifyCode vc);
        DataSet BannerData();
        DataSet Casinolist(Casinolist casinolist);
        DataSet TreeviewData();
        DataSet HighlightData(HighlightData highlightData);
        DataSet GameTab();
        DataSet Getmid(Guid uguid);
        DataSet UserData(Int32 uid);
        DataSet UserBook(UserBook userBook);
        DataSet GetCasinoList(Casino cs);
        DataSet GetCasinoTabList(CasinoTabs ct);
        DataSet GetCasinoTableList(CasinoTables ct);
        DataSet ButtonList(Int32 uid);
        DataSet ButtonUpdate(ButtonUpdate buttonUpdate);
        DataSet ButtonListcs(Int32 uid);
        DataSet ButtonUpdatecs(ButtonUpdate buttonUpdate);
        DataSet Matchdtlbet(Matchdtlbet matchdtlbet);
        DataSet Matchdtlbetodds(String gmid);
        DataSet ChangePass(ChangePass changepass);
        DataSet CasinoUserBook(CasinoUserBook casinoUserBook);
        DataSet VCasinoUserBook(CasinoUserBook casinoUserBook);
        DataSet AccountStatementAcc(AccountStatement accountStatement);
        DataSet AccountStatementCS(AccountStatement accountStatement);
        DataSet AccountStatementBet(AccountStatement accountStatement);
        DataSet AccountStatementParty3(AccountStatement accountStatement);
        DataSet AccStatePopup(AccStatePopup accStatePopup);
        DataSet AccDabaBet(AccDabaBet accDabaBet);
        DataSet AccDreamBet(AccDabaBet accDabaBet);
        DataSet AutoCon(Int64 uid);
        DataSet AutoconUpdate(AutoconUpdate autoconUpdate);
        DataSet OtherCasino(OtherCasino otherCasino);
        DataSet FancyBook(FancyBook fancyBook);
        DataSet KhadoBook(FancyBook fancyBook);
        DataSet MeterBook(FancyBook fancyBook);
        DataSet MarketAnalysis(Int32 uid);
        DataSet MarketAnalysisReportodds(String gmid);
        DataSet GetM(GetM getM);
        DataSet GameSer(GameSer gameSer);
        DataSet History(History history);
        DataSet Tvata(Tvata tvata);
        DataSet RunnerViewmore(RunnerViewmore runnerViewmore);
        DataSet TvCsData(TvCsData tvCsData);
        DataSet GetTPCSUserData(Int32 uid, String ctype, String statement);
        DataSet GetTPCSUserMster(TPCSUserMaster objtpcsum);
        DataSet LoginEZ(EZLogin ez);
        DataSet LoginSS(SSLogin ss);
        DataSet LoginQT(QTLogin qt);
        DataSet LoginEV(EZLogin ev);
        DataSet LoginR(QTLogin qt);
        DataSet LoginCF(CFLogin cf);
        DataSet updatetoken(String guid, String newtoken, String token);
        DataSet Rules();
        DataSet Casinores(Casinores casinores);
        DataSet Casino();
        DataSet CheckCasinovs(CheckCasinovs checkCasinovs);
        DataSet TPReport(TPReport tPReport);
        DataSet TPgtypelist();
        DataSet TPAllReport(TPAllReport tPAllReport);
        DataSet TPcurrentbets(Int32 uid);
        DataSet TPcurrentbets1(Int32 uid);
        DataSet AcceptRules(Guid uu_id);
        DataSet CasinoRules(CasinoRules casinoRules);
        DataSet Loginpoptheball(String guid, Int64 uid);
        DataSet Popballtoken(String guid, String seid);
        DataSet Loginludo(String guid, Int64 uid);
        DataSet Ludotoken(String guid, String seid);
        DataSet WorliPana(WorliPana worliPana);
        DataSet WorliRule(WorliRule worliRule);
        DataSet Cricketv3popup(Cricketv3popup cricketv3Popup);
        DataSet CricketSopopup(Cricketv3popup cricketv3Popup);
        DataSet Cricketv3popupsoda(Cricketv3popup cricketv3Popup);
        DataSet Usercreate();
        DataSet Paymentval(Paymentval paymentval);
        DataSet Createreq(Createreq rWithdraw);
        DataSet Getreq(String uid);
        DataSet LoginTeen(String guid, Int64 uid);
        DataSet Gamedata2(GameData gameData);
        DataSet GetCop(Guid guid);
        DataSet RptDelBet(DeleteBetReport dbr);
        DataSet Fancypopup(Fancypopup dbr);
        DataSet Casinolisttest(TPTest tt);
        DataSet Providerlist(TPTest tt);
        DataSet Categorylist(Categorylist dbr);
        DataSet Slotlist(Slotlist dbr);
        DataSet LoginTGS(TGSLogin tgs);
        DataSet LoginVL(EZLogin ez);
        DataSet LoginES(ESLogin es);
        DataSet GetRules(GetRules vt);
        DataSet KbcUserBook(CasinoUserBook casinoUserBook);
        DataSet KbcPayout(KbcPayout kbcPayout);
        DataSet LaunchCasino(CasinoLogin cl);
        DataSet Paymenturltoken(Paymenturltoken cl);
        DataSet Paymentwith(Paymentwith paymentwith);
        DataSet GetPaymentwith(String uid);
        DataSet Horsedetail(Horsedetail paymentwith);
        DataSet PlacebetDconGK(PlacebetDconGK placebet);
        DataSet GetDepolist(Int64 uid);
        DataSet Verifyamt(Couponlist couponlist);
        DataSet CouponActive(Couponlist couponlist);
        DataSet Masterexp(Couponlist couponlist);
        DataSet PaymenturlNew(Paymenturltoken userLogin);
        DataSet Paymentlst(Paymentlst userLogin);
        DataSet Paymentlstsub(Paymentlst userLogin);
        DataSet LoginVGS(VGSLogin tgs);
        DataSet LoginSSG(SSGLogin ssg);
        DataSet LoginAstar(AstarLogin astar);
        DataSet LoginTP(LoginTP ltp);
        DataSet Paymentcur(Int64 uid);
        DataSet Paymentuupdate(Paymentuupdate paymentuupdate);
    }
}

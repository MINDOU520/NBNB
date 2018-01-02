using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DALFactory;
using IDAL;

namespace BLL
{
    public  class VideoManager
    {
        private static IVideo ivideo = (IVideo)DataAccess.Get<SqlServerVideo>();
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public static int addVideo(Video video)
        {
            return ivideo.addVideo(video);
        }
        public static  int publishVideo(Video video)
        {
            return ivideo.publishVideo(video);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="videoes">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public static int addNumVideo(List<Video> videoes)
        {
            return ivideo.addNumVideo(videoes);
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public static int deleteAll()
        {
            return ivideo.deleteAll();
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="V_Id"></param>
        /// <returns>返回受影响行数</returns>
        public static int deleteKey(int V_Id)
        {
            return ivideo.deleteKey(V_Id);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public static int updateVideo(Video video)
        {
            return ivideo.updateVideo(video);
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public static DataTable SelectAll()
        {
            return ivideo.SelectAll();
        }

    /// <summary>
    /// 按住键查询
    /// </summary>
    /// <param name="V_Id"></param>
    /// <returns>返回查询结果</returns>
    public static DataTable selectKey(int V_Id)
        {
            return ivideo.selectKey(V_Id);
        }

        /// <summary>
        /// 查询前top
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public static DataTable selectTop(int top)
        {
            return ivideo.selectTop(top);
        }
        public static DataTable SelectTop4()
        {
            return ivideo.SelectTop4();
        }

       
        /// <summary>
        /// 更新点击量
        /// </summary>
        /// <param name="V_Id"></param>
        /// <returns></returns>
        public static int updateClickNum(int V_Id)
        {
            return ivideo.updatev_clickNum(V_Id);
        }

    /// <summary>
    /// 更新下载量
    /// </summary>
    /// <param name="V_Id"></param>
    /// <returns></returns>
    public static int updateDownLoadNum(int V_Id)
        {
            return ivideo.updatev_downloadNum(V_Id);
        }

        //public static List<ModelCourse.mySearch> selectKeyWord(string kw)
        //{
        //    List<ModelCourse.mySearch> msList = new List<ModelCourse.mySearch>();
        //    if ("视频录像video资源教学".Contains(kw))
        //    {
        //        ModelCourse.mySearch ms = new ModelCourse.mySearch();
        //        ms.DataTitle = "教学视频";
        //        ms.RootPageName = "教学资源/教学视频";
        //        ms.DataPage = "~/TeachingResources/TeachingVideo.aspx";
        //        ms.Score = int.MaxValue;
        //        ms.DataType = "text";
        //        msList.Add(ms);
        //    }
        //    DataTable dt = ivideo.selectKeyWord("%"+kw+"%");


        //    if (dt != null)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            ModelCourse.mySearch ms = new ModelCourse.mySearch();
        //            ms.DataID = dt.Rows[i][0].ToString();
        //            ms.DataTitle = dt.Rows[i][1].ToString();
        //            //ms.DataContent = dt.Rows[i][2].ToString();
        //            ms.DataCreateTime = dt.Rows[i][2].ToString();
        //            ms.ClickDown = Convert.ToInt32(dt.Rows[i][4]) + Convert.ToInt32(dt.Rows[i][5]);
        //            ms.DataWithImg = dt.Rows[i][6].ToString();
        //            ms.DataType = "video";
        //            ms.ImgWidth = 140;
        //            ms.ImgHeight = 100;
        //            ms.RootPageName = "教学资源/教学视频";
        //            ms.DataPage = "~/TeachingResources/PlayVideo.aspx?id=" + ms.DataID;
        //            ms.Score = ms.ClickDown + dt.Rows.Count - i;
        //            msList.Add(ms);
        //        }
        //    }
        //    else msList = null;
        //    return msList;
        //}
    }
}

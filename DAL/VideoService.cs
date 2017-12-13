using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VideoService
    {
        /// <summary>
        /// 参数赋值
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回参数数组</returns>
        private static SqlParameter[] AssignParameter(Video video)
        {
            SqlParameter[] sp = new SqlParameter[]{

            
                new SqlParameter("@v_name",video.V_Name),
                new SqlParameter("@v_time",video.V_Time),
                new SqlParameter("@v_savepath",video.V_Savepath),
                new SqlParameter("@v_clickNum",video.V_ClickNum),
                new SqlParameter("@v_downloadNum",video.V_DownloadNum),
                new SqlParameter("@v_screenImg",video.V_ScreenImg)
            };

            return sp;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public static int addVideo(Video video)
        {
            string sql = "insert into Video(v_name,v_time,v_savepath,v_clickNum,v_downloadNum,v_screenImg) values(@v_name,@v_time,@v_savepath,@v_clickNum,@v_downloadNum,@v_screenImg)";

            return DBHelper.GetExcuteNonQuery(sql, AssignParameter(video));
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="videoes">添加的数据</param>
        /// <returns>返回受影响行数</returns>
        public static int addNumVideo(List<Video> videoes)
        {
            int sum = 0;
            foreach (Video item in videoes)
            {
                sum += addVideo(item);
            }

            return sum;
        }

        /// <summary>
        /// 删除全部数据
        /// </summary>
        /// <returns>返回受影响行数</returns>
        public static int deleteAll()
        {
            string sql = "truncate table Video";

            return DBHelper.GetExcuteNonQuery(sql);
        }

        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <param name="V_Id"></param>
        /// <returns>返回受影响行数</returns>
        public static int deleteKey(int V_Id)
        {
            string sql = "delete from Video where V_Id=@V_Id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@V_Id",V_Id)
            };

            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public static DataTable SelectTop4()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="video"></param>
        /// <returns>返回受影响行数</returns>
        public static int updateVideo(Video video)
        {
            string sql = "update Video set v_name=@v_name,v_time=@v_time,v_savepath=@v_savepath,v_clickNum=@v_clickNum,v_downloadNum=@v_downloadNum,v_screenImg=@v_screenImg where V_Id=@V_Id";

            return DBHelper.GetExcuteNonQuery(sql, AssignParameter(video));
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>返回查询结果</returns>
        public static DataTable selectAll()
        {
            string sql = "select * from Video";

            return DBHelper.GetFillData(sql);
        }

        public static DataTable selectTop4()
        {
            string sql = "select  top 4  from Video order by V_Id desc";

            return DBHelper.GetFillData(sql);
        }
        /// <summary>
        /// 按住键查询
        /// </summary>
        /// <param name="V_Id"></param>
        /// <returns>返回查询结果</returns>
        public static DataTable selectKey(int V_Id)
        {
            string sql = "select * from Video where V_Id=@V_Id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@V_Id",V_Id)
            };

            return DBHelper.GetFillData(sql, sp);
        }

        /// <summary>
        /// 查询前top
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public static DataTable selectTop(int top)
        {
            string sql = "select top " + top + " * from Video order by v_clickNum+v_downloadNum desc, v_clickNum desc,v_downloadNum desc,v_time desc";

            return DBHelper.GetFillData(sql);
        }

        /// <summary>
        /// 更新点击量
        /// </summary>
        /// <param name="V_Id"></param>
        /// <returns></returns>
        public static int updatev_clickNum(int V_Id)
        {
            string sql = "update Video set v_clickNum=v_clickNum+1 where V_Id=@V_Id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@V_Id",V_Id)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        /// <summary>
        /// 更新下载量
        /// </summary>
        /// <param name="V_Id"></param>
        /// <returns></returns>
        public static int updatev_downloadNum(int V_Id)
        {
            string sql = "update Video set v_downloadNum=v_downloadNum+1 where V_Id=@V_Id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@V_Id",V_Id)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public static DataTable selectKeyWord(string kw)
        {
            string sql = "select * from Video where v_name like @kw";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@kw",kw)
            };
            return DBHelper.GetFillData(sql, sp);
        }

    }
}

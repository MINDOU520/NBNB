using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IDAL
{
    

        public interface IVideo
        {
            int addVideo(Video video);
            int addNumVideo(List<Video> videoes);
            int deleteAll();
            int deleteKey(int V_Id);
            int updateVideo(Video video);
            DataTable selectAll();
            DataTable selectKey(int V_Id);
            DataTable selectTop(int top);
            int updateClickNum(int V_Id);
            int updateDownLoadNum(int V_Id);
            DataTable selectKeyWord(string kw);
        DataTable SelectTop4();
        int publishVideo(Video video);
        DataTable SelectAll();
        int updatev_clickNum(int V_Id);
        int updatev_downloadNum(int V_Id);
    }
}

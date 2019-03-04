using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Helpers
    {
        /// <summary>
        /// 数据转换为JSON格式
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DataToJson(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5Encrypt32(string password)
        {
          
            byte[] result = Encoding.Default.GetBytes(password);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }

        ///<summary>
        /// 获取CPU序列号
        ///</summary>
        ///<returns></returns>
        private static string GetCpu()
        {
            string strCpu = null;
            var myCpu = new ManagementClass("win32_Processor");
            var myCpuCollection = myCpu.GetInstances();
            foreach (var myObject in myCpuCollection)
            {
                strCpu = myObject.Properties["Processorid"].Value.ToString();
            }
            return strCpu;
        }

        ///<summary>
        /// 生成机器码
        ///</summary>
        ///<returns></returns>
        public static string GetMachineNum()
        {
            var strNum = GetCpu() + GetMacString();
            var strMNum = strNum.Substring(0, 16); //截取前40位作为机器码
            return strMNum;
        }
        /// <summary>
        /// 获取MAC地址
        /// </summary>
        /// <returns>成功返回mac地址，失败返回null</returns>
        private static string GetMacString()
        {
            var resMac = "";
            var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var moc2 = mc.GetInstances();
            foreach (var o in moc2)
            {
                var mo = (ManagementObject)o;
                if ((bool)mo["IPEnabled"] != true) continue;
                resMac = mo["MacAddress"].ToString();
                mo.Dispose();
                return resMac;
            }
            return resMac;
        }
        ///<summary>
        /// 获取硬盘卷标号
        ///</summary>
        ///<returns></returns>
        private static string GetDiskVolumeSerialNumber()
        {
            var disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            disk.Get();
            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using RepeaterQTH.Data;


namespace RepeaterQTH.Support
{
    public class Export
    {
        public async Task DownloadCSV(IEnumerable<Repeater> repeaters, IJSRuntime jsRuntime)
        {
            string data = "Callsign, RxFreq, TxFreq, Tone, Tone Type, State,  Location\n";
            foreach (var repeater in repeaters)
            {
                data += repeater.CallSign + "," + repeater.RxFreq + "," + repeater.TxFreq + "," + repeater.CTCSS + "," + repeater.Tone + "," + repeater.State + "," + repeater.LocationInfo + "\n";
            }

            byte[] file = System.Text.Encoding.UTF8.GetBytes(data);
            var fileName = "rqth-" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
            await jsRuntime.InvokeVoidAsync("BlazorDownloadFile", fileName, "text/csv", file);
        }
        
        public async Task DownloadChirp(IEnumerable<Repeater> repeaters, IJSRuntime jsRuntime)
        {
            string data = "Location,Name,Frequency,Duplex,Offset,Tone,rToneFreq,cToneFreq\n";
            //DtcsCode,DtcsPolarity,Mode,TStep,Skip,Comment,URCALL,RPT1CALL,RPT2CALL,DVCODE
            var count = 0;
            foreach (var repeater in repeaters)
            {
                var duplex = "+";
                var offSet = Math.Round(repeater.TxFreq - repeater.RxFreq, 2);
                if (offSet < 0)
                {
                    duplex = "-";
                    offSet = Math.Abs(offSet);
                }
                var tone = repeater.Tone;
                if (tone is "T-SQL" or "T SQL") tone = "TSQL";
                if (tone == "CSQ") tone = "";
                var rxCTSSS = repeater.RxCTCSS;
                if (rxCTSSS is null or < 67) rxCTSSS = 67.0;
                var CTSSS = repeater.CTCSS;
                if (CTSSS is null or < 67) CTSSS = 67.0;
                data += count + "," + repeater.CallSign + "," + repeater.RxFreq + "," + duplex + "," + offSet + "," + tone + "," + rxCTSSS + "," + CTSSS + "\n";
                count += 1;
            }
            byte[] file = System.Text.Encoding.UTF8.GetBytes(data);
            var fileName = "rqth-Chirp-" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
            await jsRuntime.InvokeVoidAsync("BlazorDownloadFile", fileName, "text/csv", file);

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Builders
{
    class AudioBuilder : MediaBuilder
    {
        

        public override void SetUrl()
        {
            this.Media.Url = new MediaUrl { Name = "https://www.listen.com/Dolina_Larisa/Track-18" };
        }

        public override void SetAudioFile()
        {
            this.Media.AudioFile = new MediaFile { FileType = "Track 18.mp3" };
        }

        public override void SetPhotoFile()
        {
            //throw new NotImplementedException();// не используется
        }
        public override void SetVideoFile()
        {
            //throw new NotImplementedException();// не используется
        }
    }
}

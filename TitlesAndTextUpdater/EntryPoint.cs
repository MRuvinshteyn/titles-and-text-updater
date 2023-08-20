using System.Collections.Generic;
using System.Windows.Forms;
using ScriptPortal.Vegas;
using TitlesAndTextUpdater.GUI;

namespace TitlesAndTextUpdater
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            foreach (Track track in vegas.Project.Tracks)
            {
                foreach (TrackEvent trackEvent in track.Events)
                {
                    if (trackEvent.Selected && trackEvent.ActiveTake.Media.IsGenerated())
                    {
                        VideoEvent videoEvent = (VideoEvent)trackEvent;
                        Effect effect = videoEvent.ActiveTake.Media.Generator;
                        if (effect.PlugIn.Name == "Titles & Text")
                        {
                            OFXEffect ofx = effect.OFXEffect;

                            TextParametersPrompt prompt = new TextParametersPrompt(ofx.Parameters);
                            prompt.Show();
                        }
                    }
                }
            }
        }
    }
}
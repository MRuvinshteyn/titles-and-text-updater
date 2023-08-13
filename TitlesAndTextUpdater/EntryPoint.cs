using System.Windows.Forms;
using ScriptPortal.Vegas;

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

                            MessageBox.Show(ofx.Parameters.Count.ToString() + " parameters");
                            foreach (OFXParameter parameter in ofx.Parameters)
                            {
                                MessageBox.Show(parameter.Name);
                            }
                        }
                    }
                }
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HanumanInstitute.Player432hz.Business
{
    /// <summary>
    /// Manages the playback of a list of media files.
    /// </summary>
    public interface IPlaylistPlayer : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the list of files currently playing.
        /// </summary>
        IList<string> Files { get; }
        /// <summary>
        /// Gets the path of the file currently playing.
        /// </summary>
        string NowPlaying { get; set; }
        /// <summary>
        /// Gets the display title of the file currently playing.
        /// </summary>
        string NowPlayingTitle { get; set; }
        /// <summary>
        /// Starts the playback of specified list of media files.
        /// </summary>
        /// <param name="list">The list of file paths to play.</param>
        /// <param name="current">If specified, playback will start with specified file.</param>
        void Play(IEnumerable<string>? list, string? current);
        /// <summary>
        /// Starts playing the next media file from the list.
        /// </summary>
        void PlayNext();
    }
}

// Copyright (c) 2008 Josh Cooley

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace Tivo.Hme
{
    /// <summary>
    /// Represents an image resource to be displayed in a view
    /// </summary>
    public sealed class ImageResource : IHmeResource
    {
        private Application _application;
        private string _name;
        private long _resourceId;

        internal ImageResource(Application application, string name, long resourceId)
        {
            _application = application;
            _name = name;
            _resourceId = resourceId;
        }

        #region IHmeResource Members

        /// <summary>
        /// The name of the image in the <see cref="Application.Images"/> collection.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Releases the resource allocated to the associated application.
        /// </summary>
        public void Close()
        {
            Dispose();
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Releases the resource allocated to the associated application.
        /// </summary>
        public void Dispose()
        {
            if (_resourceId >= 2048)
                _application.ReleaseResourceId(_resourceId);
        }

        #endregion

        #region IEquatable<IHmeResource> Members

        /// <summary>
        /// Tests equality between two resources
        /// </summary>
        /// <param name="other">Must be an ImageResource.</param>
        /// <returns>true if the resources represent the same item; false otherwise.</returns>
        public bool Equals(IHmeResource other)
        {
            return Equals((object)other);
        }

        #endregion

        /// <summary>
        /// Tests equality between two resources
        /// </summary>
        /// <param name="obj">Must be an ImageResource.</param>
        /// <returns>true if the resources represent the same item; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            ImageResource imageResource = obj as ImageResource;
            if (imageResource != null)
                return _resourceId == imageResource._resourceId;
            else
                return false;
        }

        /// <summary>
        /// returns the hash code such that two equal resources have the same hash code value.
        /// </summary>
        /// <returns>a hash code</returns>
        public override int GetHashCode()
        {
            return _resourceId.GetHashCode();
        }
    }
}

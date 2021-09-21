//
//  KosPersonRoles.cs
//
//  Copyright (c) Christofel authors. All rights reserved.
//  Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Xml.Serialization;
using Kos.Atom;

namespace Kos.Data
{
    /// <summary>
    /// Represents the teacher or student roles of the user.
    /// </summary>
    /// <param name="Students">The references to the person's students.</param>
    /// <param name="Teacher"></param>
    public record KosPersonRoles(
        [property: XmlElement("student")] List<AtomLoadableEntity<KosStudent>> Students,
        [property: XmlElement("teacher")] AtomLoadableEntity<KosTeacher>? Teacher)
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KosPersonRoles"/> class.
        /// </summary>
        public KosPersonRoles()
            : this(default!, null)
        {
        }
    }
}
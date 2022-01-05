﻿// This file is part of CycloneDX Library for .NET
//
// Licensed under the Apache License, Version 2.0 (the “License”);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an “AS IS” BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SPDX-License-Identifier: Apache-2.0
// Copyright (c) OWASP Foundation. All Rights Reserved.

using System.Xml.Serialization;
using ProtoBuf;

namespace CycloneDX.Models.Vulnerabilities
{
    [ProtoContract]
    public class AffectedVersions
    {
        [XmlElement("version")]
        [ProtoMember(1)]
        public string Version { get; set; }

        [XmlElement("range")]
        [ProtoMember(2)]
        public string Range { get; set; }

        [XmlElement("status")]
        [ProtoMember(3)]
        public Status Status { get; set; }
    }
}

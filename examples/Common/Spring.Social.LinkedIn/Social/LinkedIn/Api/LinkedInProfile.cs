﻿#region License

/*
 * Copyright 2002-2011 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System.Runtime.Serialization;

namespace Spring.Social.LinkedIn.Api
{
    // Represents a LinkedIn profile (incomplete)
    [DataContract(Name="person", Namespace="")]
    public class LinkedInProfile
    {
        [DataMember(Name="first-name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last-name")]
        public string LastName { get; set; }
    }
}

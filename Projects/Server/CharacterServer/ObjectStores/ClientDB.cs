﻿/*
 * Copyright (C) 2012-2014 Arctium Emulation <http://arctium.org>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Collections.Generic;
using Framework.Database.ClientDB.Entities;

namespace CharacterServer.ObjectStores
{
    class ClientDB
    {
        public static List<CharBaseInfo> CharBaseInfo           { get; set; }
        public static List<CharStartOutfit> CharStartOutfits    { get; set; }
        public static List<ChrClass> ChrClasses                 { get; set; }
        public static List<ChrRace> ChrRaces                    { get; set; }
        public static List<NameGen> NameGens                    { get; set; }
        public static List<SkillLine> SkillLines                { get; set; }
        public static List<SkillLineAbility> SkillLineAbilities { get; set; }
    }
}


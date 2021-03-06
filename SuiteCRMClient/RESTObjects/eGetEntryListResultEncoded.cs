﻿/**
 * Outlook integration for SuiteCRM.
 * @package Outlook integration for SuiteCRM
 * @copyright SalesAgility Ltd http://www.salesagility.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU LESSER GENERAL PUBLIC LICENCE as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU LESSER GENERAL PUBLIC LICENCE
 * along with this program; if not, see http://www.gnu.org/licenses
 * or write to the Free Software Foundation,Inc., 51 Franklin Street,
 * Fifth Floor, Boston, MA 02110-1301  USA
 *
 * @author SalesAgility <info@salesagility.com>
 */
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteCRMClient.RESTObjects
{
   public class eGetEntryListResultEncoded
    {
       [JsonProperty("entry_list")]
       public string entry_list { get; set; }
       [JsonProperty("error")]
       public eErrorValue error{ get; set; }
       [JsonProperty("_list")]
       public string[] _list{ get; set; }
       [JsonProperty("next_offset")]
       public int next_offset{ get; set; }
       [JsonProperty("result_count")]
       public int result_count{ get; set; }
       [JsonProperty("total_count")]
       public int total_count{ get; set; }
    }
}

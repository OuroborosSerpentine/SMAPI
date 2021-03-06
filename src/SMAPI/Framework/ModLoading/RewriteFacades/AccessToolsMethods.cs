using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using HarmonyLib;

namespace StardewModdingAPI.Framework.ModLoading.RewriteFacades
{
    /// <summary>Maps Harmony 1.x <see cref="AccessTools"/> methods to Harmony 2.x to avoid breaking older mods.</summary>
    /// <remarks>This is public to support SMAPI rewriting and should not be referenced directly by mods.</remarks>
    [SuppressMessage("ReSharper", "CS1591", Justification = "Documentation not needed for facade classes.")]
    public class AccessToolsMethods
    {
        /*********
        ** Public methods
        *********/
        public static ConstructorInfo DeclaredConstructor(Type type, Type[] parameters = null)
        {
            return AccessTools.DeclaredConstructor(type, parameters, searchForStatic: true);
        }

        public static ConstructorInfo Constructor(Type type, Type[] parameters = null)
        {
            return AccessTools.Constructor(type, parameters, searchForStatic: true);
        }

        public static List<ConstructorInfo> GetDeclaredConstructors(Type type)
        {
            return AccessTools.GetDeclaredConstructors(type, searchForStatic: true);
        }
    }
}

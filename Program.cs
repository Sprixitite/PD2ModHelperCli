using System;

using PD2ModHelpLib;

namespace PD2ModHelperCLI;

public static class Program {

    public static void Main(string[] args) {

        // foreach ( string s in args ) { Console.WriteLine(s); }

        Mod testmod = new Mod("testmod", "/home/rory/Projects/testmod");

        testmod.AddMenu("mymenu", "blt_options", "mymenu_title", "mymenu_desc");
        testmod.AddOption("mymenu", new MenuButton("mybtn", "mybtn_title", "mybtn_desc", "mybtn_callback"));

    }

}
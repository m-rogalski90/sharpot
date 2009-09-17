﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpOT;
using SharpOT.Scripting;

public class TestingCharacters : IScript
{
    public bool Start(Game game)
    {
        int id = -1;

        if (!Database.AccountNameExists("1"))
        {
            id = Database.CreateAccount("1", "1");
            if (id > 0 && !Database.PlayerNameExists("God"))
                Database.CreatePlayer(id, "God", game.GenerateAvailableId());
        }
        if (!Database.AccountNameExists("2"))
        {
            id = Database.CreateAccount("2", "2");
            if (id > 0 && !Database.PlayerNameExists("Bob"))
                Database.CreatePlayer(id, "Bob", game.GenerateAvailableId());
        }
        if (!Database.AccountNameExists("3") && !Database.PlayerNameExists("Alice"))
        {
            id = Database.CreateAccount("3", "3");
            if (id > 0 && !Database.PlayerNameExists("Alice"))
                Database.CreatePlayer(id, "Alice", game.GenerateAvailableId());
        }

        return true;
    }
    public bool Stop()
    {
        return false;
    }
}
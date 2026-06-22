using HexTools;
using System.Collections.Generic;
using System.ComponentModel;

namespace DBZ_LotSS_Editor
{
    public class AppDefinition : HexAppDefinition
    {
        public AppDefinition(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject)
        {
            PartialDepth = 2;
            HexDefinitionManager.Instance.Context = new AppDefinitionContext(this);

            Register(new SpriteSystemDefinitionAccessor(synchronizingObject));
            Register(new SpriteCharacterDefinitionAccessor(synchronizingObject));
            Register(new SpriteBattlerDefinitionAccessor(synchronizingObject));
            Register(new SpritePortraitDefinitionAccessor(synchronizingObject));
            Register(new SpriteFlyersDefinitionAccessor(synchronizingObject));
            Register(new PaletteSystemDefinitionAccessor(synchronizingObject));
            Register(new PaletteCharacterDefinitionAccessor(synchronizingObject));
            Register(new PalettePortraitDefinitionAccessor(synchronizingObject));
            Register(new PaletteBattlerDefinitionAccessor(synchronizingObject));
            Register(new PaletteFlyerDefinitionAccessor(synchronizingObject));
            Register(new DataCharacterDefinitionAccessor(synchronizingObject));
            Register(new DataBattlerDefinitionAccessor(synchronizingObject));
            Register(new TextCharacterDefinitionAccessor(synchronizingObject));
            Register(new TextBattlerDefinitionAccessor(synchronizingObject));
            Register(new TextSkillDefinitionAccessor(synchronizingObject));
            Register(new TextItemDefinitionAccessor(synchronizingObject));
            Register(new TextDialogueDefinitionAccessor(synchronizingObject));
            Register(new TextDescriptionDefinitionAccessor(synchronizingObject));
        }
    }

    public class SpriteSystemDefinitionAccessor : HexAppPartialDefinition<SpriteGenericDefinition>
    {
        public SpriteSystemDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.SpriteEditor_System;

        public override string DefinitionFileName => "SpriteEditor_System.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.SpriteEditor.System = Container.Current.Definition;
        }
    }

    public class SpritePortraitDefinitionAccessor : HexAppPartialDefinition<SpritePortraitDefinition>
    {
        public SpritePortraitDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.SpriteEditor_Portraits;

        public override string DefinitionFileName => "SpriteEditor_Portraits.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.SpriteEditor.Portraits = Container.Current.Definition;
        }
    }

    public class SpriteCharacterDefinitionAccessor : HexAppPartialDefinition<SpriteGenericDefinition>
    {
        public SpriteCharacterDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.SpriteEditor_Characters;

        public override string DefinitionFileName => "SpriteEditor_Characters.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.SpriteEditor.Characters = Container.Current.Definition;
        }
    }

    public class SpriteBattlerDefinitionAccessor : HexAppPartialDefinition<SpriteGenericDefinition>
    {
        public SpriteBattlerDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.SpriteEditor_Battlers;

        public override string DefinitionFileName => "SpriteEditor_Battlers.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.SpriteEditor.Battlers = Container.Current.Definition;
        }
    }

    public class SpriteFlyersDefinitionAccessor : HexAppPartialDefinition<SpriteGenericDefinition>
    {
        public SpriteFlyersDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.SpriteEditor_Flyers;

        public override string DefinitionFileName => "SpriteEditor_Flyers.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.SpriteEditor.Flyers = Container.Current.Definition;
        }
    }

    public class PaletteSystemDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public PaletteSystemDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.PaletteEditor_System;

        public override string DefinitionFileName => "PaletteEditor_System.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.PaletteEditor.System = Container.Current.Definition;
        }
    }

    public class PaletteCharacterDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public PaletteCharacterDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.PaletteEditor_Characters;

        public override string DefinitionFileName => "PaletteEditor_Characters.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.PaletteEditor.Characters = Container.Current.Definition;
        }
    }

    public class PalettePortraitDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public PalettePortraitDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.PaletteEditor_Portraits;

        public override string DefinitionFileName => "PaletteEditor_Portraits.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.PaletteEditor.Portraits = Container.Current.Definition;
        }
    }

    public class PaletteBattlerDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public PaletteBattlerDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.PaletteEditor_Battlers;

        public override string DefinitionFileName => "PaletteEditor_Battlers.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.PaletteEditor.Battlers = Container.Current.Definition;
        }
    }

    public class PaletteFlyerDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public PaletteFlyerDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.PaletteEditor_Flyers;

        public override string DefinitionFileName => "PaletteEditor_Flyers.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.PaletteEditor.Flyers = Container.Current.Definition;
        }
    }

    public class DataCharacterDefinitionAccessor : HexAppPartialDefinition<CharacterDataDefinition>
    {
        public DataCharacterDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.DataEditor_Characters;

        public override string DefinitionFileName => "DataEditor_Characters.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.DataEditor.Characters = Container.Current.Definition;
        }
    }

    public class DataBattlerDefinitionAccessor : HexAppPartialDefinition<BattlerDataDefinition>
    {
        public DataBattlerDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.DataEditor_Battlers;

        public override string DefinitionFileName => "DataEditor_Battlers.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.DataEditor.Battlers = Container.Current.Definition;
        }
    }

    public class TextCharacterDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public TextCharacterDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.TextEditor_Characters;

        public override string DefinitionFileName => "TextEditor_Characters.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.TextEditor.Characters = Container.Current.Definition;
        }
    }

    public class TextBattlerDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public TextBattlerDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.TextEditor_Battlers;

        public override string DefinitionFileName => "TextEditor_Battlers.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.TextEditor.Battlers = Container.Current.Definition;
        }
    }

    public class TextSkillDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public TextSkillDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.TextEditor_Skills;

        public override string DefinitionFileName => "TextEditor_Skills.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.TextEditor.Skills = Container.Current.Definition;
        }
    }

    public class TextItemDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public TextItemDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.TextEditor_Items;

        public override string DefinitionFileName => "TextEditor_Items.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.TextEditor.Items = Container.Current.Definition;
        }
    }

    public class TextDialogueDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public TextDialogueDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.TextEditor_Dialogues;

        public override string DefinitionFileName => "TextEditor_Dialogues.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.TextEditor.Dialogues = Container.Current.Definition;
        }
    }

    public class TextDescriptionDefinitionAccessor : HexAppPartialDefinition<AssetDefinition>
    {
        public TextDescriptionDefinitionAccessor(ISynchronizeInvoke synchronizingObject) : base(synchronizingObject) { }

        public override byte[] DefaultDefinition => My.Resources.Resources.TextEditor_Descriptions;

        public override string DefinitionFileName => "TextEditor_Descriptions.json";

        public override void ContainerChanged()
        {
            HexDefinitionManager.Instance.Context.TextEditor.Descriptions = Container.Current.Definition;
        }
    }

    public class AppDefinitionContext : HexAppDefinitionContext
    {
        public AppDefinitionContext(HexAppDefinition appDefinition) : base(appDefinition) { }

        public DataEditorDefinition DataEditor { get; set; } = new DataEditorDefinition();
        public SpriteEditorDefinition SpriteEditor { get; set; } = new SpriteEditorDefinition();
        public GenericArtEditorDefinition PaletteEditor { get; set; } = new GenericArtEditorDefinition();
        public TextEditorDefinition TextEditor { get; set; } = new TextEditorDefinition();
    }

    public class ArtEditorDefinition<T0, T1, T2, T3, T4>
        where T0 : new()
        where T1 : new()
        where T2 : new()
        where T3 : new()
        where T4 : new()
    {
        public T0 System { get; set; } = new T0();
        public T1 Characters { get; set; } = new T1();
        public T2 Portraits { get; set; } = new T2();
        public T3 Battlers { get; set; } = new T3();
        public T4 Flyers { get; set; } = new T4();
    }

    public class ArtEditorDefinition<T> : ArtEditorDefinition<T, T, T, T, T> where T : new() { }

    public class GenericArtEditorDefinition : ArtEditorDefinition<AssetDefinition> { }

    public class SpriteEditorDefinition : ArtEditorDefinition<SpriteGenericDefinition, SpriteGenericDefinition, SpritePortraitDefinition, SpriteGenericDefinition, SpriteGenericDefinition> { }

    public class DataEditorDefinition
    {
        public CharacterDataDefinition Characters { get; set; } = new CharacterDataDefinition();
        public BattlerDataDefinition Battlers { get; set; } = new BattlerDataDefinition();
    }

    public class CharacterDataDefinition
    {
        public List<CharacterListItemDefinition> List { get; set; } = new List<CharacterListItemDefinition>();
    }

    public class BattlerDataDefinition
    {
        public BattlerMultiActionDefinition MultiAction { get; set; } = new BattlerMultiActionDefinition();
    }

    public class BattlerMultiActionDefinition
    {
        public string TurnProfileOffset { get; set; }
        public int TurnProfileCount { get; set; }
        public string SkillPointerOffset { get; set; }
        public int SkillPointerBank { get; set; }
        public string CardSetupActorWordOffset { get; set; }
        public string CardSetupValueProfileOffset { get; set; }
        public int CardSetupValueProfileCount { get; set; }
        public int CardSetupValueProfileLength { get; set; }
        public List<string> TurnProfileLabels { get; set; } = new List<string>();
    }

    public class TextEditorDefinition
    {
        public AssetDefinition Characters { get; set; } = new AssetDefinition();
        public AssetDefinition Battlers { get; set; } = new AssetDefinition();
        public AssetDefinition Skills { get; set; } = new AssetDefinition();
        public AssetDefinition Items { get; set; } = new AssetDefinition();
        public AssetDefinition Dialogues { get; set; } = new AssetDefinition();
        public AssetDefinition Descriptions { get; set; } = new AssetDefinition();
    }

    public struct TableDefinition
    {
        public string Offset { get; set; }
        public TableIndexDefinition Index { get; set; }
        public TablePointerDefinition Pointer { get; set; }
    }

    public struct TableIndexDefinition
    {
        public string Offset { get; set; }
        public byte Bit { get; set; }
    }

    public struct TablePointerDefinition
    {
        public string Offset { get; set; }
        public byte Bank { get; set; }
        public byte Length { get; set; }
        public bool IgnoreHeader { get; set; }
    }

    public class AssetDefinition
    {
        public TableDefinition Table { get; set; }
        public List<ListItemDefinition> List { get; set; } = new List<ListItemDefinition>();
    }

    public class SpritePortraitDefinition
    {
        public List<SpritePortraitListItemDefinition> List { get; set; } = new List<SpritePortraitListItemDefinition>();
    }

    public class SpriteGenericDefinition
    {
        public List<SpriteListItemDefinition> List { get; set; } = new List<SpriteListItemDefinition>();
    }

    public class ListItemDefinition
    {
        public string Offset { get; set; }
        public string Name { get; set; }
    }

    public class CharacterListItemDefinition : ListItemDefinition
    {
        public bool CanLevel { get; set; }
        public bool CanBattle { get; set; }
        public bool CanTransform { get; set; }
    }

    public class SpriteListItemDefinition : ListItemDefinition
    {
        public string Palette { get; set; }
        public int Size { get; set; }
    }

    public class SpritePortraitListItemDefinition : ListItemDefinition
    {
        public string Palette1 { get; set; }
        public string Palette2 { get; set; }
    }
}

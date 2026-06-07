using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            public IReadOnlyCollection<Form> Forms => new List<Form>()
            {
                Form_EditorDatabase,
                Form_EditorPalette,
                Form_EditorSprite,
                Form_EditorText
            }
            .AsReadOnly();

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_EditorDatabase m_Form_EditorDatabase;

            public Form_EditorDatabase Form_EditorDatabase
            {
                [DebuggerHidden]
                get
                {
                    m_Form_EditorDatabase = Create__Instance__(m_Form_EditorDatabase);
                    return m_Form_EditorDatabase;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_EditorDatabase))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_EditorDatabase);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_EditorPalette m_Form_EditorPalette;

            public Form_EditorPalette Form_EditorPalette
            {
                [DebuggerHidden]
                get
                {
                    m_Form_EditorPalette = Create__Instance__(m_Form_EditorPalette);
                    return m_Form_EditorPalette;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_EditorPalette))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_EditorPalette);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_EditorSprite m_Form_EditorSprite;

            public Form_EditorSprite Form_EditorSprite
            {
                [DebuggerHidden]
                get
                {
                    m_Form_EditorSprite = Create__Instance__(m_Form_EditorSprite);
                    return m_Form_EditorSprite;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_EditorSprite))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_EditorSprite);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_EditorText m_Form_EditorText;

            public Form_EditorText Form_EditorText
            {
                [DebuggerHidden]
                get
                {
                    m_Form_EditorText = Create__Instance__(m_Form_EditorText);
                    return m_Form_EditorText;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_EditorText))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_EditorText);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_HelpAbout m_Form_HelpAbout;

            public Form_HelpAbout Form_HelpAbout
            {
                [DebuggerHidden]
                get
                {
                    m_Form_HelpAbout = Create__Instance__(m_Form_HelpAbout);
                    return m_Form_HelpAbout;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_HelpAbout))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_HelpAbout);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_Main m_Form_Main;

            public Form_Main Form_Main
            {
                [DebuggerHidden]
                get
                {
                    m_Form_Main = Create__Instance__(m_Form_Main);
                    return m_Form_Main;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_Main))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_Main);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_OptionsPreferences m_Form_OptionsPreferences;

            public Form_OptionsPreferences Form_OptionsPreferences
            {
                [DebuggerHidden]
                get
                {
                    m_Form_OptionsPreferences = Create__Instance__(m_Form_OptionsPreferences);
                    return m_Form_OptionsPreferences;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_OptionsPreferences))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_OptionsPreferences);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_ToolData m_Form_ToolData;

            public Form_ToolData Form_ToolData
            {
                [DebuggerHidden]
                get
                {
                    m_Form_ToolData = Create__Instance__(m_Form_ToolData);
                    return m_Form_ToolData;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_ToolData))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_ToolData);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_ToolFont m_Form_ToolFont;

            public Form_ToolFont Form_ToolFont
            {
                [DebuggerHidden]
                get
                {
                    m_Form_ToolFont = Create__Instance__(m_Form_ToolFont);
                    return m_Form_ToolFont;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_ToolFont))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_ToolFont);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_ToolGraphic m_Form_ToolGraphic;

            public Form_ToolGraphic Form_ToolGraphic
            {
                [DebuggerHidden]
                get
                {
                    m_Form_ToolGraphic = Create__Instance__(m_Form_ToolGraphic);
                    return m_Form_ToolGraphic;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_ToolGraphic))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_ToolGraphic);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_ToolHistory m_Form_ToolHistory;

            public Form_ToolHistory Form_ToolHistory
            {
                [DebuggerHidden]
                get
                {
                    m_Form_ToolHistory = Create__Instance__(m_Form_ToolHistory);
                    return m_Form_ToolHistory;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form_ToolHistory))
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_ToolHistory);
                }
            }

        }


    }
}
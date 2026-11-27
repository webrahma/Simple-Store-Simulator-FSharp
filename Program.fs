namespace SimpleStore


open System
open System.Windows.Forms


module Program =


    [<STAThread>]
    [<EntryPoint>]
    let main _argv =
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(false)
        Application.SetHighDpiMode(HighDpiMode.SystemAware) |> ignore


        use mainForm = UI.createMainForm ()
        Application.Run(mainForm)
        0



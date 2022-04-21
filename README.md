# FinalProject
 classDiagram
    Program <|-- Form1
    Program : +main()
    Form1<|--cars
    class Form1{
        +save_btn_click()
        +load_btn_click()
    }

    class cars{
        +LN(get; set)
        +Brand(get; set)
        +Model(get; set)
        +Color(get; set)
        +DateIn(get; set)
        +TimeIn(get; set)
        +DateOut(get; set)
        +TimeOut(get; set)
    }

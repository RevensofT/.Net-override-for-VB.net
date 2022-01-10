Imports System.Runtime.CompilerServices

Namespace System
    Friend Structure ValueTuple(Of T1, T2)
        Public Item1 As T1, Item2 As T2
        <MethodImpl(MethodImplOptions.AggressiveInlining)>
        Public Sub New(A1 As T1, A2 As T2)
            Item1 = A1
            Item2 = A2
        End Sub
    End Structure

    Friend Structure ValueTuple(Of T1, T2, T3)
        Public Item1 As T1, Item2 As T2, Item3 As T3
        <MethodImpl(MethodImplOptions.AggressiveInlining)>
        Public Sub New(A1 As T1, A2 As T2, A3 As T3)
            Item1 = A1
            Item2 = A2
            Item3 = A3
        End Sub
    End Structure

    Friend Structure ValueTuple(Of T1, T2, T3, T4)
        Public Item1 As T1, Item2 As T2, Item3 As T3, Item4 As T4
        <MethodImpl(MethodImplOptions.AggressiveInlining)>
        Public Sub New(A1 As T1, A2 As T2, A3 As T3, A4 As T4)
            Item1 = A1
            Item2 = A2
            Item3 = A3
            Item4 = A4
        End Sub
    End Structure

    Friend Structure ValueTuple(Of T1, T2, T3, T4, T5)
        Public Item1 As T1, Item2 As T2, Item3 As T3, Item4 As T4, Item5 As T5
        <MethodImpl(MethodImplOptions.AggressiveInlining)>
        Public Sub New(A1 As T1, A2 As T2, A3 As T3, A4 As T4, A5 As T5)
            Item1 = A1
            Item2 = A2
            Item3 = A3
            Item4 = A4
            Item5 = A5
        End Sub
    End Structure

    Friend Structure ValueTuple(Of T1, T2, T3, T4, T5, T6)
        Public Item1 As T1, Item2 As T2, Item3 As T3, Item4 As T4, Item5 As T5, Item6 As T6
        <MethodImpl(MethodImplOptions.AggressiveInlining)>
        Public Sub New(A1 As T1, A2 As T2, A3 As T3, A4 As T4, A5 As T5, A6 As T6)
            Item1 = A1
            Item2 = A2
            Item3 = A3
            Item4 = A4
            Item5 = A5
            Item6 = A6
        End Sub
    End Structure

    Friend Structure ValueTuple(Of T1, T2, T3, T4, T5, T6, T7)
        Public Item1 As T1, Item2 As T2, Item3 As T3, Item4 As T4, Item5 As T5, Item6 As T6, Item7 As T7
        <MethodImpl(MethodImplOptions.AggressiveInlining)>
        Public Sub New(A1 As T1, A2 As T2, A3 As T3, A4 As T4, A5 As T5, A6 As T6, A7 As T7)
            Item1 = A1
            Item2 = A2
            Item3 = A3
            Item4 = A4
            Item5 = A5
            Item6 = A6
            Item7 = A7
        End Sub
    End Structure

    Friend Structure ValueTuple(Of T1, T2, T3, T4, T5, T6, T7, T8)
        Public Item1 As T1, Item2 As T2, Item3 As T3, Item4 As T4, Item5 As T5, Item6 As T6, Item7 As T7, Item8 As T8
        <MethodImpl(MethodImplOptions.AggressiveInlining)>
        Public Sub New(A1 As T1, A2 As T2, A3 As T3, A4 As T4, A5 As T5, A6 As T6, A7 As T7, A8 As T8)
            Item1 = A1
            Item2 = A2
            Item3 = A3
            Item4 = A4
            Item5 = A5
            Item6 = A6
            Item7 = A7
            Item8 = A8
        End Sub
    End Structure
End Namespace
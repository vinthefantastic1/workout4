@ModelType IEnumerable(Of workout4.workoutSession)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table  table-condensed">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.workoutDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.exerciseName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.weight)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.reps)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.bodyPart)
        </th>
        <th></th>
    </tr>

@code
    Dim xx As Integer = 0
    
End Code
@For Each item In Model
    Dim currentItem = item
    Dim _tempclass As String
    
    _tempclass = "warning"
    xx = xx + 1
    If xx Mod 2 = 0 Then
        _tempclass = "success"
    End If
    @<tr class='@_tempclass'>
        <td>
            @Html.HiddenFor(Function(modelItem) currentItem.workoutId)
            @Html.DisplayFor(Function(modelItem) currentItem.workoutDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.exerciseName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.weight)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.reps)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.bodyPart)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.workoutId}) 
            @*@Html.ActionLink("Details", "Details", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.PrimaryKey})*@
        </td>
    </tr>
Next

</table>

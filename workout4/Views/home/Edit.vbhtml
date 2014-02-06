@ModelType workout4.workoutSession

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>workoutSession</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.workoutId)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.workoutId)
            @Html.ValidationMessageFor(Function(model) model.workoutId)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.workoutDate)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.workoutDate)
            @Html.ValidationMessageFor(Function(model) model.workoutDate)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.exerciseName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.exerciseName)
            @Html.ValidationMessageFor(Function(model) model.exerciseName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.weight)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.weight)
            @Html.ValidationMessageFor(Function(model) model.weight)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.reps)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.reps)
            @Html.ValidationMessageFor(Function(model) model.reps)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.bodyPart)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.bodyPart)
            @Html.ValidationMessageFor(Function(model) model.bodyPart)
        </div>

        <p>
            <button type="submit" class="btn btn-primary">Save</button>
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
    <a href="@Url.Action("Index")" class="btn btn-primary" >Back To List</a>
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section

@ModelType workout4.workoutSession

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>workoutSession</legend>

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
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>



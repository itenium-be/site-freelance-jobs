Freelance Jobs Management
=========================

WinForms app to manage jobs on: https://itenium.be/freelance/

Configuration in `appsettings.json`.

Requires a user with access to [itenium-be/itenium-be.github.io](https://github.com/itenium-be/itenium-be.github.io)
to be logged in with the [Git-Credential-Manager-for-Windows](https://github.com/Microsoft/Git-Credential-Manager-for-Windows)

Adding a property
-----------------

- Add prop to `FreelanceJob` and `FreelanceJobDto`
- Update JobsService: MapToDto() & MapToModel()
- MainForm Code: Mapping in BindGrid()
- MainForm Designer: Add column to `dataSet1` and `FreelanceJobsGrid`
- JobEditForm: Mapping in SetJob() and PublishButton_Click()

Breaking change?  
Got a deserialization error but was still able to update the app.

### Adding a Location

Add in `JobEditForm_Load`

AutoUpdater
-----------

Add this to Jenkins next time!

- Update version in `_SharedAssemblyInfo.cs`
- Update version in `FreelanceJobsVersion.xml` (2 times!)
- git tag v1.4
- Create Github release with version (format: v1.4)
- Add `Itenium.FreelanceJobs.WinForms.zip` to the Github release.
	- Create a **Release** build
	- If the `Jobs` (git clone) is there, delete it
	- Control + Win + Z in `bin\Release`
	- Attach as binary to the release

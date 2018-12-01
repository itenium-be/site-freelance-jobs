Freelance Jobs Management
=========================

WinForms app to manage jobs on: https://itenium.be/freelance/

Configuration in `appsettings.json`.

Requires a user with access to [itenium-be/itenium-be.github.io](https://github.com/itenium-be/itenium-be.github.io)
to be logged in with the [Git-Credential-Manager-for-Windows](https://github.com/Microsoft/Git-Credential-Manager-for-Windows)

AutoUpdater
-----------

Create a build script for this next time!

- Update version in `_SharedAssemblyInfo.cs`
- Update version in `FreelanceJobsVersion.xml` (2 times!)
- git tag v1.2.0.0
- Create Github release with version (format: v1.2.0.0)
- Add `FreelanceJobs.zip` to the Github release.
	- Create a **Release** build
	- If the `Jobs` (git clone) is there, delete it
	- Control + Win + Z in `bin\Release`
	- Rename and attach as binary to the release

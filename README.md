# VL.Devices.DigiCamControl
A set of [VL](https://vvvv.org/documentation/vl) nodes for remo controlling DSLR cameras based on [digiCamControl](https://github.com/dukus/digiCamControl).

## Contributing to the development
If you want to contribute to this repository, clone it into a directory like:
 
    X:\vl-libs\VL.Devices.DigiCamControl

### Build the C# Project
Open

    X:\vl-libs\VL.Devices.DigiCamControl\src\VL.Devices.DigiCamControl.sln
    
in VisualStudio and build it. This is necessary for a few things that cannot yet be expressed in vl directly, like dynamic enums and static readonly instances of things. 

### Start vvvv
Then start vvvv with the commandline parameter:

    /package-repositories "X:\vl-libs\"
    
which will make all packs found in that directory available as dependencies in vl documents. 

VL.Devices.DigiCamControl will now show up as Nuget among a .vl documents available dependencies as shown [here](https://vvvv.gitbooks.io/the-gray-book/content/en/reference/libraries/dependencies.html#_nugets). Simply select the nuget (via a rightclick) to get access to its nodes. 

There is also a demo-patch coming with this package that is a bit hidden in:

    "\VL.Devices.DigiCamControl\vvvv\girlpower\DigiCamDemo.v4p"

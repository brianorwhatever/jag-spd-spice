# The MyCorp MyAPI Config File
> see https://aka.ms/autorest 

## Literate Config File
> See https://github.com/Azure/autorest/blob/master/docs/user/literate-file-formats/configuration.md

## Getting Started 
  1.) Update myApi.json (you'll see in this same folder) to align with the lastest swagger definition.

  2.) To build the SDKs for The MyCorp MyAPI, simply install AutoRest via `npm` (`npm install -g autorest`) and then run:
     > `autorest readme.md`

     To see additional help and options, run:
     > `autorest --help`

  3.) After running this command, you can return to Visual Studio and turn on hidden files - include any new ones in your project and the models subdir of your project.

For other options on installation see [Installing AutoRest](https://aka.ms/autorest/install) on the AutoRest github page.

---

## Configuration 
The following are the settings for generating this API with AutoRest.

# (more settings here...)
``` yaml
input-file:
  - carla-spice.swagger

csharp:
  output-folder: .
  add-credentials: true
  override-client-name: CarlaClient
  use-datetimeoffset: true
  sync-methods: all
  generate-empty-classes: true
  namespace: Gov.Lclb.Cllb.Interfaces
```

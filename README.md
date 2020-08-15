# NewtonGltf.vgo.extensions

This package provides NewtonGltf's extension schema for VGO.

___
## Basic Schema

- [NewtonGltf](https://github.com/izayoijiichan/newton.gltf.git)

## Extension Schema Structure

- glTF
  - extensions
    - VGO
      - meta
      - right
      - avatar
  - nodes
    - extensions
      - VGO_nodes
        - gameObject
        - colliders
          - collider
        - rigidbody
        - light
        - blendShape
        - particleSystem
        - right
        - skybox
  - materials
    - extensions
      - VGO_materials
      - VGO_materials_particle
      - VGO_materials_skybox
      - KHR_materials_unlit
      - VRMC_materials_mtoon

## List of Schema Definition

- Gltf
  - Gltf_VGO
  - Gltf_VGO_Meta
  - Gltf_VGO_Right
- Nodes
  - VGO_nodes
  - VGO_GameObject
  - VGO_Transform
  - VGO_Rigidbody
  - VGO_Collider
  - VGO_BrendShape
  - VGO_ParticleSystem
  - VGO_Skybox
  - VGO_Light
- Materials
  - VGO_materials
  - VGO_materials_particle
  - VGO_materials_skybox
  - VRMC_materials_mtoon
- Elements
  - VGO_AnimationCurve
  - VGO_BlendShapeBinding
  - VGO_BlendShapeBlink
  - VGO_BlendShapeFacePart
  - VGO_BlendShapePreset
  - VGO_BlendShapeViseme
  - VGO_Gradient
  - VGO_GradientAlphaKey
  - VGO_GradientColorKey
  - VGO_HumanAvatar
  - VGO_HumanBone
  - VGO_Keyframe
  - VGO_PhysicMaterial
  - VGO_PS_Burst
  - VGO_PS_CollisionModule
  - VGO_PS_ColorBySpeedModule
  - VGO_PS_ColorOverLifetimeModule
  - VGO_PS_CustomDataModule
  - VGO_PS_EmissionModule
  - VGO_PS_ExternalForcesModule
  - VGO_PS_ForceOverLifetimeModule
  - VGO_PS_InheritVelocityModule
  - VGO_PS_LightsModule
  - VGO_PS_LimitVelocityOverLifetimeModule
  - VGO_PS_MainModule
  - VGO_PS_MinMaxCurve
  - VGO_PS_MinMaxGradient
  - VGO_PS_NoiseModule
  - VGO_PS_Renderer
  - VGO_PS_RotationBySpeedModule
  - VGO_PS_RotationOverLifetimeModule
  - VGO_PS_ShapeModule
  - VGO_PS_SizeBySpeedModule
  - VGO_PS_SizeOverLifetimeModule
  - VGO_PS_SubEmittersModule
  - VGO_PS_TextureSheetAnimationModule
  - VGO_PS_TrailModule
  - VGO_PS_TriggerModule
  - VGO_PS_VelocityOverLifetimeModule

## Specification

- VGO JSON Schema: [1.0](https://github.com/izayoijiichan/VGO/tree/master/Documentation~/VGO/specification/1.0/schema)
- VRMC_materials_mtoon: [1.0](https://github.com/vrm-c/vrm-specification/tree/master/specification/VRMC_materials_mtoon-1.0_draft)

## Framework

- .NET Standard 2.0
- .NET Framework 4.7

## Dependent Packages

- Newtonsoft.Json 12.0.3
- [VgoGltf](https://github.com/izayoijiichan/vgo.gltf.git) 1.0.2
- [NewtonGltf](https://github.com/izayoijiichan/newton.gltf.git) 1.0.0

___
Last updated: 15 August, 2020  
Editor: Izayoi Jiichan

*Copyright (C) 2020 Izayoi Jiichan. All Rights Reserved.*

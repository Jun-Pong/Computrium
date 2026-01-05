# Computrium: The Universe Information Theory (UIT) Engine

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Status](https://img.shields.io/badge/Status-Patent%20Pending-red)]()
[![Architecture](https://img.shields.io/badge/Architecture-PIM%20%2F%20In--Situ-orange)]()
[![DOI](https://zenodo.org/badge/1126976453.svg)](https://doi.org/10.5281/zenodo.18135945)

> **"Nature is Hardware. Physics is Source."**
> **"自然即硬件，物理即源码。"**

---

# Universe Information Theory

![UIT Lensing Proof](assets/UIT_lensing_simulation.png)

## 🌌 Visual Proof of Concept: Gravitational Lensing
The image above is a real-time rendering output from the Universe Information Theory core addressing field. 

**Key Technical Breakthroughs Demonstrated:**
* **Zero Collision Detection**: Unlike traditional Ray-Tracing (NVIDIA RTX), our photons follow signal-addressing fields.
* **O(1) Complexity**: Rendering cost is independent of geometry; it scales only with field density.
* **Mass-Bandwidth Equivalence**: The "Black Hole" effect is a natural emergent property of high-bandwidth occupancy in the UIT bus.

---

## 🛡️ Intellectual Property & Patent Status
All architectural logic, including the field-guided addressing and in-situ computing protocols, are strictly protected:
* **Core Architecture**: Patent Pending (filed).
* **Implementation**: Source code remains private during the audit phase.
* **Binary Access**: Compiled demonstration builds will be released in the "Releases" section for verification only.

Unauthorized reverse engineering or re-implementation of the UIT addressing field is a direct violation of global IP laws.

---

## 📑 Executive Summary (项目摘要)

**Computrium** 是一个实验性的物理仿真架构，旨在验证 **宇宙信息论 (Universe Information Theory, UIT)**。

本项目不是基于传统牛顿力学或广义相对论几何计算的仿真引擎，而是提出了一种全新的计算范式：**基于原位去中心化场数据聚合 (In-situ Decentralized Field Data Aggregation)**。该架构通过模拟时空网格的数据传输带宽限制，自然涌现出惯性、引力及相对论效应，旨在解决大规模多体仿真中的算力瓶颈与存储墙问题。

本项目处于早期架构验证阶段 (Pre-Alpha)。核心定义（如 Payload 的具体结构、CarrierSignal 的计算方式）可能会随着仿真数据的反馈而进行重构 (Refactor)。

本仓库目前作为该技术的**核心理论架构公示 (Architecture Disclosure)** 及**现有技术声明 (Prior Art Statement)**。

---

## ⚖️ Intellectual Property & Legal Notice (知识产权与法律声明)

**PATENT PENDING / 专利申请中**

The methodology, hardware architecture, and data structures described herein are currently under examination by the National Intellectual Property Administration (CNIPA).
本文所述的方法论、硬件架构及数据结构目前正处于国家知识产权局的审查程序中。

**Application References (申请索引):**
本项目核心技术（UIT 架构、带宽-质量映射逻辑及原位计算硬件实现）受以下专利家族保护。任何未经授权的商业复现（包括但不限于 ASIC 设计、FPGA 仿真、物理引擎算法）均将面临法律追责。

1.  **Invention Patent Application (发明专利申请):**
    * **Application No.:** [2026100000964]
    * **Subject:** 一种基于原位去中心化场数据聚合的大规模并行仿真方法
    * **Application No.:** [2026100001967]
    * **Subject:** 一种基于原位去中心化场数据聚合的大规模并行仿真方法、处理架构及存储介质
    * **Application No.:** [2026100036788]
    * **Subject:** 一种基于全域离散信号场的分布式场耦合计算系统及方法
2.  **Utility Model Application (实用新型申请):**
    * **Application No.:** [2026200001089]
    * **Subject:** A processing architecture for parallel field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真处理架构)
    * **Application No.:** [2026200001873]
    * **Subject:** A processing architecture for parallel field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真处理架构及芯片)

**Prior Art Declaration:**
This repository serves as a rigid proof of publication. Any unauthorized filing of patents covering the same technical scope after the priority date of the applications listed above will be challenged based on this prior art.
(本仓库作为技术公开的有力证明。任何在此优先权日之后针对相同技术范围的未授权专利申请，都将基于本现有技术面临挑战。)

---

## 🏗 Theoretical Architecture (理论架构)

**Computrium** 基于“宇宙即去中心化分布式计算系统”的底层逻辑。我们认为，现代物理学最大的偏差在于试图用“内核态”去解释系统的冷启动（大爆炸），而忽视了系统运行时的总线架构。

### 🔑 The Fundamental Equivalence: Bandwidth & Frequency

在 UIT 架构中，我们重新定义了物理资源：

1. **Bandwidth (空间属性)**: 
   空间节点的并发处理上限。它代表了总线在不发生“逻辑死锁”的情况下，能容纳的信号叠加极值。
2. **Frequency (时序表现)**: 
   在去中心化架构下，带宽本质上是‘时钟周期资源的独占率’，而频率则是系统状态翻转的物理极限。

### 1. The Particle Primitive (粒子原语)
在 UIT 中，粒子并非实体，而是**单实例逻辑单元 (Single Instance)**。

* **Signal Transceiver (信号收发器)**: 
    * **TX (发送)**: 将所有载荷 (Payload) 信号混合，并以波的形式广播。
    * **RX (接收)**: 监听空间总线中的信号波（自动过滤系统底噪/真空零能）。
* **Direction Vector (方向向量)**: 
    * 每一个粒子必须在总线中保持传输。粒子的下一跳方向由自身向量与 RX 接收到的向量和叠加决定。
* **Payload (载荷指针)**: 
    * 挂载于粒子的功能指针。Payload 赋予粒子“属性”，并从收发器中提取对应频段的向量进行叠加。

### 2. The Resource: Space & Mass (资源：空间与质量)
在 UIT 架构中，空间不是背景，而是**带宽资源**。

* **Mass = Bandwidth Occupancy (质量即带宽占用率)**:
    质量并非粒子的内禀属性，而是总线空间的实时负载状态。粒子（Payload）的存在即意味着对该区域总线带宽的消耗。
* **Gravity (引力)**: 
    引力不是一种“力”，而是**寻址偏转现象**。由于高带宽占用（大质量）区域信号强度最高，粒子的方向向量会自发向该拥堵区域偏转。
* **Expansion (膨胀)**: 
    系统熵增（热效应）导致的全局带宽退化。

### 🛡️ Hardware Implementation & IP Wall

UIT 架构最显著的特征在于其 **可工程化性**。我们已经验证了如何在 FPGA/模拟电路中复现这一系统逻辑：

* **Logic Core**: 通过建立“带宽占用率 (Mass)”与“局部处理频率 (Frequency)”的负反馈回路。
* **Emergent Effect**: 这种底层限制会导致信号流自发产生偏转，即“引力”的硬件涌现。

**NOTICE TO ARCHITECTS:**
上述“带宽-频率耦合反馈”逻辑是 **Computrium 核心专利 [2026XXXXXXXX]** 的保护要点。任何基于此逻辑实现的硬件加速器、模拟仿真芯片或存算一体架构，均需获得书面授权。

🛡️ 核心协议：黑洞与屏蔽层封装 (The Shielded Anchor Protocol)
为了解决大规模模拟的复杂度，本项目定义了一种名为“美妙粒子”的自组织结构，其逻辑严禁被第三方申请专利：

1. 黑洞内核：单跳寻址隔离 (Restricted Broadcast)
逻辑定义：黑洞被定义为具有极高权重 Payload 的内核。

广播限制：黑洞的信号广播范围被硬编码限制为单跳寻址（Single-hop Addressing）。其信号无法穿透到邻域之外。

物理效应：在黑洞最外层空间制造一个“绝对引力陷阱”。

2. 屏蔽层：单向数据阀门 (One-way Data Valve)
被动吸附：外壳粒子位于黑洞单跳范围内，读取到极高电平梯度，从而被强制吸附在内核周围。

主动隔绝：屏蔽层粒子仅广播自身的 Payload 信号。

禁断逻辑：屏蔽层禁止转发任何来自内核方向的寻址包。这保证了内核的计算噪音（溢出错误）被物理隔绝，对外仅表现为一个稳定的引力锚点。
  
---

# 🔬 Phenomena Mapping: Physics Reinterpreted (Experimental)
## 物理现象映射：重新定义宇宙法则 (实验性)

> **核心声明**：本章节旨在证明 UIT 架构的“底层普适性”。我们不通过预设公式来“模拟”物理，而是通过总线逻辑的运行，让宏观物理现象作为逻辑副产物自然涌现。

### 1. 物质实体感与不可穿透性 (Solidity & Address Locking)
**Logic Core**: 通过建立“地址排他锁定”机制。当基本粒子占据一个总线单元时，该单元的带宽占用率达到 100% 饱和态，系统禁止任何次级 Payload 写入相同地址。

### 2. 引力偏转与动态加速 (Gravitational Deflection & Dynamic Acceleration)
**Logic Core**: 通过建立“方向矢量 (Direction Vector)”受高信号强度场 (Signal Intensity Field) 强制偏转的逻辑。

* **偏转机制**：粒子的下一跳方向并非固定，而是受局部总线信号强度的加权影响。当粒子进入高信号区域，其自身的运动方向矢量会发生自发偏转。
* **垂直涌现**：随着粒子与信号源距离缩短，偏转角度逐渐增大并趋于垂直于信号梯度。这种物理逻辑导致了粒子在寻址空间内的位移增量加大。
* **结论**：引力并非一种吸力，而是**矢量场对寻址路径的纠偏**。速度的增加本质上是矢量偏转角度趋近于最优寻址路径时的逻辑副产物。

### 5. 惯性与寻址阻抗 (Inertia & Addressing Impedance)
**Logic Core**: 通过建立“自身信号带宽占用”与“逻辑更新频率”的负相关模型。

* **寻址堆积**：当粒子处于高速运动或高载荷状态时，其对局部总线地址的请求频率极高。
* **时序延迟**：由于自身信号已经大量占用总线带宽，系统对该粒子“方向矢量”变更的响应速度会自然下降。这种响应延迟在宏观上表现为物体维持原有运动状态的倾向。
* **结论**：惯性并非粒子的内禀属性，而是**总线信道对高频寻址请求的物理阻抗**。运动越快，寻址请求堆积越严重，更新原有矢量方向所需的时钟周期就越多。

### 6. 能量量子化与时钟周期 (Energy Quantization & Clock Cycles)
**Logic Core**: 通过建立“最小执行周期 (Minimum Tick)”作为系统运算的离散基准。

* **离散本质**：在分布式总线架构中，任何信号的叠加、位移或 Payload 的读写，都必须以一个完整的系统时钟周期为最小单位。
* **现象映射**：所谓的“能量量子”，本质上是总线执行一次完整寻址操作所消耗的最小资源量。由于系统逻辑不支持“半个周期”的执行指令，所有相互作用在底层均表现为非连续的跳变。
* **结论**：宇宙的量子化特征并非物质的固有属性，而是由于**总线系统的底层指令集是离散执行的**。

### 3. 奇点与数据流喷射 (Singularity & Buffer Flush)
**Logic Core**: 通过建立“缓存溢出重置”机制。当 Payload 堆积强行突破总线承载极限，系统触发强制复位指令，将压缩数据降解为原始比特流高速弹出。

### 4. 宇宙膨胀 (Expansion & Bandwidth Degradation)
**Logic Core**: 通过建立“总线熵增与带宽退化”模型。随着系统运行时间增加，全局总线信道受干扰导致单位空间寻址效率下降，表现为信号传输所需时钟周期增加。

---

## 🗓 Roadmap & Status (路线图与状态)

* **Phase I: Architecture Definition (Current)**
    * [x] Patent Filing (Invention & Utility Model).
    * [x] Theoretical framework formulation (The "Computrium" Paper).
    * [x] Public disclosure of core concepts via GitHub.

* **Phase II: Core Implementation (Upcoming)**
    * [ ] Release of `Computrium.Core` (C# implementation of the Manifold Logic).
    * [ ] Visualization tools for Bandwidth/Gravity mapping.

* **Phase III: Hardware Acceleration**
    * [ ] FPGA/ASIC verification of the In-situ Aggregation logic.

---

## 📄 License (开源协议)

Copyright © 2024 [Jun-Pong].

Licensed under the **Apache License, Version 2.0** (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

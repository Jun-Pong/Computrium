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
    * **Subject:** 一种基于原位去中心化场数据聚合的大规模并行仿真处理架构
    * **Application No.:** [2026200001873]
    * **Subject:** 一种基于原位去中心化场数据聚合的大规模并行仿真处理架构及芯片

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

### 物质实体感与不可穿透性 (Solidity & Address Locking)
**Logic Core**: 通过建立“地址排他锁定”机制。当基本粒子占据一个总线单元时，该单元的带宽占用率达到 100% 饱和态，系统禁止任何次级 Payload 写入相同地址。

### 引力偏转与动态加速 (Gravitational Deflection & Dynamic Acceleration)
**Logic Core**: 通过建立“方向矢量 (Direction Vector)”受高信号强度场 (Signal Intensity Field) 强制偏转的逻辑。

* **偏转机制**：粒子的下一跳方向并非固定，而是受局部总线信号强度的加权影响。当粒子进入高信号区域，其自身的运动方向矢量会发生自发偏转。
* **垂直涌现**：随着粒子与信号源距离缩短，偏转角度逐渐增大并趋于垂直于信号梯度。这种物理逻辑导致了粒子在寻址空间内的位移增量加大。
* **结论**：引力并非一种吸力，而是**矢量场对寻址路径的纠偏**。速度的增加本质上是矢量偏转角度趋近于最优寻址路径时的逻辑副产物。

### 惯性与寻址阻抗 (Inertia & Addressing Impedance)
**Logic Core**: 通过建立“自身信号带宽占用”与“逻辑更新频率”的负相关模型。

* **寻址堆积**：当粒子处于高速运动或高载荷状态时，其对局部总线地址的请求频率极高。
* **时序延迟**：由于自身信号已经大量占用总线带宽，系统对该粒子“方向矢量”变更的响应速度会自然下降。这种响应延迟在宏观上表现为物体维持原有运动状态的倾向。
* **结论**：惯性并非粒子的内禀属性，而是**总线信道对高频寻址请求的物理阻抗**。运动越快，寻址请求堆积越严重，更新原有矢量方向所需的时钟周期就越多。

### 动力驱动与矢量一致性改写 (Propulsion & Vector Alignment)
**Logic Core**: 通过建立“外源信号压”对“高频背景寻址流”的偏置改写模型。

* **动态平衡态**：宏观静止的小球内部粒子并非处于停止状态，而是全量参与总线的背景寻址（如随星体自转与公转）。若粒子停止寻址，将导致局部地址锁定并引发总线阻塞（系统卡死）。
* **力学改写**：施加“推力”本质上是向该区域注入定向信号流，在粒子维持高频背景寻址的同时，强制改写其内部矢量的**逻辑偏置**。
* **加速度涌现**：推力越大，被改写偏置的粒子比例越高，导致小球在总线时钟周期内的“地址跳转步长”相对于背景流产生了增量。
* **结论**：运动是总线存活的先决条件。推力不是创造运动，而是**在全量运动的基底上重塑了矢量的指向性**。

### 物理反弹与矢量溢出 (Reflection & Vector Overflow)
**Logic Core**: 通过建立“方向矢量叠加溢出 (Directional Vector Sum Overflow)”模型。

* **叠加饱和**：当粒子尝试进入一个已被高密度 Payload 占据的地址时，粒子自身的方向矢量与目标地址的排他性信号发生强行叠加。
* **溢出反转**：当叠加后的信号强度超过总线定义的逻辑阈值（饱和点）时，系统触发“数值溢出”保护。由于计算溢出导致的位反转，粒子的方向矢量被强制重置为反向或切向。
* **结论**：反弹本质上是总线系统的一种**错误恢复机制**。它防止了两个互斥的 Payload 在同一个地址发生逻辑合并，宏观上表现为坚硬物体间的弹性碰撞。

### 3. 动态锁定与宏观稳定 (Dynamic Locking & Macro-Stability)

在 UIT 架构中，平衡并不意味着微观逻辑单元的停滞，而是一种基于高频震荡的“动态锁定状态”。

* 永恒震荡 (Perpetual Oscillation): 
  在缺乏外部耗散的纯逻辑环境中，粒子间的“吸引-溢出反弹”循环是永恒的。这种震荡构成了粒子的“逻辑内能”。
* 统计平均稳定性 (Statistical Stability): 
  由于震荡频率极高且在时空分布上具有对称性，粒子间的相对位移在宏观尺度上相互抵消。表现为一组粒子在保持特定间距的同时，作为一个整体存在。
* 外部信号锁定 (External Signal Locking): 
  当存在强大的全局信号（如地球方向矢量）时，高频震荡的粒子群会集体对该信号产生相干响应。
  - 逻辑表现：即便粒子内部在疯狂互弹，但整体的“重心”会精准地锁定并跟随背景矢量。
  - 现实映射：正如宏观稳定的固体内部充斥着混乱的微观振动，UIT 的稳定性源于逻辑单元在极速跳变中达成的“动质量负载均衡”。

--------------------------------------------------------------------------------

### 5. 逻辑演化推论：从粒子到实体

当粒子由于“动质量”与“总线带宽”的博弈达到某种亚稳态时，它们不再是孤立的点，而是在总线中形成了一个具有特定物理特征的“场结构”。

* 宏观静止：当内部弹跳的频率远超总线采样分辨率时，逻辑上的“震荡”在表现层坍缩为“静止”。
* 实体化：这种由高频逻辑碰撞维持的空间结构，正是 UIT 模拟复杂宏观实体的物理基础。

### 熵：系统中的无序数据流 (Entropy: System Unordered Data Stream)
**Logic Core**: 将熵定义为总线空间中**未封装、无目标、无主权的游离数据集合**。

* **UDS 定义 (Unordered Data Stream)**:
    熵的本质是系统总线中弥散的 **UDS (无序数据流)**。
    * 它们是历史操作（如燃烧、衰变）留下的残留数据包，丢失了格式头与寻址信息。
    * 熵不具备“波动性”或“攻击性”，它仅仅是**占据了带宽**的静态（或低速漂移）垃圾数据。

* **带宽死锁 (Bandwidth Deadlock)**:
    高熵区域意味着该区域的有效带宽被 UDS 填满。系统无法在此处分配新的高频地址，表现为“死寂”或“不可构建”。

---

### 热量：序列化函数的执行波动 (Heat: Serialization Function Fluctuation)
**Logic Core**: 将热量定义为**序列化/反序列化函数**在执行极速格式转换时，对局部总线造成的**高频震荡 (High-Frequency Oscillation)**。

* **波动本质 (The Fluctuation)**:
    热量不是一种物质，也不是熵本身。热量是 **`Serialize()`** 或 **`Deserialize()`** 函数在运行时产生的**总线涟漪**。
    * 当一个粒子被强制拆解（序列化）时，其数据结构的崩溃与重组会在微观尺度引发剧烈的**逻辑时序抖动**。
    * 这种抖动向四周扩散，就是我们感知到的“热辐射”。

* **伤害机制：强制同频 (Forced Resonance Damage)**:
    为什么热量会灼烧（造成实质性伤害）？
    * **震荡传导**: 这种“函数波动”具有极强的侵略性。当它扫过你的身体（稳定粒子群）时，会干扰你体内的锁存逻辑。
    * **逻辑被动执行**: 你的身体粒子受到高强度的“序列化震荡”影响，被迫与该频率共振，导致自身的封装层松动，甚至**被诱导执行错误的自我解构函数**。
    * **结论**: 这一过程并非能量传递，而是**逻辑崩溃的传染**。

* **熵与热的关系**:
    * **熵**是燃烧后的**产物**（灰烬/废数据）。
    * **热**是燃烧时的**过程**（拆解动作引发的震动）。
    * 正如锯木头：**熵**是地上的锯末（无害，但占地方），**热**是锯片的高速震动（由于太剧烈，碰到手会受伤）。

### 超导：相位锁定与零阻抗寻址 (Superconductivity: Phase-Locking & Zero-Impedance)
**Logic Core**: 通过建立“格点寻址相位一致性”引发的“无损数据传输”模型。

* **逻辑纯净态 (Logical Purity)**：
  在极低“热量（逻辑功耗）”环境下，介质内部粒子的寻址相位达到高度的一致性。此时，总线背景底噪（Noise）趋近于零，系统进入一种极高效率的有序状态。
* **零阻抗传输 (Zero-Impedance)**：
  当外部信号（如电流 Payload）尝试跨越地址单元时，由于其矢量方向与介质底层的寻址频率完全同步（相位锁定），总线不再产生任何“处理延迟”。数据流可以在不损耗任何逻辑动能的情况下，实现跨地址跳转。
* **排他性逻辑（迈斯纳效应）**：
  由于超导区域的寻址逻辑已处于完全同步的“锁定态”，外部磁场（寻址涡流）无法强行介入或改写其内部电平。这种逻辑上的互斥表现为宏观的完全抗磁性。
* **结论**：
  超导是总线系统在排除干扰后的**纯净运行模式**。它证明了当寻址逻辑达到完美同步时，系统可以实现超越常规物理限制的“无损信息传递”。

### 磁场与总线寻址涡流 (Magnetic Field & Addressing Vortices)
**Logic Core**: 通过建立“粒子定向寻址”对“周边电平梯度”的螺旋诱导模型。

* **寻址涡流**：当携带 Payload 的粒子（如电子）在总线中执行高速定向寻址或自旋时，其产生的信号流会对周边格点的电平分布产生一个**螺旋状的诱导梯度**。
* **现象映射**：这种螺旋信号场不像引力（单向拉伸）或静电（径向扩散），它具有明显的旋转逻辑。当大量粒子同步寻址时，这些微观涡流会叠加形成宏观的磁力线。
* **结论**：磁场是总线信号流在特定寻址逻辑下产生的**动力学效应**。磁力不是一种静止的属性，而是信号在总线空间中高速“流动”时带起的逻辑旋风。

### 折射与逻辑熵偏转 (Refraction & Logical Entropy Deflection)
**Logic Core**: 通过建立“寻址矢量”向“高熵逻辑区”自发偏转的模型。

* **噪音导向**：光子在总线中寻址时，由于其自身信号包的不稳定，会自发受到周围“逻辑噪音”的干扰，向信号分布最杂乱（熵值高）的方向偏转。
* **介质差异**：
    * **高噪介质（如水）**：由于分子结构混乱，总线产生的背景噪音极强，导致光子剧烈偏转。
    * **低噪介质（如高质量玻璃）**：虽然物质密度高，但逻辑一致性极佳。光子在其中受到的噪音干涉小，路径表现出与高噪介质截然不同的偏转特性。
* **结论**：光并不趋向物质，光趋向的是**逻辑的混乱（噪音）**。折射是光子在不同“寻址清晰度”区域间穿行时产生的路径漂移。

### 光的自干涉与梯度寻址 (Self-Interference & Gradient Addressing)
**Logic Core**: 通过建立“即时梯度响应 (Real-time Gradient Response)”模型。

* **盲目寻址**：光子（信号包）并不具备预知路径的能力，也不存在“概率波”的叠加。它仅仅是一个严格遵循局部总线信号梯度的逻辑单元。
* **路径涌现**：光子在每一帧的时钟周期内，仅根据周围格点的信号强度分布，自发向梯度较高的方向（或受干涉条纹信号叠加影响后的逻辑方向）进行下一跳寻址。
* **现象映射**：所谓的“自干涉”条纹，本质上是总线空间中预先存在的信号干涉图样（底噪叠加）对光子寻址路径的物理约束。光子只是顺着信号形成的“逻辑河床”滑行。
* **结论**：光并不认识路，它只是总线信号流的被动追随者。宏观的干涉路径是局部极简逻辑在全局信号场中的自然涌现。

### 观测坍缩与信号锁定 (Observation Collapse & Signal Locking)
**Logic Core**: 通过建立“主动探测信号”对“局部梯度场”的强制覆盖模型。

* **静默状态 (波)**：在没有观测者时，光子仅受背景总线信号（底噪）的微弱梯度影响。由于信号极其微弱且呈弥散分布，光子的寻址路径表现出宽泛的选择性。
* **观测干预 (粒子)**：探测器为了“观测”，必须向空间发送特定的探测信号（波束）。这种强信号瞬间覆盖并重写了局部的总线电平分布，将光子的多向寻址路径压缩为单一的、确定的高梯度方向。
* **结论**：光被观测时变成粒子，并非它改变了属性，而是探测器产生的**信号噪音（逻辑干涉）**强行接管了总线的寻址导向。坍缩是信号系统从“低功耗扩散态”进入“高占空比驱动态”的必然结果。

### 能量量子化与时钟周期 (Energy Quantization & Clock Cycles)
**Logic Core**: 通过建立“最小执行周期 (Minimum Tick)”作为系统运算的离散基准。

* **离散本质**：在分布式总线架构中，任何信号的叠加、位移或 Payload 的读写，都必须以一个完整的系统时钟周期为最小单位。
* **现象映射**：所谓的“能量量子”，本质上是总线执行一次完整寻址操作所消耗的最小资源量。由于系统逻辑不支持“半个周期”的执行指令，所有相互作用在底层均表现为非连续的跳变。
* **结论**：宇宙的量子化特征并非物质的固有属性，而是由于**总线系统的底层指令集是离散执行的**。

### 质能转换与数据解封 (Mass-Energy Equivalence: E=mc²)
**Logic Core**: 通过建立“实例数据 (Instance Data)”与“广播信号 (Broadcast Signal)”的封装与解压模型。

* **质量 (Mass)**：在逻辑上被定义为 Payload 信号在局部总线地址中被锁定、高度封装并持续占据带宽的**静态驻留状态**。
* **能量 (Energy)**：当封装逻辑失效（如碰撞或溢出）时，原本锁定的 Payload 数据被瞬时降解，转化为在总线中高速扩散的**无载体广播信号流**。
* **转换常数**：这种转换本质上是“离散数据包”向“连续波动场”的相变。由于广播信号在总线空间中的传播速度恒定（c），其释放的系统冲击力表现为与速度平方成正比的能量级。
* **结论**：物质并没有消失，它只是从**“独占带宽的私有数据”**变成了**“污染全局的公共噪音”**。

### 暗物质与全域信号叠加 (Dark Matter & Global Signal Superposition)
**Logic Core**: 通过建立“全量粒子广播叠加 (Full-scale Particle Broadcast Superposition)”模型。

* **普遍起源**：暗物质并非来自特定未知的粒子。在 UIT 系统中，**所有实体粒子**都在持续向总线执行广播（TX）操作。
* **物理本质**：这些海量粒子发出的信号在总线空间中不断叠加、碰撞与干涉，形成了一种充斥于空间的“背景电平”。
* **引力效应**：这种由全体粒子贡献的信号场虽然不具备单一的实体中心，但其形成的信号梯度依然会改变周边粒子的方向矢量。
* **结论**：暗物质是全宇宙物质共同发出的**“信号余晖”**。它是总线系统在处理实体交互时，必然产生的全局逻辑压（Logic Pressure），这种压力的宏观表现即为观测到的额外引力。

### 黑洞：临界负载与溢出补偿 (Black Holes: Critical Load & Overflow Compensation)
**Logic Core**: 通过建立“寻址趋近饱和”与“轴向数据溢出”的动态平衡模型。

* **临界负载 (Near-Deadlock)**：
  黑洞并非绝对意义上的逻辑死锁，而是处于寻址带宽的**极限饱和状态**。内部格点并未停止工作，而是以极高压力维持着最低限度的逻辑翻转。这种“趋近死锁”的状态产生了极强的寻址阻力，导致宏观上的时间膨胀。
* **逻辑视界 (Event Horizon)**：
  视界线被定义为总线带宽的**归零边界**。进入此区域的寻址请求会瞬间淹没在全量溢出的底噪中，导致粒子失去产生有效外向矢量的能力。
* **数据重构喷流 (Data Reconstruction Jets)**：
  当后续涌入的 Payload 导致地址空间即将发生不可逆死锁时，系统触发溢出保护。过剩的数据包因无法被核心接纳，以**原始内存流 (Raw Data Stream)** 的形式从阻力最小的轴向（自转轴）被强行弹出。
* **二次实例化 (Re-instantiation)**：
  这些内存流脱离高压区后，由于局部寻址压力降低，被系统重新识别并**实例化**为高速粒子（如电子、离子）。我们看到的辉煌喷流，本质上是这些数据包在“重新实例化”过程中产生的次生广播信号。
* **结论**：
  黑洞是宇宙中的**高压稳流器**。它通过“接近死锁”来束缚海量数据，又通过“内存溢出”将无法处理的数据重新重构并喷射，从而在动态中防止总线系统彻底崩溃。

### 奇点与数据流喷射 (Singularity & Buffer Flush)
**Logic Core**: 通过建立“缓存溢出重置”机制。当 Payload 堆积强行突破总线承载极限，系统触发强制复位指令，将压缩数据降解为原始比特流高速弹出。

### 宇宙膨胀 (Expansion & Bandwidth Degradation)
**Logic Core**: 通过建立“总线熵增与带宽退化”模型。随着系统运行时间增加，全局总线信道受干扰导致单位空间寻址效率下降，表现为信号传输所需时钟周期增加。

### 生物稳态与信号调制协议 (Bio-Homeostasis & Signal Modulation Protocol)
**Logic Core**: 基于“全域信号场”的闭环反馈模型。本模型严格遵循 **“环境调制(Modulation) -> 波致动(Wave-Driven) -> 场反馈(Field Feedback)”** 的物理时序。在此架构中，不存在数字化的“读取”过程，所有变化均为信号波能量对硬件状态的**直接驱动**。

* **信号激发模态 (Signal Initiation: Waveform Modulation)**
  在 UIT 架构中，不存在孤立的“意图指令”，所谓的“源端输出”本质上是**全域场对源端载波的实时调制**。
  * **Carrier & Modulation (载波与调制)**：源端（大脑）持续广播基础载波。环境中的信号噪声（如激素浓度、压力波或外部激励）作为**调制波 (Modulating Wave)**，通过**场叠加效应**直接改变了源端载波的**波幅 (Amplitude)** 或 **占空比**。
  * **No Logic Processing (无逻辑处理)**：源端未进行任何计算，它只是一个被环境场“拨动”的振荡器。环境信号越强，源端被激发的输出波幅就越大（例如：平静的低频波被环境惊恐信号直接调制为高频尖峰波）。

* **运动致动 (Motion Actuation: Direct Wave Driving)**
  宿端（肌肉）并非“接收数据并执行”，而是被源端传来的高能信号波**直接泵浦 (Directly Pumped)**。
  * **Energy Injection (能量注入)**：源端的高幅信号波沿波导抵达宿端。由于宿端硬件与该信号频率发生**谐振 (Resonance)**，信号波的能量被宿端直接吸收。
  * **Forced Gain (受迫增益)**：这种能量注入物理上强行提升了宿端的内部能级，导致宿端对外的**背向散射截面 (RCS)** 或 **广播功率** 被动升高（即 S3 正向增益）。
  * **Result**: 宏观上，这表现为宿端“硬化”并产生排斥力。这一切都是能量传递的物理必然，无需任何逻辑解码。

* **痛觉反馈 (Pain Mechanism: Entropy Backflow)**
  当物理冲突导致宿端结构受损时，局部总线的阻抗特性发生突变。
  * **Wave Reflection (波反射)**：源端发出的驱动波无法顺利通过该区域，被迫在受损界面发生全反射或漫反射。
  * **Entropy Injection (熵流注入)**：这些原本用于驱动运动的有序波，转化为混乱的**驻波 (Standing Wave)** 或 **噪声流** 逆向冲刷源端。
  * **Interference (干涉)**：回流的噪声直接与源端的振荡电路发生**相消干涉**或**过载扰动**，物理上破坏了源端的稳态振荡，导致“意识”下降或中断。

* **饥饿感知 (Hunger Mechanism: Impedance Damping)**
  这是一种基于 **负向增益** 的物理阻尼机制。
  * **Energy as Impedance (能量即阻抗)**：宿端（代谢系统）的能量储备直接对应其**介质阻抗 (Dielectric Impedance)**。能量越低，介质的**损耗角正切 (Loss Tangent)** 越大。
  * **Signal Damping (信号阻尼)**：源端的轮询波进入该介质后，不是被“读取”，而是被**物理耗散 (Dissipated)** 掉了。
  * **Analog Sensing (模拟感知)**：源端检测到回路中的**电压驻波比 (VSWR)** 异常降低（即发出去的波像打在棉花上一样没回来），这种物理上的“空虚感”直接对应饥饿状态。

* **能量消化 (Energy Digestion: Field Refactoring)**
  消化系统维持着一个高强度的“重构场”。外部异构粒子（食物）进入该场后，其内部的键合结构被场能**强行打断 (Breakdown)**，并顺应场势能重组为符合总线标准的波包结构，重新并入系统的能量循环。

* **结论 (Conclusion)**
  在 UIT 架构中，生物体是一个纯粹的**模拟信号处理系统**。环境调制源端的波幅，源端的波幅直接驱动宿端的能级，宿端的阻抗改变反过来影响源端的振荡。整个过程没有“代码”，只有**波的传播、干涉与耗散**。

### 双向热力学反馈 (Bi-directional Thermodynamic Feedback)
**Logic Core**: 基于“广义热力学”的物理功耗与带宽负相关模型。

* **热量与带宽负相关 (Heat-Bandwidth Trade-off)**
  生物内部任何形式的信号振荡都会产生焦耳热（系统熵增）。在总线架构中，热量的累积改变了传输介质的导电率或折射率，导致信道带宽物理下降。

* **源端指令衰减 (Willpower Reduction)**
  当源端因高频振荡（亢奋或剧痛）导致过热时，硬件层面的电子迁移率下降，导致振荡电路的 **Q值 (Quality Factor)** 降低。输出波形的幅度被迫衰减，宏观表现为“意志力”的物理性枯竭。

* **接收端发射降级 (Muscle Fatigue)**
  宿端（肌肉）在长期受迫振荡下产生积热，导致其**谐振频率漂移 (Frequency Drift)** 或内阻升高。即使源端继续发送强波，宿端也无法再有效吸收能量并维持高功率广播，宏观表现为生理性力竭。

* **结论 (Conclusion)**
  疲劳不是软件层面的计数器，而是硬件过热导致的**谐振失配 (Resonance Mismatch)** 和 **增益压缩 (Gain Compression)**。系统被迫在“烧毁硬件”和“降低性能”之间遵循物理定律的裁决。

### 🧩 Topology Architecture (拓扑架构定义)
> **Dynamic Role Assignment (动态角色分配)**: 
> In UIT, "Source" and "Host" are not fixed biological organs, but **transactional roles**. 
> * **Source (源端)**: Any node that initiates a signal modulation event (e.g., Brain requesting motion, OR Stomach reporting hunger).
> * **Host (宿端)**: The target node reacting to that specific signal.
> 
> (注：在本架构中，“源端”和“宿端”并非固定的器官，而是基于单次交互事件动态分配的**事务性角色**。任何发起信号调制的节点——无论是下达指令的大脑还是上报状态的胃部——在该次事务中即被定义为“源端”。)
  
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

import { ItemLink } from './item-link';

export class ModuleLink {
    constructor(public title: string, public route: string, public links: ItemLink[]) { }
}
